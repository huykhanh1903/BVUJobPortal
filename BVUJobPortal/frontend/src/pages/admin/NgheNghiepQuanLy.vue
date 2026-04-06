<template>
  <div class="min-h-screen bg-gray-50 p-6">
    <h1 class="text-2xl font-bold text-gray-800 mb-6">🛠️ Quản lý nghề nghiệp</h1>

    <div class="bg-white shadow rounded-xl p-4 mb-6 grid md:grid-cols-4 gap-4 items-end">
      <div class="md:col-span-2">
        <label class="block text-sm text-gray-600 mb-1">Tìm kiếm</label>
        <input
          v-model="keyword"
          type="text"
          placeholder="Nhập tên nghề..."
          class="px-3 py-2 border rounded-lg w-full focus:ring focus:ring-indigo-300"
        />
      </div>

      <div class="flex gap-2 md:col-span-2 justify-end">
        <button @click="applyFilter" class="px-4 py-2 bg-indigo-600 text-white rounded-lg hover:bg-indigo-700">
          🔍 Lọc
        </button>
        <button
          @click="resetFilter"
          class="px-4 py-2 bg-gray-300 text-gray-700 rounded-lg hover:bg-gray-400"
        >
          ♻️ Reset
        </button>
        <button @click="openAddModal" class="px-4 py-2 bg-green-600 text-white rounded-lg hover:bg-green-700">
          ➕ Thêm nghề
        </button>
      </div>
    </div>

    <div class="bg-white shadow rounded-xl overflow-hidden">
      <table class="min-w-full border-collapse" v-if="!loading && ngheList.length > 0">
        <thead>
          <tr class="bg-indigo-600 text-white text-left text-sm">
            <th class="px-4 py-3 w-16">ID</th>
            <th class="px-4 py-3">Tên nghề</th>
            <th class="px-4 py-3">Lĩnh vực</th>
            <th class="px-4 py-3 text-center w-32">Số CN</th>
            <th class="px-4 py-3">Ngày tạo</th>
            <th class="px-4 py-3 text-center w-32">Thao tác</th>
          </tr>
        </thead>
        <tbody>
          <tr
            v-for="ng in ngheList"
            :key="ng.id"
            class="border-b hover:bg-gray-50 text-sm"
          >
            <td class="px-4 py-3 font-mono text-gray-600">{{ ng.id }}</td>

            <td class="px-4 py-3 font-medium text-indigo-700">{{ ng.tenNghe }}</td>

            <td class="px-4 py-3 text-gray-700">{{ ng.tenLinhVuc || "—" }}</td>

            <td class="px-4 py-3 text-center">
              <span class="px-2 py-1 bg-indigo-100 text-indigo-700 text-xs rounded-full">
                {{ ng.soLuongChuyenNganh || 0 }}
              </span>
            </td>

            <td class="px-4 py-3 text-gray-500">{{ formatDate(ng.ngayTao) }}</td>

            <td class="px-3 py-2 text-center">
              <button
                @click="openDetailModal(ng)"
                class="p-2 bg-indigo-500 text-white rounded hover:bg-indigo-600"
                title="Xem chi tiết"
              >
                👁️
              </button>
            </td>
          </tr>
        </tbody>
      </table>

      <div v-if="loading" class="p-6 text-center text-gray-500">⏳ Đang tải dữ liệu...</div>
      <div v-if="!loading && ngheList.length === 0" class="p-6 text-center text-gray-500">
        🚫 Không có nghề nào.
      </div>
    </div>

    <div v-if="showDeleteModal" class="fixed inset-0 bg-black/60 flex items-center justify-center z-[60]">
      <div class="bg-white p-6 rounded-xl w-full max-w-md shadow-2xl animate-fade-in">
        <h2 class="text-lg font-bold mb-4 text-gray-800">⚠️ Xác nhận xóa nghề</h2>
        <p class="text-sm text-gray-600 mb-4 leading-relaxed">
          Bạn có chắc muốn xóa nghề
          <b>{{ selectedNghe?.tenNghe }}</b> (ID: {{ selectedNghe?.id }})?
          <br />
          <span class="text-red-500 text-xs">Hành động này không thể hoàn tác!</span>
        </p>
        <div class="flex justify-end gap-2 mt-4">
          <button @click="closeDeleteModal" class="px-4 py-2 bg-gray-300 rounded">Hủy</button>
          <button @click="confirmDelete" class="px-4 py-2 bg-red-600 text-white rounded hover:bg-red-700">
            Xóa
          </button>
        </div>
      </div>
    </div>
