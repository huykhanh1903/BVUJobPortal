<template>
  <div class="flex flex-col min-h-screen bg-gray-50">
    <nav v-if="!hideLayout" class="bg-white shadow-md fixed top-0 left-0 right-0 z-50">
      <div class="max-w-7xl mx-auto px-4 sm:px-6 lg:px-8">
        <div class="flex justify-between items-center h-16">
          <div class="flex items-center space-x-3">
            <img src="/logo-bvu.png" alt="BVU Logo" class="h-12 w-10" />
            <router-link
              to="/"
              class="text-lg sm:text-xl font-bold text-blue-700 hover:text-blue-800 transition"
            >
              BVU Job Portal
            </router-link>
          </div>

          <!-- Menu PC -->
          <div class="hidden md:flex items-center space-x-6 text-gray-700">
            <router-link to="/" class="hover:text-blue-700 transition">
              Trang chủ
            </router-link>

            <!-- ======================= SINH VIÊN ======================= -->
            <template v-if="auth.user?.vaiTro === 'SinhVien'">
              <router-link
                to="/viec-lam"
                class="hover:text-blue-700"
                @click="mobileOpen = false"
              >
                📋 Danh sách công việc
              </router-link>
              <router-link
                to="/cong-ty"
                class="hover:text-blue-700"
              >
                🏢 Danh sách công ty
              </router-link>
            </template>

            <!-- ======================= NHÀ TUYỂN DỤNG ======================= -->
            <template v-if="auth.user?.vaiTro === 'NhaTuyenDung'">
              <router-link
                to="/nha-tuyen-dung/tin-tuyen-dung"
                class="hover:text-blue-700 transition"
              >
                📂 Tin đã đăng
              </router-link>

              <router-link
                to="/nha-tuyen-dung/don-ung-tuyen"
                class="hover:text-blue-700 transition"
              >
                📨 Đơn ứng tuyển
              </router-link>

              <router-link
                to="/nha-tuyen-dung/dang-tin"
                class="text-blue-700 font-semibold hover:text-blue-800 transition"
              >
                📢 Đăng tin
              </router-link>
              <router-link
                :to="{ name: 'NTD_TimUngVien' }"
                class="menu-link"
              >
                🔍 Tìm ứng viên
              </router-link>
            </template>

            <!-- ======================= DOANH NGHIỆP ======================= -->
            <template v-if="auth.user?.vaiTro === 'DoanhNghiep'">
              <router-link
                to="/doanh-nghiep/nhan-su"
                class="hover:text-blue-700 transition"
              >
                👥 Quản lý nhân sự
              </router-link>

              <router-link
                :to="`/cong-ty/${auth.user?.congTyId}`"
                class="hover:text-blue-700 transition"
              >
                🏢 Hồ sơ công ty
              </router-link>
              <router-link
                to="/doanh-nghiep/viec-lam"
                class="hover:text-blue-700 transition"
              >
                💼 Danh sách công việc
              </router-link>

            </template>

            <!-- ======================= CHƯA ĐĂNG NHẬP ======================= -->
            <template v-if="!auth.isAuthenticated">
              <router-link
                to="/dang-nhap"
                class="px-4 py-2 rounded-lg bg-blue-600 text-white font-semibold hover:bg-blue-700 transition"
              >
                Đăng nhập
              </router-link>
              <router-link
                to="/dang-ky"
                class="px-4 py-2 rounded-lg bg-green-600 text-white font-semibold hover:bg-green-700 transition"
              >
                Đăng ký
              </router-link>
            </template>

            
            <!-- ======================= AVATAR / DROPDOWN ======================= -->
            <template v-else>
              <div class="relative">
                <img
                  :src="auth.user?.avatarUrl ? getAvatarUrl(auth.user.avatarUrl) : '/default-avatar.png'"
                  alt="User Avatar"
                  class="h-10 w-10 rounded-full border cursor-pointer object-cover"
                  @click="toggleMenu"
                />

                <!-- Dropdown -->
                <transition
                  enter-active-class="transition duration-200 ease-out"
                  enter-from-class="opacity-0 translate-y-1"
                  enter-to-class="opacity-100 translate-y-0"
                  leave-active-class="transition duration-150 ease-in"
                  leave-from-class="opacity-100 translate-y-0"
                  leave-to-class="opacity-0 translate-y-1"
                >
                  <div
                    v-if="menuOpen"
                    class="absolute right-0 mt-2 w-60 bg-white shadow-lg rounded-lg border z-50 overflow-hidden"
                  >
                    <!-- Header -->
                    <div class="flex items-center gap-3 px-4 py-3 border-b bg-gray-50">
                      <img
                        :src="auth.user?.avatarUrl ? getAvatarUrl(auth.user.avatarUrl) : '/default-avatar.png'"
                        class="h-10 w-10 rounded-full border object-cover"
                      />
                      <div>
                        <p class="text-xs text-gray-500">Xin chào,</p>
                        <p class="font-semibold text-gray-800">{{ auth.user?.hoTen }}</p>
                      </div>
                    </div>

                    <!-- Hồ sơ cá nhân -->
                    <router-link
                      v-if="['SinhVien', 'NhaTuyenDung', 'DoanhNghiep'].includes(auth.user?.vaiTro)"
                      to="/hoso"
                      class="block px-4 py-2 hover:bg-gray-100 text-gray-700"
                      @click="menuOpen = false"
                    >
                      Hồ sơ cá nhân
                    </router-link>

                    <router-link
                      v-if="auth.user?.vaiTro === 'DoanhNghiep'"
                      to="/doanh-nghiep/nhan-su"
                      class="block px-4 py-2 hover:bg-gray-100 text-gray-700"
                      @click="menuOpen = false"
                    >
                      Quản lý nhân sự
                    </router-link>

                    <router-link
                      v-if="auth.user?.vaiTro === 'SinhVien'"
                      to="/lich-su-ung-tuyen"
                      class="block px-4 py-2 hover:bg-gray-100 text-gray-700"
                      @click="menuOpen = false"
                    >
                      👥 Lịch sử ứng tuyển
                    </router-link>
                    <router-link
                      v-if="auth.user?.vaiTro === 'DoanhNghiep'"
                      :to="`/cong-ty/${auth.user?.congTyId}`"
                      class="block px-4 py-2 hover:bg-gray-100 text-gray-700"
                      @click="menuOpen = false"
                    >
                      Hồ sơ công ty
                    </router-link>

                    <!-- Logout -->
                    <button
                      @click="logout"
                      class="w-full text-left px-4 py-2 hover:bg-gray-100 text-red-600 font-medium"
                    >
                      Đăng xuất
                    </button>
                  </div>
                </transition>
              </div>
              <!-- 🔔 THÔNG BÁO -->
              <div class="relative" v-if="auth.isAuthenticated">
                <button
                  @click="toggleThongBao"
                  class="relative p-2 hover:bg-gray-100 rounded-full"
                >
                  <i class="fa-solid fa-bell text-xl"></i>

                  <!-- Badge -->
                  <span
                    v-if="soThongBaoChuaDoc > 0"
                    class="absolute -top-1 -right-1 bg-red-500 text-white text-xs
                          w-5 h-5 rounded-full flex items-center justify-center"
                  >
                    {{ soThongBaoChuaDoc }}
                  </span>
                </button>
                <!-- Dropdown -->
                <div
                  v-if="showThongBao"
                  class="absolute right-0 mt-2 w-96 bg-white border rounded-xl shadow-lg z-50"
                >
                  <!-- Header -->
                  <div class="px-4 py-3 font-semibold border-b">
                    🔔 Thông báo
                  </div>

                  <!-- DANH SÁCH THÔNG BÁO (SCROLL Ở ĐÂY) -->
                  <div class="max-h-80 overflow-y-auto scrollbar-thin scrollbar-thumb-gray-300">

                    <div
                      v-if="thongBaos.length === 0"
                      class="p-4 text-gray-500 text-sm"
                    >
                      Không có thông báo nào
                    </div>

                    <div
                      v-for="tb in thongBaos"
                      :key="tb.id"
                      @click="openThongBao(tb)"
                      class="px-4 py-3 text-sm cursor-pointer hover:bg-gray-50 border-b"
                      :class="!tb.daDoc ? 'bg-indigo-50' : ''"
                    >
                      <p class="font-semibold">{{ tb.tieuDe }}</p>
                      <p class="text-gray-600 text-xs mt-1 line-clamp-2">
                        {{ tb.noiDung }}
                      </p>
                    </div>
                  </div>
                </div>
              </div>
            </template>
          </div>

          <button
            class="md:hidden p-2 text-gray-700 hover:text-blue-700 focus:outline-none"
            @click="mobileOpen = !mobileOpen"
          >
            <i class="fas" :class="mobileOpen ? 'fa-times' : 'fa-bars'"></i>
          </button>
        </div>
      </div>

      <!-- ======================= MOBILE MENU ======================= -->
      <transition
        enter-active-class="transition duration-300 ease-out"
        enter-from-class="opacity-0 -translate-y-4"
        enter-to-class="opacity-100 translate-y-0"
        leave-active-class="transition duration-200 ease-in"
        leave-from-class="opacity-100 translate-y-0"
        leave-to-class="opacity-0 -translate-y-4"
      >
        <div v-if="mobileOpen" class="md:hidden bg-white border-t border-gray-200 shadow-lg">
          <div class="px-6 py-4 flex flex-col space-y-3 text-gray-700">

            <!-- Home -->
            <router-link to="/" class="hover:text-blue-700">
              🏠 Trang chủ
            </router-link>

            <!-- Sinh viên -->
            <router-link
              v-if="auth.user?.vaiTro === 'SinhVien'"
              to="/cv"
              class="hover:text-blue-700"
              @click="mobileOpen = false"
            >
              📄 CV của tôi
            </router-link>
            <router-link
              v-if="auth.user?.vaiTro === 'SinhVien'"
              to="/viec-lam"
              class="hover:text-blue-700"
              @click="mobileOpen = false"
            >
              📋 Danh sách công việc
            </router-link>
            <router-link
              v-if="auth.user?.vaiTro === 'SinhVien'"
              to="/cong-ty"
              class="hover:text-blue-700"
            >
              🏢 Danh sách công ty
            </router-link>

            <!-- Nhà tuyển dụng -->
            <template v-if="auth.user?.vaiTro === 'NhaTuyenDung'">
              <router-link
                to="/nha-tuyen-dung/tin-tuyen-dung"
                class="hover:text-blue-700"
                @click="mobileOpen = false"
              >
                📂 Tin đã đăng
              </router-link>

              <router-link
                to="/nha-tuyen-dung/dang-tin"
                class="text-blue-700 font-semibold"
                @click="mobileOpen = false"
              >
                📢 Đăng tin tuyển dụng
              </router-link>
              <router-link
                to="/nha-tuyen-dung/don-ung-tuyen"
                class="hover:text-blue-700 transition"
              >
                📨 Đơn ứng tuyển
              </router-link>
            </template>

            <!-- DOANH NGHIỆP – FULL MOBILE MENU -->
            <template v-if="auth.user?.vaiTro === 'DoanhNghiep'">
              <router-link
                to="/doanh-nghiep/nhan-su"
                class="hover:text-blue-700"
                @click="mobileOpen = false"
              >
                👥 Quản lý nhân sự
              </router-link>
            </template>

            <!-- Chưa đăng nhập -->
            <template v-if="!auth.isAuthenticated">
              <router-link
                to="/dang-nhap"
                class="px-4 py-2 text-center bg-blue-600 text-white rounded-lg hover:bg-blue-700"
                @click="mobileOpen = false"
              >
                Đăng nhập
              </router-link>
              <router-link
                to="/dang-ky"
                class="px-4 py-2 text-center bg-green-600 text-white rounded-lg hover:bg-green-700"
                @click="mobileOpen = false"
              >
                Đăng ký
              </router-link>
            </template>

            <!-- Đăng xuất -->
            <template v-else>
              <button
                @click="logout"
                class="text-red-600 text-left hover:underline"
              >
                🚪 Đăng xuất
              </button>
            </template>
          </div>
        </div>
      </transition>
    </nav>

    <!-- Page Content -->
    <main :class="['flex-1', !hideLayout ? 'pt-16' : 'pt-0']">
      <router-view v-slot="{ Component }">
        <transition name="fade-slide" mode="out-in">
          <component :is="Component" />
        </transition>
      </router-view>
    </main>

    <!-- CHAT AI FLOATING WIDGET -->
    <ChatWidget v-if="!hideLayout" />

    <!-- Footer -->
    <footer
      v-if="!hideLayout"
      class="bg-blue-800 text-blue-100 pt-12 pb-6 mt-16"
    >
      <div
        class="max-w-7xl mx-auto grid grid-cols-1 sm:grid-cols-2 lg:grid-cols-4 gap-8 px-6"
      >
        <div>
          <h3 class="font-bold mb-4 text-white">Về JobBVU</h3>
          <ul class="space-y-2 text-sm">
            <li>
              <router-link to="/gioi-thieu" class="hover:underline">Giới thiệu</router-link>
            </li>
            <li>
              <router-link to="/lien-he" class="hover:underline">Liên hệ</router-link>
            </li>
            <li>
              <router-link to="/ho-tro" class="hover:underline">Hỗ trợ</router-link>
            </li>
            <li>
              <router-link to="/dieu-khoan" class="hover:underline">Điều khoản</router-link>
            </li>
          </ul>
        </div>

        <div>
          <h3 class="font-bold mb-4 text-white">Hồ sơ & CV</h3>
          <ul class="space-y-2 text-sm">
            <li><router-link to="/cv" class="hover:underline">Quản lý CV</router-link></li>
            <li><router-link to="/hoso" class="hover:underline">Hồ sơ cá nhân</router-link></li>
            <li><router-link to="/huong-dan-cv" class="hover:underline">Hướng dẫn CV</router-link></li>
            <li><router-link to="/review-cv" class="hover:underline">Đánh giá CV</router-link></li>
          </ul>
        </div>

        <div>
          <h3 class="font-bold mb-4 text-white">Liên hệ</h3>
          <p class="text-sm">🏫 70 Trương Công Định, Phường 3, TP. Vũng Tàu</p>
          <p class="text-sm">📞 1900 633 069</p>
          <p class="text-sm">📧 jobbvu@bvu.edu.vn</p>
          <div class="flex gap-4 mt-3 text-lg">
            <a href="#" class="hover:text-white"><i class="fab fa-facebook"></i></a>
            <a href="#" class="hover:text-white"><i class="fab fa-twitter"></i></a>
            <a href="#" class="hover:text-white"><i class="fab fa-linkedin"></i></a>
          </div>
        </div>

        <div>
          <h3 class="font-bold mb-4 text-white">Đại học Bà Rịa - Vũng Tàu</h3>
          <ul class="space-y-2 text-sm">
            <li><router-link to="/gioi-thieu" class="hover:underline">Giới thiệu</router-link></li>
            <li><router-link to="/dao-tao" class="hover:underline">Đào tạo</router-link></li>
            <li><router-link to="/nganh" class="hover:underline">Ngành học</router-link></li>
            <li><router-link to="/tuyen-sinh" class="hover:underline">Tuyển sinh</router-link></li>
          </ul>
        </div>
      </div>

      <div class="text-center text-sm text-blue-200 mt-8 border-t border-blue-700 pt-4">
        © 2025 BVU Job Portal. All rights reserved.
      </div>
    </footer>
  </div>
