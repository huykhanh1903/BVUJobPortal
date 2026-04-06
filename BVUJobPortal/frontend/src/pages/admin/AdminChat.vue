<template>
  <div class="min-h-screen bg-gray-100 p-6">
    <div class="max-w-[100%] mx-auto bg-white rounded-2xl shadow-lg p-6">
      <h1 class="text-2xl font-bold mb-4 flex items-center gap-2">
        💬 Hộp thư người dùng 
      </h1>

      <div class="grid grid-cols-4 gap-4">

        <div class="col-span-1 bg-gray-50 border rounded-xl p-3 h-[600px] overflow-y-auto">
          <h2 class="font-semibold text-gray-700 mb-3">Danh sách người dùng</h2>

          <div
            v-for="u in danhSachNguoiDung"
            :key="u.userId"
            @click="chonNguoiDung(u)"
            class="p-3 rounded-lg cursor-pointer flex items-center gap-3 hover:bg-indigo-50 transition"
            :class="selectedUserId === u.userId ? 'bg-indigo-100 border border-indigo-300' : ''"
          >
            <div class="w-10 h-10 flex items-center justify-center rounded-full bg-indigo-500 text-white font-semibold">
              {{ u.hoTen.charAt(0) }}
            </div>

            <div>
              <p class="font-medium text-gray-800">{{ u.hoTen }}</p>
              <p class="text-xs text-gray-400">ID: {{ u.userId }}</p>
            </div>
          </div>
        </div>

        <div class="col-span-2 flex flex-col bg-white border rounded-xl h-[600px]">
          <div class="p-3 border-b bg-gray-50 rounded-t-xl flex items-center gap-3">
            <span v-if="selectedUser">
              💼 Đang chat với:
              <strong class="text-indigo-600">{{ selectedUser.hoTen }}</strong>
            </span>
            <span v-else class="text-gray-500">Chọn người dùng để bắt đầu chat</span>
          </div>

          <div ref="box" class="flex-1 p-4 space-y-3 overflow-y-auto bg-gray-50">

            <div
              v-for="m in messages"
              :key="m.id"
              class="flex gap-2"
              :class="m.isFromAI || m.isFromAdmin ? '' : 'flex-row-reverse'"
            >
              <div
                class="w-8 h-8 flex items-center justify-center rounded-full shadow text-white text-sm"
                :class="m.isFromAdmin ? 'bg-indigo-600' : 'bg-purple-600'"
              >
                {{ m.isFromAdmin ? 'A' : 'U' }}
              </div>

              <div
                class="px-3 py-2 rounded-xl text-sm max-w-[70%] shadow"
                :class="m.isFromAdmin
                  ? 'bg-indigo-600 text-white rounded-br-none'
                  : 'bg-white text-gray-800 rounded-bl-none'"
              >
                {{ m.message }}
              </div>
            </div>

          </div>

          <div class="p-3 border-t flex items-center gap-2">
            <input
              v-model="input"
              @keyup.enter="sendMessage"
              placeholder="Nhập phản hồi..."
              class="flex-1 border px-3 py-2 rounded-xl focus:ring-indigo-500"
            />
            <button
              @click="sendMessage"
              class="px-4 py-2 bg-indigo-600 text-white rounded-xl hover:bg-indigo-700"
            >
              Gửi
            </button>
          </div>
        </div>

        <div class="col-span-1 p-4 bg-gray-50 rounded-xl border shadow-sm h-[600px]">
          <h2 class="text-lg font-semibold mb-2">⚙️ Cấu hình AI trợ lý</h2>
          <p class="text-gray-600 mb-4 text-sm">
            Khi tắt AI, sinh viên sẽ chat trực tiếp với Admin.
          </p>

          <div class="p-5 border rounded-xl bg-white flex items-center justify-between">
            <div>
              <p class="text-sm text-gray-500">Trạng thái AI</p>
              <p class="text-lg font-semibold"
                 :class="aiEnabled ? 'text-green-600' : 'text-red-600'">
                {{ aiEnabled ? 'Đang bật' : 'Đang tắt' }}
              </p>
            </div>

            <button
              @click="toggleAI"
              class="relative inline-flex h-8 w-16 rounded-full transition cursor-pointer"
              :class="aiEnabled ? 'bg-green-500' : 'bg-red-500'"
            >
              <span
                class="absolute h-7 w-7 bg-white rounded-full shadow transform transition-all"
                :class="aiEnabled ? 'translate-x-8' : 'translate-x-1'"
              ></span>
            </button>
          </div>

          <button
            @click="toggleAI"
            class="mt-6 w-full py-3 rounded-lg text-white font-semibold shadow transition"
            :class="aiEnabled ? 'bg-red-500 hover:bg-red-600' : 'bg-green-600 hover:bg-green-700'"
          >
            {{ aiEnabled ? 'Tắt AI ngay' : 'Bật AI ngay' }}
          </button>
        </div>

      </div>
    </div>
  </div>
