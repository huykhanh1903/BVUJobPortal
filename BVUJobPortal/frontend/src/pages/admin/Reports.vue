<template>
  <div class="min-h-screen bg-gray-50 p-6">
    <h1 class="text-2xl font-bold text-gray-800 mb-6">🚨 Quản lý báo cáo</h1>

    <div class="bg-white shadow rounded-xl p-4 mb-6 grid md:grid-cols-4 gap-4 items-end">
      <div>
        <label class="block text-sm text-gray-600 mb-1">Trạng thái</label>
        <select v-model="status" class="px-3 py-2 border rounded-lg bg-white w-full">
          <option value="">Tất cả</option>
          <option value="chuaxuly">Chưa xử lý</option>
          <option value="daxuly">Đã xử lý</option>
        </select>
      </div>
      <div class="md:col-span-2">
        <label class="block text-sm text-gray-600 mb-1">Tìm theo tiêu đề / nội dung</label>
        <input
          v-model="keyword"
          type="text"
          placeholder="Nhập từ khóa..."
          class="px-3 py-2 border rounded-lg w-full"
        />
      </div>
      <div class="flex gap-2 justify-end">
        <button @click="applyFilter" class="px-4 py-2 bg-indigo-600 text-white rounded-lg hover:bg-indigo-700">
          Lọc
        </button>
        <button @click="resetFilter" class="px-4 py-2 bg-gray-300 text-gray-700 rounded-lg hover:bg-gray-400">
          Reset
        </button>
      </div>
    </div>

    <div class="bg-white shadow rounded-xl overflow-hidden">
      <table class="min-w-full border-collapse" v-if="!loading && reports.length > 0">
        <thead>
          <tr class="bg-indigo-600 text-white text-left text-sm">
            <th class="px-4 py-3 w-16">ID</th>
            <th class="px-4 py-3">Tiêu đề</th>
            <th class="px-4 py-3">Người gửi</th>
            <th class="px-4 py-3">Ngày gửi</th>
            <th class="px-4 py-3">Trạng thái</th>
            <th class="px-4 py-3 text-center w-40">Thao tác</th>
          </tr>
        </thead>
        <tbody>
          <tr v-for="r in reports" :key="r.id" class="border-b hover:bg-gray-50 text-sm">
            <td class="px-4 py-3 font-mono text-gray-600">{{ r.id }}</td>
            <td class="px-4 py-3 font-medium">{{ r.tieuDe }}</td>
            <td class="px-4 py-3">{{ r.nguoiBaoCao || "Ẩn danh" }}</td>
            <td class="px-4 py-3 text-gray-500">{{ new Date(r.ngayTao).toLocaleDateString("vi-VN") }}</td>
            <td class="px-4 py-3">
              <span
                class="px-2 py-1 rounded-full text-xs font-semibold"
                :class="{
                  'bg-yellow-100 text-yellow-700': !r.daXuLy,
                  'bg-green-100 text-green-700': r.daXuLy
                }"
              >
                {{ r.daXuLy ? "✅ Đã xử lý" : "⏳ Chưa xử lý" }}
              </span>
            </td>
            <td class="px-3 py-2 text-center w-40 flex justify-center gap-2">
              <button
                @click="openDetailModal(r)"
                class="icon-btn bg-blue-500 hover:bg-blue-600"
                title="Xem chi tiết"
              >
                <EyeIcon class="w-5 h-5" />
              </button>
              <button
                v-if="!r.daXuLy"
                @click="handleReport(r)"
                class="icon-btn bg-green-500 hover:bg-green-600"
                title="Đánh dấu đã xử lý"
              >
                <CheckIcon class="w-5 h-5" />
              </button>
            </td>
          </tr>
        </tbody>
      </table>

      <div v-if="loading" class="p-6 text-center text-gray-500">⏳ Đang tải dữ liệu...</div>

      <div v-if="!loading && reports.length === 0" class="p-6 text-center text-gray-500">
        🚫 Không có báo cáo nào.
      </div>
    </div>

    <div v-if="showDetailModal" class="fixed inset-0 bg-black/50 flex items-center justify-center z-50">
      <div class="bg-white p-6 rounded-xl w-full max-w-lg shadow-xl">
        <h2 class="text-lg font-bold mb-4">📋 Chi tiết báo cáo</h2>
        <p><b>Tiêu đề:</b> {{ selectedReport?.tieuDe }}</p>
        <p><b>Nội dung:</b> {{ selectedReport?.noiDung }}</p>
        <p><b>Người gửi:</b> {{ selectedReport?.nguoiBaoCao || "Ẩn danh" }}</p>
        <p><b>Ngày gửi:</b> {{ new Date(selectedReport?.ngayTao).toLocaleString("vi-VN") }}</p>
        <div class="flex justify-end gap-2 mt-4">
          <button @click="closeDetailModal" class="px-4 py-2 rounded bg-gray-300 hover:bg-gray-400">Đóng</button>
        </div>
      </div>
    </div>
  </div>
</template>

<script setup>
import { ref, onMounted } from "vue";
import api from "@/api/axios";
import { useAuthStore } from "@/store/auth";
import { useToast } from "vue-toastification";
import { EyeIcon, CheckIcon } from "@heroicons/vue/24/solid";

const auth = useAuthStore();
const toast = useToast();

const reports = ref([]);
const page = ref(1), pageSize = ref(10);
const status = ref(""), keyword = ref("");
const loading = ref(false);

const showDetailModal = ref(false);
const selectedReport = ref(null);

const fetchReports = async () => {
  loading.value = true;
  try {
    const res = await api.get("/Admin/bao-cao", {
      headers: { Authorization: `Bearer ${auth.token}` },
    });
    reports.value = res.data || [];
  } catch (err) {
    console.error("Lỗi tải báo cáo:", err);
    toast.error("Không thể tải báo cáo!");
  } finally {
    loading.value = false;
  }
};

const openDetailModal = (report) => { selectedReport.value = report; showDetailModal.value = true; };
const closeDetailModal = () => { showDetailModal.value = false; selectedReport.value = null; };

const handleReport = async (report) => {
  try {
    await api.put(`/Admin/bao-cao/${report.id}/xu-ly`, {}, { headers: { Authorization: `Bearer ${auth.token}` } });
    report.daXuLy = true;
    toast.success("Đã xử lý báo cáo!");
  } catch (err) {
    console.error("Lỗi xử lý báo cáo:", err);
    toast.error("Xử lý thất bại!");
  }
};

const applyFilter = () => {
  let filtered = [...reports.value];
  if (status.value === "chuaxuly") filtered = filtered.filter(r => !r.daXuLy);
  if (status.value === "daxuly") filtered = filtered.filter(r => r.daXuLy);
  if (keyword.value) filtered = filtered.filter(r => 
    r.tieuDe.toLowerCase().includes(keyword.value.toLowerCase()) || 
    r.noiDung.toLowerCase().includes(keyword.value.toLowerCase())
  );
  reports.value = filtered;
};

const resetFilter = () => { status.value=""; keyword.value=""; fetchReports(); };

onMounted(fetchReports);
</script>

