<template>
  <div class="min-h-screen bg-gray-50 p-6">
    <h1 class="text-2xl font-bold text-gray-800 mb-6">💼 Quản lý công việc</h1>

    <div class="bg-white shadow rounded-xl p-4 mb-6 grid md:grid-cols-6 gap-4 items-end">
      <div>
        <label class="block text-sm text-gray-600 mb-1">Lĩnh vực</label>
        <select v-model="category" class="px-3 py-2 border rounded-lg bg-white w-full">
          <option value="">Tất cả</option>
          <option v-for="c in categories" :key="c.id" :value="c.tenLinhVuc">{{ c.tenLinhVuc }}</option>
        </select>
      </div>

      <div>
        <label class="block text-sm text-gray-600 mb-1">Trạng thái duyệt</label>
        <select v-model="status" class="px-3 py-2 border rounded-lg bg-white w-full">
          <option value="">Tất cả</option>
          <option value="daduyet">Đã duyệt</option>
          <option value="choduyet">Chờ duyệt</option>
        </select>
      </div>

      <div>
        <label class="block text-sm text-gray-600 mb-1">Từ ngày</label>
        <input v-model="fromDate" type="date" class="px-3 py-2 border rounded-lg bg-white w-full" />
      </div>

      <div>
        <label class="block text-sm text-gray-600 mb-1">Đến ngày</label>
        <input v-model="toDate" type="date" class="px-3 py-2 border rounded-lg bg-white w-full" />
      </div>

      <div class="md:col-span-2">
        <label class="block text-sm text-gray-600 mb-1">Tìm theo tiêu đề / công ty</label>
        <input
          v-model="keyword"
          type="text"
          placeholder="Nhập từ khóa..."
          class="px-3 py-2 border rounded-lg w-full"
        />
      </div>

      <div class="md:col-span-6 flex gap-2 justify-end">
        <button @click="applyFilter" class="px-4 py-2 bg-indigo-600 text-white rounded-lg hover:bg-indigo-700">
          🔍 Lọc
        </button>
        <button @click="resetFilter" class="px-4 py-2 bg-gray-300 text-gray-700 rounded-lg hover:bg-gray-400">
          Reset
        </button>
      </div>
    </div>

    <div class="bg-white shadow rounded-xl overflow-hidden">
      <table class="min-w-full border-collapse" v-if="!loading && jobs.length > 0">
        <thead>
          <tr class="bg-indigo-600 text-white text-left text-sm">
            <th class="px-4 py-3 w-16">ID</th>
            <th class="px-4 py-3">Tiêu đề</th>
            <th class="px-4 py-3">Công ty</th>
            <th class="px-4 py-3">Lĩnh vực</th>
            <th class="px-4 py-3">Ngày đăng</th>
            <th class="px-4 py-3 text-center">Trạng thái</th>
            <th class="px-4 py-3 text-center w-56">Thao tác</th>
          </tr>
        </thead>

        <tbody>
          <tr v-for="j in jobs" :key="j.id" class="border-b hover:bg-gray-50 text-sm">
            <td class="px-4 py-3 font-mono text-gray-600">{{ j.id }}</td>
            <td class="px-4 py-3 font-semibold text-indigo-700">{{ j.tieuDe }}</td>
            <td class="px-4 py-3">{{ j.tenCongTy || "—" }}</td>
            <td class="px-4 py-3">{{ j.linhVuc || "—" }}</td>
            <td class="px-4 py-3 text-gray-500">{{ formatDate(j.ngayDang) }}</td>
            <td class="px-4 py-3 text-center">
              <span
                class="px-2 py-1 rounded-full text-xs font-semibold"
                :class="{
                  'bg-green-100 text-green-700': j.daDuyet,
                  'bg-yellow-100 text-yellow-700': !j.daDuyet
                }"
              >
                {{ j.daDuyet ? "Đã duyệt" : "Chờ duyệt" }}
              </span>
            </td>

            <td class="px-3 py-2 text-center flex justify-center gap-2">
              <button @click="xemChiTiet(j)" class="icon-btn bg-blue-500 hover:bg-blue-600" title="Xem chi tiết">
                👁️
              </button>
              <button
                @click="openDeleteModal(j)"
                class="icon-btn bg-red-500 hover:bg-red-600"
                title="Xóa công việc"
              >
                🗑️
              </button>
            </td>
          </tr>
        </tbody>
      </table>

      <div v-if="loading" class="p-6 text-center text-gray-500">⏳ Đang tải dữ liệu...</div>
      <div v-if="!loading && jobs.length === 0" class="p-6 text-center text-gray-500">
        🚫 Không có công việc nào phù hợp.
      </div>
    </div>

    <div
      v-if="showDetailModal"
      class="fixed inset-0 bg-black/50 flex items-center justify-center z-50 overflow-y-auto"
    >
      <div class="bg-white max-w-5xl w-full rounded-xl shadow-xl p-8 my-8 space-y-6">
        <div class="flex justify-between items-start border-b pb-4">
          <div>
            <h2 class="text-2xl font-bold text-indigo-700 mb-1">{{ selectedJob?.tieuDe }}</h2>
            <p class="text-gray-600">💼 {{ selectedJob?.viTri }}</p>
            <p class="text-gray-500 text-sm">
              📅 Ngày đăng: {{ formatDate(selectedJob?.ngayDang) }} |
              ⏰ Hạn nộp: {{ formatDate(selectedJob?.hanNopHoSo) }}
            </p>
          </div>
          <span
            class="px-3 py-1 rounded-full text-sm font-semibold"
            :class="selectedJob?.daDuyet ? 'bg-green-100 text-green-700' : 'bg-yellow-100 text-yellow-700'"
          >
            {{ selectedJob?.daDuyet ? 'Đã duyệt' : 'Chờ duyệt' }}
          </span>
        </div>

        <section class="space-y-4 text-gray-700">
          <div>
            <h3 class="text-blue-700 font-semibold mb-1">📋 Mô tả công việc</h3>
            <p class="whitespace-pre-line">{{ selectedJob?.moTaCongViec || '—' }}</p>
          </div>

          <div>
            <h3 class="text-blue-700 font-semibold mb-1">🎯 Yêu cầu ứng viên</h3>
            <p class="whitespace-pre-line">{{ selectedJob?.yeuCauUngVien || '—' }}</p>
          </div>

          <div class="grid md:grid-cols-2 gap-4 bg-gray-50 p-4 rounded-lg">
            <p><b>💰 Mức lương:</b> {{ selectedJob?.mucLuong || 'Thỏa thuận' }}</p>
            <p><b>🕓 Thời gian làm việc:</b> {{ selectedJob?.thoiGianLamViec || 'Không rõ' }}</p>
            <p><b>🎓 Trình độ học vấn:</b> {{ selectedJob?.trinhDoHocVan || 'Không yêu cầu' }}</p>
            <p><b>🧩 Kinh nghiệm:</b> {{ selectedJob?.kinhNghiem || 'Không yêu cầu' }}</p>
            <p><b>📚 Ngành học phù hợp:</b> {{ selectedJob?.nganhHocPhuHop || 'Không xác định' }}</p>
            <p><b>👥 Số lượng tuyển:</b> {{ selectedJob?.soLuongTuyen }}</p>
          </div>

          <div>
            <h3 class="text-blue-700 font-semibold mb-1">💎 Chế độ đãi ngộ</h3>
            <p>{{ selectedJob?.cheDoDaiNgo || 'Không có thông tin' }}</p>
          </div>

          <div class="grid md:grid-cols-2 gap-4 bg-gray-50 p-4 rounded-lg">
            <p><b>📨 Hình thức ứng tuyển:</b> {{ selectedJob?.hinhThucUngTuyen }}</p>
            <p><b>📧 Email nhận hồ sơ:</b> {{ selectedJob?.emailNhanHoSo }}</p>
            <p><b>📞 Liên hệ:</b> {{ selectedJob?.nguoiLienHe || '—' }} ({{ selectedJob?.chucVuNguoiLienHe || '—' }})</p>
            <p><b>☎️ Số điện thoại:</b> {{ selectedJob?.soDienThoaiLienHe || '—' }}</p>
            <p><b>🌐 Website:</b> {{ selectedJob?.website || '—' }}</p>
            <p><b>🏢 Địa chỉ làm việc:</b> {{ selectedJob?.diaChiLamViec || '—' }}</p>
          </div>
        </section>

        <div class="flex justify-end gap-3 border-t pt-4">
          <button @click="closeDetailModal" class="px-5 py-2 rounded-lg bg-gray-300 hover:bg-gray-400">
            Đóng
          </button>

          <button
            v-if="!selectedJob?.daDuyet"
            @click="duyetCongViec(selectedJob)"
            class="px-5 py-2 bg-green-600 text-white rounded-lg hover:bg-green-700"
          >
            ✅ Duyệt tin
          </button>

          <button
            v-if="selectedJob?.daDuyet"
            @click="huyDuyetCongViec(selectedJob)"
            class="px-5 py-2 bg-yellow-500 text-white rounded-lg hover:bg-yellow-600"
          >
            🚫 Hủy duyệt
          </button>

          <button
            @click="openDeleteModal(selectedJob)"
            class="px-5 py-2 bg-red-600 text-white rounded-lg hover:bg-red-700"
          >
            🗑️ Xóa
          </button>
        </div>
      </div>
    </div>


    <div v-if="showDeleteModal" class="fixed inset-0 bg-black/50 flex items-center justify-center z-50">
      <div class="bg-white p-6 rounded-xl w-full max-w-md shadow-xl text-center">
        <h2 class="text-lg font-bold mb-4">⚠️ Xác nhận xóa công việc</h2>
        <p class="text-sm text-gray-600 mb-4">
          Bạn có chắc muốn xóa <b>{{ selectedJob?.tieuDe }}</b>?<br />
          <span class="text-red-500">Hành động này không thể hoàn tác.</span>
        </p>
        <div class="flex justify-center gap-3">
          <button @click="closeDeleteModal" class="px-4 py-2 rounded bg-gray-300 hover:bg-gray-400">
            Hủy
          </button>
          <button @click="confirmDelete" class="px-4 py-2 rounded bg-red-600 text-white hover:bg-red-700">
            Đồng ý
          </button>
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