>
    <div v-if="showDetailModal" class="fixed inset-0 bg-black/40 flex items-center justify-center z-40">
      <div class="bg-white p-6 rounded-xl w-full max-w-lg shadow-xl max-h-[90vh] overflow-y-auto animate-fade-in">
        <div class="flex justify-between items-center mb-4">
          <h2 class="text-lg font-bold text-gray-800">📘 Chi tiết nghề nghiệp</h2>
          <button @click="closeDetailModal" class="text-2xl text-gray-500 hover:text-gray-800">×</button>
        </div>

        <div class="space-y-3 text-gray-700 text-sm">
          <p><b>🆔 ID:</b> {{ selectedNghe.id }}</p>
          <p><b>🏷️ Tên nghề:</b> {{ selectedNghe.tenNghe }}</p>
          <p>
            <b>📄 Mô tả:</b>
            <span class="block mt-1 text-gray-600 whitespace-pre-line">
              {{ selectedNghe.moTa || "Không có mô tả" }}
            </span>
          </p>

          <p><b>🏷️ Lĩnh vực:</b> {{ selectedNghe.tenLinhVuc || "—" }}</p>

          <p><b>📚 Số chuyên ngành:</b>
            <span class="text-indigo-600 font-semibold">
              {{ selectedNghe.soLuongChuyenNganh || 0 }}
            </span>
          </p>

          <p><b>📅 Ngày tạo:</b> {{ formatDate(selectedNghe.ngayTao) }}</p>
        </div>

        <div class="flex justify-end gap-2 mt-6">
          <button @click="openEditModal(selectedNghe)" class="px-4 py-2 bg-yellow-500 text-white rounded hover:bg-yellow-600">
            ✏️ Sửa
          </button>
          <button @click="openDeleteModal(selectedNghe)" class="px-4 py-2 bg-red-600 text-white rounded hover:bg-red-700">
            🗑️ Xóa
          </button>
          <button @click="closeDetailModal" class="px-4 py-2 bg-gray-300 rounded hover:bg-gray-400">
            Đóng
          </button>
        </div>
      </div>
    </div>

    <div v-if="showModal" class="fixed inset-0 bg-black/50 flex items-center justify-center z-50">
      <div class="bg-white p-6 rounded-xl w-full max-w-md shadow-2xl animate-fade-in">
        <h2 class="text-lg font-bold mb-4">
          {{ isEdit ? "✏️ Chỉnh sửa nghề" : "➕ Thêm nghề" }}
        </h2>

        <form @submit.prevent="saveNghe" class="space-y-4">
          <div>
            <label class="block text-sm text-gray-600 mb-1">Tên nghề</label>
            <input
              v-model="form.tenNghe"
              type="text"
              class="w-full border rounded-lg px-3 py-2 focus:ring focus:ring-indigo-300"
              required
            />
          </div>

          <div>
            <label class="block text-sm text-gray-600 mb-1">Mô tả</label>
            <textarea
              v-model="form.moTa"
              rows="3"
              class="w-full border rounded-lg px-3 py-2 focus:ring focus:ring-indigo-300"
            ></textarea>
          </div>

          <div>
            <label class="block text-sm text-gray-600 mb-1">Thuộc lĩnh vực</label>
            <select
              v-model="form.linhVucId"
              class="w-full border rounded-lg px-3 py-2 focus:ring focus:ring-indigo-300"
              required
            >
              <option disabled value="">-- Chọn lĩnh vực --</option>
              <option v-for="lv in linhVucList" :key="lv.id" :value="lv.id">
                {{ lv.tenLinhVuc }}
              </option>
            </select>
          </div>

          <div class="flex justify-end gap-2 mt-6">
            <button @click="closeModal" type="button" class="px-4 py-2 bg-gray-300 rounded hover:bg-gray-400">
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

