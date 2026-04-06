<template>
  <div class="min-h-screen bg-gray-50 font-[Inter]">

    <!-- ================= BANNER ENTERPRISE+ ================= -->
    <div class="relative h-[340px] overflow-hidden">

      <div class="absolute inset-0 bg-gradient-to-br from-indigo-800 via-indigo-600 to-indigo-500"></div>
      <div class="absolute inset-0 bg-white/10 backdrop-blur-3xl mix-blend-overlay"></div>

      <!-- Wave Bottom -->
      <svg class="absolute bottom-0 left-0 w-full" viewBox="0 0 1440 160">
        <path fill="#f9fafb"
          d="M0,96L120,112C240,128,480,160,720,149.3C960,139,1200,85,1320,58.7L1440,32V160H1320C1200,160,960,160,720,160C480,160,240,160,120,160H0Z">
        </path>
      </svg>

      <!-- Center Info -->
      <div class="absolute inset-0 flex flex-col items-center justify-center text-center">
        <div class="p-3 rounded-3xl bg-white/30 backdrop-blur-xl shadow-2xl -mb-4 transition hover:scale-105">
          <img :src="baseURL + congTy.logoUrl"
               class="w-28 h-28 rounded-2xl border-4 border-white shadow-xl object-cover bg-white" />
        </div>

        <h1 class="text-4xl font-extrabold text-white drop-shadow-xl mt-7 tracking-wide">
          {{ congTy.tenCongTy }}
        </h1>
          <div class="flex items-center gap-2 justify-center mt-2">
          <span
            v-if="congTy.daDuocAdminXacMinh"
            class="px-3 py-1 text-xs font-semibold rounded-full
                  bg-green-100 text-green-700 flex items-center gap-1"
          >
            <i class="fa-solid fa-circle-check"></i> Đã xác minh
          </span>

          <span
            v-else
            class="px-3 py-1 text-xs font-semibold rounded-full
                  bg-yellow-100 text-yellow-700 flex items-center gap-1"
          >
            <i class="fa-solid fa-clock"></i> Chờ xác minh
          </span>
        </div>
        <p class="text-indigo-100 text-sm mt-2 flex items-center justify-center gap-2">
          <i class="fa-solid fa-location-dot"></i>
          {{ congTy.diaChiLamViec}}<span v-if="congTy.tenTinhThanh">, {{ congTy.tenTinhThanh}}</span>
        </p>

        <!-- Actions -->
        <div class="flex gap-4 mt-6">
          <button class="glass-btn">⭐ Theo dõi</button>

          <a v-if="congTy.website"
             :href="congTy.website"
             target="_blank"
             class="main-btn">
            🌐 Website
          </a>
        </div>
      </div>
    </div>

    <!-- ================= MAIN CONTENT ================= -->
    <div class="px-10 pt-12 max-w-7xl mx-auto">

      <!-- ===== STATS ===== -->
      <div class="grid sm:grid-cols-2 lg:grid-cols-4 gap-6 mb-10">

        <div class="stat-box flex items-center gap-4">
          <div class="stat-icon-floating bg-indigo-100 text-indigo-700"><i class="fa-solid fa-briefcase"></i></div>
          <div>
            <h3 class="stat-number">{{ danhSachCongViec.length }}</h3>
            <p class="stat-label">Việc làm đang tuyển</p>
          </div>
        </div>

        <div class="stat-box flex items-center gap-4">
          <div class="stat-icon-floating bg-purple-100 text-purple-700">
            <i class="fa-solid fa-users"></i>
          </div>
          <div>
            <h3 class="stat-number">{{ hienThi(congTy.quyMoNhanSu) }}</h3>
            <p class="stat-label">Quy mô nhân sự</p>
          </div>
        </div>

        <div class="stat-box flex items-center gap-4">
          <div class="stat-icon-floating bg-emerald-100 text-emerald-700">
            <i class="fa-solid fa-calendar"></i>
          </div>
          <div>
            <h3 class="stat-number">{{ congTy.namThanhLap || "—" }}</h3>
            <p class="stat-label">Năm thành lập</p>
          </div>
        </div>

        <div class="stat-box flex items-center gap-4">
          <div class="stat-icon-floating bg-amber-100 text-amber-700">
            <i class="fa-solid fa-layer-group"></i>
          </div>
          <div>
            <h3 class="stat-number">{{ congTy.soLuongLinhVuc ?? 0 }}</h3>
            <p class="stat-label">Lĩnh vực hoạt động</p>
          </div>
        </div>

      </div>

      <!-- ===== GIỚI THIỆU ===== -->
      <section ref="aboutRef" class="section-card">
        <h2 class="section-title">🏢 Giới thiệu công ty</h2>

        <p class="section-text">
          {{ congTy.gioiThieu || "Chưa có mô tả chi tiết cho công ty." }}
        </p>

        <div class="info-grid">
          <p><b>📍 Địa chỉ:</b> {{ congTy.diaChiLamViec }}</p>

          <p><b>🌍 Website:</b>
            <a :href="congTy.website" target="_blank" class="link">
              {{ congTy.website || "—" }}
            </a>
          </p>

          <p><b>📧 Email liên hệ:</b> {{ congTy.emailLienHe || "—" }}</p>
          <p><b>📞 Hotline:</b> {{ congTy.soDienThoaiLienHe || "—" }}</p>
          <p><b>🏛️ Tỉnh/Thành:</b> {{ congTy.tenTinhThanh || "—" }}</p>
          <p v-if="congTy.nguoiLienHe">
            <b>👤 Người liên hệ:</b>
            {{ congTy.nguoiLienHe }}
            <span v-if="congTy.chucVuNguoiLienHe">
              ({{ congTy.chucVuNguoiLienHe }})
            </span>
          </p>
        </div>
      </section>

      <!-- ===== JOB LIST ===== -->
      <section ref="jobsRef" class="section-card mb-20">
        <h2 class="section-title">💼 Việc làm đang tuyển</h2>

        <div v-if="danhSachCongViec.length === 0" class="text-gray-500">
          Công ty hiện chưa đăng tin tuyển dụng nào.
        </div>

        <div class="grid md:grid-cols-2 gap-6 mt-6">
          <div v-for="job in danhSachCongViec"
               :key="job.id"
               @click="goToJob(job.id)"
               class="job-card-enterprise">

            <span class="job-ribbon">Hot</span>

            <h3 class="job-title-enterprise">{{ job.tieuDe }}</h3>

            <p class="job-location-enterprise">
              <i class="fa-solid fa-location-dot mr-1"></i> {{ job.diaChiLamViec }}
            </p>

            <div class="job-footer-enterprise">
              <span>💰 {{ job.luong || "Thoả thuận" }}</span>
              <span>📅 {{ formatDate(job.ngayDang) }}</span>
            </div>

          </div>
        </div>
      </section>

      <!-- ===== LIÊN HỆ ===== -->
      <section ref="contactRef" class="section-card mb-20">
        <h2 class="section-title">📞 Liên hệ</h2>

        <div class="space-y-2 text-gray-700 text-sm">
          <p><b>Email:</b> {{ congTy.emailLienHe || "—" }}</p>
          <p><b>Hotline:</b> {{ congTy.soDienThoaiLienHe || "—" }}</p>
          <p><b>Địa chỉ:</b> {{ congTy.diaChiLamViec || "—" }}</p>

          <p v-if="congTy.nguoiLienHe">
            <b>Người liên hệ:</b> {{ congTy.nguoiLienHe }}
            ({{ congTy.chucVuNguoiLienHe }})
          </p>
        </div>
      </section>

    </div>
  </div>
