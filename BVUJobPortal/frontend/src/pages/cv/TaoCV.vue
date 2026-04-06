<template>
  <div class="flex min-h-screen bg-gray-50">
    <aside class="w-1/4 bg-white border-r shadow-lg p-6 space-y-6">
      <h2 class="text-lg font-bold text-gray-800 mb-3">🎨 Thiết kế & Font</h2>

      <div>
        <label class="block text-sm font-medium mb-1 text-gray-600">Font chữ</label>
        <select v-model="selectedFont" class="w-full border rounded p-2">
          <option v-for="font in fonts" :key="font" :value="font">{{ font }}</option>
        </select>
      </div>

      <div>
        <label class="block text-sm font-medium mb-1 text-gray-600">Cỡ chữ: {{ fontSize }}px</label>
        <input type="range" min="12" max="20" v-model="fontSize" class="w-full accent-blue-600" />
      </div>

      <div>
        <label class="block text-sm font-medium mb-1 text-gray-600">Khoảng cách dòng: {{ lineHeight }}</label>
        <input type="range" min="1" max="2" step="0.1" v-model="lineHeight" class="w-full accent-blue-600" />
      </div>

      <div>
        <label class="block text-sm font-medium mb-1 text-gray-600">Màu chủ đạo</label>
        <input type="color" v-model="themeColor" class="w-12 h-8 border rounded cursor-pointer" />
      </div>

      <div>
        <h3 class="font-semibold mt-6 mb-2 text-gray-800">🧩 Mẫu CV</h3>
        <div v-if="loadingTemplates" class="text-gray-400 italic">Đang tải mẫu...</div>
        <div v-else class="grid grid-cols-2 gap-3">
          <div
            v-for="t in templateList"
            :key="t.id"
            @click="selectedTemplate = t.id"
            class="cursor-pointer border-2 rounded-lg overflow-hidden transition hover:scale-[1.03]"
            :class="selectedTemplate === t.id ? 'border-blue-600 shadow-lg' : 'border-gray-200'"
          >
            <img :src="`http://localhost:7248${t.previewUrl}`" alt="preview" class="object-cover w-full h-28" />
            <p class="text-xs text-center font-medium py-1">{{ t.tenTemplate }}</p>
          </div>
        </div>
      </div>
    </aside>

    <main class="flex-1 overflow-y-auto p-8 bg-white">
      <h1 class="text-2xl font-bold text-gray-800 mb-6 flex items-center gap-2">📝 Tạo CV mới</h1>

      <form @submit.prevent="createCV" class="space-y-6">
        <div>
          <label class="block font-semibold mb-1">🎯 Mục tiêu nghề nghiệp</label>
          <textarea
            v-model="form.mucTieuNgheNghiep"
            class="w-full border rounded-lg p-2 focus:ring focus:ring-blue-100"
            rows="3"
            placeholder="Ví dụ: Mong muốn trở thành lập trình viên backend chuyên nghiệp..."
          />
        </div>

        <div>
          <label class="block font-semibold mb-1">🎓 Học vấn</label>
          <div v-for="(hv, i) in form.hocVan" :key="i" class="grid grid-cols-2 gap-4 mb-3">
            <input v-model="hv.truong" placeholder="Trường" class="border p-2 rounded" />
            <input v-model="hv.nganhHoc" placeholder="Ngành học" class="border p-2 rounded" />
            <input v-model="hv.thoiGianHoc" placeholder="Thời gian (VD: 2021 - 2025)" class="border p-2 rounded col-span-2" />
            <input v-model="hv.thanhTich" placeholder="Thành tích" class="border p-2 rounded col-span-2" />
          </div>
          <button type="button" @click="addHocVan" class="text-blue-600 text-sm">+ Thêm học vấn</button>
        </div>

        <div>
          <label class="block font-semibold mb-1">💼 Kinh nghiệm làm việc</label>
          <textarea
            v-model="form.kinhNghiem[0].moTa"
            class="w-full border rounded-lg p-2 focus:ring focus:ring-blue-100"
            rows="3"
            placeholder="Mô tả kinh nghiệm làm việc..."
          />
        </div>

        <div>
          <label class="block font-semibold mb-1">🛠️ Kỹ năng chuyên môn</label>
          <input
            v-model="kyNangChuyenMonInput"
            @keyup.enter.prevent="addKyNangChuyenMon"
            placeholder="Nhập kỹ năng và Enter (VD: .NET, SQL, Java)"
            class="border p-2 rounded w-full"
          />
          <div class="flex flex-wrap gap-2 mt-2">
            <span v-for="(k, i) in form.kyNangChuyenMon" :key="i" class="bg-indigo-100 text-indigo-700 px-2 py-1 rounded">
              {{ k }}
            </span>
          </div>
        </div>

        <div>
          <label class="block font-semibold mb-1">🤝 Kỹ năng mềm</label>
          <input
            v-model="kyNangMemInput"
            @keyup.enter.prevent="addKyNangMem"
            placeholder="Nhập kỹ năng mềm và Enter (VD: Làm việc nhóm, giao tiếp...)"
            class="border p-2 rounded w-full"
          />
          <div class="flex flex-wrap gap-2 mt-2">
            <span v-for="(k, i) in form.kyNangMem" :key="i" class="bg-green-100 text-green-700 px-2 py-1 rounded">
              {{ k }}
            </span>
          </div>
        </div>
