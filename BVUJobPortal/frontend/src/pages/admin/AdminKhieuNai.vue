<template>
  <div class="min-h-screen bg-gray-50 p-6">
    <h1 class="text-2xl font-bold text-gray-800 mb-6">📨 Quản lý khiếu nại</h1>

    <div class="bg-white rounded-2xl shadow overflow-hidden">
      <table class="w-full text-sm">
        <thead class="bg-indigo-600 text-white text-left">
          <tr>
            <th class="p-4">Người gửi</th>
            <th class="p-4">Nội dung</th>
            <th class="p-4">Ngày gửi</th>
            <th class="p-4 text-center">Trạng thái</th>
            <th class="p-4 text-center w-32">Thao tác</th>
          </tr>
        </thead>

        <tbody>
          <tr
            v-for="kn in danhSach"
            :key="kn.id"
            class="border-t hover:bg-gray-50"
          >
            <td class="p-4">
              <div class="font-semibold text-gray-800">
                {{ kn.nguoiDung.hoTen }}
              </div>
              <div class="text-xs text-gray-500">
                {{ kn.nguoiDung.email }}
              </div>
            </td>

            <td class="p-4 max-w-md">
              <p class="truncate text-gray-700">
                {{ kn.noiDung }}
              </p>
            </td>
->
            <td class="p-4 text-gray-600">
              {{ formatDate(kn.ngayGui) }}
            </td>

            <td class="p-4 text-center">
              <span
                class="px-3 py-1 rounded-full text-xs font-semibold"
                :class="badgeClass(kn.trangThai)"
              >
                {{ hienThiTrangThai(kn.trangThai) }}
              </span>
            </td>

            <td class="p-4 text-center">
              <button
                v-if="kn.trangThai === 'DangXuLy'"
                @click="chonKhieuNai(kn)"
                class="px-3 py-1 bg-indigo-600 text-white rounded-lg text-xs hover:bg-indigo-700"
              >
                👁️ Xử lý
              </button>
            </td>
          </tr>
        </tbody>
      </table>

      <div
        v-if="danhSach.length === 0"
        class="p-6 text-center text-gray-500"
      >
        🚫 Không có khiếu nại nào
      </div>
    </div>

    <div
      v-if="selected"
      class="fixed inset-0 bg-black/50 flex items-center justify-center z-50"
    >
      <div
        class="bg-white rounded-2xl w-full max-w-lg p-6 shadow-2xl animate-fade-in"
      >
        <div class="flex justify-between items-center mb-4">
          <h2 class="text-lg font-bold text-gray-800">
            🛠️ Xử lý khiếu nại
          </h2>
          <button
            @click="selected = null"
            class="text-2xl text-gray-400 hover:text-gray-700"
          >
            ×
          </button>
        </div>

        <div class="space-y-3 text-sm text-gray-700">
          <p>
            <b>👤 Người gửi:</b> {{ selected.nguoiDung.hoTen }}
          </p>
          <p>
            <b>📧 Email:</b> {{ selected.nguoiDung.email }}
          </p>
          <p>
            <b>📄 Nội dung:</b>
            <span class="block mt-1 text-gray-600 whitespace-pre-line">
              {{ selected.noiDung }}
            </span>
          </p>
        </div>

        <textarea
          v-model="phanHoi"
          rows="3"
          placeholder="Nhập phản hồi của admin..."
          class="w-full border rounded-xl p-3 mt-4 focus:ring focus:ring-indigo-300"
        />

        <div class="flex justify-end gap-3 mt-6">
          <button
            @click="xuLy('TuChoi')"
            class="px-4 py-2 bg-gray-300 rounded-xl hover:bg-gray-400"
          >
            ❌ Từ chối
          </button>
          <button
            @click="xuLy('DaChapNhan')"
            class="px-4 py-2 bg-green-600 text-white rounded-xl hover:bg-green-700"
          >
            ✅ Chấp nhận & mở khóa
          </button>
        </div>
      </div>
    </div>
  </div>
</template>

<script setup>
import { ref, onMounted } from "vue";
import api from "@/api/axios";
import { useToast } from "vue-toastification";

const toast = useToast();
const danhSach = ref([]);
const selected = ref(null);
const phanHoi = ref("");

onMounted(async () => {
  const res = await api.get("/khieu-nai");
  danhSach.value = res.data || [];
});

const chonKhieuNai = (kn) => {
  selected.value = kn;
  phanHoi.value = "";
};

const xuLy = async (trangThai) => {
  await api.put(`/khieu-nai/${selected.value.id}/xu-ly`, {
    trangThai,
    phanHoiAdmin: phanHoi.value,
  });

  toast.success("✔ Xử lý thành công!");

  selected.value.trangThai = trangThai;
  selected.value.phanHoiAdmin = phanHoi.value;
  selected.value = null;
};

const formatDate = (d) =>
  d ? new Date(d).toLocaleString("vi-VN") : "—";

const hienThiTrangThai = (s) => ({
  DangXuLy: "Đang xử lý",
  DaChapNhan: "Đã chấp nhận",
  TuChoi: "Từ chối",
}[s] || s);

const badgeClass = (s) => ({
  DangXuLy: "bg-yellow-100 text-yellow-700",
  DaChapNhan: "bg-green-100 text-green-700",
  TuChoi: "bg-red-100 text-red-700",
}[s]);
</script>

<style scoped>
@keyframes fade-in {
  from {
    opacity: 0;
    transform: scale(0.95);
  }
  to {
    opacity: 1;
    transform: scale(1);
  }
}
.animate-fade-in {
  animation: fade-in 0.25s ease-out;
}
</style>
