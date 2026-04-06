<template>
  <div class="min-h-screen bg-gradient-to-br from-gray-50 via-blue-50/20 to-white font-[Inter]">

    <!-- =================== HEADER =================== -->
    <header class="bg-white sticky top-0 z-30 border-b shadow-sm/50 backdrop-blur-md">
      <div class="max-w-7xl mx-auto px-6 py-8">

        <div class="flex flex-col">

          <!-- TITLE + ICON -->
          <div class="flex items-center gap-3">
            <div class="w-12 h-12 flex items-center justify-center rounded-xl bg-indigo-100 text-indigo-600 text-2xl shadow-inner">
              <i class="fa-solid fa-magnifying-glass"></i>
            </div>

            <h1 class="text-3xl md:text-4xl font-extrabold text-gray-800 leading-tight">
              Tìm kiếm việc làm cho sinh viên BVU
            </h1>
          </div>

          <!-- SUBTITLE -->
          <p class="text-gray-600 text-lg mt-2 ml-0.5">
            Hơn <span class="font-semibold text-indigo-600">100+</span> công việc được cập nhật mỗi ngày
          </p>

        </div>

      </div>
    </header>


    <div class="max-w-7xl mx-auto px-6 mt-10 grid grid-cols-1 lg:grid-cols-4 gap-8">

      <aside
        class="lg:col-span-1 bg-white/90 border shadow-xl rounded-3xl p-6 h-fit sticky top-28 neumorph">

        <!-- HEADER -->
        <div class="flex items-center gap-4 mb-6">
          <div class="icon-box">
            <i class="fas fa-filter text-indigo-600 text-lg"></i>
          </div>
          <h2 class="text-2xl font-extrabold text-gray-800">Bộ lọc tìm kiếm</h2>
        </div>

        <div class="space-y-6">

          <div class="filter-block">
            <span class="filter-title flex items-center gap-2">
              <i class="fa-solid fa-magnifying-glass text-indigo-500"></i>
              Từ khóa
            </span>
            <input
              v-model="keyword"
              @input="onChangeFilter"
              class="filter-input"
              placeholder="VD: Lập trình viên..."
            />
          </div>

          <div class="divider"></div>

          <div class="filter-block">
            <span class="filter-title flex items-center gap-2">
              <i class="fa-solid fa-layer-group text-indigo-500"></i>
              Lĩnh vực
            </span>
            <select v-model="selectedField" @change="onChangeFilter" class="filter-input">
              <option value="">Tất cả</option>
              <option v-for="lv in linhVucs" :key="lv.id" :value="lv.id">
                {{ lv.tenLinhVuc }}
              </option>
            </select>
          </div>

          <div class="filter-block">
            <span class="filter-title flex items-center gap-2">
              <i class="fa-solid fa-briefcase text-indigo-500"></i>
              Ngành nghề
            </span>
            <select
              v-model="selectedNghe"
              @change="onChangeFilter"
              class="filter-input"
              :disabled="!selectedField"
            >
              <option value="">Chọn lĩnh vực trước</option>
              <option v-for="nghe in ngheNghieps" :key="nghe.id" :value="nghe.id">
                {{ nghe.tenNghe }}
              </option>
            </select>
          </div>

          <div class="filter-block">
            <span class="filter-title flex items-center gap-2">
              <i class="fa-solid fa-user-graduate text-indigo-500"></i>
              Chuyên ngành
            </span>
            <select
              v-model="selectedChuyenNganh"
              @change="onChangeFilter"
              class="filter-input"
              :disabled="!selectedNghe"
            >
              <option value="">Chọn ngành nghề trước</option>
              <option v-for="cn in chuyenNganhs" :key="cn.id" :value="cn.id">
                {{ cn.tenChuyenNganh }}
              </option>
            </select>
          </div>

          <div class="divider"></div>

          <div class="filter-block">
            <span class="filter-title flex items-center gap-2">
              <i class="fa-solid fa-money-bill text-indigo-500"></i>
              Mức lương
            </span>
            <select v-model="selectedSalary" @change="onChangeFilter" class="filter-input">
              <option value="">Tất cả mức lương</option>
              <option value="duoi3">Dưới 3 triệu</option>
              <option value="3to7">Trên 3 triệu</option>
              <option value="7to10">Trên 7 triệu</option>
              <option value="10to15">Trên 10 triệu</option>
              <option value="tren15">Trên 15 triệu</option>
              <option value="thoathuan">Thoả thuận</option>
            </select>
          </div>

          <div class="filter-block">
            <span class="filter-title flex items-center gap-2">
              <i class="fa-solid fa-chart-line text-indigo-500"></i>
              Kinh nghiệm
            </span>
            <select v-model="selectedExperience" @change="onChangeFilter" class="filter-input">
              <option value="">Tất cả</option>
              <option v-for="kn in kinhNghiemList" :key="kn.id" :value="kn.id">
                {{ kn.ten }}
              </option>
            </select>
          </div>

          <div class="divider"></div>

          <div class="filter-block relative">
            <span class="filter-title flex items-center gap-2">
              <i class="fa-solid fa-map-location-dot text-indigo-500"></i>
              Địa điểm
            </span>

            <button
              @click="showLocationDropdown = !showLocationDropdown"
              class="filter-input flex justify-between"
            >
              <span>{{ locationLabel }}</span>
              <i class="fa-solid fa-chevron-down text-xs"></i>
            </button>

            <transition name="fade">
              <div
                v-if="showLocationDropdown"
                class="location-dropdown neumorph p-4"
              >
                <input v-model="locationSearch" class="filter-input" placeholder="Tìm kiếm..." />
                <div class="max-h-56 overflow-y-auto mt-2">
                  <label
                    v-for="t in filteredTinhThanhs"
                    :key="t.id"
                    class="location-item"
                  >
                    <input type="checkbox" :value="t.id" v-model="selectedProvinces" />
                    {{ t.tenTinh }}
                  </label>
                </div>
              </div>
            </transition>
          </div>

          <div class="divider"></div>

          <div class="filter-block">
            <span class="filter-title flex items-center gap-2">
              <i class="fa-solid fa-id-badge text-indigo-500"></i>
              Loại công việc
            </span>

            <div class="flex flex-wrap gap-2">
              <!-- Tất cả -->
              <button
                @click="selectJobType('')"
                :class="['job-type-pill', selectedJobType === '' ? 'job-type-active' : '']"
              >
                <i class="fa-regular fa-circle"></i> Tất cả
              </button>

              <button
                v-for="type in jobTypes"
                :key="type.id"
                @click="selectJobType(type.id)"
                :class="['job-type-pill', String(selectedJobType) === String(type.id) ? 'job-type-active' : '']"
              >
                {{ type.ten }}
              </button>
            </div>
          </div>

          <!-- RESET BUTTON -->
          <button @click="resetFilters" class="reset-btn">
            <i class="fa-solid fa-arrow-rotate-right mr-2"></i>
            Đặt lại bộ lọc
          </button>
        </div>

      </aside>

      <main class="lg:col-span-3">

        <!-- Loading -->
        <div v-if="loading" class="space-y-5">
          <div v-for="n in 5" :key="n" class="job-loading"></div>
        </div>

        <!-- Empty -->
        <div v-else-if="paginatedJobs.length === 0"
             class="text-center py-20 text-gray-500 text-lg">
          😢 Không tìm thấy công việc phù hợp.
        </div>

        <!-- Job List -->
        <div v-else class="space-y-6">

          <div
            v-for="job in paginatedJobs"
            :key="job.id"
            class="job-card group transition-all overflow-hidden cursor-pointer"
            @click="goToDetail(job.id)"
          >

              <div class="flex gap-5">

                <!-- LOGO -->
                <div class="h-16 w-16 rounded-2xl bg-gray-100 group-hover:bg-indigo-50 transition p-2 flex items-center justify-center">
                  <img
                    v-if="job.logoUrl"
                    :src="job.logoUrl.startsWith('http') ? job.logoUrl : 'https://localhost:7248' + job.logoUrl"
                    class="h-full w-full object-cover rounded-xl"
                  />
                  <i v-else class="fas fa-building text-gray-400 text-2xl"></i>
                </div>

                <!-- JOB INFO -->
                <div class="flex-1">

                  <!-- Title -->
                  <h3 class="text-lg font-bold text-gray-800 group-hover:text-indigo-600 transition">
                    {{ job.tieuDe }}
                  </h3>

                  <!-- Company -->
                  <p class="text-gray-500 text-sm font-medium">
                    {{ job.tenCongTy }}
                  </p>

                  <!-- TAGS (salary, location, job type) -->
                  <div class="flex flex-wrap gap-2 mt-3">

                    <!-- Salary -->
                    <span class="job-tag">
                      💰 {{ formatSalary(job) }}
                    </span>

                    <!-- Location -->
                    <span class="job-tag">
                      📍 {{ job.tenTinhThanh || formatDiaDiem(job.khuVucLamViec) }}
                    </span>

                    <!-- Job Type -->
                    <span class="job-tag job-type">
                      🕑 {{ job.tenLoaiCongViec || job.loaiCongViec }}
                    </span>

                  </div>

                  <!-- Posted date -->
                  <div class="posted-badge">
                    🕒 {{ formatPostedDate(job.ngayDang) }}
                  </div>
                </div>

                <!-- ACTION BUTTONS -->
                <div class="flex flex-col items-end justify-between py-1">
                  <!-- Save -->
                  <button
                    @click.stop="toggleSave(job)"
                    :class="isSaved(job.id) ? 'text-red-500' : 'text-gray-400'"
                    class="text-xl hover:scale-110 transition"
                  >
                    <i :class="isSaved(job.id) ? 'fas fa-heart' : 'far fa-heart'"></i>
                  </button>

                  <!-- Apply -->
                  <router-link
                    :to="`/viec-lam/${job.id}`"
                    @click.stop
                    class="apply-btn !px-5 !py-2.5 font-medium rounded-lg shadow"
                  >
                    Chi tiết
                  </router-link>

                </div>
              </div>
          </div>

        </div>

        <!-- Pagination -->
        <div v-if="totalPages > 1" class="flex items-center justify-center gap-2 mt-10 select-none">

          <!-- Prev -->
          <button
            @click="prevPage"
            :disabled="currentPage === 1"
            class="page-btn-new"
          >
            <i class="fa-solid fa-chevron-left text-xs"></i>
          </button>

          <!-- Page numbers -->
          <button
            v-for="page in totalPages"
            :key="page"
            @click="currentPage = page"
            :class="[
              'page-number',
              currentPage === page ? 'active-page' : ''
            ]"
          >
            {{ page }}
          </button>

          <!-- Next -->
          <button
            @click="nextPage"
            :disabled="currentPage === totalPages"
            class="page-btn-new"
          >
            <i class="fa-solid fa-chevron-right text-xs"></i>
          </button>

        </div>
      </main>
    </div>
  </div>
