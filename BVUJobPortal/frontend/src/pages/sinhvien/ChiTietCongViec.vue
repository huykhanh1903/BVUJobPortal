<template>
  <div class="bg-gray-50 min-h-screen py-10">
    <div class="max-w-6xl mx-auto px-4">

      <!-- ================= BIG MAIN CARD ================= -->
      <div class="bg-white rounded-3xl shadow-lg p-8 space-y-12">

        <!-- ================= HEADER JOB ================= -->
        <header class="flex flex-col md:flex-row items-start md:items-center gap-6">
          
          <!-- Logo -->
          <div>
            <img
              v-if="job.logoUrl"
              :src="job.logoUrl.startsWith('http') ? job.logoUrl : baseUrl + job.logoUrl"
              class="w-24 h-24 object-cover rounded-xl border shadow-sm"
            />
            <div v-else class="w-24 h-24 flex items-center justify-center bg-gray-100 rounded-xl text-gray-400 text-4xl">
              <i class="fa-solid fa-building"></i>
            </div>
          </div>

          <!-- Title & Company -->
          <div class="flex-1 space-y-2">
            <h1 class="text-3xl font-extrabold text-gray-900 leading-snug">
              {{ job.tieuDe }}
            </h1>

            <p class="text-gray-600 text-lg flex items-center gap-2">
              <i class="fa-solid fa-building text-indigo-500"></i>
              {{ job.tenCongTy }}
            </p>

            <!-- Tags -->
            <div class="flex flex-wrap gap-3 mt-3">
              <span class="tag">💼 {{ job.tenLoaiCongViec }}</span>
              <span class="tag">📊 {{ job.tenCapBac }}</span>
              <span class="tag">⏳ {{ job.tenKinhNghiem }}</span>
            </div>
          </div>

          <!-- Apply button -->
          <button
            @click="apply"
            class="apply-btn"
          >
            Ứng tuyển ngay
          </button>
        </header>

        <!-- Divider -->
        <div class="divider"></div>

        <!-- ================= GENERAL INFO ================= -->
        <section>
          <h2 class="section-title">Thông tin chung</h2>

          <div class="info-grid">

            <div class="info-box">
              <p class="label">Mức lương</p>
              <p class="value text-emerald-600">{{ formatSalary(job) }}</p>
            </div>

            <div class="info-box">
              <p class="label">Hạn nộp hồ sơ</p>
              <p class="value">{{ formatDate(job.hanNopHoSo) }}</p>
            </div>

            <div class="info-box">
              <p class="label">Giới tính yêu cầu</p>
              <p class="value">{{ job.gioiTinh || "Không yêu cầu" }}</p>
            </div>

            <div class="info-box">
              <p class="label">Số lượng tuyển</p>
              <p class="value">{{ job.soLuongTuyen }}</p>
            </div>

          </div>
        </section>

        <!-- Divider -->
        <div class="divider"></div>

        <!-- ================= LOCATION ================= -->
        <section>
          <h2 class="section-title"> Địa điểm làm việc</h2>

          <div class="space-y-2">
            <div
              v-for="(kv, index) in job.khuVucs"
              :key="index"
              class="location-tag"
            >
              📍 {{ kv.diaChiCuThe }}, {{ cleanLocation(job.khuVucLamViec[index]) }}
            </div>

            <p v-if="!job.khuVucs || job.khuVucs.length === 0" class="text-gray-500 text-sm">
              Địa điểm đang cập nhật...
            </p>
          </div>
        </section>

        <!-- Divider -->
        <div class="divider"></div>

        <!-- ================= CATEGORY ================= -->
        <section>
          <h2 class="section-title">Phân loại công việc</h2>

          <div class="bg-gray-50 border rounded-2xl p-6 space-y-3">

            <div v-if="job.linhVucs?.length" class="category-line">
              <span class="cat-label text-blue-700">📘 Lĩnh vực phù hợp:</span>
              <span>{{ job.linhVucs.join(", ") }}</span>
            </div>

            <div v-if="job.nganhNghieps?.length" class="category-line">
              <span class="cat-label text-emerald-700">🏢 Ngành nghề phù hợp:</span>
              <span>{{ job.nganhNghieps.join(", ") }}</span>
            </div>

            <div v-if="job.chuyenNganhs?.length" class="category-line">
              <span class="cat-label text-purple-700">🎓 Chuyên ngành phù hợp:</span>
              <span>{{ job.chuyenNganhs.join(", ") }}</span>
            </div>

          </div>
        </section>

        <!-- Divider -->
        <div class="divider"></div>

        <!-- ================= DESCRIPTION ================= -->
        <section>
          <h2 class="section-title">📝 Mô tả công việc</h2>
          <div v-html="job.moTaCongViec" class="prose max-w-none"></div>
        </section>

        <!-- Divider -->
        <div class="divider"></div>

        <!-- ================= BENEFITS ================= -->
        <section>
          <h2 class="section-title">🎁 Quyền lợi ứng viên</h2>
          <div v-html="job.quyenLoiUngVien" class="prose max-w-none"></div>
        </section>

        <!-- Divider -->
        <div class="divider"></div>

        <!-- ================= COMPANY ================= -->
        <section>
          <h2 class="section-title">🏢 Thông tin công ty</h2>

          <p class="text-gray-700 mb-4">{{ job.gioiThieuCongTy }}</p>

          <div class="text-gray-700 space-y-2">
            <p>🌐 Website: <a :href="job.website" class="link" target="_blank">{{ job.website }}</a></p>
            <p>📧 Email: {{ job.emailLienHe }}</p>
            <p>📞 Số điện thoại: {{ job.soDienThoaiLienHe }}</p>
          </div>
        </section>

      </div>
    </div>
  </div>
