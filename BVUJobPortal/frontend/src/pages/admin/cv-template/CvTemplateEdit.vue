<template>
  <div class="p-6 max-w-5xl mx-auto">
    <div class="flex justify-between items-center mb-6">
      <h1 class="text-2xl font-bold text-gray-800">
        ✏️ Chỉnh sửa Template CV
      </h1>

      <router-link
        to="/admin/cv-template"
        class="px-4 py-2 bg-gray-200 text-gray-700 rounded-lg hover:bg-gray-300"
      >
        ← Quay lại
      </router-link>
    </div>

    <div v-if="loading" class="text-center py-10 text-gray-500">⏳ Đang tải...</div>

    <div v-else class="bg-white p-6 rounded-2xl shadow space-y-6">

      <div class="flex gap-6">
        <div class="w-[280px]">
          <div class="a4-preview shadow rounded-xl overflow-hidden bg-gray-100">
            <img
              v-if="form.previewUrl"
              :src="form.previewUrl"
              class="w-full h-full object-contain"
            />
            <div v-else class="w-full h-full flex items-center justify-center text-gray-400">
              Không có preview
            </div>
          </div>

          <button
            class="mt-3 w-full py-2 bg-blue-600 text-white rounded-lg hover:bg-blue-700"
            @click="openBuilder"
          >
            🛠 Mở Builder
          </button>
        </div>

        <div class="flex-1 space-y-4">
          <div>
            <label class="text-sm font-medium">Tên template</label>
            <input
              v-model="form.tenTemplate"
              class="w-full mt-1 px-3 py-2 border rounded-lg"
              placeholder="Nhập tên template..."
            />
          </div>

          <div>
            <label class="text-sm font-medium">Mô tả</label>
            <textarea
              v-model="form.moTa"
              rows="4"
              class="w-full mt-1 px-3 py-2 border rounded-lg"
              placeholder="Mô tả ngắn của template..."
            ></textarea>
          </div>

          <div>
            <label class="text-sm font-medium">Trạng thái</label>
            <select
              v-model="form.isPublished"
              class="w-full mt-1 px-3 py-2 border rounded-lg"
            >
              <option :value="true">Đang hiển thị</option>
              <option :value="false">Nháp (chưa công bố)</option>
            </select>
          </div>
        </div>
      </div>

      <div class="flex justify-end gap-3">
        <button
          class="px-5 py-2 bg-red-100 text-red-600 rounded-lg hover:bg-red-200"
          @click="deleteTemplate"
        >
          🗑 Xóa template
        </button>

        <button
          class="px-5 py-2 bg-blue-600 text-white rounded-lg hover:bg-blue-700"
          @click="saveTemplate"
        >
          💾 Lưu thay đổi
        </button>
      </div>
    </div>
  </div>
</template>

<script setup>
import { ref, onMounted } from "vue";
import { useRoute, useRouter } from "vue-router";
import api from "@/api/axios";
import { useToast } from "vue-toastification";
import { useAuthStore } from "@/store/auth";

const toast = useToast();
const route = useRoute();
const router = useRouter();
const auth = useAuthStore();

const id = route.params.id;

const loading = ref(true);
const form = ref({
  tenTemplate: "",
  moTa: "",
  previewUrl: "",
  mauChuDao: "",
  font: "",
  layoutJson: "",
  styleJson: "",
  isPublished: false,
});

async function loadTemplate() {
  try {
    const res = await api.get(`/admin/cv-templates/${id}`, {
      headers: { Authorization: `Bearer ${auth.token}` },
    });

    Object.assign(form.value, res.data);

  } catch (e) {
    toast.error("Không tải được template!");
  } finally {
    loading.value = false;
  }
}

onMounted(loadTemplate);

// SAVE CHANGES
async function saveTemplate() {
  try {
    await api.put(`/admin/cv-templates/${id}`, form.value, {
      headers: { Authorization: `Bearer ${auth.token}` },
    });
    toast.success("Đã lưu template!");
  } catch (e) {
    toast.error("Không thể lưu template!");
  }
}

// OPEN BUILDER
function openBuilder() {
  router.push(`/admin/cv-template/edit/${id}`);
}

// DELETE
async function deleteTemplate() {
  if (!confirm("Bạn có chắc muốn xóa template này?")) return;

  try {
    await api.delete(`/AdminCVTemplate/${id}`, {
      headers: { Authorization: `Bearer ${auth.token}` },
    });

    toast.success("Đã xóa!");
    router.push("/admin/cv-template");

  } catch (e) {
    toast.error("Lỗi xóa template!");
  }
}
</script>

<style scoped>
.a4-preview {
  width: 100%;
  padding-top: 141%; /* Tỉ lệ A4 dọc */
  position: relative;
}
.a4-preview img {
  position: absolute;
  inset: 0;
  width: 100%;
  height: 100%;
}
</style>