</template>

<script setup>
import { ref, computed, watch, onMounted } from "vue";
import { useAuthStore } from "@/store/auth";
import { useRoute, useRouter } from "vue-router";
import ChatWidget from "@/components/ai/ChatWidget.vue";

const auth = useAuthStore();
const menuOpen = ref(false);
const mobileOpen = ref(false);
const route = useRoute();
const router = useRouter();
const baseURL = "https://localhost:7248";

/* Avatar URL Fix */
const getAvatarUrl = (path) => {
  if (!path) return "/default-avatar.png";
  if (path.includes("/uploads/avatars//uploads/avatars/")) {
    path = path.replace("/uploads/avatars//uploads/avatars/", "/uploads/avatars/");
  }
  return path.startsWith("http") ? path : `${baseURL}${path}`;
};

const hideLayout = computed(() => {
  const noLayoutRoutes = [
    "/dang-nhap",
    "/dang-ky",
    "/admin",
    "/admin/users",
    "/admin/jobs",
    "/admin/categories",
    "/admin/companies",
    "/admin/reports",
    "/admin/create-user",
    "/admin/notifications",
    "/admin/cv-templates",
    "/admin/nghe-nghiep",
    "/admin/chuyen-nganh",
    "/admin/cv-template/builder",
    "/admin/cv-template/builder/:id",
    "/admin/cv-templates-new",
    "/admin/chat",
    "/admin/ai",
    "/admin/khieu-nai",


    "/cv/xem",
  ];

  // Nếu route khớp đúng path → ẩn
  if (noLayoutRoutes.includes(route.path)) return true;
  return false;
});


