<template>
  <div class="p-8">
    <h2 class="text-lg font-semibold text-gray-700 border-b pb-2">⚙️ Quản trị viên</h2>
    <p class="mt-3 text-gray-700">Xin chào, <b>{{ user.hoTen }}</b>!</p>
    <p class="text-gray-500 mt-1">
      Bạn đang đăng nhập với quyền:
      <b>{{ user.vaiTro === "SuperAdmin" ? "👑 Super Admin" : "⚙️ Admin" }}</b>
    </p>
    <p class="text-gray-600 mt-3">
      Truy cập vào bảng điều khiển quản lý tại
      <router-link
        to="/admin/dashboard"
        class="text-indigo-600 hover:underline font-medium"
      >Dashboard</router-link>.
    </p>
  </div>
</template>

<script setup>
defineProps({ user: Object });
</script>
