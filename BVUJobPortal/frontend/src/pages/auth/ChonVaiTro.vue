<template>
  <div class="min-h-screen flex items-center justify-center bg-gray-100 p-6">
    <div class="bg-white rounded-2xl shadow-xl p-8 max-w-lg w-full text-center">

      <h2 class="text-2xl font-bold text-gray-800 mb-4">
        Chọn vai trò để hoàn tất đăng nhập
      </h2>

      <p class="text-gray-500 mb-8">
        Vui lòng chọn 1 vai trò phù hợp để tiếp tục sử dụng hệ thống.
      </p>

      <div class="grid gap-4">

        <button
          @click="chonVaiTro('SinhVien')"
          class="role-btn bg-blue-600 hover:bg-blue-700 text-white"
        >
          🎓 Tôi là Sinh viên
        </button>

        <button
          @click="chonVaiTro('NhaTuyenDung')"
          class="role-btn bg-green-600 hover:bg-green-700 text-white"
        >
          🧑‍💼 Tôi là Nhà tuyển dụng
        </button>

      </div>

    </div>
  </div>
</template>

<script setup>
import { useToast } from "vue-toastification";
import { useAuthStore } from "@/store/auth";
import { useRouter } from "vue-router";
import api from "@/api/axios";

const auth = useAuthStore();
const router = useRouter();
const toast = useToast();

const chonVaiTro = async (role) => {
  try {
    const res = await api.put(
      "/TaiKhoan/chon-vai-tro",
      { vaiTro: role },   // ⭐ SỬA ĐÚNG
      {
        headers: {
          Authorization: `Bearer ${auth.token}`,
        },
      }
    );

    if (!res.data.thanhCong) {
      toast.error("Không thể cập nhật vai trò!");
      return;
    }

    toast.success("Cập nhật vai trò thành công!");

    await auth.fetchUser();

    if (role === "SinhVien") {
      router.push("/");
    } else if (role === "NhaTuyenDung") {
      router.push("/nha-tuyen-dung/tin-tuyen-dung");
    }

  } catch (err) {
    console.error(err);
    toast.error("Lỗi khi chọn vai trò!");
  }
};
</script>

<style scoped>
.role-btn {
  @apply w-full py-3 rounded-xl font-semibold shadow-md transition text-lg;
}
</style>