</template>

<script setup>
import { ref, onMounted, nextTick } from "vue";
import api from "@/api/axios";
import { useAuthStore } from "@/store/auth";
import { useToast } from "vue-toastification";

const toast = useToast();
const auth = useAuthStore();

const danhSachNguoiDung = ref([]);
const messages = ref([]);
const selectedUser = ref(null);
const selectedUserId = ref(null);
const input = ref("");
const box = ref(null);
const aiEnabled = ref(true);

const fetchDanhSach = async () => {
  try {
    const res = await api.get("/Admin/messages");
    const adminId = auth.user.id;
    const users = {};

    res.data.forEach(m => {
      if (m.senderId !== 0 && m.senderId !== adminId) {
        users[m.senderId] = { userId: m.senderId, hoTen: "Người dùng " + m.senderId };
      }
      if (m.senderId === 0 && m.receiverId !== adminId) {
        users[m.receiverId] = { userId: m.receiverId, hoTen: "Người dùng " + m.receiverId };
      }
    });

    danhSachNguoiDung.value = Object.values(users);
  } catch (err) {
    console.error(err);
  }
};

const chonNguoiDung = async (user) => {
  selectedUser.value = user;
  selectedUserId.value = user.userId;

  const res = await api.get("/Admin/messages");

  messages.value = res.data
    .filter(m => m.senderId === selectedUserId.value || m.receiverId === selectedUserId.value)
    .map(m => ({
      ...m,
      isFromAdmin: m.senderId === auth.user.id,
      isFromAI: m.senderId === 0
    }));

  await nextTick();
  box.value.scrollTop = box.value.scrollHeight;
};

const sendMessage = async () => {
  if (!input.value.trim()) return;

  const text = input.value;
  input.value = "";

  await api.post("/Admin/reply", { userId: selectedUserId.value, message: text });

  messages.value.push({
    id: Date.now(),
    message: text,
    isFromAdmin: true
  });

  nextTick(() => {
    box.value.scrollTop = box.value.scrollHeight;
  });
};

setInterval(async () => {
  if (selectedUserId.value) await chonNguoiDung(selectedUser.value);
}, 2000);

const toggleAI = async () => {
  try {
    const newStatus = !aiEnabled.value;
    const res = await api.put(`/Admin/toggle-ai?enable=${newStatus}`);
    
    aiEnabled.value = newStatus;

    if (newStatus) {
      toast.success("AI đã được bật!");
    } else {
      toast.error("AI đã bị tắt!");
    }

  } catch (err) {
    toast.error("Không thể cập nhật trạng thái AI!");
  }
};


onMounted(fetchDanhSach);
</script>

<style scoped>
::-webkit-scrollbar {
  width: 6px;
}
::-webkit-scrollbar-thumb {
  background: #cbd5e1;
  border-radius: 10px;
}
</style>
