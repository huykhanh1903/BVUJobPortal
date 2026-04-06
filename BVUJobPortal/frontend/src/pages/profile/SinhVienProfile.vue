<template>
  <div class="p-8 grid md:grid-cols-3 gap-8">
    <div class="md:col-span-1 space-y-5">
      <h2 class="text-lg font-semibold text-gray-700 border-b pb-2">👤 Thông tin cá nhân</h2>
      <p><strong>Họ tên:</strong> {{ user.hoTen }}</p>
      <p><strong>Email:</strong> {{ user.email }}</p>
      <p><strong>Số điện thoại:</strong> {{ user.sdt || "—" }}</p>
      <router-link
        to="/hoso/chinh-sua"
        class="inline-block mt-4 px-4 py-2 bg-indigo-600 text-white rounded-lg hover:bg-indigo-700 transition"
      >
        ✏️ Chỉnh sửa hồ sơ
      </router-link>
    </div>

    <div class="md:col-span-2 space-y-5">
      <h2 class="text-lg font-semibold text-gray-700 border-b pb-2">🎓 Thông tin sinh viên</h2>
      <p><strong>Khóa học:</strong> {{ user.khoaHoc || "—" }}</p>
      <p><strong>Lớp học:</strong> {{ user.lopHoc || "—" }}</p>
    </div>
  </div>
</template>

<script setup>
defineProps({ user: Object });
</script>