</template>

<script setup>
import { ref, onMounted, computed } from "vue";
import api from "@/api/axios";
import { useAuthStore } from "@/store/auth";
import { useToast } from "vue-toastification";

const auth = useAuthStore();
const toast = useToast();
const sidebarCollapsed = ref(false);

const jobs = ref([]);
const linhVucs = ref([]);

const selectedSalary = ref("");

// ==== ĐỊA ĐIỂM ====
const tinhThanhs = ref([]);
const selectedProvinces = ref([]);      // chọn nhiều tỉnh
const showLocationDropdown = ref(false);
const locationSearch = ref("");

// ==== LỌC KHÁC ====
const selectedJobType = ref("");
const keyword = ref("");
const selectedField = ref("");
const currentPage = ref(1);
const pageSize = 6;
const loading = ref(true);
const isApiSearch = ref(false);

const ngheNghieps = ref([]);
const selectedNghe = ref("");

const chuyenNganhs = ref([]);
const selectedChuyenNganh = ref("");

const kinhNghiemList = ref([]);
const selectedExperience = ref("");
const jobTypes = ref([]);

import { watch } from "vue";
import { useRoute } from "vue-router";
const route = useRoute();

watch(
  () => route.query,
  (q) => {

    // keyword
    if (q.keyword !== undefined) {
      keyword.value = q.keyword;
    }

    // lĩnh vực
    if (q.linhVucId !== undefined) {
      selectedField.value = Number(q.linhVucId);
    }

    // nghề
    if (q.ngheId !== undefined) {
      selectedNghe.value = Number(q.ngheId);
    }

    // chuyên ngành
    if (q.chuyenNganhId !== undefined) {
      selectedChuyenNganh.value = Number(q.chuyenNganhId);
    }

    // Gọi API lại
    timKiemCongViec();
    currentPage.value = 1;
  },
  { deep: true }
);

