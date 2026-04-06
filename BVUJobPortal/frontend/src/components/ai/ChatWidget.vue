<template>
  <div class="fixed bottom-6 right-6 z-50 select-none">

    <button
      v-if="!open"
      @click="toggleChat"
      class="w-16 h-16 rounded-full bg-[#4f46e5] text-white text-3xl shadow-xl 
             flex items-center justify-center hover:scale-110 active:scale-95 
             transition-all duration-200"
    >
      🤖
    </button>

    <div
      v-else
      class="w-[660px] h-[620px] bg-white/90 backdrop-blur-md shadow-2xl rounded-3xl 
             flex flex-col overflow-hidden border border-gray-200 animate-pop"
    >

      <div class="bg-gradient-to-r from-indigo-600 to-purple-600 text-white p-4 
                  flex justify-between items-center shadow">
        <div class="font-semibold text-lg flex items-center gap-2">
          🤖 BVU Assistant
        </div>
        <button 
          @click="toggleChat" 
          class="text-white text-xl hover:scale-110 transition"
        >✖</button>
      </div>

      <div v-if="showSuggestions"
           class="p-3 bg-white border-b flex gap-3 overflow-x-auto suggestions">
        <button
          v-for="s in suggestions"
          :key="s.text"
          @click="sendSuggestion(s.text)"
          class="suggestion-item"
        >
          <span class="text-lg">{{ s.icon }}</span>
          <span class="text-[11px] font-medium">{{ s.text }}</span>
        </button>
      </div>

      <div ref="box" class="flex-1 p-4 space-y-4 overflow-y-auto bg-gray-50 message-area">

        <div
          v-for="(msg, i) in messages"
          :key="i"
          class="flex items-start gap-2"
          :class="msg.from === 'user' ? 'justify-end' : 'justify-start'"
        >

          <div v-if="msg.from !== 'user'"
               class="w-9 h-9 rounded-full bg-purple-600 text-white flex items-center justify-center shadow">
            🤖
          </div>

          <div
            class="rounded-2xl px-4 py-2 max-w-[75%] text-sm shadow message-bubble"
            :class="msg.from === 'user'
              ? 'bg-indigo-600 text-white rounded-tr-none'
              : 'bg-white text-gray-800 rounded-tl-none'"
            v-html="msg.html || msg.text"
          ></div>

          <div v-if="msg.from === 'user'"
               class="w-9 h-9 rounded-full bg-indigo-600 text-white flex items-center justify-center shadow">
            👤
          </div>
        </div>

        <div v-if="typing" class="flex items-center gap-2 text-gray-500 ml-1">
          🤖 <span class="dot"></span><span class="dot"></span><span class="dot"></span>
        </div>
      </div>

      <form @submit.prevent="sendMessage" 
            class="p-3 bg-white border-t flex items-center gap-2">
        
        <div class="flex-1 flex items-center bg-gray-100 rounded-full px-3 py-2 shadow-inner">
          <input
            v-model="input"
            ref="inputRef"
            @input="hideSuggestions"
            placeholder="Nhập tin nhắn..."
            class="bg-transparent w-full outline-none text-sm"
          />
        </div>

        <button
          type="submit"
          :disabled="typing"
          class="w-10 h-10 rounded-full bg-indigo-600 text-white flex items-center 
                 justify-center shadow hover:bg-indigo-700 active:scale-95 
                 transition disabled:opacity-40"
        >
          ➤
        </button>
      </form>

    </div>
  </div>
</template>

<script setup>
import { ref, nextTick } from "vue";
import { useAuthStore } from "@/store/auth";
import api from "@/api/axios";
import { marked } from "marked";
import DOMPurify from "dompurify";

const auth = useAuthStore();
const userId = auth.user?.id;

const open = ref(false);
const messages = ref([]);
const input = ref("");
const inputRef = ref(null);
const showSuggestions = ref(true);
const typing = ref(false);
const aiEnabled = ref(true);
const box = ref(null);

