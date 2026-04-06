<template>
  <div class="p-8 space-y-6">
    <h2 class="text-lg font-semibold text-gray-700 border-b pb-2">💼 Thông tin nhà tuyển dụng</h2>

    <div v-if="user.thongTinDoanhNghiep" class="bg-green-50 border border-green-200 rounded-xl p-5">
      <h3 class="font-bold text-green-700 text-lg mb-1">{{ user.thongTinDoanhNghiep.tenCongTy }}</h3>
      <p>{{ user.thongTinDoanhNghiep.diaChiLamViec }}</p>
      <p class="text-green-600 mt-1 font-semibold">✅ Đã được xác thực</p>
    </div>

    <div v-else class="bg-white border border-gray-200 rounded-xl p-6 shadow-sm">
      <p class="text-gray-600 mb-4">
        Bạn chưa được xác thực với công ty nào. Vui lòng nhập mã công ty để gửi yêu cầu xác thực.
      </p>
      <router-link
        to="/hoso/xac-thuc"
        class="px-4 py-2 bg-indigo-600 text-white rounded-lg hover:bg-indigo-700 transition"
      >
        🔍 Gửi yêu cầu xác thực
      </router-link>
    </div>
  </div>
</template>

<script setup>
defineProps({ user: Object });
</script>
