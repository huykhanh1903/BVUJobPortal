<template>
  <div class="min-h-screen flex flex-col md:flex-row bg-gray-50">
    <!-- LEFT -->
    <div
      class="hidden md:flex flex-1 flex-col justify-center items-center bg-gradient-to-br from-slate-900 via-indigo-900 to-violet-800 text-white p-10 relative overflow-hidden"
    >
      <div class="absolute -top-20 -left-20 w-72 h-72 bg-indigo-500/30 rounded-full blur-3xl animate-pulse"></div>
      <div class="absolute -bottom-24 -right-24 w-80 h-80 bg-violet-500/30 rounded-full blur-3xl animate-pulse [animation-duration:4s]"></div>

      <div class="max-w-md text-center relative z-10">
        <img src="/logo-bvu.png" alt="BVU Logo" class="mx-auto h-24 mb-6 drop-shadow-lg" />
        <h1 class="text-4xl font-extrabold mb-4 tracking-tight">BVU Job Portal</h1>
        <p class="text-indigo-100 mb-8 text-lg leading-relaxed">
          Kết nối sinh viên BVU với nhà tuyển dụng — nhanh chóng, minh bạch, hiệu quả.
        </p>

        <div class="bg-white/10 backdrop-blur-md rounded-2xl p-6 space-y-3 text-left text-sm shadow-lg">
          <p class="flex items-center gap-3">
            <CheckCircleIcon class="h-5 w-5 text-green-400" />
            <span>Tìm & lọc việc theo lĩnh vực</span>
          </p>
          <p class="flex items-center gap-3">
            <CheckCircleIcon class="h-5 w-5 text-green-400" />
            <span>Tạo & tải CV PDF dễ dàng</span>
          </p>
          <p class="flex items-center gap-3">
            <CheckCircleIcon class="h-5 w-5 text-green-400" />
            <span>Quản lý hồ sơ ứng tuyển</span>
          </p>
        </div>
      </div>
    </div>

    <div class="flex-1 flex justify-center items-center bg-gradient-to-br from-gray-900 via-gray-800 to-gray-700 px-4 py-10 md:py-0">
      <div class="w-full max-w-md bg-white/95 backdrop-blur-xl rounded-3xl shadow-2xl p-8 sm:p-10 relative">
        <router-link
          to="/"
          class="absolute top-4 left-4 text-sm text-gray-500 hover:text-indigo-600 flex items-center gap-1"
        >
          <span class="text-lg">←</span> Trang chủ
        </router-link>

        <h2 class="text-3xl font-bold text-center text-gray-800 mb-3">Đăng nhập</h2>
        <p class="text-center text-gray-500 mb-8 text-sm sm:text-base">Chào mừng bạn trở lại 👋</p>

        <form @submit.prevent="handleLogin" class="space-y-5">
          <div class="relative">
            <span class="absolute inset-y-0 left-3 flex items-center text-gray-400">
              <EnvelopeIcon class="h-5 w-5" />
            </span>
            <input
              v-model="email"
              ref="emailInput"
              type="email"
              placeholder="Email"
              class="w-full pl-10 px-4 py-3 border rounded-xl bg-gray-50 focus:bg-white focus:ring-2 focus:ring-indigo-500 outline-none transition text-sm sm:text-base"
              required
            />
          </div>

          <div class="relative">
            <span class="absolute inset-y-0 left-3 flex items-center text-gray-400">
              <LockClosedIcon class="h-5 w-5" />
            </span>
            <input
              v-model="matKhau"
              :type="showPassword ? 'text' : 'password'"
              placeholder="Mật khẩu"
              class="w-full pl-10 pr-10 py-3 border rounded-xl bg-gray-50 focus:bg-white focus:ring-2 focus:ring-indigo-500 outline-none transition text-sm sm:text-base"
              required
            />
            <span
              class="absolute inset-y-0 right-3 flex items-center text-gray-400 cursor-pointer hover:text-indigo-600"
              @click="togglePassword"
            >
              <i :class="showPassword ? 'fas fa-eye-slash' : 'fas fa-eye'"></i>
            </span>
          </div>

          <div class="flex items-center justify-between text-sm text-gray-600 flex-wrap gap-2">
            <label class="flex items-center space-x-2">
              <input type="checkbox" class="rounded border-gray-300 accent-indigo-600" />
              <span>Ghi nhớ tôi</span>
            </label>
            <router-link to="/quen-mat-khau" class="text-indigo-600 hover:underline">
              Quên mật khẩu?
            </router-link>
          </div>

          <button
            type="submit"
            :disabled="loading"
            class="w-full py-3 rounded-xl font-semibold text-white bg-gradient-to-r from-indigo-600 via-purple-600 to-pink-500 shadow-lg hover:scale-105 transform transition disabled:opacity-60 text-sm sm:text-base flex justify-center items-center gap-2"
          >
            <span v-if="loading" class="flex items-center gap-2">
              <svg
                class="animate-spin h-5 w-5 text-white"
                xmlns="http://www.w3.org/2000/svg"
                fill="none"
                viewBox="0 0 24 24"
              >
                <circle class="opacity-25" cx="12" cy="12" r="10" stroke="currentColor" stroke-width="4"></circle>
                <path
                  class="opacity-75"
                  fill="currentColor"
                  d="M4 12a8 8 0 018-8v4a4 4 0 00-4 4H4z"
                ></path>
              </svg>
              Đang đăng nhập…
            </span>
            <span v-else>Đăng nhập</span>
          </button>
        </form>

        <div class="flex items-center my-6">
          <div class="flex-1 h-px bg-gray-200"></div>
          <span class="px-3 text-gray-400 text-sm">hoặc đăng nhập bằng</span>
          <div class="flex-1 h-px bg-gray-200"></div>
        </div>

        <div class="flex justify-center gap-4">
          <button class="social-btn text-red-500" @click="loginWithGoogle">
            <font-awesome-icon :icon="['fab','google']" />
          </button>

          <button class="social-btn text-blue-600">
            <font-awesome-icon :icon="['fab','facebook']" />
          </button>

          <button class="social-btn text-gray-800">
            <font-awesome-icon :icon="['fab','github']" />
          </button>
        </div>
        <p class="mt-6 text-center text-sm text-gray-600">
          Chưa có tài khoản?
          <router-link to="/dang-ky" class="text-indigo-600 font-semibold hover:underline">
            Đăng ký ngay
          </router-link>
        </p>
      </div>
    </div>
  </div>