watch(selectedNghe, async (ngheId) => {
  selectedChuyenNganh.value = "";

  if (ngheId) {
    await loadChuyenNganhByNghe(ngheId);
  } else {
    chuyenNganhs.value = [];
  }
});
watch(selectedChuyenNganh, (cnId) => {
  if (!cnId) return;

  onChangeFilter();
});


const savedJobs = ref(JSON.parse(localStorage.getItem("savedJobs") || "[]"));

// 🔹 Lấy tất cả công việc (chỉ hiển thị job đã duyệt)
const fetchJobs = async () => {
  try {
    const res = await api.get("/CongViec/tat-ca");
    jobs.value = res.data.filter((j) => j.daDuyet === true);
  } catch (err) {
    console.error("Lỗi tải danh sách công việc:", err);
  } finally {
    loading.value = false;
  }
  isApiSearch.value = false;
};

const allJobs = ref([]);
onMounted(async () => {
  const res = await api.get("/CongViec/tat-ca");
  allJobs.value = res.data;
});

// 🔹 Lấy lĩnh vực
const fetchLinhVucs = async () => {
  try {
    const res = await api.get("/Admin/linh-vuc");
    linhVucs.value = res.data?.duLieu ?? res.data ?? [];
  } catch (err) {
    console.error("Lỗi tải lĩnh vực:", err);
  }
};

