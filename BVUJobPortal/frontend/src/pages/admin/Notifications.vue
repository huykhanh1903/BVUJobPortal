<template>
  <div class="min-h-screen bg-gray-50 p-6">
    <h1 class="text-2xl font-bold text-gray-800 mb-6">🔔 Quản lý thông báo</h1>

    <div class="bg-white shadow rounded-xl p-6 mb-6">
      <h2 class="text-lg font-semibold mb-4">➕ Tạo thông báo mới</h2>
      <div>
        <label class="block text-sm text-gray-600 mb-1">Kiểu gửi</label>
        <select
          v-model="newNotification.kieuGui"
          class="w-full px-3 py-2 border rounded-lg"
        >
          <option value="personal">👤 Gửi 1 người dùng</option>
          <option value="role">👥 Gửi theo vai trò</option>
          <option value="all">🌍 Gửi toàn hệ thống</option>
        </select>
      </div>
      <div v-if="newNotification.kieuGui === 'personal'">
        <label class="block text-sm text-gray-600 mb-1">ID người dùng</label>
        <input
          v-model.number="newNotification.nguoiDungId"
          type="number"
          placeholder="Nhập ID người dùng"
          class="w-full px-3 py-2 border rounded-lg"
        />
      </div>
      <div v-if="newNotification.kieuGui === 'role'">
        <label class="block text-sm text-gray-600 mb-1">Vai trò</label>
        <select
          v-model="newNotification.vaiTro"
          class="w-full px-3 py-2 border rounded-lg"
        >
          <option value="SinhVien">Sinh viên</option>
          <option value="NhaTuyenDung">Nhà tuyển dụng</option>
          <option value="DoanhNghiep">Doanh nghiệp</option>
          <option value="Admin">Admin</option>
        </select>
      </div><div v-if="newNotification.kieuGui === 'all'" class="text-sm text-gray-500">
        Thông báo sẽ được gửi tới toàn bộ người dùng trong hệ thống.
      </div>
      <form @submit.prevent="createNotification" class="space-y-4">
        <div>
          <label class="block text-sm text-gray-600 mb-1">Tiêu đề</label>
          <input
            v-model="newNotification.tieuDe"
            type="text"
            placeholder="Nhập tiêu đề..."
            class="w-full px-3 py-2 border rounded-lg"
            required
          />
        </div>
        <div>
          <label class="block text-sm text-gray-600 mb-1">Nội dung</label>
          <textarea
            v-model="newNotification.noiDung"
            rows="3"
            placeholder="Nhập nội dung..."
            class="w-full px-3 py-2 border rounded-lg"
            required
          ></textarea>
        </div>
        <div class="flex justify-end">
          <button
            type="submit"
            class="px-4 py-2 bg-indigo-600 text-white rounded-lg hover:bg-indigo-700"
            :disabled="loading"
          >
            {{ loading ? "Đang gửi..." : "Gửi thông báo" }}
          </button>
        </div>
      </form>
    </div>

    <div class="bg-white shadow rounded-xl overflow-hidden">
      <table class="min-w-full border-collapse" v-if="!loading && notifications.length > 0">
        <thead>
          <tr class="bg-indigo-600 text-white text-left text-sm">
            <th class="px-4 py-3 w-16">ID</th>
            <th class="px-4 py-3">Tiêu đề</th>
            <th class="px-4 py-3">Nội dung</th>
            <th class="px-4 py-3">Người tạo</th>
            <th class="px-4 py-3">Ngày tạo</th>
          </tr>
        </thead>
        <tbody>
          <tr v-for="n in notifications" :key="n.id" class="border-b hover:bg-gray-50 text-sm">
            <td class="px-4 py-3 font-mono text-gray-600">{{ n.id }}</td>
            <td class="px-4 py-3 font-semibold text-indigo-700">{{ n.tieuDe }}</td>
            <td class="px-4 py-3 text-gray-700">{{ n.noiDung }}</td>
            <td class="px-4 py-3">{{ n.nguoiTao }}</td>
            <td class="px-4 py-3 text-gray-500">{{ new Date(n.ngayTao).toLocaleString("vi-VN") }}</td>
          </tr>
        </tbody>
      </table>

      <div v-if="loading" class="p-6 text-center text-gray-500">⏳ Đang tải dữ liệu...</div>

      <div v-if="!loading && notifications.length === 0" class="p-6 text-center text-gray-500">
        🚫 Chưa có thông báo nào.
      </div>
    </div>
  </div>
</template>

<script setup>
import { ref, onMounted } from "vue";
import api from "@/api/axios";
import { useAuthStore } from "@/store/auth";
import { useToast } from "vue-toastification";

const auth = useAuthStore();
const toast = useToast();

const notifications = ref([]);
const newNotification = ref({
  tieuDe: "",
  noiDung: "",
  loai: "HeThong",
  nguoiDungId: null,
  vaiTro: "",
  guiToanHeThong: false,
  kieuGui: "role",
});
const loading = ref(false);

const fetchNotifications = async () => {
  loading.value = true;
  try {
    const res = await api.get("/Admin/thong-bao", {
      headers: { Authorization: `Bearer ${auth.token}` },
    });
    notifications.value = res.data || [];
  } catch (err) {
    console.error("Lỗi tải thông báo:", err);
    toast.error("Không thể tải thông báo!");
  } finally {
    loading.value = false;
  }
};

const createNotification = async () => {
  if (!newNotification.value.tieuDe.trim() || !newNotification.value.noiDung.trim()) {
    return toast.error("Vui lòng nhập đầy đủ tiêu đề và nội dung!");
  }

  const payload = {
    tieuDe: newNotification.value.tieuDe,
    noiDung: newNotification.value.noiDung,
    loai: newNotification.value.loai,
    url: null,
    nguoiDungId: null,
    vaiTro: null,
    guiToanHeThong: false,
  };

  if (newNotification.value.kieuGui === "personal") {
    payload.nguoiDungId = newNotification.value.nguoiDungId;
  }

  if (newNotification.value.kieuGui === "role") {
    payload.vaiTro = newNotification.value.vaiTro;
  }

  if (newNotification.value.kieuGui === "all") {
    payload.guiToanHeThong = true;
  }

  loading.value = true;
  try {
    await api.post("/Admin/thong-bao", payload, {
      headers: { Authorization: `Bearer ${auth.token}` },
    });

    toast.success("Gửi thông báo thành công!");
    fetchNotifications();

    newNotification.value = {
      tieuDe: "",
      noiDung: "",
      loai: "HeThong",
      nguoiDungId: null,
      vaiTro: "",
      guiToanHeThong: false,
      kieuGui: "role",
    };
  } catch (err) {
    console.error(err);
    toast.error("Gửi thông báo thất bại!");
  } finally {
    loading.value = false;
  }
};


onMounted(fetchNotifications);
</script>