</template>

<script setup>
import { ref, onMounted } from "vue";
import { useAuthStore } from "../../store/auth";
import { useRouter } from "vue-router";

import { CheckCircleIcon, EnvelopeIcon, LockClosedIcon } from "@heroicons/vue/24/solid";
import { library } from "@fortawesome/fontawesome-svg-core";
import { FontAwesomeIcon } from "@fortawesome/vue-fontawesome";
import { faGoogle, faFacebook, faGithub } from "@fortawesome/free-brands-svg-icons";
import { useToast } from "vue-toastification";

library.add(faGoogle, faFacebook, faGithub);

const email = ref("");
const matKhau = ref("");
const showPassword = ref(false);
const emailInput = ref(null);
const auth = useAuthStore();
const router = useRouter();
const loading = ref(false);
const toast = useToast();

const togglePassword = () => (showPassword.value = !showPassword.value);
onMounted(() => {
  emailInput.value?.focus();
  loadGoogleSDK();
});

const handleLogin = async () => {
  loading.value = true;
  const result = await auth.login(email.value, matKhau.value);
  loading.value = false;

  if (result?.biKhoa) {
    return router.push({
      path: "/tai-khoan-bi-khoa",
      query: {
        lyDo:
          result.lyDo ||
          "Tài khoản đã bị khóa. Vui lòng liên hệ quản trị viên."
      }
    });
  }

  if (result.requireVerify) {
    const verifiedEmail = result.email || email.value;

    sessionStorage.setItem("pendingEmail", verifiedEmail);

    toast.warning(result.message || "Email chưa được xác thực. OTP đã được gửi lại!");

    return router.push(
      `/xac-thuc-email?email=${encodeURIComponent(verifiedEmail)}`
    );
  }

  if (!result.success) {
    toast.error(result.message || "Đăng nhập thất bại!");
    return;
  }

  toast.success(result.message || "Đăng nhập thành công!");

  const role = auth.user?.vaiTro;

  if (role === "Admin" || role === "SuperAdmin") {
    return router.push("/admin");
  }

  if (role === "NhaTuyenDung") {
    return router.push("/nha-tuyen-dung/tin-tuyen-dung");
  }

  if (role === "DoanhNghiep") {
    return router.push("/doanh-nghiep/nhan-su");
  }

  router.push("/");

};