const suggestions = [
  { icon: "💼", text: "Tư vấn ngành nghề phù hợp" },
  { icon: "📄", text: "Gợi ý cải thiện CV" },
  { icon: "🎤", text: "Gợi ý trả lời phỏng vấn" },
  { icon: "🔍", text: "Tìm việc phù hợp với ngành học" },
  { icon: "📚", text: "Lộ trình học tập theo kỹ năng" },
];

const renderMarkdown = (md) => DOMPurify.sanitize(marked(md, { breaks: true }));

const loadAiStatus = async () => {
  try {
    const res = await api.get("Admin/ai-status");
    aiEnabled.value = res.data.aiEnabled;
  } catch {
    aiEnabled.value = true;
  }
};

const loadMessages = async () => {
  try {
    const res = await api.get("chat/messages");

    messages.value = res.data.map(m => ({
      from: m.senderId === userId ? "user" : "admin",
      text: m.message,
      html: renderMarkdown(m.message)
    }));

    scrollBottom();
  } catch (e) {
    console.error("Load messages error:", e);
  }
};

setInterval(() => {
  if (open.value) loadMessages();
}, 2500);

const scrollBottom = () => {
  nextTick(() => {
    box.value?.scrollTo({ top: box.value.scrollHeight, behavior: "smooth" });
  });
};

const hideSuggestions = () => (showSuggestions.value = false);

const sendSuggestion = (text) => {
  hideSuggestions();
  input.value = text;
  sendMessage();
};

const typewriter = async (text, index) => {
  let buf = "", i = 0;
  return new Promise((resolve) => {
    const t = setInterval(() => {
      buf += text[i];
      messages.value[index].html = renderMarkdown(buf);
      scrollBottom();
      i++;
      if (i >= text.length) {
        clearInterval(t);
        resolve();
      }
    }, 15);
  });
};

const toggleChat = async () => {
  open.value = !open.value;
  if (open.value) {
    await loadMessages();
    await loadAiStatus();
    nextTick(() => inputRef.value?.focus());
  }
};

const sendMessage = async () => {
  if (!input.value.trim() || typing.value) return;

  const text = input.value;
  input.value = "";
  hideSuggestions();

  messages.value.push({ from: "user", text });
  scrollBottom();

  messages.value.push({ from: "admin", html: "" });
  const idx = messages.value.length - 1;
  typing.value = true;

  await loadAiStatus();

  if (aiEnabled.value) {
    try {
      const res = await api.post("ai/chat", { message: text });
      await typewriter(res.data.reply, idx);
    } catch {
      messages.value[idx].html = "⚠️ Lỗi AI!";
    }
  }
  else {
    try {
      await api.post("Admin/reply", {
        userId,
        message: text,
      });

      await typewriter(
        "👨‍💼 Tin nhắn đã được gửi tới Admin!",
        idx
      );
    } catch {
      messages.value[idx].html = "⚠️ Không gửi được!";
    }
  }

  typing.value = false;
};
</script>


<style scoped>
.animate-pop {
  animation: popIn 0.25s ease-out;
}
@keyframes popIn {
  from { opacity: 0; transform: scale(0.85) translateY(10px); }
  to   { opacity: 1; transform: scale(1) translateY(0); }
}

.dot {
  width: 7px;
  height: 7px;
  margin-right: 2px;
  background: #9ca3af;
  border-radius: 50%;
  display: inline-block;
  animation: blink 1.4s infinite both;
}
.dot:nth-child(2){ animation-delay: 0.2s; }
.dot:nth-child(3){ animation-delay: 0.4s; }

@keyframes blink {
  0% { opacity: .2; }
  20% { opacity: 1; }
  100% { opacity: .2; }
}

.suggestions::-webkit-scrollbar { display: none; }
.suggestion-item {
  padding: 10px 16px;
  background: white;
  border-radius: 18px;
  border: 1px solid #e5e7eb;
  box-shadow: 0 1px 2px rgba(0,0,0,0.05);
  cursor: pointer;
  transition: .2s ease;
  display: flex;
  flex-direction: column;
  align-items: center;
}
.suggestion-item:hover {
  background: #f5f5ff;
  transform: translateY(-2px);
  border-color: #c7c9ff;
}

.message-bubble p,
.message-bubble li {
  margin: 0;
}

</style>