</template>

<script setup>
import { ref, onMounted } from "vue";
import { useRoute, useRouter } from "vue-router";
import api from "@/api/axios";

const route = useRoute();
const router = useRouter();

const congTy = ref({});
const danhSachCongViec = ref([]);

const baseURL = "https://localhost:7248";

const formatDate = (d) =>
  d ? new Date(d).toLocaleDateString("vi-VN") : "—";

// ===== Tabs + Scroll =====
const activeTab = ref("gioi-thieu");

const aboutRef = ref(null);
const jobsRef = ref(null);
const contactRef = ref(null);

const scrollTo = (target, tab) => {
  activeTab.value = tab;
  target.value?.scrollIntoView({ behavior: "smooth", block: "start" });
};

// ===== Fetch Data =====
const fetchData = async () => {
  const id = route.params.id;

  try {
    const [congTyRes, jobRes] = await Promise.all([
      api.get(`/Admin/cong-ty/${id}`),
      api.get(`/Admin/cong-ty/${id}/cong-viec`)
    ]);

    congTy.value = congTyRes.data;

    danhSachCongViec.value = jobRes.data ?? [];

  } catch (err) {
    console.error("Lỗi tải hồ sơ công ty:", err);
  }
};


const goToJob = (id) => {
  router.push(`/viec-lam/${id}`);
};

onMounted(fetchData);
const hienThi = (value, macDinh = "—") => {
  if (value === null || value === undefined) return macDinh;
  if (typeof value === "string" && value.trim() === "") return macDinh;
  return value;
};
</script>


<style scoped>

/* Tabs */
.tab {
  @apply px-2 pb-1 border-b-2 border-transparent hover:border-indigo-600 hover:text-indigo-700 transition;
}
.tab-active {
  @apply px-2 pb-1 border-b-2 border-indigo-600 text-indigo-700 font-semibold;
}

/* Buttons */
.glass-btn {
  @apply px-5 py-2 bg-white/30 text-white font-semibold rounded-xl shadow backdrop-blur-xl 
         hover:bg-white/40 transition;
}
.main-btn {
  @apply px-5 py-2 bg-indigo-600 text-white font-semibold rounded-xl shadow hover:bg-indigo-700 transition;
}

/* Stats */
.stat-box {
  @apply bg-white rounded-2xl shadow-md p-5 border border-gray-100;
}
.stat-icon-floating {
  @apply w-12 h-12 flex items-center justify-center rounded-xl text-xl shadow bg-white;
}
.stat-number {
  @apply text-2xl font-extrabold text-gray-900;
}
.stat-label {
  @apply text-gray-600 text-sm;
}

/* Sections */
.section-title {
  @apply text-2xl font-bold text-gray-800 mb-4 border-l-4 border-indigo-600 pl-3;
}
.section-card {
  @apply bg-white rounded-2xl shadow-xl p-8 mb-10;
}
.section-text {
  @apply text-gray-700 leading-relaxed whitespace-pre-line mt-3;
}
.info-grid {
  @apply grid sm:grid-cols-2 lg:grid-cols-3 gap-5 mt-8 text-gray-700 text-sm;
}
.link {
  @apply text-blue-600 underline hover:text-blue-800 transition;
}

/* Job Card */
.job-card-enterprise {
  @apply relative bg-white border rounded-2xl p-6 shadow-sm 
         hover:shadow-2xl hover:-translate-y-1 transition cursor-pointer;
}
.job-ribbon {
  @apply absolute top-4 right-4 bg-red-500 text-white text-xs font-semibold px-2 py-1 rounded-md shadow;
}
.job-title-enterprise {
  @apply text-xl font-bold text-gray-900 mb-2;
}
.job-location-enterprise {
  @apply text-gray-600 text-sm;
}
.job-footer-enterprise {
  @apply flex justify-between text-gray-500 text-sm mt-4;
}

</style>
