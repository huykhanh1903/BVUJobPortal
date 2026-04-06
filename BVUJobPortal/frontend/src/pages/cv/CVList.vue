<template>
  <div class="p-8 bg-gray-50 min-h-screen">
    <div class="flex items-center justify-between mb-8">
      <h1 class="text-3xl font-bold text-gray-800 flex items-center gap-3">
        📂 Quản lý CV
      </h1>

      <router-link
        to="/cv/chon-mau"
        class="px-5 py-2 bg-blue-600 text-white rounded-xl shadow hover:bg-blue-700 transition"
      >
        ➕ Tạo CV mới
      </router-link>
    </div>

    <div v-if="loading" class="text-center text-gray-500 py-12">
      ⏳ Đang tải CV...
    </div>

    <div
      v-else-if="cvs.length === 0"
      class="text-center py-16 bg-white rounded-2xl shadow"
    >
      <p class="text-gray-600 mb-4 text-lg">
        Bạn chưa có CV nào trong hệ thống.
      </p>

      <router-link
        to="/cv/chon-mau"
        class="px-6 py-3 bg-indigo-600 text-white rounded-xl font-semibold hover:bg-indigo-700 transition"
      >
        ➕ Tạo CV ngay
      </router-link>
    </div>

    <div v-else class="grid gap-6 sm:grid-cols-2 lg:grid-cols-3">
      <div
        v-for="cv in cvs"
        :key="cv.id"
        class="bg-white rounded-2xl shadow hover:shadow-xl transform hover:-translate-y-1 transition p-6 flex flex-col"
      >
        <div
          class="h-32 bg-gradient-to-br from-blue-100 to-indigo-200 rounded-lg flex items-center justify-center text-5xl text-indigo-500 mb-4"
        >
          <i class="fas fa-file-alt"></i>
        </div>

        <div class="flex-1">
          <h2 class="text-lg font-bold text-gray-800 truncate mb-1">
            {{ cv.mucTieuNgheNghiep || "CV chưa có mục tiêu" }}
          </h2>
          <p class="text-sm text-gray-500">
            📅 Tạo: {{ formatDate(cv.ngayTao) }} |
            Cập nhật: {{ formatDate(cv.ngayCapNhat) }}
          </p>

          <p
            v-if="cv.hocVan?.length"
            class="text-sm text-gray-600 mt-2 line-clamp-2"
          >
            🎓 {{ cv.hocVan[0].truong }} - {{ cv.hocVan[0].nganhHoc }}
          </p>
        </div>

        <div class="flex flex-wrap gap-2 mt-4">

          <router-link
            :to="`/cv/xem/${cv.id}`"
            class="flex-1 text-center px-3 py-2 rounded-lg bg-gray-100 hover:bg-gray-200 text-sm text-gray-700"
          >
            👀 Xem
          </router-link>

          <!-- <button
            @click="taiPdf(cv.id)"
            class="flex-1 text-center px-3 py-2 rounded-lg bg-green-100 hover:bg-green-200 text-sm text-green-700"
          >
            ⬇️ PDF
          </button> -->

          <!-- <button
            @click="taiPdfTemplate(cv.id)"
            class="flex-1 text-center px-3 py-2 rounded-lg bg-blue-100 hover:bg-blue-200 text-sm text-blue-700"
          >
            📄 Template PDF
          </button> -->

          <router-link
            :to="`/cv/sua/${cv.id}`"
            class="flex-1 text-center px-3 py-2 rounded-lg bg-yellow-100 hover:bg-yellow-200 text-sm text-yellow-700"
          >
            ✏️ Sửa
          </router-link>

          <button
            @click="deleteCV(cv.id)"
            class="flex-1 text-center px-3 py-2 rounded-lg bg-red-100 hover:bg-red-200 text-sm text-red-700"
          >
            🗑️ Xóa
          </button>

        </div>
      </div>
    </div>

    <div
      v-if="deleting"
      class="fixed inset-0 bg-black/40 flex items-center justify-center z-50"
    >
      <div class="bg-white px-6 py-4 rounded-xl shadow-lg">
        ⏳ Đang xử lý xóa CV...
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
const cvs = ref([]);
const loading = ref(true);
const deleting = ref(false);

function formatDate(dateStr) {
  if (!dateStr || dateStr === "0001-01-01T00:00:00") return "—";
  return new Date(dateStr).toLocaleDateString("vi-VN");
}

async function fetchCVs() {
  loading.value = true;
  try {
    const res = await api.get("/CV/list", {
      headers: { Authorization: `Bearer ${auth.token}` },
    });
    cvs.value = res.data || [];
  } catch (err) {
    console.error("Lỗi tải CV:", err);
    toast.error("Không thể tải danh sách CV!");
  } finally {
    loading.value = false;
  }
}

async function deleteCV(id) {
  if (!confirm("Bạn có chắc muốn xóa CV này?")) return;

  deleting.value = true;
  try {
    await api.delete(`/CV/${id}`, {
      headers: { Authorization: `Bearer ${auth.token}` },
    });
    cvs.value = cvs.value.filter((cv) => cv.id !== id);

    toast.success("Đã xóa CV thành công!");
  } catch (err) {
    console.error("Lỗi xóa CV:", err);
    toast.error("Xóa CV thất bại!");
  } finally {
    deleting.value = false;
  }
}

async function taiPdf(id) {
  try {
    const res = await api.get(`/CV/${id}/tai-pdf`, {
      responseType: "blob",
      headers: { Authorization: `Bearer ${auth.token}` },
    });

    const url = window.URL.createObjectURL(new Blob([res.data]));
    const link = document.createElement("a");
    link.href = url;
    link.download = `CV_${id}.pdf`;
    link.click();
    window.URL.revokeObjectURL(url);
  } catch (err) {
    console.error("PDF error:", err);
    toast.error("Không thể tải PDF!");
  }
}

async function taiPdfTemplate(id) {
  try {
    const res = await api.get(`/CV/${id}/export-template`, {
      responseType: "blob",
      headers: { Authorization: `Bearer ${auth.token}` }
    });

    const url = window.URL.createObjectURL(new Blob([res.data]));
    const link = document.createElement("a");
    link.href = url;
    link.download = `CV_${id}_template.pdf`;
    link.click();
    window.URL.revokeObjectURL(url);

    toast.success("Tải PDF Template thành công!");
  } catch (err) {
    console.error("PDF template error:", err);
    toast.error("Không thể tải PDF Template!");
  }
}
async function exportPDFTemplate() {
  try {
    const el = document.getElementById("cv-preview");
    if (!el) return;

    const html = el.outerHTML;

    let css = "";

    for (const sheet of document.styleSheets) {
      try {
        for (const rule of sheet.cssRules) {
          css += rule.cssText;
        }
      } catch (err) {
        const href = sheet.href;
        if (href) {
          try {
            const r = await fetch(href);
            css += await r.text();
          } catch (e) {
            console.warn("Không load được CSS:", href);
          }
        }
      }
    }

    const res = await api.post(
      "/CV/export-html",
      {
        html,
        css,
        width: 794,
        height: 1123
      },
      { responseType: "blob" }
    );

    const url = URL.createObjectURL(new Blob([res.data]));
    const a = document.createElement("a");
    a.href = url;
    a.download = `CV_${route.params.id}.pdf`;
    a.click();
    URL.revokeObjectURL(url);

  } catch (err) {
    console.error("Export PDF lỗi:", err);
    alert("Xuất PDF thất bại!");
  }
}
onMounted(fetchCVs);
</script>

<style scoped>
@import url("https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css");
</style>
