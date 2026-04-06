<template>
  <div class="max-w-6xl mx-auto py-10">
    <h1 class="text-3xl font-bold text-gray-800 mb-6 text-center">
      🎨 Chọn mẫu CV yêu thích
    </h1>

    <div v-if="loading" class="text-center text-gray-500">⏳ Đang tải...</div>

    <div v-else class="grid md:grid-cols-3 gap-6">
      <div
        v-for="t in templates"
        :key="t.id"
        class="border rounded-xl shadow hover:shadow-lg transition overflow-hidden bg-white"
      >
        <img
          :src="fixPreview(t.previewUrl)"
          class="w-full h-64 object-cover"
        />
        <div class="p-4 space-y-2">
          <h2 class="font-bold text-lg">{{ t.tenTemplate }}</h2>
          <p class="text-gray-600 text-sm">{{ t.moTa }}</p>
          <button
            @click="chonMau(t.id)"
            class="mt-2 w-full bg-blue-600 text-white py-2 rounded hover:bg-blue-700"
          >
            Dùng mẫu này
          </button>
        </div>
      </div>
    </div>
  </div>
</template>

<script setup>
import { ref, onMounted } from "vue";
import api from "@/api/axios";
import { useRouter } from "vue-router";

const templates = ref([]);
const loading = ref(true);
const router = useRouter();

async function fetchTemplates() {
  try {
    const res = await api.get("/CVTemplate/list");
    templates.value = res.data;
  } finally {
    loading.value = false;
  }
}

function chonMau(id) {
  router.push(`/cv/xem-mau/${id}`);
}
function fixPreview(url) {
  if (!url) return "/no-preview.png";

  if (url.startsWith("data:")) return url;
  if (url.startsWith("http")) return url;
  return `https://localhost:7248${url}`;
}


onMounted(fetchTemplates);
</script>
