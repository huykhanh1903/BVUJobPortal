<template>
  <div
    class="fixed inset-0 bg-black/50 flex items-center justify-center z-50"
  >
    <div class="bg-white p-8 rounded-2xl shadow-lg w-full max-w-lg relative">
      <button
        @click="$emit('close')"
        class="absolute top-3 right-4 text-gray-400 hover:text-gray-700 text-2xl"
      >
        ✕
      </button>

      <h2 class="text-xl font-bold mb-6">
        {{ template ? "✏️ Chỉnh sửa mẫu CV" : "➕ Tạo mẫu CV mới" }}
      </h2>

      <form @submit.prevent="saveTemplate" class="space-y-4">
        <div>
          <label class="block text-sm font-semibold mb-1">Tên mẫu</label>
          <input v-model="form.tenTemplate" class="w-full border rounded p-2" required />
        </div>

        <div>
          <label class="block text-sm font-semibold mb-1">Mô tả</label>
          <textarea v-model="form.moTa" class="w-full border rounded p-2" rows="3"></textarea>
        </div>

        <div>
          <label class="block text-sm font-semibold mb-1">Màu chủ đạo</label>
          <input type="color" v-model="form.mauChuDao" class="w-16 h-10 cursor-pointer" />
          <span class="ml-3">{{ form.mauChuDao }}</span>
        </div>

        <div>
          <label class="block text-sm font-semibold mb-1">Font</label>
          <select v-model="form.font" class="w-full border rounded p-2">
            <option>Arial</option>
            <option>Roboto</option>
            <option>Calibri</option>
            <option>Georgia</option>
          </select>
        </div>

        <div>
          <label class="block text-sm font-semibold mb-1">Preview URL</label>
          <input
            v-model="form.previewUrl"
            class="w-full border rounded p-2"
            placeholder="/images/templates/modern.png"
          />
        </div>

        <div class="flex justify-end gap-2 pt-4">
          <button
            type="button"
            @click="$emit('close')"
            class="px-4 py-2 bg-gray-100 rounded hover:bg-gray-200"
          >
            Hủy
          </button>
          <button
            type="submit"
            class="px-5 py-2 bg-green-600 text-white rounded-lg hover:bg-green-700 transition"
          >
            💾 Lưu
          </button>
        </div>
      </form>
    </div>
  </div>
</template>

<script setup>
import { ref, watch } from "vue";
import api from "@/api/axios";
import { useToast } from "vue-toastification";

const props = defineProps({
  template: Object,
});
const emit = defineEmits(["close", "refresh"]);
const toast = useToast();

const form = ref({
  tenTemplate: "",
  moTa: "",
  mauChuDao: "#0057B8",
  font: "Arial",
  previewUrl: "",
});

watch(
  () => props.template,
  (t) => {
    if (t) form.value = { ...t };
  },
  { immediate: true }
);

async function saveTemplate() {
  try {
    if (props.template) {
      await api.put(`/CVTemplate/${props.template.id}`, form.value);
      toast.success("Cập nhật mẫu thành công!");
    } else {
      await api.post("/CVTemplate/Tao-Template", form.value);
      toast.success("Tạo mẫu thành công!");
    }
    emit("refresh");
    emit("close");
  } catch (err) {
    console.error(err);
    toast.error("Lưu mẫu thất bại!");
  }
}
</script>
