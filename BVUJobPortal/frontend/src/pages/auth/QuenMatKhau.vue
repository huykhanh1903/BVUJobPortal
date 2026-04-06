<template>
  <div class="min-h-screen flex justify-center items-center bg-gray-100 px-4">
    <div class="bg-white p-8 rounded-2xl shadow-lg w-full max-w-md">

      <h2 class="text-2xl font-bold text-center mb-3">Quên mật khẩu</h2>
      <p class="text-gray-600 mb-6 text-center">
        Nhập email của bạn để nhận mã OTP đặt lại mật khẩu.
      </p>

      <form @submit.prevent="sendOtp">
        <input
          v-model="email"
          type="email"
          required
          class="w-full px-4 py-3 border rounded-xl bg-gray-50 focus:ring-2 focus:ring-indigo-500"
          placeholder="Email của bạn"
        />

        <button
          class="w-full py-3 mt-4 bg-indigo-600 text-white rounded-xl hover:bg-indigo-700 transition"
          :disabled="loading"
        >
          <span v-if="loading">Đang gửi…</span>
          <span v-else>Gửi mã OTP</span>
        </button>
      </form>

    </div>
  </div>
</template>

<script setup>
import { ref } from "vue";
import api from "@/api/axios";
import { useRouter } from "vue-router";
import { useToast } from "vue-toastification";

const email = ref("");
const loading = ref(false);
const router = useRouter();
const toast = useToast();

const sendOtp = async () => {
  loading.value = true;

  try {
    await api.post("/TaiKhoan/quen-mat-khau", { email: email.value });

    toast.success("OTP đã gửi! Vui lòng kiểm tra email.");
    router.push(`/dat-lai-mat-khau?email=${email.value}`);
  } catch (err) {
    toast.error("Không gửi được OTP!");
  }

  loading.value = false;
};
</script>
