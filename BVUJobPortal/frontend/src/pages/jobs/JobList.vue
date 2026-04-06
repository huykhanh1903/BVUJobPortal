<template>
  <div class="p-8 bg-gray-50 min-h-screen">
    <div class="flex justify-between items-center mb-8">
      <h1 class="text-3xl font-bold text-gray-800">📋 Danh sách tin tuyển dụng</h1>
      <router-link
        to="/nha-tuyen-dung/dang-tin"
        class="px-5 py-2 bg-blue-600 text-white rounded-lg shadow hover:bg-blue-700 transition"
      >
        ➕ Đăng tin mới
      </router-link>
    </div>

    <div v-if="loading" class="text-gray-500 text-center py-10">⏳ Đang tải danh sách...</div>

    <div v-else-if="jobs.length === 0" class="text-center py-16 bg-white rounded-2xl shadow">
      <p class="text-gray-600 mb-4 text-lg">Bạn chưa đăng tin tuyển dụng nào.</p>
      <router-link
        to="/nha-tuyen-dung/dang-tin"
        class="px-6 py-3 bg-indigo-600 text-white rounded-lg hover:bg-indigo-700"
      >
        ➕ Đăng tin ngay
      </router-link>
    </div>

    <div v-else class="grid sm:grid-cols-2 lg:grid-cols-3 gap-6">
      <div
        v-for="job in jobs"
        :key="job.id"
        class="bg-white rounded-xl shadow hover:shadow-xl transition p-5 flex flex-col justify-between"
      >
        <div>
          <h2 class="text-lg font-bold text-gray-800 truncate">{{ job.tieuDe }}</h2>
          <p class="text-sm text-gray-500 mt-1">📍 {{ job.diaDiem || "Chưa cập nhật" }}</p>
          <p class="text-sm text-gray-500">💰 {{ job.mucLuong || "Thỏa thuận" }}</p>
          <p class="text-sm text-gray-400 mt-2">
            🗓️ Hạn nộp: {{ formatDate(job.hanNopHoSo) }}
          </p>
        </div>

        <div class="flex gap-2 mt-4">
          <router-link
            :to="`/nha-tuyen-dung/chi-tiet/${job.id}`"
            class="flex-1 text-center px-3 py-2 rounded bg-gray-100 hover:bg-gray-200 text-sm"
          >
            👀 Xem
          </router-link>
          <router-link
            :to="`/nha-tuyen-dung/sua-tin/${job.id}`"
            class="flex-1 text-center px-3 py-2 rounded bg-yellow-100 hover:bg-yellow-200 text-sm text-yellow-700"
          >
            ✏️ Sửa
          </router-link>
          <button
            @click="deleteJob(job.id)"
            class="flex-1 text-center px-3 py-2 rounded bg-red-100 hover:bg-red-200 text-sm text-red-700"
          >
            🗑️ Xóa
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
import { useAuthStore } from "@/store/auth";

const auth = useAuthStore();
const toast = useToast();

const jobs = ref([]);
const loading = ref(true);

function formatDate(date) {
  if (!date || date === "0001-01-01T00:00:00") return "Không xác định";
  return new Date(date).toLocaleDateString("vi-VN");
}

async function fetchJobs() {
  loading.value = true;
  try {
    const res = await api.get("/CongViec/lich-su-dang-tuyen", {
      headers: { Authorization: `Bearer ${auth.token}` },
    });
    jobs.value = res.data || [];
  } catch (err) {
    console.error(err);
    toast.error("Không thể tải danh sách tin!");
  } finally {
    loading.value = false;
  }
}

async function deleteJob(id) {
  if (!confirm("Bạn có chắc muốn xóa tin này không?")) return;
  try {
    await api.delete(`/CongViec/xoa/${id}`, {
      headers: { Authorization: `Bearer ${auth.token}` },
    });
    jobs.value = jobs.value.filter((x) => x.id !== id);
    toast.success("🗑️ Đã xóa tin tuyển dụng!");
  } catch (err) {
    toast.error("Xóa thất bại!");
  }
}

onMounted(fetchJobs);
</script>