<template>
  <div class="otp-bg min-h-screen flex items-center justify-center px-4">

    <div
      class="bg-white p-8 rounded-2xl shadow-2xl w-full max-w-md transform transition"
      :class="{ 'shake': shakeError }"
    >

      <h2 class="text-2xl font-bold text-center mb-2">Xác thực Email</h2>
      <p class="text-gray-600 text-center mb-6">
        Nhập mã OTP đã gửi đến <strong>{{ email }}</strong>
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

      <button
        class="w-full py-3 bg-indigo-600 text-white rounded-xl font-semibold hover:bg-indigo-700 transition shadow disabled:opacity-50"
        :disabled="loading"
        @click="submitOtp"
      >
        <span v-if="loading">Đang xác thực…</span>
        <span v-else>Xác nhận OTP</span>
      </button>

      <p class="text-center text-gray-500 text-sm mt-5">
        Không nhận được mã?
        <button
          class="text-indigo-600 font-semibold hover:underline"
          @click="resendOtp"
          :disabled="countdown > 0 || loadingResend"
        >
          <span v-if="countdown > 0">Gửi lại sau {{ countdown }}s</span>
          <span v-else>Gửi lại OTP</span>
        </button>
      </p>

    </div>
  </div>
</template>

<script setup>
import { ref, reactive, onMounted, nextTick } from "vue";
import { useRoute, useRouter } from "vue-router";
import { useToast } from "vue-toastification";
import api from "@/api/axios";

const route = useRoute();
const router = useRouter();
const toast = useToast();

const email = route.query.email || sessionStorage.getItem("pendingEmail");

const otpDigits = reactive(["", "", "", "", "", ""]);
const otpRefs = ref([]);

const loading = ref(false);
const loadingResend = ref(false);
const shakeError = ref(false);

const countdown = ref(60);
let timer = null;

function startCountdown() {
  countdown.value = 60;
  clearInterval(timer);

  timer = setInterval(() => {
    countdown.value--;
    if (countdown.value <= 0) clearInterval(timer);
  }, 1000);
}

onMounted(() => {
  nextTick(() => otpRefs.value[0]?.focus());
  startCountdown();
});

function onInput(index) {
  const val = otpDigits[index];

  if (!/^[0-9]$/.test(val)) {
    otpDigits[index] = "";
    return;
  }

  if (index < 5) {
    otpRefs.value[index + 1]?.focus();
  }
}

function onBackspace(index, e) {
  if (otpDigits[index] === "" && index > 0) {
    otpRefs.value[index - 1]?.focus();
  }
}

function onPaste(e) {
  const pasted = e.clipboardData.getData("text").trim();

  if (/^\d{6}$/.test(pasted)) {
    for (let i = 0; i < 6; i++) {
      otpDigits[i] = pasted[i];
    }
    nextTick(() => otpRefs.value[5]?.focus());
  }

  e.preventDefault();
}

async function submitOtp() {
  const otp = otpDigits.join("");
  if (otp.length !== 6) {
    triggerShake();
    toast.error("OTP phải đủ 6 chữ số!");
    return;
  }

  loading.value = true;

  try {
    await api.post("/TaiKhoan/xac-thuc-email", { email, otp });

    toast.success("✔ Xác thực thành công!");

    setTimeout(() => router.push("/dang-nhap"), 800);
  } catch {
    triggerShake();
    toast.error("OTP không đúng hoặc đã hết hạn!");
  }

  loading.value = false;
}

async function resendOtp() {
  if (countdown.value > 0) return;

  loadingResend.value = true;

  try {
    await api.post("/TaiKhoan/gui-lai-otp", { email });
    toast.success("OTP mới đã được gửi!");
    startCountdown();
  } catch {
    toast.error("Không gửi lại OTP được!");
  }

  loadingResend.value = false;
}
function triggerShake() {
  shakeError.value = true;
  setTimeout(() => (shakeError.value = false), 500);
}
</script>

<style scoped>
.otp-bg {
  background: linear-gradient(120deg, #4f46e5, #7c3aed, #ec4899);
  background-size: 300% 300%;
  animation: gradientMove 10s ease infinite;
}

@keyframes gradientMove {
  0% { background-position: 0% 50%; }
  50% { background-position: 100% 50%; }
  100% { background-position: 0% 50%; }
}

.otp-box {
  width: 50px;
  height: 56px;
  font-size: 24px;
  border: 2px solid #d1d5db;
  border-radius: 12px;
  text-align: center;
  font-weight: bold;
  background: #f5f5f5;
  transition: all 0.2s ease;
}

.otp-box:focus {
  border-color: #6366f1;
  background: white;
  box-shadow: 0 0 6px rgba(99, 102, 241, 0.5);
}

.shake {
  animation: shakeAnim 0.35s ease-in-out;
}

@keyframes shakeAnim {
  0% { transform: translateX(0); }
  20% { transform: translateX(-6px); }
  40% { transform: translateX(6px); }
  60% { transform: translateX(-6px); }
  80% { transform: translateX(6px); }
  100% { transform: translateX(0); }
}
</style>