const loadGoogleSDK = () => {
  return new Promise((resolve) => {
    if (window.google) {
      resolve();
      return;
    }

    const script = document.createElement("script");
    script.src = "https://accounts.google.com/gsi/client";
    script.async = true;
    script.defer = true;
    script.onload = () => resolve();

    document.head.appendChild(script);
  });
};

const handleGoogleResponse = async (response) => {
  try {
    const googleToken = response.credential;

    const res = await fetch("https://localhost:7248/api/TaiKhoan/google-login", {
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify({ googleToken }),
    });

    const data = await res.json();

    if (!data.token) {
      toast.error(data.thongBao || "Đăng nhập Google thất bại!");
      return;
    }

    auth.setToken(data.token);

    await auth.fetchUser();

    if (auth.user?.vaiTro === "Guest") {
      toast.info("Vui lòng chọn vai trò để hoàn tất tài khoản!");
      router.push("/chon-vai-tro");
      return;
    }

    toast.success("Đăng nhập Google thành công!");
    redirectByRole();

  } catch (err) {
    console.error(err);
    toast.error("Lỗi đăng nhập Google!");
  }
};

const loginWithGoogle = async () => {
  await loadGoogleSDK();

  const client = google.accounts.oauth2.initTokenClient({
    client_id: "116774327198-nnl6bh15o2jb0br9ioha6vj4gft7c9a0.apps.googleusercontent.com",
    scope: "email profile openid",
    prompt: "select_account",
    callback: async (tokenResponse) => {
      try {
        const googleToken = tokenResponse.access_token;

        const res = await fetch("https://localhost:7248/api/TaiKhoan/google-login", {
          method: "POST",
          headers: { "Content-Type": "application/json" },
          body: JSON.stringify({ googleToken }),
        });

        const data = await res.json();

        if (!data.accessToken && !data.AccessToken) {
          toast.error(data.thongBao || "Đăng nhập Google thất bại!");
          return;
        }

        auth.setToken(data.accessToken || data.AccessToken);

        await auth.fetchUser();

        if (auth.user?.vaiTro === "Guest" || !auth.user?.vaiTro) {
          toast.info("Vui lòng chọn vai trò để hoàn tất tài khoản!");
          router.push("/chon-vai-tro");
          return; 
        }

        toast.success("Đăng nhập Google thành công!");
        redirectByRole();

      } catch (err) {
        console.error(err);
        toast.error("Lỗi đăng nhập Google");
      }
    }
  });

  client.requestAccessToken();
};

const handleGoogleCredential = async (response) => {
  try {
    const googleToken = response.credential;

    const res = await fetch("https://localhost:7248/api/TaiKhoan/google-login", {
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify({ googleToken }),
    });

    const data = await res.json();

    if (!data.accessToken && !data.AccessToken) {
      toast.error(data.thongBao || "Đăng nhập Google thất bại!");
      return;
    }

    auth.setToken(data.accessToken || data.AccessToken);

    await auth.fetchUser();
    toast.success("Đăng nhập Google thành công!");

    switch (auth.user?.vaiTro) {
      case "Admin":
      case "SuperAdmin":
        router.push("/admin");
        break;
      case "NhaTuyenDung":
        router.push("/nha-tuyen-dung/tin-tuyen-dung");
        break;
      case "DoanhNghiep":
        router.push("/doanh-nghiep/nhan-su");
        break;
      default:
        router.push("/");
    }
  } catch (err) {
    console.error(err);
    toast.error("Lỗi đăng nhập Google");
  }
};

const redirectByRole = () => {
  switch (auth.user?.vaiTro) {
    case "Admin":
    case "SuperAdmin":
      router.push("/admin");
      break;

    case "NhaTuyenDung":
      router.push("/nha-tuyen-dung/tin-tuyen-dung");
      break;

    case "DoanhNghiep":
      router.push("/doanh-nghiep/nhan-su");
      break;

    default:
      router.push("/");
  }
};

</script>

<script>
export default { components: { FontAwesomeIcon } };
</script>

<style scoped>
.social-btn {
  @apply w-12 h-12 flex items-center justify-center rounded-full border border-gray-300 hover:bg-gray-100 shadow-sm transition text-xl;
}
</style>