const loadNgheNghiep = async () => {
  try {
    const res = await api.get("/Admin/nghe-nghiep");
    ngheNghieps.value = res.data?.duLieu ?? res.data ?? [];
  } catch (err) {
    console.error("Lỗi tải danh sách nghề nghiệp:", err);
    toast.error("Không tải được danh sách nghề nghiệp!");
  }
};

const loadChuyenNganh = async () => {
  try {
    const res = await api.get("/Admin/chuyen-nganh");
    chuyenNganhs.value = res.data?.duLieu ?? res.data ?? [];
  } catch (err) {
    console.error("Lỗi tải danh sách chuyên ngành:", err);
    toast.error("Không tải được danh sách chuyên ngành!");
  }
};

const loadKinhNghiem = async () => {
  try {
    const res = await api.get("/Admin/muc-kinh-nghiem");
    kinhNghiemList.value = res.data?.duLieu ?? res.data ?? [];
  } catch (err) {
    console.error("Lỗi tải mức kinh nghiệm:", err);
  }
};

// ====== API: Load ngành theo lĩnh vực ======
const loadNgheByLinhVuc = async (linhVucId) => {
  if (!linhVucId) {
    await loadNgheNghiep(); // reset → tải tất cả
    return;
  }

  try {
    const res = await api.get(`/Admin/linh-vuc/${linhVucId}/nghe-nghiep`);
    ngheNghieps.value = res.data;
  } catch (err) {
    console.error("Lỗi tải nghề theo lĩnh vực:", err);
  }
};

// ====== API: Load chuyên ngành theo nghề ======
const loadChuyenNganhByNghe = async (ngheId) => {
  if (!ngheId) {
    await loadChuyenNganh(); // reset → tải tất cả
    return;
  }

  try {
    const res = await api.get(`/Admin/nghe-nghiep/${ngheId}/chuyen-nganh`);
    chuyenNganhs.value = res.data;
  } catch (err) {
    console.error("Lỗi tải chuyên ngành theo nghề:", err);
  }
};

const loadLoaiCongViec = async () => {
  try {
    const res = await api.get("/Admin/loai-cong-viec");
    jobTypes.value = res.data?.duLieu ?? res.data ?? [];
  } catch (err) {
    console.error("Lỗi tải loại công việc:", err);
  }
};

const selectJobType = (id) => {
  selectedJobType.value = selectedJobType.value === id ? "" : id;
  onChangeFilter();
};

