<template>
  <div class="min-h-screen flex justify-center items-center bg-gray-100 px-4">
    <div class="bg-white p-8 rounded-2xl shadow-lg w-full max-w-md">

      <h2 class="text-2xl font-bold text-center mb-3">Đặt lại mật khẩu</h2>
      <p class="text-gray-600 text-center mb-4">
        Nhập mã OTP gửi đến <strong>{{ email }}</strong>
      </p>

      <div class="flex justify-between mb-6">
        <input
          v-for="(digit, i) in otpDigits"
          :key="i"
          ref="otpRefs"
          maxlength="1"
          type="text"
          inputmode="numeric"
          class="otp-box"
          v-model="otpDigits[i]"
          @input="onInput(i)"
          @keydown.backspace="onBackspace(i, $event)"
          @paste="onPaste($event)"
        />
      </div>

      <input
        v-model="newPassword"
        type="password"
        placeholder="Mật khẩu mới"
        class="w-full px-4 py-3 border rounded-xl bg-gray-50 focus:ring-2 focus:ring-indigo-500"
      />

      <button
        @click="resetPassword"
        class="w-full py-3 mt-4 bg-indigo-600 text-white rounded-xl hover:bg-indigo-700 transition"
        :disabled="loading"
      >
        <span v-if="loading">Đang xử lý…</span>
        <span v-else>Đặt lại mật khẩu</span>
      </button>

      <p class="text-center text-gray-500 text-sm mt-5">
        Không nhận được mã?
        <button @click="resendOtp" class="text-indigo-600 hover:underline">
          Gửi lại OTP
        </button>
      </p>

    </div>
  </div>
</template>

<script setup>
import { reactive, ref, nextTick, onMounted } from "vue";
import api from "@/api/axios";
import { useRoute, useRouter } from "vue-router";
import { useToast } from "vue-toastification";

const route = useRoute();
const router = useRouter();
const toast = useToast();

const email = route.query.email;
const newPassword = ref("");
const loading = ref(false);

const otpDigits = reactive(["", "", "", "", "", ""]);
const otpRefs = ref([]);

function onInput(index) {
  const val = otpDigits[index];
  if (!/^[0-9]$/.test(val)) {
    otpDigits[index] = "";
    return;
  }
  if (index < 5) otpRefs.value[index + 1]?.focus();
}

function onBackspace(index) {
  if (otpDigits[index] === "" && index > 0) otpRefs.value[index - 1]?.focus();
}

function onPaste(e) {
  const pasted = e.clipboardData.getData("text").trim();
  if (/^\d{6}$/.test(pasted)) {
    for (let i = 0; i < 6; i++) otpDigits[i] = pasted[i];
    nextTick(() => otpRefs.value[5]?.focus());
  }
  e.preventDefault();
}

onMounted(() => nextTick(() => otpRefs.value[0]?.focus()));

const resetPassword = async () => {
  const otp = otpDigits.join("");

  if (otp.length !== 6) return toast.error("OTP phải gồm 6 số!");
  if (newPassword.value.length < 6)
    return toast.error("Mật khẩu mới phải >= 6 ký tự!");

  loading.value = true;

  try {
    const res = await api.post("/TaiKhoan/dat-lai-mat-khau", {
      email,
      otp,
      matKhauMoi: newPassword.value,
    });

    toast.success(res.data.thongBao || "Đặt lại mật khẩu thành công!");
    router.push("/dang-nhap");
  } catch (err) {
    toast.error("OTP không đúng hoặc đã hết hạn!");
  }

  loading.value = false;
};

const resendOtp = async () => {
  try {
    await api.post("/TaiKhoan/gui-lai-otp", { email });
    toast.success("OTP mới đã được gửi!");
  } catch {
    toast.error("Không thể gửi lại OTP");
  }
};
</script>

<style scoped>
.otp-box {
  width: 48px;
  height: 55px;
  font-size: 22px;
  text-align: center;
  border: 2px solid #d1d5db;
  border-radius: 12px;
  background: #f1f5f9;
  font-weight: bold;
  transition: .2s;
}
.otp-box:focus {
  background: white;
  border-color: #6366f1;
  box-shadow: 0 0 8px rgba(99,102,241,.4);
}
</style>
