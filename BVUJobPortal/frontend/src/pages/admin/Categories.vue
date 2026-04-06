<template>
  <div class="min-h-screen bg-gray-50 p-6">
    <h1 class="text-2xl font-bold text-gray-800 mb-6">📚 Quản lý lĩnh vực</h1>

    <div class="bg-white shadow rounded-xl p-4 mb-6 grid md:grid-cols-4 gap-4 items-end">
      <div class="md:col-span-2">
        <label class="block text-sm text-gray-600 mb-1">Tìm kiếm</label>
        <input
          v-model="keyword"
          type="text"
          placeholder="Nhập tên lĩnh vực..."
          class="px-3 py-2 border rounded-lg w-full focus:ring focus:ring-indigo-300"
        />
      </div>
      <div class="flex gap-2 md:col-span-2 justify-end">
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
          ♻️ Reset
        </button>
        <button
          @click="openAddModal"
          class="px-4 py-2 bg-green-600 text-white rounded-lg hover:bg-green-700"
        >
          ➕ Thêm lĩnh vực
        </button>
      </div>
    </div>

    <div class="bg-white shadow rounded-xl overflow-hidden">
      <table class="min-w-full border-collapse" v-if="!loading && categories.length > 0">
        <thead>
          <tr class="bg-indigo-600 text-white text-left text-sm">
            <th class="px-4 py-3 w-16">ID</th>
            <th class="px-4 py-3">Tên lĩnh vực</th>
            <th class="px-4 py-3">Ngày tạo</th>
            <th class="px-4 py-3 text-center w-32">Thao tác</th>
          </tr>
        </thead>
        <tbody>
          <tr
            v-for="c in categories"
            :key="c.id"
            class="border-b hover:bg-gray-50 text-sm"
          >
            <td class="px-4 py-3 font-mono text-gray-600">{{ c.id }}</td>
            <td class="px-4 py-3 font-medium text-indigo-700">{{ c.tenLinhVuc }}</td>
            <td class="px-4 py-3 text-gray-500">{{ formatDate(c.ngayTao) }}</td>
            <td class="px-3 py-2 text-center">
              <button
                @click="openDetailModal(c)"
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
      <div v-if="!loading && categories.length === 0" class="p-6 text-center text-gray-500">
        🚫 Không có lĩnh vực nào.
      </div>
    </div>

    <div v-if="showDeleteModal" class="fixed inset-0 bg-black/60 flex items-center justify-center z-[60]">
      <div class="bg-white p-6 rounded-xl w-full max-w-md shadow-2xl animate-fade-in">
        <h2 class="text-lg font-bold mb-4 text-gray-800 flex items-center gap-2">⚠️ Xác nhận xóa lĩnh vực</h2>
        <p class="text-sm text-gray-600 mb-4 leading-relaxed">
          Bạn có chắc muốn xóa lĩnh vực
          <b>{{ selectedCategory?.tenLinhVuc }}</b> (ID: {{ selectedCategory?.id }})?
          <br />
          <span class="text-red-500 text-xs">Hành động này không thể hoàn tác!</span>
        </p>
        <div class="flex justify-end gap-2 mt-4">
          <button
            @click="closeDeleteModal"
            class="px-4 py-2 rounded bg-gray-300 text-gray-800 hover:bg-gray-400"
          >
            Hủy
          </button>
          <button
            @click="confirmDelete"
            class="px-4 py-2 rounded bg-red-600 text-white hover:bg-red-700"
          >
            Xóa
          </button>
        </div>
      </div>
    </div>

    <div v-if="showDetailModal" class="fixed inset-0 bg-black/40 flex items-center justify-center z-40">
      <div class="bg-white p-6 rounded-xl w-full max-w-lg shadow-xl overflow-y-auto max-h-[90vh] animate-fade-in">
        <div class="flex justify-between items-center mb-4">
          <h2 class="text-lg font-bold text-gray-800 flex items-center gap-2">📘 Chi tiết lĩnh vực</h2>
          <button @click="closeDetailModal" class="text-2xl text-gray-500 hover:text-gray-800">×</button>
        </div>

        <div class="space-y-3 text-gray-700 text-sm">
          <p><b>🆔 ID:</b> {{ selectedCategory.id }}</p>
          <p><b>🏷️ Tên lĩnh vực:</b> {{ selectedCategory.tenLinhVuc }}</p>
          <p>
            <b>📄 Mô tả:</b>
            <span class="block mt-1 text-gray-600 whitespace-pre-line">
              {{ selectedCategory.moTa || "Không có mô tả" }}
            </span>
          </p>
          <p><b>📅 Ngày tạo:</b> {{ formatDate(selectedCategory.ngayTao) }}</p>
          <p><b>📊 Số lượng công việc:</b>
            <span class="font-semibold text-indigo-600">{{ selectedCategory.soLuongCongViec || 0 }}</span>
          </p>
        </div>

        <div class="flex justify-end gap-2 mt-6">
          <button
            @click="openEditModal(selectedCategory)"
            class="px-4 py-2 rounded bg-yellow-500 text-white hover:bg-yellow-600"
          >
            ✏️ Sửa
          </button>
          <button
            @click="openDeleteModal(selectedCategory)"
            class="px-4 py-2 rounded bg-red-600 text-white hover:bg-red-700"
          >
            🗑️ Xóa
          </button>
          <button
            @click="closeDetailModal"
            class="px-4 py-2 rounded bg-gray-300 hover:bg-gray-400"
          >
            Đóng
          </button>
        </div>
      </div>
    </div>

    <div v-if="showModal" class="fixed inset-0 bg-black/50 flex items-center justify-center z-50">
      <div class="bg-white p-6 rounded-xl w-full max-w-md shadow-2xl animate-fade-in">
        <h2 class="text-lg font-bold mb-4">
          {{ isEdit ? "✏️ Chỉnh sửa lĩnh vực" : "➕ Thêm lĩnh vực" }}
        </h2>

        <form @submit.prevent="saveCategory" class="space-y-4">
          <div>
            <label class="block text-sm text-gray-600 mb-1">Tên lĩnh vực</label>
            <input
              v-model="form.tenLinhVuc"
              type="text"
              placeholder="Nhập tên lĩnh vực"
              class="w-full border rounded-lg px-3 py-2 focus:ring focus:ring-indigo-300"
              required
            />
          </div>
          <div>
            <label class="block text-sm text-gray-600 mb-1">Mô tả</label>
            <textarea
              v-model="form.moTa"
              rows="3"
              placeholder="Mô tả ngắn lĩnh vực..."
              class="w-full border rounded-lg px-3 py-2 focus:ring focus:ring-indigo-300"
            ></textarea>
          </div>

          <div class="flex justify-end gap-2 mt-6">
            <button type="button" @click="closeModal" class="px-4 py-2 rounded bg-gray-300 hover:bg-gray-400">
              Hủy
            </button>
            <button type="submit" class="px-4 py-2 rounded bg-indigo-600 text-white hover:bg-indigo-700">
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
import { useAuthStore } from "@/store/auth";
import { useToast } from "vue-toastification";