const normalize = (str) =>
  (str || "")
    .normalize("NFD")
    .replace(/[\u0300-\u036f]/g, "")
    .toLowerCase();

const filteredTinhThanhs = computed(() => {
  const text = normalize(locationSearch.value);
  if (!text) return tinhThanhs.value;
  return tinhThanhs.value.filter((t) =>
    normalize(t.tenTinh).includes(text)
  );
});

// label hiển thị trên nút "Địa điểm"
const locationLabel = computed(() => {
  if (!selectedProvinces.value.length) return "Tất cả địa điểm";

  if (selectedProvinces.value.length === 1) {
    const t = tinhThanhs.value.find(
      (tt) => String(tt.id) === String(selectedProvinces.value[0])
    );
    return t ? t.tenTinh : "1 địa điểm đã chọn";
  }

  return `${selectedProvinces.value.length} địa điểm đã chọn`;
});

// 🔹 Bộ lọc tổng (chỉ chạy khi KHÔNG search API)
const filteredJobs = computed(() => {
  return jobs.value.filter((j) => {
    const text = normalize(keyword.value);

    const matchText =
      normalize(j.tieuDe).includes(text) ||
      normalize(j.tenCongTy || "").includes(text) ||
      normalize(j.moTaCongViec || "").includes(text) ||
      normalize(j.yeuCauUngVien || "").includes(text) ||
      normalize(j.chuyenNganhs?.map(cn => cn.ten).join(" ") || "").includes(text) ||
      normalize(j.nganhNghieps?.map(n => n.ten).join(" ") || "").includes(text);

    const matchField = selectedField.value
      ? j.linhVucs?.some(lv => String(lv.id) === String(selectedField.value))
      : true;

    let matchLocation = true;
    if (selectedProvinces.value.length) {
      const selectedNames = selectedProvinces.value
        .map(id => {
          const t = tinhThanhs.value.find(tt => String(tt.id) === String(id));
          return t ? normalize(t.tenTinh) : null;
        })
        .filter(Boolean);

      matchLocation = j.khuVucLamViec?.some(loc =>
        selectedNames.some(x => normalize(loc).includes(x))
      );
    }

    let matchSalary = true;
    if (selectedSalary.value && j.kieuLuong?.toLowerCase() !== "thoathuan") {
      const from = j.luongTu || 0;
      const to = j.luongDen || from;
      switch (selectedSalary.value) {
        case "duoi3": matchSalary = to < 3000000; break;
        case "3to7": matchSalary = from >= 3000000 && to <= 7000000; break;
        case "7to10": matchSalary = from >= 7000000 && to <= 10000000; break;
        case "10to15": matchSalary = from >= 10000000 && to <= 15000000; break;
        case "tren15": matchSalary = from > 15000000; break;
      }
    }

    const matchNghe = selectedNghe.value
      ? j.nganhNghieps?.some(ng => String(ng.id) === String(selectedNghe.value))
      : true;

    const matchChuyenNganh = selectedChuyenNganh.value
      ? j.chuyenNganhs?.includes(
          chuyenNganhs.value.find(c => c.id === selectedChuyenNganh.value)?.tenChuyenNganh
        )
      : true;

    const matchJobType = selectedJobType.value
      ? String(j.loaiCongViecId) === String(selectedJobType.value)
      : true;

    const matchExperience = selectedExperience.value
      ? String(j.mucKinhNghiemId) === String(selectedExperience.value)
      : true;

    return (
      matchText &&
      matchField &&
      matchLocation &&
      matchSalary &&
      matchJobType &&
      matchNghe &&
      matchChuyenNganh &&
      matchExperience
    );
  });
});

const goToDetail = (id) => {
  router.push(`/viec-lam/${id}`);
};

