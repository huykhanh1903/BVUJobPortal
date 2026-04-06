<template>
  <div class="relative">
    <button @click="toggle" class="relative text-xl">
      <i class="fa-regular fa-bell"></i>

      <span
        v-if="unreadCount > 0"
        class="absolute -top-2 -right-2 bg-red-500 text-white text-xs
               w-5 h-5 rounded-full flex items-center justify-center"
      >
        {{ unreadCount }}
      </span>
    </button>

    <div
      v-if="open"
      class="absolute right-0 mt-3 w-96 bg-white rounded-xl shadow-xl border z-50"
    >
      <div class="px-4 py-3 border-b font-semibold">
        🔔 Thông báo
      </div>

      <div v-if="loading" class="p-4 text-center text-gray-500">
        Đang tải...
      </div>

      <div v-else-if="notifications.length === 0"
           class="p-6 text-center text-gray-500">
        Không có thông báo
      </div>

      <div v-else class="max-h-96 overflow-y-auto">
        <div
          v-for="tb in notifications"
          :key="tb.id"
          @click="openThongBao(tb)"
          class="px-4 py-3 border-b cursor-pointer hover:bg-gray-50"
          :class="!tb.daDoc ? 'bg-indigo-50' : ''"
        >
          <p class="font-medium text-sm">
            {{ tb.tieuDe }}
          </p>
          <p class="text-xs text-gray-600 mt-1">
            {{ tb.noiDung }}
          </p>
        </div>
      </div>
    </div>
  </div>
</template>
<script setup>
import { ref, onMounted } from "vue";
import api from "@/api/axios";
import { useRouter } from "vue-router";

const router = useRouter();

const open = ref(false);
const loading = ref(false);
const notifications = ref([]);
const unreadCount = ref(0);

const toggle = async () => {
  open.value = !open.value;
  if (open.value) {
    await loadNotifications();
  }
};

const loadNotifications = async () => {
  loading.value = true;
  try {
    const [listRes, countRes] = await Promise.all([
      api.get("/ThongBao/danh-sach"),
      api.get("/ThongBao/chua-doc")
    ]);

    notifications.value = listRes.data ?? [];
    unreadCount.value = countRes.data ?? 0;
  } catch (e) {
    console.error("Lỗi load thông báo", e);
  } finally {
    loading.value = false;
  }
};

const openThongBao = async (tb) => {
  if (!tb.daDoc) {
    await api.post(`/ThongBao/danh-dau-doc/${tb.id}`);
    tb.daDoc = true;
    unreadCount.value--;
  }

  open.value = false;

  if (tb.url) {
    router.push(tb.url);
  }
};

onMounted(loadNotifications);
</script>
