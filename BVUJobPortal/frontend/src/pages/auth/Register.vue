<template>
  <div class="min-h-screen flex flex-col md:flex-row bg-gray-50">
    <div
      class="hidden md:flex flex-1 flex-col justify-center items-center bg-gradient-to-br from-slate-900 via-indigo-900 to-violet-800 text-white p-10 relative overflow-hidden"
    >
      <div class="absolute -top-20 -left-20 w-72 h-72 bg-indigo-500/30 rounded-full blur-3xl animate-pulse"></div>
      <div class="absolute -bottom-24 -right-24 w-80 h-80 bg-violet-500/30 rounded-full blur-3xl animate-pulse [animation-duration:4s]"></div>

      <div class="max-w-md text-center relative z-10">
        <img src="/logo-bvu.png" alt="BVU Logo" class="mx-auto h-24 mb-6 drop-shadow-lg" />
        <h1 class="text-4xl font-extrabold mb-4">BVU Job Portal</h1>
        <p class="text-indigo-100 mb-8 text-lg leading-relaxed">
          Đăng ký tài khoản để bắt đầu hành trình nghề nghiệp cùng BVU 🚀
        </p>

        <div class="bg-white/10 backdrop-blur-md rounded-2xl p-6 space-y-3 text-left text-sm shadow-lg">
          <p class="flex items-center gap-3">
            <CheckCircleIcon class="h-5 w-5 text-green-400" />
            <span>Truy cập hàng trăm công việc hấp dẫn</span>
          </p>
          <p class="flex items-center gap-3">
            <CheckCircleIcon class="h-5 w-5 text-green-400" />
            <span>Tạo và tải CV PDF chuyên nghiệp</span>
          </p>
          <p class="flex items-center gap-3">
            <CheckCircleIcon class="h-5 w-5 text-green-400" />
            <span>Quản lý hồ sơ cá nhân dễ dàng</span>
          </p>
        </div>
      </div>
    </div>
    <div class="flex-1 flex justify-center items-center bg-gradient-to-br from-gray-900 via-gray-800 to-gray-700 px-4 py-10 md:py-0">
      <div class="w-full max-w-md bg-white/95 backdrop-blur-xl rounded-3xl shadow-2xl p-8 sm:p-10 relative">

        <!-- Back button -->
        <router-link
          to="/"
          class="absolute top-4 left-4 text-sm text-gray-500 hover:text-indigo-600 flex items-center gap-1"
        >
          <span class="text-lg">←</span> Trang chủ
        </router-link>

        <h2 class="text-3xl font-bold text-center text-gray-800 mb-3">Đăng ký</h2>
        <p class="text-center text-gray-500 mb-8 text-sm sm:text-base">Tạo tài khoản sinh viên BVU 🎓</p>

        <form @submit.prevent="handleRegister" class="space-y-5">
          <div class="relative">
            <span class="absolute inset-y-0 left-3 flex items-center text-gray-400">
              <UserIcon class="h-5 w-5" />
            </span>
            <input
              v-model="hoTen"
              ref="nameInput"
              type="text"
              placeholder="Họ và tên"
              class="w-full pl-10 px-4 py-3 border rounded-xl bg-gray-50 focus:bg-white focus:ring-2 focus:ring-indigo-500 outline-none transition text-sm sm:text-base"
              required
            />
          </div>
          <div class="relative">
            <span class="absolute inset-y-0 left-3 flex items-center text-gray-400">
              <EnvelopeIcon class="h-5 w-5" />
            </span>
            <input
              v-model="email"
              type="email"
              placeholder="Email"
              class="w-full pl-10 px-4 py-3 border rounded-xl bg-gray-50 focus:bg-white focus:ring-2 focus:ring-indigo-500 outline-none transition text-sm sm:text-base"
              required
            />
          </div>
          <div class="relative">
            <span class="absolute inset-y-0 left-3 flex items-center text-gray-400">
              <PhoneIcon class="h-5 w-5" />
            </span>
            <input
              v-model="sdt"
              type="tel"
              placeholder="Số điện thoại"
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

          <select
            v-model="vaiTro"
            class="w-full px-4 py-3 border rounded-xl bg-gray-50 focus:bg-white focus:ring-2 focus:ring-indigo-500 outline-none transition text-sm sm:text-base"
            required
          >
            <option disabled value="">-- Chọn vai trò --</option>
            <option value="SinhVien">Sinh viên</option>
            <option value="NhaTuyenDung">Nhà tuyển dụng</option>
          </select>

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
              Đang đăng ký…
            </span>
            <span v-else>Đăng ký</span>
          </button>
        </form>

        <div class="flex items-center my-6">
          <div class="flex-1 h-px bg-gray-200"></div>
          <span class="px-3 text-gray-400 text-sm">hoặc đăng ký bằng</span>
          <div class="flex-1 h-px bg-gray-200"></div>
        </div>

        <div class="flex justify-center gap-4">
          <button class="social-btn text-red-500"><font-awesome-icon :icon="['fab','google']" /></button>
          <button class="social-btn text-blue-600"><font-awesome-icon :icon="['fab','facebook']" /></button>
          <button class="social-btn text-gray-800"><font-awesome-icon :icon="['fab','github']" /></button>
        </div>

        <p class="mt-6 text-center text-sm text-gray-600">
          Đã có tài khoản?
          <router-link to="/dang-nhap" class="text-indigo-600 font-semibold hover:underline">
            Đăng nhập ngay
          </router-link>
        </p>
      </div>
    </div>
  </div>
</template>

<script setup>
import { ref, onMounted } from "vue";
import { useRouter } from "vue-router";
import { useAuthStore } from "../../store/auth";
import { useToast } from "vue-toastification";
import { CheckCircleIcon, EnvelopeIcon, LockClosedIcon, UserIcon, PhoneIcon } from "@heroicons/vue/24/solid";
import { library } from "@fortawesome/fontawesome-svg-core";
import { FontAwesomeIcon } from "@fortawesome/vue-fontawesome";
import { faGoogle, faFacebook, faGithub } from "@fortawesome/free-brands-svg-icons";

library.add(faGoogle, faFacebook, faGithub);

const hoTen = ref("");
const email = ref("");
const sdt = ref("");
const matKhau = ref("");
const vaiTro = ref("");
const showPassword = ref(false);
const loading = ref(false);
const nameInput = ref(null);

const auth = useAuthStore();
const router = useRouter();
const toast = useToast();

const togglePassword = () => (showPassword.value = !showPassword.value);

onMounted(() => {
  nameInput.value?.focus();
});

const handleRegister = async () => {
  loading.value = true;
  try {
    const result = await auth.register({
      hoTen: hoTen.value,
      email: email.value,
      sdt: sdt.value,
      matKhau: matKhau.value,
      vaiTro: vaiTro.value,
    });

    if (result.success) {
      sessionStorage.setItem("pendingEmail", email.value);

      toast.success(result.message || "🎉 Đăng ký thành công! Vui lòng kiểm tra email để lấy mã OTP.");
      router.push(`/xac-thuc-email?email=${encodeURIComponent(email.value)}`);
    } else {
      toast.error(result.message || "❌ Đăng ký thất bại!");
    }
  } catch (err) {
    console.error(err);
    toast.error("⚠️ Lỗi hệ thống, vui lòng thử lại!");
  } finally {
    loading.value = false;
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