const dataToShow = computed(() => {
  let source = allJobs.value;

  // 🔍 TỪ KHÓA
  if (keyword.value) {
    const k = normalize(keyword.value);
    source = source.filter(j =>
      normalize(j.tieuDe).includes(k) ||
      normalize(j.tenCongTy).includes(k)
    );
  }

  // 🧩 LĨNH VỰC
  if (selectedField.value) {
    source = source.filter(j =>
      j.linhVucs?.some(lv => lv.id === selectedField.value)
    );
  }

  // 🧩 NGÀNH NGHỀ
  if (selectedNghe.value) {
    source = source.filter(j =>
      j.nganhNghieps?.some(n => n.id === selectedNghe.value)
    );
  }

  // 🧩 CHUYÊN NGÀNH
  if (selectedChuyenNganh.value) {
    source = source.filter(j =>
      j.chuyenNganhs?.some(cn => cn.id === selectedChuyenNganh.value)
    );
  }

  // 💼 KINH NGHIỆM
  if (selectedExperience.value) {
    source = source.filter(j =>
      j.mucKinhNghiemId === selectedExperience.value
    );
  }

  // 🗺️ LỌC TỈNH / KHU VỰC LÀM VIỆC
if (selectedProvinces.value.length) {
  const selectedNames = selectedProvinces.value
    .map(id => {
      const t = tinhThanhs.value.find(
        tt => Number(tt.id) === Number(id)
      );
      return t ? normalize(t.tenTinh) : null;
    })
    .filter(Boolean);

  source = source.filter(j =>
    Array.isArray(j.khuVucLamViec) &&
    j.khuVucLamViec.some(loc =>
      selectedNames.some(tinh =>
        normalize(loc).includes(tinh)
      )
    )
  );
}


  // 💰 MỨC LƯƠNG (theo bucket của em)
  if (selectedSalary.value) {
    source = source.filter(j => {
      const to = j.luongDen ?? 0;
      switch (selectedSalary.value) {
        case "duoi3": return to < 3_000_000;
        case "3to7": return to >= 3_000_000 && to < 7_000_000;
        case "7to10": return to >= 7_000_000 && to < 10_000_000;
        case "10to15": return to >= 10_000_000 && to < 15_000_000;
        case "tren15": return to >= 15_000_000;
        default: return true;
      }
    });
  }

  return source;
});


const totalPages = computed(() =>
  Math.ceil(dataToShow.value.length / pageSize)
);

// 🔹 Phân trang
const paginatedJobs = computed(() => {
  const start = (currentPage.value - 1) * pageSize;
  return dataToShow.value.slice(start, start + pageSize);
});

const nextPage = () => {
  if (currentPage.value < totalPages.value) currentPage.value++;
};
const prevPage = () => {
  if (currentPage.value > 1) currentPage.value--;
};

const filterJobs = () => {
  currentPage.value = 1;
};

// ✅ Định dạng ngày
const formatDate = (dateStr) => {
  if (!dateStr) return "—";
  return new Date(dateStr).toLocaleDateString("vi-VN");
};

// ⚠️ Cảnh báo đăng nhập
const showLoginWarning = () => {
  if (!auth.isAuthenticated) {
    toast.warning("⚠️ Vui lòng đăng nhập để ứng tuyển công việc này!");
  } else if (auth.user?.vaiTro !== "SinhVien") {
    toast.error("❌ Chỉ tài khoản Sinh viên mới có thể ứng tuyển công việc!");
  }
};

const fetchTinhThanhs = async () => {
  try {
    const res = await api.get("/DiaChi/tinh-thanh");
    tinhThanhs.value = res.data?.duLieu ?? res.data ?? [];
  } catch (err) {
    console.error("Lỗi tải tỉnh/thành:", err);
  }
};

// 🎉 Ứng tuyển thành công
const applySuccess = (title) => {
  toast.success(`🎉 Bạn đã ứng tuyển công việc "${title}" thành công!`);
};

// ❤️ Lưu / Bỏ lưu công việc
const toggleSave = (job) => {
  const index = savedJobs.value.indexOf(job.id);
  if (index === -1) {
    savedJobs.value.push(job.id);
    toast.success(`💖 Đã lưu công việc "${job.tieuDe}"`);
  } else {
    savedJobs.value.splice(index, 1);
    toast.info(`🗑️ Đã bỏ lưu công việc "${job.tieuDe}"`);
  }
  localStorage.setItem("savedJobs", JSON.stringify(savedJobs.value));
};

