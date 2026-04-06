<template>
  <div class="min-h-screen bg-gray-50 p-6">
    <h1 class="text-2xl font-bold text-gray-800 mb-6">🎓 Quản lý chuyên ngành</h1>
    <div class="bg-white shadow rounded-xl p-4 mb-6 grid md:grid-cols-4 gap-4 items-end">

      <div class="md:col-span-2">
        <label class="block text-sm text-gray-600 mb-1">Tìm kiếm</label>
        <input
          v-model="keyword"
          type="text"
          placeholder="Nhập tên chuyên ngành..."
          class="px-3 py-2 border rounded-lg w-full focus:ring focus:ring-indigo-300"
        />
      </div>
-->
      <div>
        <label class="block text-sm text-gray-600 mb-1">Nghề nghiệp</label>
        <select
          v-model="selectedNgheFilter"
          class="px-3 py-2 border rounded-lg w-full bg-white focus:ring focus:ring-indigo-300"
        >
          <option value="">Tất cả</option>
          <option v-for="ng in ngheOptions" :key="ng.id" :value="ng.id">
            {{ ng.tenNghe }}
          </option>
        </select>
      </div>

      <div class="flex gap-2 justify-end md:col-span-1">
        <button
          @click="applyFilter"
          class="px-4 py-2 bg-indigo-600 text-white rounded-lg hover:bg-indigo-700"
        >
          🔍 Lọc
        </button>
        <button
          @click="resetFilter"
          class="px-4 py-2 bg-gray-300 text-gray-700 rounded-lg hover:bg-gray-400"
        >
          ♻ Reset
        </button>
        <button
          @click="openAddModal"
          class="px-4 py-2 bg-green-600 text-white rounded-lg hover:bg-green-700"
        >
          ➕ Thêm chuyên ngành
        </button>
      </div>
    </div>

    <div class="bg-white shadow rounded-xl overflow-hidden">
      <table class="min-w-full border-collapse" v-if="!loading && majors.length > 0">
        <thead>
          <tr class="bg-indigo-600 text-white text-left text-sm">
            <th class="px-4 py-3 w-16">ID</th>
            <th class="px-4 py-3">Tên chuyên ngành</th>
            <th class="px-4 py-3">Nghề</th>
            <th class="px-4 py-3">Ngày tạo</th>
            <th class="px-4 py-3 text-center w-32">Thao tác</th>
          </tr>
        </thead>

        <tbody>
          <tr
            v-for="m in majors"
            :key="m.id"
            class="border-b hover:bg-gray-50 text-sm"
          >
            <td class="px-4 py-3 font-mono text-gray-600">{{ m.id }}</td>
            <td class="px-4 py-3 font-medium text-indigo-700">{{ m.tenChuyenNganh }}</td>
            <td class="px-4 py-3">{{ m.tenNghe || "—" }}</td>
            <td class="px-4 py-3 text-gray-500">{{ formatDate(m.ngayTao) }}</td>

            <td class="px-3 py-2 text-center flex justify-center gap-2">
              <button
                @click="openDetailModal(m)"
                class="p-2 bg-indigo-500 text-white rounded hover:bg-indigo-600"
              >
                👁️
              </button>
            </td>
          </tr>
        </tbody>
      </table>

      <div v-if="!loading && majors.length === 0" class="p-6 text-center text-gray-500">
        🚫 Không có chuyên ngành nào.
      </div>

      <div v-if="loading" class="p-6 text-center text-gray-500">⏳ Đang tải dữ liệu...</div>
    </div>

    <div v-if="showDeleteModal" class="fixed inset-0 bg-black/60 flex items-center justify-center z-50">
      <div class="bg-white p-6 rounded-xl w-full max-w-md shadow-xl animate-fade-in">
        <h2 class="text-lg font-bold mb-4 text-gray-800">⚠ Xóa chuyên ngành</h2>
        <p class="text-gray-600 mb-4">
          Bạn có chắc muốn xóa chuyên ngành <b>{{ selectedMajor.tenChuyenNganh }}</b>?
          <br />
          <span class="text-red-500 text-xs">Hành động này không thể hoàn tác.</span>
        </p>

        <div class="flex justify-end gap-2">
          <button @click="closeDeleteModal" class="px-4 py-2 bg-gray-300 rounded">Hủy</button>
          <button @click="confirmDelete" class="px-4 py-2 bg-red-600 text-white rounded hover:bg-red-700">
            Xóa
          </button>
        </div>
      </div>
    </div>

    <div v-if="showDetailModal" class="fixed inset-0 bg-black/40 flex items-center justify-center z-40">
      <div class="bg-white p-6 rounded-xl w-full max-w-lg shadow-xl max-h-[90vh] overflow-y-auto animate-fade-in">
        <div class="flex justify-between items-center mb-4">
          <h2 class="text-lg font-bold text-gray-800">📘 Chi tiết chuyên ngành</h2>
          <button @click="closeDetailModal" class="text-2xl text-gray-500">×</button>
        </div>

        <div class="space-y-3 text-sm text-gray-700">
          <p><b>ID:</b> {{ selectedMajor.id }}</p>
          <p><b>Tên chuyên ngành:</b> {{ selectedMajor.tenChuyenNganh }}</p>
          <p><b>Nghề:</b> {{ selectedMajor.tenNghe }}</p>
          <p><b>Mô tả:</b> {{ selectedMajor.moTa || "Không có" }}</p>
          <p><b>Ngày tạo:</b> {{ formatDate(selectedMajor.ngayTao) }}</p>
        </div>

        <div class="flex justify-end gap-2 mt-6">
          <button
            @click="openEditModal(selectedMajor)"
            class="px-4 py-2 bg-yellow-500 text-white rounded hover:bg-yellow-600"
          >
            ✏ Sửa
          </button>
          <button
            @click="openDeleteModal(selectedMajor)"
            class="px-4 py-2 bg-red-600 text-white rounded hover:bg-red-700"
          >
            🗑 Xóa
          </button>
          <button @click="closeDetailModal" class="px-4 py-2 bg-gray-300 rounded">Đóng</button>
        </div>
      </div>
    </div>

    <div v-if="showModal" class="fixed inset-0 bg-black/50 flex items-center justify-center z-50">
      <div class="bg-white p-6 rounded-xl w-full max-w-md shadow-xl animate-fade-in">

        <h2 class="text-lg font-bold mb-4">
          {{ isEdit ? "✏️ Chỉnh sửa chuyên ngành" : "➕ Thêm chuyên ngành" }}
        </h2>

        <form @submit.prevent="saveMajor" class="space-y-4">

          <div>
            <label class="block text-sm text-gray-600 mb-1">Tên chuyên ngành</label>
            <input
              v-model="form.tenChuyenNganh"
              required
              type="text"
              class="w-full border rounded-lg px-3 py-2"
              placeholder="Nhập tên chuyên ngành"
            />
          </div>

          <div>
            <label class="block text-sm text-gray-600 mb-1">Nghề</label>
            <select
              v-model="form.ngheNghiepId"
              required
              class="w-full border rounded-lg px-3 py-2 bg-white"
            >
              <option disabled value="">-- Chọn nghề --</option>
              <option v-for="ng in ngheOptions" :key="ng.id" :value="ng.id">
                {{ ng.tenNghe }}
              </option>
            </select>
          </div>

          <div>
            <label class="block text-sm text-gray-600 mb-1">Mô tả</label>
            <textarea
              v-model="form.moTa"
              rows="3"
              class="w-full border rounded-lg px-3 py-2"
            ></textarea>
          </div>

          <div class="flex justify-end gap-2 mt-4">
            <button type="button" @click="closeModal" class="px-4 py-2 bg-gray-300 rounded">
              Hủy
            </button>
            <button type="submit" class="px-4 py-2 bg-indigo-600 text-white rounded hover:bg-indigo-700">
              {{ isEdit ? "Cập nhật" : "Thêm mới" }}
            </button>
          </div>

        </form>

      </div>
    </div>
  </div>