const auth = useAuthStore();
const toast = useToast();

const jobs = ref([]);
const categories = ref([]);
const page = ref(1), pageSize = ref(10), total = ref(0), totalPages = ref(1);
const status = ref(""), category = ref(""), keyword = ref(""), fromDate = ref(""), toDate = ref("");
const loading = ref(false);

const showDeleteModal = ref(false);
const showDetailModal = ref(false);
const selectedJob = ref(null);

const formatDate = (d) => (!d ? "—" : new Date(d).toLocaleDateString("vi-VN"));

const fetchJobs = async () => {
  loading.value = true;
  try {
    const res = await api.get("/Admin/cong-viec", {
      headers: { Authorization: `Bearer ${auth.token}` },
      params: {
        trang: page.value,
        soLuongMoiTrang: pageSize.value,
        tuKhoa: keyword.value || null,
        linhVuc: category.value || null,
        tuNgay: fromDate.value || null,
        denNgay: toDate.value || null,
        daDuyet: status.value === "daduyet" ? true : status.value === "choduyet" ? false : null,
      },
    });
    jobs.value = res.data.duLieu || res.data;
  } catch {
    toast.error("Không thể tải danh sách công việc!");
  } finally {
    loading.value = false;
  }
};

const xemChiTiet = async (job) => {
  try {
    const res = await api.get(`/CongViec/${job.id}`, {
      headers: { Authorization: `Bearer ${auth.token}` },
    });
    selectedJob.value = res.data;
    showDetailModal.value = true;
  } catch {
    toast.error("Không thể tải chi tiết công việc!");
  }
};