// Kiểm tra công việc đã lưu chưa
const isSaved = (id) => savedJobs.value.includes(id);

onMounted(async () => {
  await Promise.all([
    fetchJobs(),
    fetchLinhVucs(),
    fetchTinhThanhs(),
    loadNgheNghiep(),
    loadChuyenNganh(),
    loadKinhNghiem(),
    loadLoaiCongViec(),
  ]);
  applyRouteFilters();
  window.scrollTo({ top: 0, behavior: "smooth" });
});

const applyRouteFilters = () => {
  
  // ----- Keyword -----
  if (route.query.keyword) {
    keyword.value = route.query.keyword;
    
  }

  // ----- Lĩnh vực -----
  if (route.query.linhVucId) {
    selectedField.value = Number(route.query.linhVucId);
  }

  // ----- Nghề -----
  if (route.query.ngheId) {
    selectedNghe.value = Number(route.query.ngheId);
  }

  // ----- Chuyên ngành -----
  if (route.query.chuyenNganhId) {
    selectedChuyenNganh.value = Number(route.query.chuyenNganhId);
  }

  // ⭐ Gọi API tìm kiếm duy nhất ⭐
  timKiemCongViec();

  // Cập nhật phân trang
  filterJobs();
};

const resetFilters = () => {
  keyword.value = "";
  selectedField.value = "";
  selectedNghe.value = "";
  selectedChuyenNganh.value = "";
  selectedSalary.value = "";
  selectedJobType.value = "";
  selectedProvinces.value = [];
  locationSearch.value = "";
  selectedExperience.value = "";
  
  // Tải lại ALL nghề & chuyên ngành (vì reset lĩnh vực)
  loadNgheNghiep();
  loadChuyenNganh();

  timKiemCongViec();// chạy lại filter
  
};

const formatMoney = (value) => {
  if (!value || value === 0) return null;
  return (value / 1_000_000).toLocaleString("vi-VN", {
    minimumFractionDigits: 0,
    maximumFractionDigits: 0
  }) + " triệu";
};

const formatSalary = (job) => {
  if (job.kieuLuong?.toLowerCase() === "thoathuan") {
    return "Thoả thuận";
  }

  const from = job.luongTu || 0;
  const to = job.luongDen || 0;

  if (from && to) return `${formatMoney(from)} - ${formatMoney(to)}`;
  if (from && !to) return `Từ ${formatMoney(from)}`;
  if (!from && to) return `Đến ${formatMoney(to)}`;

  return "Không có";
};

const formatDiaDiem = (locations) => {
  if (!locations || locations.length === 0) return "Không rõ";

  // Rút gọn "Thành phố Hà Nội" → "Hà Nội"
  const cleaned = locations.map(loc => loc.replace("Thành phố ", ""));

  if (cleaned.length === 1) return cleaned[0];

  return `${cleaned[0]} +${cleaned.length - 1} nơi khác`;
};
const formatPostedDate = (dateStr) => {
  if (!dateStr) return "Không rõ";

  const date = new Date(dateStr);
  const now = new Date();

  const diffMs = now - date;
  const diffDays = Math.floor(diffMs / (1000 * 60 * 60 * 24));

  if (diffDays === 0) return "Hôm nay";
  if (diffDays === 1) return "Hôm qua";
  if (diffDays < 7) return `${diffDays} ngày trước`;
  if (diffDays < 30) return `${Math.floor(diffDays / 7)} tuần trước`;

  return date.toLocaleDateString("vi-VN");
};

const timKiemCongViec = async () => {
  try {
    loading.value = true;

    const payload = {
      keyword: keyword.value?.trim() || null,
      linhVucId: selectedField.value ? Number(selectedField.value) : null,
      ngheNghiepId: selectedNghe.value ? Number(selectedNghe.value) : null,
      chuyenNganhIds: selectedChuyenNganh.value ? [Number(selectedChuyenNganh.value)] : [],
    };

    const res = await api.post("/TuKhoa/tim-kiem-cong-viec", payload);

    // Response backend của bạn trả ra list job (id, tieuDe, tenCongTy, logoUrl, luongTu/luongDen, ngayDang,...)
    jobs.value = res.data ?? [];
    currentPage.value = 1;
    isApiSearch.value = true;
  } catch (err) {
    console.error("Lỗi tìm kiếm công việc:", err);
    toast.error("Không tìm kiếm được công việc!");
  } finally {
    loading.value = false;
  }
};