</template>

<script setup>
import { ref, onMounted } from "vue";
import api from "@/api/axios";
import { useToast } from "vue-toastification";

const toast = useToast();

const majors = ref([]);
const ngheOptions = ref([]);
const keyword = ref("");
const selectedNgheFilter = ref("");
const loading = ref(false);

const showModal = ref(false);
const showDetailModal = ref(false);
const showDeleteModal = ref(false);
const isEdit = ref(false);

const selectedMajor = ref({});
const form = ref({
  id: null,
  tenChuyenNganh: "",
  ngheNghiepId: "",
  moTa: ""
});

function formatDate(date) {
  if (!date) return "—";
  return new Date(date).toLocaleDateString("vi-VN");
}

async function fetchNghe() {
  const res = await api.get("/Admin/nghe-nghiep");
  ngheOptions.value = res.data || [];
}
async function fetchMajors() {
  loading.value = true;
  try {
    const res = await api.get("/Admin/chuyen-nganh");
    majors.value = res.data || [];
  } catch {
    toast.error("Không thể tải chuyên ngành");
  } finally {
    loading.value = false;
  }
}

function openAddModal() {
  isEdit.value = false;
  form.value = { id: null, tenChuyenNganh: "", ngheNghiepId: "", moTa: "" };
  showModal.value = true;
}