const auth = useAuthStore();
const toast = useToast();

const categories = ref([]);
const keyword = ref("");
const loading = ref(false);

const showModal = ref(false);
const showDetailModal = ref(false);
const showDeleteModal = ref(false);
const isEdit = ref(false);
const form = ref({ id: null, tenLinhVuc: "", moTa: "" });
const selectedCategory = ref({});

function formatDate(date) {
  if (!date) return "—";
  return new Date(date).toLocaleString("vi-VN");
}

async function fetchCategories() {
  loading.value = true;
  try {
    const res = await api.get("/Admin/linh-vuc", {
      headers: { Authorization: `Bearer ${auth.token}` },
    });
    categories.value = res.data || [];
  } catch {
    toast.error("Không thể tải danh sách lĩnh vực!");
  } finally {
    loading.value = false;
  }
}

function openDetailModal(c) {
  selectedCategory.value = { ...c };
  showDetailModal.value = true;
}
function closeDetailModal() {
  showDetailModal.value = false;
}

function openAddModal() {
  isEdit.value = false;
  form.value = { id: null, tenLinhVuc: "", moTa: "" };
  showModal.value = true;
}
function openEditModal(c) {
  isEdit.value = true;
  form.value = { ...c };
  showModal.value = true;
}
function closeModal() {
  showModal.value = false;
}

function openDeleteModal(c) {
  selectedCategory.value = c;
  showDeleteModal.value = true;
}
function closeDeleteModal() {
  showDeleteModal.value = false;
}

async function saveCategory() {
  const payload = {
    tenLinhVuc: form.value.tenLinhVuc.trim(),
    moTa: form.value.moTa?.trim() || null,
  };

  try {
    if (isEdit.value) {
      const res = await api.put(`/Admin/linh-vuc/${form.value.id}`, payload, {
        headers: {
          Authorization: `Bearer ${auth.token}`,
          "Content-Type": "application/json",
        },
      });

      toast.success("✅ Cập nhật lĩnh vực thành công!");

      const index = categories.value.findIndex(c => c.id === form.value.id);
      if (index !== -1) {
        categories.value[index] = { ...categories.value[index], ...payload };
      }

      if (showDetailModal.value && selectedCategory.value?.id === form.value.id) {
        selectedCategory.value = {
          ...selectedCategory.value,
          ...payload,
        };
      }
    } else {
      const res = await api.post("/Admin/linh-vuc", payload, {
        headers: {
          Authorization: `Bearer ${auth.token}`,
          "Content-Type": "application/json",
        },
      });

      toast.success("✅ Thêm lĩnh vực thành công!");

      const newCategory = res.data || {
        ...payload,
        id: Math.random(),
      };

      if (!newCategory.ngayTao) {
        newCategory.ngayTao = new Date().toISOString();
      }

      categories.value.unshift(newCategory);
    }

    showModal.value = false;

  } catch (err) {
    console.error("❌ Lỗi lưu lĩnh vực:", err);
    toast.error("Lưu lĩnh vực thất bại!");
  }
}



async function confirmDelete() {
  try {
    await api.delete(`/Admin/linh-vuc/${selectedCategory.value.id}`, {
      headers: { Authorization: `Bearer ${auth.token}` },
    });
    toast.success("🗑️ Đã xóa lĩnh vực!");
    showDeleteModal.value = false;
    showDetailModal.value = false;
    fetchCategories();
  } catch {
    toast.error("Xóa thất bại!");
  }
}

function applyFilter() {
  if (!keyword.value.trim()) return fetchCategories();
  categories.value = categories.value.filter((c) =>
    c.tenLinhVuc?.toLowerCase().includes(keyword.value.toLowerCase())
  );
}
function resetFilter() {
  keyword.value = "";
  fetchCategories();
}

onMounted(fetchCategories);
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