const toggleMenu = () => {
  menuOpen.value = !menuOpen.value;
  showThongBao.value = false;
};

const logout = () => {
  auth.logout();
  menuOpen.value = false;
  mobileOpen.value = false;
  router.push("/");
};

watch(
  () => auth.user,
  (user) => {
    if (auth.loading) return;
    if (
      user &&
      (user.vaiTro === "Admin" || user.vaiTro === "SuperAdmin") &&
      route.path === "/"
    ) {
      router.replace("/admin");
      return;
    }
    if (!user && route.meta.requiresAuth) {
      router.replace("/");
    }
  },
  { immediate: true }
);

import api from "@/api/axios";

const thongBaos = ref([]);
const soThongBaoChuaDoc = ref(0);
const showThongBao = ref(false);
onMounted(async () => {
  if (auth.isAuthenticated) {
    await loadThongBao();
  }
});


const loadThongBao = async () => {
  try {
    const [ds, chuaDoc] = await Promise.all([
      api.get("/ThongBao/danh-sach"),
      api.get("/ThongBao/chua-doc"),
    ]);

    thongBaos.value = ds.data ?? [];
    soThongBaoChuaDoc.value = chuaDoc.data ?? 0;
  } catch (err) {
    console.error("Lỗi tải thông báo:", err);
  }
};

watch(
  () => auth.isAuthenticated,
  async (isAuth) => {
    if (isAuth) {
      await loadThongBao();
    } else {
      thongBaos.value = [];
      soThongBaoChuaDoc.value = 0;
    }
  }
);


const toggleThongBao = async () => {
  showThongBao.value = !showThongBao.value;
  menuOpen.value = false;

  if (showThongBao.value && thongBaos.value.length === 0) {
    await loadThongBao();
  }
};
const openThongBao = async (tb) => {
  if (!tb.daDoc) {
    await api.post(`/ThongBao/danh-dau-doc/${tb.id}`);
    tb.daDoc = true;
    soThongBaoChuaDoc.value--;
  }

  showThongBao.value = false;

  if (tb.url) {
    router.push(tb.url);
  }
};
</script>
