<template>
  <div class="min-h-screen bg-gradient-to-b from-indigo-50 to-white font-[Inter]">

    <!-- HERO HEADER -->
    <section class="bg-white border-b">
      <div class="max-w-7xl mx-auto px-6 py-10">
        <div class="flex flex-col md:flex-row md:items-center md:justify-between gap-6">
          <div>
            <h1 class="text-3xl font-extrabold text-gray-800">
              🏢 Doanh nghiệp tuyển dụng
            </h1>
            <p class="text-gray-500 mt-2">
              Kết nối sinh viên BVU với hơn <b>50+ doanh nghiệp uy tín</b>
            </p>
          </div>

          <div class="hidden md:block">
            <span class="px-4 py-2 rounded-full bg-indigo-100 text-indigo-700 text-sm font-medium">
              🚀 Cập nhật liên tục
            </span>
          </div>
        </div>
      </div>
    </section>

    <!-- FILTER CARD -->
    <section class="sticky top-0 z-20 bg-white/80 backdrop-blur border-b">
      <div class="max-w-7xl mx-auto px-6 py-5">
        <div class="grid md:grid-cols-4 gap-4 items-center">

          <!-- SEARCH -->
          <div class="md:col-span-2 relative">
            <input
              v-model="search"
              @input="filterList"
              placeholder="🔍 Tìm theo tên công ty..."
              class="w-full px-4 py-3 rounded-xl bg-gray-100
                     focus:bg-white border focus:ring-2 focus:ring-indigo-500 transition"
            />
          </div>

          <!-- SORT -->
          <select
            v-model="sortBy"
            class="px-4 py-3 rounded-xl bg-gray-100 border
                   focus:ring-2 focus:ring-indigo-500"
          >
            <option value="name">🔤 Tên A → Z</option>
            <option value="jobs">💼 Nhiều việc tuyển</option>
          </select>

          <!-- TỈNH -->
          <div class="relative">
            <button
              @click="showTinhDropdown = !showTinhDropdown"
              class="w-full px-4 py-3 bg-gray-100 rounded-xl border
                     flex justify-between items-center hover:bg-white"
            >
              <span class="truncate">
                {{ selectedTinhThanh
                  ? tinhThanhs.find(t => t.id === selectedTinhThanh)?.tenTinh
                  : "📍 Tất cả tỉnh thành" }}
              </span>
              <i class="fa-solid fa-chevron-down text-xs"></i>
            </button>

            <transition name="fade">
              <div
                v-if="showTinhDropdown"
                class="absolute mt-2 w-full bg-white border rounded-2xl shadow-xl p-3 z-30"
              >
                <input
                  v-model="tinhSearch"
                  placeholder="Tìm tỉnh..."
                  class="w-full px-3 py-2 mb-2 rounded-lg border bg-gray-50"
                />

                <div class="max-h-56 overflow-y-auto text-sm">
                  <div
                    @click="selectTinh(null)"
                    class="px-3 py-2 rounded-lg hover:bg-indigo-50 cursor-pointer"
                  >
                    🌍 Tất cả tỉnh
                  </div>

                  <div
                    v-for="t in filteredTinhThanhs"
                    :key="t.id"
                    @click="selectTinh(t.id)"
                    class="px-3 py-2 rounded-lg hover:bg-indigo-50 cursor-pointer"
                  >
                    {{ t.tenTinh }}
                  </div>
                </div>
              </div>
            </transition>
          </div>
        </div>
      </div>
    </section>

    <!-- CONTENT -->
    <section class="max-w-7xl mx-auto px-6 py-10">

      <!-- LOADING -->
      <div v-if="loading" class="grid sm:grid-cols-2 lg:grid-cols-3 gap-6">
        <div v-for="n in 6" :key="n" class="company-skeleton"></div>
      </div>

      <!-- EMPTY -->
      <div
        v-else-if="filteredCompanies.length === 0"
        class="py-20 text-center text-gray-500 text-lg"
      >
        😥 Không tìm thấy công ty phù hợp
      </div>

      <!-- COMPANY GRID -->
      <div v-else class="grid sm:grid-cols-2 lg:grid-cols-3 gap-6">
        <div
          v-for="ct in pagedCompanies"
          :key="ct.id"
          @click="goToDetail(ct.id)"
          class="company-card cursor-pointer"
        >
          <div class="flex items-center gap-4 mb-4">
            <div class="w-14 h-14 rounded-xl bg-gray-100 overflow-hidden flex items-center justify-center">
              <img
                v-if="ct.logoUrl"
                :src="formatLogo(ct.logoUrl)"
                class="w-full h-full object-cover"
              />
              <i v-else class="fa-solid fa-building text-gray-400 text-xl"></i>
            </div>

            <div>
              <h3 class="font-bold text-gray-800 leading-tight">
                {{ ct.tenCongTy }}
              </h3>
              <p class="text-sm text-gray-500">
                📍 {{ ct.tenTinhThanh || "Chưa cập nhật" }}
              </p>
            </div>
          </div>

          <div class="flex justify-between items-center text-sm">
            <span class="text-indigo-600 font-medium">
              💼 {{ ct.soLuongCongViec }} việc làm
            </span>
            <span class="text-gray-400 text-xs">Xem chi tiết →</span>
          </div>
        </div>
      </div>

      <!-- PAGINATION -->
      <div
        v-if="totalPages > 1"
        class="flex justify-center gap-2 mt-10"
      >
        <button
          @click="currentPage--"
          :disabled="currentPage === 1"
          class="px-3 py-2 rounded-lg border text-sm disabled:opacity-40"
        >
          ◀
        </button>

        <button
          v-for="p in totalPages"
          :key="p"
          @click="currentPage = p"
          :class="[
            'px-3 py-2 rounded-lg border text-sm',
            p === currentPage
              ? 'bg-indigo-600 text-white'
              : 'hover:bg-gray-100'
          ]"
        >
          {{ p }}
        </button>

        <button
          @click="currentPage++"
          :disabled="currentPage === totalPages"
          class="px-3 py-2 rounded-lg border text-sm disabled:opacity-40"
        >
          ▶
        </button>
      </div>
    </section>
  </div>
