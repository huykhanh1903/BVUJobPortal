<template>
  <div class="flex min-h-screen bg-gray-50">
    <aside class="w-1/4 bg-white border-r p-6 space-y-6">
      <h2 class="font-bold text-lg mb-3">🎨 Thiết kế & Font</h2>
      <div>
        <label class="block text-sm mb-1 font-semibold">Font chữ</label>
        <select v-model="font" class="border rounded w-full p-2">
          <option>Arial</option>
          <option>Roboto</option>
          <option>Calibri</option>
          <option>Georgia</option>
          <option>Inter</option>
          <option>Segoe UI</option>
        </select>
      </div>

      <div>
        <label class="block text-sm mb-1 font-semibold">Màu chủ đạo</label>
        <input type="color" v-model="mauChuDao" class="w-12 h-8 cursor-pointer" />
      </div>
      <button
        @click="batDauTaoCV"
        class="mt-8 w-full bg-green-600 text-white py-2 rounded-lg hover:bg-green-700 transition"
      >
        ➕ Tạo CV với mẫu này
      </button>
    </aside>
    <main
      class="flex-1 flex justify-center items-start p-10 bg-gray-100 overflow-auto"
    >
      <div
        v-if="template"
        class="scale-[0.8] bg-white shadow-xl border rounded-lg p-4 transition-all"
        :style="{ 
          fontFamily: font,
          borderColor: mauChuDao 
        }"
      >
        <img
          :src="fixPreview(template.previewUrl)"
          class="w-[700px] rounded-lg border"
          :style="{ borderColor: mauChuDao }"
        />
      </div>

      <div v-else class="text-gray-500 italic text-lg">
        Đang tải mẫu CV...
      </div>
    </main>
  </div>
</template>

<script setup>
import { ref, onMounted } from "vue";
import { useRoute, useRouter } from "vue-router";
import api from "@/api/axios";

const route = useRoute();
const router = useRouter();

const template = ref(null);
const font = ref("Roboto");
const mauChuDao = ref("#1e3a8a");

function fixPreview(url) {
  if (!url) return "/no-preview.png";

  if (url.startsWith("data:")) return url;

  if (url.startsWith("http")) return url;

  return `https://localhost:7248${url}`;
}

async function fetchTemplate() {
  const res = await api.get(`/CVTemplate/${route.params.id}`);
  template.value = res.data;

  font.value = res.data.font || "Roboto";
  mauChuDao.value = res.data.mauChuDao || "#1e3a8a";
}

function batDauTaoCV() {
  router.push(`/cv/tao-theo-mau/${template.value.id}`);
}

onMounted(fetchTemplate);
</script>