let _timer = null;
const onChangeFilter = () => {
  currentPage.value = 1;
  // clearTimeout(_timer);
  // _timer = setTimeout(() => {
  //   timKiemCongViec();
  // }, 300);
};
watch(selectedField, async (linhVucId) => {
  selectedNghe.value = "";
  selectedChuyenNganh.value = "";

  if (linhVucId) {
    await loadNgheByLinhVuc(linhVucId);
  } else {
    ngheNghieps.value = [];
  }

  // Gọi API tìm kiếm lại
  onChangeFilter();
});

</script>

<style scoped>

.neumorph {
  background: bg-white;
  box-shadow: 8px 8px 20px #cdd0d7, 
              -8px -8px 20px #ffffff;
  border-radius: 24px;
}

.icon-box {
  @apply w-12 h-12 flex items-center justify-center 
         rounded-2xl bg-indigo-100 shadow-inner;
}

.filter-title {
  @apply text-sm font-semibold text-gray-700 mb-1 flex items-center gap-2;
}

.filter-block {
  @apply space-y-2;
}

.divider {
  @apply h-px bg-gray-300 my-4;
}

.filter-input {
  @apply w-full px-4 py-2.5 rounded-xl border shadow-sm
         bg-white text-gray-700
         focus:ring-2 focus:ring-indigo-500 focus:border-indigo-500
         transition;
}

.location-dropdown {
  @apply absolute left-0 w-64 mt-2 p-4 rounded-2xl border shadow-xl bg-white;
}

.location-item {
  @apply flex items-center gap-2 px-2 py-1 text-sm cursor-pointer 
         rounded-lg hover:bg-gray-50;
}

.reset-btn {
  @apply w-full py-3 mt-4 rounded-xl bg-indigo-50 text-indigo-600
         font-semibold text-center shadow-sm
         hover:bg-indigo-100 transition;
}

.job-card {
  @apply bg-white border rounded-3xl p-6 shadow-sm
         transition-all cursor-pointer
         hover:shadow-xl hover:border-indigo-300;
}

.job-tag {
  @apply text-xs px-3 py-1 rounded-full font-medium
         bg-gray-100 text-gray-700;
}

.job-type {
  @apply bg-indigo-50 text-indigo-600;
}

.posted-badge {
  @apply inline-block mt-3 px-2 py-1 rounded-md
         text-[11px] text-gray-500 bg-gray-50;
}

.apply-btn {
  @apply px-5 py-2.5 bg-indigo-600 text-white rounded-xl shadow
         font-medium text-sm
         hover:bg-indigo-700 transition;
}

.job-type-pill {
  @apply flex items-center gap-2 px-4 py-2 text-sm rounded-xl border
         bg-white text-gray-700 shadow-sm cursor-pointer
         hover:bg-indigo-50 hover:border-indigo-300 hover:text-indigo-600
         transition select-none;
}

.job-type-active {
  @apply bg-indigo-600 text-white border-indigo-600 shadow-md
         hover:bg-indigo-700 hover:border-indigo-700;
}

.page-btn-new {
  @apply w-10 h-10 rounded-xl border shadow-sm flex items-center justify-center
         bg-white text-gray-600
         hover:bg-indigo-50 hover:text-indigo-600
         transition disabled:opacity-40 disabled:hover:bg-white;
}

.page-number {
  @apply w-10 h-10 rounded-xl border shadow-sm flex items-center justify-center
         bg-white text-gray-700 cursor-pointer select-none
         hover:bg-indigo-50 hover:border-indigo-300 hover:text-indigo-600
         transition;
}

.active-page {
  @apply bg-indigo-600 border-indigo-600 text-white shadow-lg
         hover:bg-indigo-700 hover:border-indigo-700;
}

.job-loading {
  @apply h-24 bg-white border rounded-2xl shadow animate-pulse;
}
.shadow-sm\/50 {
  box-shadow: 0 2px 8px rgba(0,0,0,0.06);
}

</style>
