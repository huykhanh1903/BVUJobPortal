<template>
  <div class="min-h-screen bg-gray-100 py-10 px-4 flex justify-center">

    <div v-if="loading" class="text-gray-500 text-lg">⏳ Đang tải...</div>

    <div v-else-if="don" class="w-full max-w-6xl bg-white shadow-xl rounded-2xl p-8">

      <div class="flex justify-between items-center mb-6">
        <div>
          <h1 class="text-2xl font-bold text-gray-800">
            Đơn ứng tuyển — {{ don.tieuDeCongViec }}
          </h1>
          <p class="text-gray-600 mt-1">
            🗓 Ngày ứng tuyển: <strong>{{ formatDate(don.ngayUngTuyen) }}</strong>
          </p>
        </div>

        <span :class="statusColor(don.trangThai)"
              class="px-4 py-2 rounded-xl text-white font-semibold">
          {{ don.trangThai }}
        </span>
      </div>
>
    <div class="flex gap-4 mb-6"
        v-if="don.trangThai !== 'Đã chấp nhận' && don.trangThai !== 'Từ chối'">
        
    <button
        @click="chapNhan"
        class="px-5 py-2 bg-green-600 hover:bg-green-700 text-white rounded-xl shadow">
        ✔ Chấp nhận
    </button>

    <button
        @click="tuChoi"
        class="px-5 py-2 bg-red-600 hover:bg-red-700 text-white rounded-xl shadow">
        ✖ Từ chối
    </button>

    </div>

    <div
    v-if="hasPdf(don.cvFileUrl)"
    class="mb-10"
    >
    <h2 class="text-xl font-bold mb-4">📄 CV PDF ứng viên đính kèm</h2>

    <embed
        :src="base + don.cvFileUrl"
        type="application/pdf"
        class="w-full h-[900px] border rounded-lg shadow"
    />

    <div class="mt-4">
        <a
        :href="base + don.cvFileUrl"
        target="_blank"
        class="px-5 py-2 bg-indigo-600 text-white rounded-xl shadow hover:bg-indigo-700 transition"
        >
        ⬇️ Tải CV PDF
        </a>
    </div>
    </div>

    <div
      v-else-if="don.profileDetail"
    >
      <h2 class="text-xl font-bold mb-4">🧾 CV Hồ Sơ Sinh Viên</h2>

      <iframe
        src="/cv/xem?ntd=true"
        class="w-full h-[1200px] border rounded-xl shadow bg-white"
      ></iframe>
    </div>

      <div v-else-if="don.profileDetail">
        <h2 class="text-xl font-bold mb-4">🧾 CV Hồ Sơ Sinh Viên</h2>

        <iframe
          src="/cv/xem?ntd=true"
          class="w-full h-[1200px] border rounded-xl shadow"
        ></iframe>
      </div>

    </div>
  </div>
</template>


<script setup>
import { ref, onMounted } from "vue";
import api from "@/api/axios";
import { useRoute } from "vue-router";

const route = useRoute();
const loading = ref(true);
const don = ref(null);
const base = "https://localhost:7248";

onMounted(async () => {
  await loadDon();
});

const loadDon = async () => {
  const res = await api.get(`/UngTuyen/ntd/chi-tiet/${route.params.id}`);
  don.value = res.data;

  if (don.value.profileDetail) {
    sessionStorage.setItem("cvSinhVien", JSON.stringify(don.value.profileDetail));
  }

  loading.value = false;
};

const chapNhan = async () => {
  if (!confirm("Bạn chắc chắn CHẤP NHẬN ứng viên này?")) return;

  await api.post(`/UngTuyen/ntd/chap-nhan/${don.value.id}`);
  
  await loadDon();
  
  alert("✔ Đã chấp nhận ứng viên!");
};

const tuChoi = async () => {
  if (!confirm("Bạn chắc chắn TỪ CHỐI ứng viên này?")) return;

  await api.post(`/UngTuyen/ntd/tu-choi/${don.value.id}`);

  await loadDon();
  
  alert("❌ Đã từ chối ứng viên!");
};

const formatDate = (d) => new Date(d).toLocaleString("vi-VN");

const statusColor = (status) => ({
  "Đang chờ": "bg-yellow-500",
  "Đã xem": "bg-blue-600",
  "Từ chối": "bg-red-600",
  "Đạt": "bg-green-600"
}[status] || "bg-gray-500");
const hasPdf = (url) => {
  if (!url) return false;
  if (typeof url !== "string") return false;

  const trimmed = url.trim();
  if (trimmed === "") return false;

  return trimmed.toLowerCase().endsWith(".pdf");
};

</script>