const ngheList = ref([]);
const linhVucList = ref([]);
const keyword = ref("");
const loading = ref(false);

const showModal = ref(false);
const showDetailModal = ref(false);
const showDeleteModal = ref(false);
const isEdit = ref(false);

const form = ref({
  id: null,
  tenNghe: "",
  moTa: "",
  linhVucId: ""
});

const selectedNghe = ref({});

function formatDate(date) {
  if (!date) return "—";
  return new Date(date).toLocaleString("vi-VN");
}

async function fetchNghe() {
  loading.value = true;
  try {
    const res = await api.get("/Admin/nghe-nghiep");
    ngheList.value = res.data || [];
  } catch {
    toast.error("Không thể tải danh sách nghề!");
  } finally {
    loading.value = false;
  }
}

async function fetchLinhVuc() {
  try {
    const res = await api.get("/Admin/linh-vuc");
    linhVucList.value = res.data || [];
  } catch {
    toast.error("Không thể tải lĩnh vực!");
  }
}

function openDetailModal(item) {
  selectedNghe.value = { ...item };
  showDetailModal.value = true;
}
function closeDetailModal() {
  showDetailModal.value = false;
}

function openAddModal() {
  isEdit.value = false;
  form.value = { id: null, tenNghe: "", moTa: "", linhVucId: "" };
  showModal.value = true;
}
a
function openEditModal(item) {
  isEdit.value = true;
  form.value = { ...item };
  showModal.value = true;
}

function closeModal() {
  showModal.value = false;
}

function openDeleteModal(item) {
  selectedNghe.value = item;
  showDeleteModal.value = true;
}
function closeDeleteModal() {
  showDeleteModal.value = false;
}

async function saveNghe() {
  const payload = {
    tenNghe: form.value.tenNghe.trim(),
    moTa: form.value.moTa?.trim() || null,
    linhVucId: form.value.linhVucId
  };

  try {
    if (isEdit.value) {
      await api.put(`/Admin/nghe-nghiep/${form.value.id}`, {
        id: form.value.id,
        ...payload
      });

      toast.success("✔ Cập nhật nghề thành công!");

      const idx = ngheList.value.findIndex((x) => x.id === form.value.id);
      if (idx !== -1) ngheList.value[idx] = { ...ngheList.value[idx], ...payload };
    } else {
      const res = await api.post("/Admin/nghe-nghiep", payload);
      toast.success("✔ Thêm nghề thành công!");

      ngheList.value.unshift(res.data);
    }

    showModal.value = false;
  } catch {
    toast.error("❌ Lưu thất bại!");
  }
}

async function confirmDelete() {
  try {
    await api.delete(`/Admin/nghe-nghiep/${selectedNghe.value.id}`);
    toast.success("🗑️ Đã xóa nghề!");
    showDeleteModal.value = false;
    showDetailModal.value = false;
    fetchNghe();
  } catch {
    toast.error("Xóa thất bại!");
  }
}

function applyFilter() {
  if (!keyword.value.trim()) return fetchNghe();
  ngheList.value = ngheList.value.filter((n) =>
    n.tenNghe?.toLowerCase().includes(keyword.value.toLowerCase())
  );
}

function resetFilter() {
  keyword.value = "";
  fetchNghe();
}

onMounted(() => {
  fetchNghe();
  fetchLinhVuc();
});
</script>

<style scoped>
@keyframes fade-in {
  from { opacity: 0; transform: scale(0.95); }
  to { opacity: 1; transform: scale(1); }
}
.animate-fade-in {
  animation: fade-in 0.25s ease-out;
}
</style>