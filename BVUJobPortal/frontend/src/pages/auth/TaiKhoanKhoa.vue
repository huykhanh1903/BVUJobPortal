<template>
  <div
    class="min-h-screen flex items-center justify-center bg-gradient-to-br from-indigo-100 via-purple-100 to-pink-100 px-4"
  >
    <div
      class="relative max-w-md w-full bg-white/80 backdrop-blur-xl rounded-3xl shadow-2xl p-8 text-center border border-white"
    >
      <div
        class="absolute -top-10 left-1/2 -translate-x-1/2 w-32 h-32 bg-red-400/30 rounded-full blur-3xl"
      ></div>
      <div
        class="mx-auto mb-4 flex items-center justify-center h-20 w-20 rounded-full bg-red-100 text-red-600 text-4xl shadow-inner animate-pulse"
      >
        🔒
      </div>

      <h1 class="text-2xl font-extrabold text-gray-800 mb-2">
        Tài khoản đã bị khóa
      </h1>

      <p class="text-gray-600 mb-6 leading-relaxed">
        Rất tiếc! Tài khoản của bạn hiện không thể truy cập vào hệ thống
        <strong>BVU Job Portal</strong>.
      </p>
      <div
        class="bg-red-50 border border-red-200 rounded-2xl p-4 text-left text-red-700 mb-6"
      >
        <p class="font-semibold mb-1 flex items-center gap-2">
          ⚠️ Lý do khóa:
        </p>
        <p class="text-sm leading-relaxed">
          {{ lyDo }}
        </p>
      </div>

      <div class="bg-white rounded-2xl p-4 shadow-inner text-left mb-6">
        <label class="block text-sm font-semibold text-gray-700 mb-2">
          📝 Gửi khiếu nại đến quản trị viên
        </label>

        <textarea
          v-model="noiDung"
          rows="4"
          :disabled="daGuiKhieuNai"
          placeholder="Nhập nội dung khiếu nại của bạn..."
          class="w-full px-4 py-3 border rounded-xl text-sm resize-none
                 focus:ring-2 focus:ring-indigo-500 outline-none
                 disabled:bg-gray-100 disabled:cursor-not-allowed"
        ></textarea>

        <button
          @click="guiKhieuNai"
          :disabled="loading || daGuiKhieuNai || !noiDung.trim()"
          class="mt-3 w-full py-3 rounded-xl font-semibold transition
                 bg-indigo-600 text-white hover:bg-indigo-700
                 disabled:opacity-50"
        >
          <span v-if="daGuiKhieuNai">⏳ Đang chờ xử lý</span>
          <span v-else>{{ loading ? "Đang gửi..." : "Gửi khiếu nại" }}</span>
        </button>

        <div
          v-if="daGuiKhieuNai"
          class="mt-3 text-sm text-green-700 bg-green-50 border border-green-200 rounded-xl p-3"
        >
          ✅ Khiếu nại của bạn đã được gửi và đang chờ quản trị viên xử lý.
        </div>
      </div>

      <div class="flex flex-col gap-3">
        <router-link
          to="/"
          class="inline-flex items-center justify-center gap-2 px-6 py-3 rounded-xl
                 bg-gray-800 text-white font-semibold hover:bg-gray-900 transition shadow-lg"
        >
          🏠 Quay về trang chủ
        </router-link>
      </div>

      <p class="mt-6 text-xs text-gray-500">
        Khiếu nại của bạn sẽ được quản trị viên xem xét trong thời gian sớm nhất.
      </p>
    </div>
  </div>
</template>

<script setup>
import { ref, onMounted } from "vue";
import { useRoute } from "vue-router";
import api from "@/api/axios";
import { useToast } from "vue-toastification";

const route = useRoute();
const toast = useToast();

const lyDo =
  route.query.lyDo ||
  "Không có thông tin chi tiết về lý do khóa tài khoản.";

const noiDung = ref("");
const loading = ref(false);
const daGuiKhieuNai = ref(false);

onMounted(async () => {
  try {
    const res = await api.get("/khieu-nai/trang-thai");

    if (res.data?.trangThai === "DangXuLy") {
      daGuiKhieuNai.value = true;
    }
  } catch {
  }
});

const guiKhieuNai = async () => {
  if (!noiDung.value.trim()) {
    toast.error("Vui lòng nhập nội dung khiếu nại!");
    return;
  }

  loading.value = true;
  try {
    await api.post("/khieu-nai", {
      noiDung: noiDung.value,
    });

    toast.success(
      "Gửi khiếu nại thành công! Vui lòng chờ phản hồi từ quản trị viên."
    );

    noiDung.value = "";
    daGuiKhieuNai.value = true;
  } catch (err) {
    toast.error(
      err.response?.data?.thongBao ||
      "Bạn đã gửi khiếu nại trước đó. Vui lòng chờ xử lý."
    );
  } finally {
    loading.value = false;
  }
};
</script>