>
        <div>
          <label class="block font-semibold mb-1">📜 Chứng chỉ</label>
          <div v-for="(cc, i) in form.chungChi" :key="i" class="grid grid-cols-3 gap-4 mb-3">
            <input v-model="cc.tenChungChi" placeholder="Tên chứng chỉ" class="border p-2 rounded" />
            <input v-model="cc.noiCap" placeholder="Nơi cấp" class="border p-2 rounded" />
            <input type="date" v-model="cc.ngayCap" class="border p-2 rounded" />
          </div>
          <button type="button" @click="addChungChi" class="text-blue-600 text-sm">+ Thêm chứng chỉ</button>
        </div>

        <div>
          <label class="block font-semibold mb-1">🚀 Hoạt động / Dự án</label>
          <div v-for="(hd, i) in form.hoatDongDuAn" :key="i" class="grid grid-cols-3 gap-4 mb-3">
            <input v-model="hd.ten" placeholder="Tên dự án" class="border p-2 rounded" />
            <input v-model="hd.vaiTro" placeholder="Vai trò" class="border p-2 rounded" />
            <input v-model="hd.moTa" placeholder="Mô tả ngắn" class="border p-2 rounded" />
          </div>
          <button type="button" @click="addDuAn" class="text-blue-600 text-sm">+ Thêm dự án</button>
        </div>

        <div class="flex justify-end gap-3 pt-6">
          <router-link to="/cv" class="px-5 py-2 bg-gray-100 text-gray-700 rounded-lg hover:bg-gray-200 transition">
            Hủy
          </router-link>
          <button type="submit" class="px-5 py-2 bg-green-600 text-white rounded-lg hover:bg-green-700 transition">
            💾 Lưu CV
          </button>
        </div>
      </form>
    </main>

    <aside class="w-[40%] bg-gray-100 flex justify-center items-start overflow-y-auto p-6">
      <div
        class="scale-[0.6] lg:scale-[0.75] xl:scale-[0.9] origin-top transition-all duration-300"
        :style="{
          fontFamily: selectedFont,
          '--cv-color': themeColor,
          fontSize: fontSize + 'px',
          lineHeight: lineHeight,
        }"
      >
        <CVPreview :template-id="selectedTemplate" :cv="form" />
      </div>
    </aside>
  </div>
</template>

<script setup>
import { ref, onMounted } from "vue";
import api from "@/api/axios";
import { useAuthStore } from "@/store/auth";
import { useRouter } from "vue-router";
import { useToast } from "vue-toastification";
import CVPreview from "@/components/cv/CVPreview.vue";

const auth = useAuthStore();
const router = useRouter();
const toast = useToast();

const form = ref({
  mucTieuNgheNghiep: "",
  hocVan: [{ truong: "", nganhHoc: "", thoiGianHoc: "", thanhTich: "" }],
  kinhNghiem: [{}],
  kyNangChuyenMon: [],
  kyNangMem: [],
  chungChi: [{ tenChungChi: "", ngayCap: "", noiCap: "" }],
  hoatDongDuAn: [{ ten: "", vaiTro: "", moTa: "" }],
  ngayTao: new Date().toISOString(),
  ngayCapNhat: new Date().toISOString(),
  templateId: null,
});

const kyNangChuyenMonInput = ref("");
const kyNangMemInput = ref("");

const templateList = ref([]);
const selectedTemplate = ref(null);
const loadingTemplates = ref(true);

const selectedFont = ref("Roboto");
const fonts = ["Arial", "Roboto", "Georgia", "Calibri", "Open Sans"];
const fontSize = ref(14);
const lineHeight = ref(1.4);
const themeColor = ref("#1e3a8a");

async function fetchTemplates() {
  try {
    const res = await api.get("/CVTemplate/list");
    templateList.value = res.data || [];
    if (templateList.value.length > 0) selectedTemplate.value = templateList.value[0].id;
  } catch (err) {
    console.error("Lỗi tải danh sách template:", err);
    toast.error("Không thể tải danh sách mẫu CV!");
  } finally {
    loadingTemplates.value = false;
  }
}

const addHocVan = () => form.value.hocVan.push({ truong: "", nganhHoc: "", thoiGianHoc: "", thanhTich: "" });
const addChungChi = () => form.value.chungChi.push({ tenChungChi: "", ngayCap: "", noiCap: "" });
const addDuAn = () => form.value.hoatDongDuAn.push({ ten: "", vaiTro: "", moTa: "" });

const addKyNangChuyenMon = () => {
  if (kyNangChuyenMonInput.value.trim()) {
    form.value.kyNangChuyenMon.push(kyNangChuyenMonInput.value.trim());
    kyNangChuyenMonInput.value = "";
  }
};
const addKyNangMem = () => {
  if (kyNangMemInput.value.trim()) {
    form.value.kyNangMem.push(kyNangMemInput.value.trim());
    kyNangMemInput.value = "";
  }
};

async function createCV() {
  if (!selectedTemplate.value) {
    toast.warning("Vui lòng chọn mẫu CV!");
    return;
  }

  try {
    form.value.templateId = selectedTemplate.value;
    await api.post("/CV/tao", form.value, {
      headers: { Authorization: `Bearer ${auth.token}` },
    });
    toast.success("✅ Tạo CV thành công!");
    router.push("/cv");
  } catch (err) {
    console.error("Lỗi tạo CV:", err);
    toast.error("❌ Tạo CV thất bại!");
  }
}

onMounted(fetchTemplates);
</script>

<style scoped>
:root {
  --cv-color: #1e3a8a;
}
</style>