</template>


<script setup>
import { ref, onMounted } from "vue";
import api from "@/api/axios";
import { useRoute, useRouter } from "vue-router";

const route = useRoute();
const router = useRouter();

const job = ref({});
const baseUrl = "https://localhost:7248";

onMounted(async () => {
  const res = await api.get(`/CongViec/${route.params.id}`);
  job.value = res.data;
});

const apply = () => {
  router.push(`/ung-tuyen/${job.value.id}`);
};

const formatSalary = (j) => {
  if (!j) return "—";
  if (j.kieuLuong?.toLowerCase() === "thoathuan") return "Thoả thuận";

  const from = j.luongTu ?? null;
  const to = j.luongDen ?? null;

  if (!from && !to) return "Thoả thuận";
  if (from && !to) return from.toLocaleString("vi-VN") + " đ";
  if (!from && to) return to.toLocaleString("vi-VN") + " đ";

  return from.toLocaleString("vi-VN") + " - " + to.toLocaleString("vi-VN") + " đ";
};

const formatDate = (d) => (d ? new Date(d).toLocaleDateString("vi-VN") : "—");


const cleanLocation = (loc) => {
  if (!loc) return "Địa điểm chưa rõ";
  return loc.replace("Thành phố ", "");
};
</script>


<style>
.section-title {
  @apply text-xl font-bold text-gray-800 mb-4 flex items-center gap-2;
}

.tag {
  @apply bg-gray-100 text-gray-700 px-3 py-1 rounded-full text-sm;
}

.apply-btn {
  @apply px-6 py-3 bg-emerald-500 hover:bg-emerald-600 text-white 
         rounded-xl font-semibold text-lg shadow transition;
}

.divider {
  @apply h-px bg-gray-200;
}

.info-grid {
  @apply grid md:grid-cols-2 gap-6;
}

.label {
  @apply text-gray-600 font-semibold;
}

.value {
  @apply text-gray-800 text-lg font-medium;
}

.location-tag {
  @apply px-3 py-2 bg-emerald-50 text-emerald-700 border border-emerald-200 
         text-sm rounded-lg w-fit;
}

.category-line {
  @apply flex items-start gap-2 text-sm;
}

.cat-label {
  @apply font-semibold whitespace-nowrap;
}

.link {
  @apply text-blue-600 hover:underline;
}

.info-box {
  @apply space-y-1;
}

.prose p {
  @apply mb-2 leading-relaxed;
}
/* vùng nội dung render từ v-html */
.prose {
  @apply text-gray-800 leading-relaxed;
}

/* OL / UL */
.prose ol {
  @apply list-decimal pl-6 my-3;
}
.prose ul {
  @apply list-disc pl-6 my-3;
}

/* LI */
.prose li {
  @apply my-1;
}

/* nếu backend có nhúng <br>, <p>... */
.prose p {
  @apply mb-3;
}
.prose h1, .prose h2, .prose h3 {
  @apply font-bold text-gray-900 mt-4 mb-2;
}
.prose a {
  @apply text-indigo-600 underline;
}


</style>