const closeDetailModal = () => { showDetailModal.value = false; selectedJob.value = null; };

const duyetCongViec = async (job) => {
  await api.put(`/Admin/cong-viec/${job.id}/duyet`, null, { headers: { Authorization: `Bearer ${auth.token}` } });
  toast.success("✅ Đã duyệt công việc");
  fetchJobs(); closeDetailModal();
};

const huyDuyetCongViec = async (job) => {
  await api.put(`/Admin/cong-viec/${job.id}/huy-duyet`, null, { headers: { Authorization: `Bearer ${auth.token}` } });
  toast.info("🚫 Đã hủy duyệt công việc");
  fetchJobs(); closeDetailModal();
};

const openDeleteModal = (job) => { selectedJob.value = job; showDeleteModal.value = true; };
const closeDeleteModal = () => { showDeleteModal.value = false; };
const confirmDelete = async () => {
  await api.delete(`/Admin/cong-viec/${selectedJob.value.id}`, { headers: { Authorization: `Bearer ${auth.token}` } });
  toast.success("🗑️ Đã xóa công việc");
  fetchJobs(); closeDeleteModal(); closeDetailModal();
};

const applyFilter = () => { fetchJobs(); };
const resetFilter = () => { category.value=""; status.value=""; keyword.value=""; fromDate.value=""; toDate.value=""; fetchJobs(); };

onMounted(() => {
  fetchJobs();
});
</script>

<style scoped>
.icon-btn {
  @apply p-2 text-white rounded transition duration-200;
}
</style>
