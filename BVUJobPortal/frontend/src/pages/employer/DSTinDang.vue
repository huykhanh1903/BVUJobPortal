<template>
  <div class="min-h-screen bg-gradient-to-br from-gray-50 via-blue-50 to-white p-6 md:p-10 font-[Inter]">

    <div class="flex flex-wrap justify-between items-center mb-8 gap-4">
      <div>
        <h1 class="text-3xl md:text-4xl font-extrabold text-gray-800 flex items-center gap-2">
          💼 <span>Quản lý tin tuyển dụng</span>
        </h1>
        <p class="text-gray-500 mt-1 text-sm md:text-base">
          Xem, theo dõi và quản lý các tin việc làm bạn đã đăng.
        </p>
      </div>

      <router-link
        to="/nha-tuyen-dung/dang-tin"
        class="px-5 py-3 bg-gradient-to-r from-blue-600 to-indigo-600 text-white font-semibold rounded-xl shadow-md hover:shadow-lg hover:scale-105 transition-transform text-sm md:text-base"
      >
        ➕ Đăng tin mới
      </router-link>
    </div>

    <div class="flex flex-wrap gap-3 bg-white rounded-2xl p-4 shadow-sm border border-gray-100 mb-6 items-center">
      <div class="relative flex-1">
        <input
          v-model="search"
          placeholder="🔍 Tìm theo tiêu đề, vị trí hoặc công ty..."
          class="w-full px-5 py-3 border rounded-xl focus:ring-2 focus:ring-indigo-500 outline-none shadow-sm placeholder-gray-400"
        />
      </div>

      <select
        v-model="filter"
        class="px-4 py-3 border rounded-xl bg-gray-50 text-gray-700 focus:ring-2 focus:ring-indigo-500 outline-none shadow-sm"
      >
        <option value="all">Tất cả</option>
        <option value="approved">✅ Đã duyệt</option>
        <option value="pending">🕓 Chờ duyệt</option>
      </select>
    </div>

    <div class="hidden md:block bg-white shadow-lg rounded-2xl border border-gray-100 table-wrapper">
      <table class="min-w-full divide-y divide-gray-200 text-sm">
        <thead class="bg-gradient-to-r from-blue-50 to-indigo-50">
          <tr>
            <th class="px-6 py-4 text-left font-semibold text-gray-600 uppercase tracking-wider">Tiêu đề</th>
            <th class="px-6 py-4 text-left font-semibold text-gray-600 uppercase tracking-wider">Vị trí</th>
            <th class="px-6 py-4 text-left font-semibold text-gray-600 uppercase tracking-wider">Mức lương</th>
            <th class="px-6 py-4 text-left font-semibold text-gray-600 uppercase tracking-wider">Trạng thái</th>
            <th class="px-6 py-4 text-left font-semibold text-gray-600 uppercase tracking-wider">Ngày đăng</th>
            <th class="px-6 py-4 text-left font-semibold text-gray-600 uppercase tracking-wider">Hạn nộp</th>
            <th class="px-6 py-4 text-center font-semibold text-gray-600 uppercase tracking-wider">Thao tác</th>
          </tr>
        </thead>

        <tbody class="divide-y divide-gray-100">
          <tr
            v-for="job in filteredJobs"
            :key="job.id"
            class="hover:bg-blue-50/50 transition-colors"
          >
            <td class="px-6 py-4">
              <p class="font-medium text-gray-800 truncate">{{ job.tieuDe }}</p>
              <p class="text-gray-400 text-sm">{{ job.tenCongTy || "—" }}</p>
            </td>

            <td class="px-6 py-4 text-gray-700">{{ formatKhuVuc(job.khuVucLamViec) }}</td>

            <td class="px-6 py-4 text-gray-700">
              {{ formatSalary(job) }}
            </td>

            <td class="px-6 py-4">
              <span
                class="px-3 py-1.5 rounded-full text-xs font-semibold"
                :class="job.daDuyet ? 'bg-green-100 text-green-700' : 'bg-yellow-100 text-yellow-700'"
              >
                {{ job.daDuyet ? "Đã duyệt" : "Chờ duyệt" }}
              </span>
            </td>

            <td class="px-6 py-4 text-gray-500">{{ formatDate(job.ngayDang) }}</td>
            <td class="px-6 py-4 text-gray-500">{{ formatDate(job.hanNopHoSo) }}</td>

            <td class="px-6 py-4 text-center">
              <div class="flex justify-center gap-3">
                <router-link
                  :to="`/nha-tuyen-dung/tin-tuyen-dung/${job.id}`"
                  class="text-blue-600 hover:text-blue-800 font-medium"
                  title="Xem"
                >
                  👁️
                </router-link>

                <button
                  @click="openDeleteModal(job)"
                  class="text-red-600 hover:text-red-800 font-medium"
                  title="Xoá"
                >
                  🗑️
                </button>
              </div>
            </td>
          </tr>

          <tr v-if="filteredJobs.length === 0">
            <td colspan="7" class="text-center py-10 text-gray-500">
              😢 Không tìm thấy tin tuyển dụng nào phù hợp.
            </td>
          </tr>
        </tbody>
      </table>
    </div>

    <div class="md:hidden space-y-4">
      <div
        v-for="job in filteredJobs"
        :key="job.id"
        class="bg-white rounded-2xl p-4 shadow border border-gray-100 hover:shadow-md transition-all"
      >
        <div class="flex justify-between items-start">
          <div>
            <h3 class="text-lg font-semibold text-gray-800 leading-tight">{{ job.tieuDe }}</h3>
            <p class="text-gray-500 text-sm">{{ job.tenCongTy || "—" }}</p>
          </div>

          <span
            class="text-xs px-2 py-1 rounded-full"
            :class="job.daDuyet ? 'bg-green-100 text-green-700' : 'bg-yellow-100 text-yellow-700'"
          >
            {{ job.daDuyet ? "Đã duyệt" : "Chờ duyệt" }}
          </span>
        </div>

        <div class="mt-3 text-gray-600 text-sm space-y-1">
          <p>📍 {{ formatKhuVuc(job.khuVucLamViec) }}</p>
          <p>💰 {{ formatSalary(job) }}</p>
          <p>📅 Ngày đăng: {{ formatDate(job.ngayDang) }}</p>
          <p>⏰ Hạn nộp: {{ formatDate(job.hanNopHoSo) }}</p>
        </div>

        <div class="flex justify-end gap-2 mt-4 text-sm font-medium">
          <router-link
            :to="`/nha-tuyen-dung/tin-tuyen-dung/${job.id}`"
            class="px-3 py-1 rounded-lg bg-blue-100 text-blue-700"
          >
            👁️ Xem
          </router-link>

          <button
            @click="openDeleteModal(job)"
            class="px-3 py-1 rounded-lg bg-red-100 text-red-700"
          >
            🗑️ Xoá
          </button>
        </div>
      </div>

      <div v-if="filteredJobs.length === 0" class="text-center py-10 text-gray-500">
        😢 Không có tin tuyển dụng nào.
      </div>
    </div>

    <div
      v-if="showModal"
      class="fixed inset-0 bg-black/40 backdrop-blur-sm flex items-center justify-center z-50"
    >
      <div class="bg-white p-8 rounded-2xl shadow-2xl w-full max-w-md text-center animate-fade-in">
        <h2 class="text-2xl font-bold text-gray-800 mb-3">Xoá tin tuyển dụng?</h2>

        <p class="text-gray-500 mb-6">
          Bạn có chắc chắn muốn xoá tin
          <span class="font-semibold text-gray-700">“{{ selectedJob?.tieuDe }}”</span>?
        </p>

        <div class="flex justify-center gap-4">
          <button @click="showModal = false" class="px-5 py-2 bg-gray-200 rounded-lg">
            Hủy
          </button>
          <button @click="deleteJob(selectedJob.id)" class="px-5 py-2 bg-red-600 text-white rounded-lg">
            Xoá
          </button>
        </div>
      </div>
    </div>

  </div>