function openEditModal(m) {
  isEdit.value = true;
  form.value = { ...m };
  showModal.value = true;
}

function closeModal() {
  showModal.value = false;
}

function openDetailModal(m) {
  selectedMajor.value = { ...m };
  showDetailModal.value = true;
}

function closeDetailModal() {
  showDetailModal.value = false;
}

function openDeleteModal(m) {
  selectedMajor.value = m;
  showDeleteModal.value = true;
}

function closeDeleteModal() {
  showDeleteModal.value = false;
}

async function saveMajor() {
  const payload = {
    TenChuyenNganh: form.value.tenChuyenNganh,
    NgheNghiepId: form.value.ngheNghiepId,
    MoTa: form.value.moTa || null
  };

  try {
    if (isEdit.value) {
      await api.put(`/Admin/chuyen-nganh/${form.value.id}`, { Id: form.value.id, ...payload });
      toast.success("Cập nhật thành công!");
    } else {
      const res = await api.post("/Admin/chuyen-nganh", payload);
      toast.success("Thêm chuyên ngành thành công!");
      majors.value.unshift(res.data);
    }

    showModal.value = false;
    fetchMajors();

  } catch {
    toast.error("Lỗi khi lưu dữ liệu");
  }
}

async function confirmDelete() {
  try {
    await api.delete(`/Admin/chuyen-nganh/${selectedMajor.value.id}`);
    toast.success("Đã xóa chuyên ngành!");
    showDeleteModal.value = false;
    fetchMajors();
  } catch {
    toast.error("Xóa thất bại!");
  }
}

function applyFilter() {
  fetchMajors().then(() => {
    majors.value = majors.value.filter((m) => {
      const matchKeyword = m.tenChuyenNganh
        .toLowerCase()
        .includes(keyword.value.toLowerCase());
      const matchNghe =
        !selectedNgheFilter.value ||
        m.ngheNghiepId === selectedNgheFilter.value;
      return matchKeyword && matchNghe;
    });
  });
}

function resetFilter() {
  keyword.value = "";
  selectedNgheFilter.value = "";
  fetchMajors();
}

onMounted(() => {
  fetchNghe();
  fetchMajors();
});
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
  animation: fade-in 0.2s ease-out;
}
</style>