</template>


<script setup>
import { ref, onMounted, computed } from "vue";
import api from "@/api/axios";
import { useRouter, useRoute } from "vue-router";

const router = useRouter();
const route = useRoute();

const companies = ref([]);
const search = ref("");
const isSearching = ref(false);
const loading = ref(true);

const tinhThanhs = ref([]);
const selectedTinhThanh = ref(null);
const showTinhDropdown = ref(false);
const tinhSearch = ref("");

const currentPage = ref(1);
const pageSize = ref(12);

const sortBy = ref("name");

const fetchCompanies = async () => {
  try {
    const res = await api.get("/Admin/cong-ty");
    companies.value = res.data ?? [];
  } catch (err) {
    console.error("Lỗi tải công ty:", err);
  } finally {
    loading.value = false;
  }
};

const normalize = (str) =>
  (str || "")
    .normalize("NFD")
    .replace(/[\u0300-\u036f]/g, "")
    .toLowerCase();
    
const filteredCompanies = computed(() => {
  let result = [...companies.value];

  if (search.value) {
    const key = normalize(search.value);
    result = result.filter(ct =>
      normalize(ct.tenCongTy).includes(key)
    );
  }

  if (sortBy.value === "name") {
    result.sort((a, b) =>
      a.tenCongTy.localeCompare(b.tenCongTy, "vi", { sensitivity: "base" })
    );
  }

  if (sortBy.value === "jobs") {
    result.sort((a, b) =>
      (b.soLuongCongViec || 0) - (a.soLuongCongViec || 0)
    );
  }

  return result;
});



const filterList = () => {
  clearTimeout(_timer);

  _timer = setTimeout(() => {
    currentPage.value = 1;

    if (!search.value && !selectedTinhThanh.value) {
      isSearching.value = false;
      fetchCompanies();
    } else {
      searchCompanies();
    }
  }, 400);
};




const goToDetail = (id) => {
  router.push(`/cong-ty/${id}`);
};

const formatLogo = (path) => {
  return path.startsWith("http")
    ? path
    : `https://localhost:7248${path}`;
};
let _timer = null;

const searchCompanies = async () => {
  loading.value = true;
  isSearching.value = true;

  try {
    const payload = {
      keyword: search.value || null,
      tinhThanhId: selectedTinhThanh.value || null,
      quyMoNhanSu: null,
      namThanhLapTu: null,
      namThanhLapDen: null,
      linhVucId: null
    };

    const res = await api.post("/TuKhoa/tim-kiem-cong-ty", payload);
    companies.value = res.data ?? [];
  } catch (err) {
    console.error("Lỗi tìm kiếm công ty:", err);
    companies.value = [];
  } finally {
    loading.value = false;
  }
};

const filteredTinhThanhs = computed(() => {
  const key = normalize(tinhSearch.value);
  if (!key) return tinhThanhs.value;
  return tinhThanhs.value.filter(t =>
    normalize(t.tenTinh).includes(key)
  );
});
const selectTinh = (id) => {
  selectedTinhThanh.value = id;
  showTinhDropdown.value = false;
  filterList();
};
const fetchTinhThanhs = async () => {
  try {
    const res = await api.get("DiaChi/Tinh-Thanh"); // ✅ API đúng
    tinhThanhs.value = res.data ?? [];
    console.log("✅ Danh sách tỉnh:", tinhThanhs.value);
  } catch (err) {
    console.error("❌ Lỗi tải tỉnh thành:", err);
  }
};

onMounted(async () => {
  await fetchTinhThanhs();

  const keywordFromUrl = route.query.keyword;

  if (keywordFromUrl) {
    search.value = keywordFromUrl;
    currentPage.value = 1;
    await searchCompanies();
  } else {
    await fetchCompanies();
  }
});


const totalPages = computed(() => {
  return Math.ceil(filteredCompanies.value.length / pageSize.value);
});

const pagedCompanies = computed(() => {
  const start = (currentPage.value - 1) * pageSize.value;
  const end = start + pageSize.value;
  return filteredCompanies.value.slice(start, end);
});

import { watch } from "vue";

watch(
  () => route.query.keyword,
  (newKeyword) => {
    if (newKeyword) {
      search.value = newKeyword;
      currentPage.value = 1;
      searchCompanies();
    }
  }
);


</script>

<style scoped>
.company-card {
  @apply bg-white p-5 rounded-2xl border shadow-sm
         hover:shadow-xl hover:-translate-y-1
         transition-all duration-300;
}

.company-skeleton {
  @apply h-40 bg-white rounded-2xl border animate-pulse;
}

</style>