</template>

<script setup>
import { ref, computed, onMounted } from "vue";
import api from "@/api/axios";
import { useToast } from "vue-toastification";
import { useAuthStore } from "@/store/auth";

const auth = useAuthStore();
const toast = useToast();

const jobs = ref([]);
const search = ref("");
const filter = ref("all");
const showModal = ref(false);
const selectedJob = ref(null);

function formatDate(date) {
  if (!date || date === "0001-01-01T00:00:00") return "—";
  return new Date(date).toLocaleDateString("vi-VN");
}

function formatSalary(j) {
  if (j.kieuLuong === "TuDen") {
    return `${j.luongTu?.toLocaleString("vi-VN")}₫ - ${j.luongDen?.toLocaleString("vi-VN")}₫`;
  }
  return "Thỏa thuận";
}

async function fetchJobs() {
  try {
    const res = await api.get("/CongViec/lich-su-dang-tuyen", {
      headers: { Authorization: `Bearer ${auth.token}` },
    });
    jobs.value = res.data || [];
  } catch {
    toast.error("Không thể tải danh sách!");
  }
}

const filteredJobs = computed(() =>
  jobs.value.filter((j) => {
    const text = search.value.toLowerCase();
    const matchText =
      j.tieuDe.toLowerCase().includes(text) ||
      (j.viTri || "").toLowerCase().includes(text) ||
      (j.tenCongTy || "").toLowerCase().includes(text);

    const matchStatus =
      filter.value === "all"
        ? true
        : filter.value === "approved"
        ? j.daDuyet
        : !j.daDuyet;

    return matchText && matchStatus;
  })
);

function openDeleteModal(job) {
  selectedJob.value = job;
  showModal.value = true;
}

async function deleteJob(id) {
  try {
    await api.delete(`/CongViec/xoa/${id}`, {
      headers: { Authorization: `Bearer ${auth.token}` },
    });

    jobs.value = jobs.value.filter((x) => x.id !== id);
    toast.success("🗑️ Đã xoá tin tuyển dụng!");
  } catch {
    toast.error("❌ Xoá thất bại!");
  } finally {
    showModal.value = false;
  }


}
function formatKhuVuc(list) {
  if (!list || list.length === 0) return "—";
  return list.join(", ");
}

onMounted(fetchJobs);
</script>

<style scoped>
.table-wrapper {
  scrollbar-gutter: stable;
  overflow-y: auto;
  max-height: 720px;
}

table {
  table-layout: fixed;
}

td, th {
  white-space: nowrap;
  overflow: hidden;
  text-overflow: ellipsis;
}

td:nth-child(4) span {
  min-width: 90px;
  text-align: center;
}

@keyframes fade-in {
  from { opacity: 0; transform: scale(0.9); }
  to { opacity: 1; transform: scale(1); }
}

.animate-fade-in {
  animation: fade-in 0.25s ease-in-out;
}
</style>