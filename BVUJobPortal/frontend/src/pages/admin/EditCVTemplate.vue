<template>
  <div class="p-8 bg-gray-50 min-h-screen">
    <!-- Header -->
    <div class="flex justify-between items-center mb-6">
      <h1 class="text-2xl font-bold text-gray-800">
        🧩 {{ isEdit ? "Chỉnh sửa mẫu CV" : "Tạo mẫu CV mới" }}
      </h1>
      <router-link
        to="/admin/cv-templates"
        class="px-3 py-1 bg-gray-100 rounded hover:bg-gray-200"
      >
        ← Quay lại
      </router-link>
    </div>

    <div class="grid grid-cols-2 gap-6 mb-8 bg-white rounded-xl shadow p-6">
      <div>
        <label class="font-semibold block mb-1">Tên mẫu</label>
        <input v-model="form.tenTemplate" class="w-full border rounded p-2" />
      </div>
      <div>
        <label class="font-semibold block mb-1">Font chữ</label>
        <select v-model="form.font" class="w-full border rounded p-2">
          <option>Arial</option>
          <option>Roboto</option>
          <option>Georgia</option>
          <option>Calibri</option>
        </select>
      </div>
      <div>
        <label class="font-semibold block mb-1">Màu chủ đạo</label>
        <input type="color" v-model="form.mauChuDao" class="h-10 w-20 border rounded" />
      </div>
      <div>
        <label class="font-semibold block mb-1">Preview URL</label>
        <input v-model="form.previewUrl" class="w-full border rounded p-2" />
      </div>
      <div class="col-span-2">
        <label class="font-semibold block mb-1">Mô tả</label>
        <textarea v-model="form.moTa" class="w-full border rounded p-2" rows="3"></textarea>
      </div>
    </div>

    <div class="bg-white rounded-xl shadow p-6">
      <TemplateBuilder v-model="layoutJson" />
    </div>
    <div class="bg-white rounded-xl shadow p-6 mt-6">
      <h3 class="font-semibold mb-3">🎨 Tùy chỉnh style (JSON)</h3>
      <textarea
        v-model="styleJson"
        rows="6"
        class="w-full border rounded p-2 font-mono text-sm"
      ></textarea>
    </div>

    <div class="flex justify-end gap-3 mt-8">
      <button
        @click="saveTemplate"
        class="px-6 py-2 bg-green-600 text-white rounded-lg hover:bg-green-700 transition"
      >
        💾 Lưu Template
      </button>
    </div>
  </div>
</template>

<script setup>
import { ref, onMounted, computed } from "vue";
import api from "@/api/axios";
import { useRouter, useRoute } from "vue-router";
import { useToast } from "vue-toastification";

// import TemplateBuilder from "@/components/admin/TemplateBuilder.vue";

const router = useRouter();
const route = useRoute();
const toast = useToast();

const form = ref({
  tenTemplate: "",
  moTa: "",
  mauChuDao: "#0057B8",
  font: "Arial",
  previewUrl: "",
  isPublished: false,
});

const layoutJson = ref({
  blocks: [],
});

const styleJson = ref(
  JSON.stringify(
    {
      header: { color: "#0057B8", fontSize: 22 },
      body: { fontSize: 14 },
    },
    null,
    2
  )
);

const isEdit = computed(() => !!route.params.id);

onMounted(async () => {
  if (isEdit.value) {
    try {
      const res = await api.get(`/admin/cv-templates/${route.params.id}`);
      Object.assign(form.value, res.data);
      layoutJson.value = JSON.parse(res.data.layoutJson || '{"blocks": []}');
      styleJson.value = JSON.stringify(
        JSON.parse(res.data.styleJson || "{}"),
        null,
        2
      );
    } catch {
      toast.error("Không thể tải dữ liệu mẫu!");
    }
  }
});

async function saveTemplate() {
  try {
    const payload = {
      ...form.value,
      layoutJson: JSON.stringify(layoutJson.value),
      styleJson: styleJson.value,
    };

    if (isEdit.value) {
      await api.put(`/admin/cv-templates/${route.params.id}`, payload);
      toast.success("✅ Cập nhật mẫu thành công!");
    } else {
      await api.post("/admin/cv-templates", payload);
      toast.success("✅ Tạo mẫu mới thành công!");
    }

    router.push("/admin/cv-templates");
  } catch (err) {
    console.error(err);
    toast.error("❌ Lưu mẫu thất bại!");
  }
}
</script>