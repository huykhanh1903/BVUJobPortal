<template>
  <div class="chat-wrapper">
    <h2 class="title">
      💬 Trò chuyện hỗ trợ
      <span v-if="aiEnabled" class="ai">(AI đang bật 🤖)</span>
      <span v-else class="admin">(Admin đang hỗ trợ 👨‍💼)</span>
    </h2>

    <div class="messages" ref="scrollBox">
      <div
        v-for="msg in messages"
        :key="msg.id"
        :class="msg.isFromAI ? 'msg ai' : 'msg user'"
      >
        {{ msg.message }}
      </div>
    </div>

    <div class="input-box">
      <input v-model="text" @keyup.enter="send" placeholder="Nhập tin nhắn..." />
      <button @click="send">Gửi</button>
    </div>
  </div>
</template>
<script setup>
import { ref, onMounted, nextTick } from "vue";
import api from "@/api/axios";
import { useAuthStore } from "@/store/auth";

const auth = useAuthStore();

const aiEnabled = ref(true);
const messages = ref([]);
const text = ref("");
const scrollBox = ref(null);

const loadStatus = async () => {
  const res = await api.get("/api/Admin/ai-status");
  aiEnabled.value = res.data.aiEnabled;
};

const loadMyMessages = async () => {
  const res = await api.get("/api/Admin/messages");
  messages.value = res.data.filter(x => x.receiverId === auth.user.id);
  await nextTick();
  scrollBox.value.scrollTop = scrollBox.value.scrollHeight;
};

const send = async () => {
  if (!text.value.trim()) return;

  const content = text.value;
  text.value = "";

  messages.value.push({
    message: content,
    isFromAI: false
  });

  await nextTick();
  scrollBox.value.scrollTop = scrollBox.value.scrollHeight;

  if (aiEnabled.value) {

    const res = await api.post("/api/chat/ai", { message: content });
    messages.value.push({
      message: res.data.reply,
      isFromAI: true
    });
  } else {
    await api.post("/api/Admin/reply", {
      userId: auth.user.id,
      message: content
    });
  }

  await nextTick();
  scrollBox.value.scrollTop = scrollBox.value.scrollHeight;
};

onMounted(async () => {
  await loadStatus();
  await loadMyMessages();
});
</script>
<style scoped>
.chat-wrapper {
  max-width: 420px;
  margin: auto;
  background: white;
  padding: 15px;
  border-radius: 14px;
  box-shadow: 0 6px 20px rgba(0,0,0,0.1);
}
.title {
  font-size: 18px;
  font-weight: bold;
  margin-bottom: 10px;
}
.admin { color: #0ea5e9; }
.ai { color: #16a34a; }

.messages {
  height: 300px;
  overflow-y: auto;
  padding: 10px;
  background: #f1f5f9;
  border-radius: 10px;
  margin-bottom: 12px;
}

.msg {
  padding: 8px 12px;
  border-radius: 12px;
  margin-bottom: 10px;
  max-width: 80%;
  white-space: pre-wrap;
}

.msg.user {
  background: #e0f2fe;
  margin-left: auto;
}

.msg.ai {
  background: #dcfce7;
  margin-right: auto;
}

.input-box {
  display: flex;
  gap: 10px;
}

input {
  flex: 1;
  padding: 8px 12px;
  border-radius: 8px;
  border: 1px solid #cbd5e1;
}

button {
  background: #10b981;
  color: white;
  padding: 8px 14px;
  border-radius: 8px;
}
</style>
