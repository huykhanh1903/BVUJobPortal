<template>
  <div class="p-6">
    <div class="flex items-center justify-between mb-6">
      <h1 class="text-2xl font-bold text-gray-800">📄 Quản lý Template CV</h1>

      <router-link
        to="/admin/cv-template/builder"
        class="px-4 py-2 bg-blue-600 text-white rounded-lg hover:bg-blue-700 transition"
      >
        ➕ Tạo template mới
      </router-link>
    </div>

    <div v-if="loading" class="text-center text-gray-500 py-10">
      ⏳ Đang tải template...
    </div>

    <div
      v-else-if="templates.length === 0"
      class="text-center bg-white p-10 shadow rounded-xl"
    >
      <p class="text-gray-600 mb-4">Chưa có template nào!</p>

      <router-link
        to="/admin/cv-template/builder"
        class="px-5 py-2 bg-blue-600 text-white rounded-lg hover:bg-blue-700"
      >
        ➕ Tạo template đầu tiên
      </router-link>
    </div>

    <div v-else class="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-6">
      <div
        v-for="t in templates"
        :key="t.id"
        class="bg-white shadow rounded-xl p-4 hover:shadow-lg transition"
      >
        <div class="a4-preview mb-4">
          <img
            v-if="t.previewUrl"
            :src="t.previewUrl"
            class="h-full object-contain"
          />
          <span v-else class="absolute inset-0 flex items-center justify-center text-gray-400 text-sm">Không có preview</span>
        </div>

        <h2 class="text-lg font-semibold text-gray-800 truncate">
          {{ t.tenTemplate }}
        </h2>
        <p class="text-gray-500 text-sm line-clamp-2">{{ t.moTa }}</p>

        <div class="flex gap-2 mt-4">
          <router-link
            :to="`/admin/cv-template/builder/${t.id}`"
            class="flex-1 px-3 py-2 text-center bg-yellow-100 text-yellow-700 rounded hover:bg-yellow-200 text-sm"
          >
            ✏️ Sửa
          </router-link>
          <button
            @click="togglePublish(t)"
            :class="[
              'flex-1 px-3 py-2 text-center rounded text-sm font-semibold transition',
              t.isPublished 
                ? 'bg-red-100 text-red-700 hover:bg-red-200' 
                : 'bg-green-100 text-green-700 hover:bg-green-200'
            ]"
          >
            {{ t.isPublished ? "Ẩn" : "Đăng" }}
          </button>
          <button
            @click="deleteTemplate(t.id)"
            class="flex-1 px-3 py-2 text-center bg-red-100 text-red-700 rounded hover:bg-red-200 text-sm"
          >
            🗑 Xóa
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
const templates = ref([]);
const loading = ref(true);

async function loadTemplates() {
  loading.value = true;
  try {
    const res = await api.get("/admin/cv-templates", {
      headers: { Authorization: `Bearer ${auth.token}` },
    });
    templates.value = res.data;
  } catch (err) {
    toast.error("Không tải được danh sách template!");
  } finally {
    loading.value = false;
  }
}

async function togglePublish(t) {
  try {
    const newState = !t.isPublished;

    await api.patch(
      `/admin/cv-templates/${t.id}/publish`,
      { isPublished: newState },
      { headers: { Authorization: `Bearer ${auth.token}` } }
    );

    t.isPublished = newState;
    toast.success(newState ? "Đã ĐĂNG template!" : "Đã ẨN template!");
  } catch (err) {
    console.error(err);
    toast.error("Lỗi cập nhật trạng thái!");
  }
}



async function deleteTemplate(id) {
  if (!confirm("Xóa template này?")) return;

  try {
    await api.delete(`/admin/cv-templates/${id}`, {
      headers: { Authorization: `Bearer ${auth.token}` },
    });
    templates.value = templates.value.filter((x) => x.id !== id);
    toast.success("Đã xóa template!");
  } catch {
    toast.error("Lỗi xóa template!");
  }
}

onMounted(loadTemplates);
</script>

<style scoped>
.a4-preview {
  width: 100%;
  padding-top: calc(141.4%);
  background-color: #f3f4f6;
  border-radius: 12px;
  position: relative;
  overflow: hidden;
  display: flex;
  justify-content: center;
  align-items: center;
}

.a4-preview img {
  position: absolute;
  inset: 0;
  width: 100%;
  height: 100%;
  object-fit: contain;
}
</style>