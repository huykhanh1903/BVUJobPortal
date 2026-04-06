<template>
  <div class="text-gray-800 space-y-6">

    <!-- HEADER -->
    <div class="bg-gradient-to-r from-blue-600 to-indigo-700 text-white p-6 rounded-2xl shadow-md">
      <div class="flex flex-col sm:flex-row sm:items-center gap-6">
        
        <!-- LOGO -->
        <div>
          <img
            v-if="user?.thongTinDoanhNghiep?.logoUrl"
            :src="getAvatarUrl(user.thongTinDoanhNghiep.logoUrl)"
            class="h-24 w-24 object-cover rounded-xl border-4 border-white shadow-lg"
          />
          <div
            v-else
            class="h-24 w-24 rounded-xl bg-white/20 flex items-center justify-center text-4xl font-bold"
          >
            {{ user?.thongTinDoanhNghiep?.tenCongTy?.charAt(0) || "C" }}
          </div>
        </div>

        <!-- NAME + LOCATION -->
        <div class="flex-1">
          <h1 class="text-3xl font-bold tracking-tight">
            {{ user.thongTinDoanhNghiep.tenCongTy }}
          </h1>

          <p class="text-gray-200 mt-1 flex items-center gap-2">
            <i class="fas fa-map-marker-alt"></i>
            {{ user.thongTinDoanhNghiep.tinhThanhPho || "Chưa cập nhật" }}
          </p>

          <!-- STATUS -->
          <div class="mt-4">
            <span
              v-if="user.thongTinDoanhNghiep.daDuocAdminXacMinh"
              class="bg-green-100 text-green-700 px-4 py-1.5 rounded-full text-sm font-medium inline-flex items-center gap-2"
            >
              <i class="fas fa-check-circle"></i>
              Đã được admin xác minh
            </span>
            <span
              v-else
              class="bg-yellow-100 text-yellow-700 px-4 py-1.5 rounded-full text-sm font-medium inline-flex items-center gap-2"
            >
              <i class="fas fa-hourglass-half"></i>
              Đang chờ xác minh
            </span>
          </div>
        </div>

        <!-- EDIT BUTTON -->
        <router-link
          to="/hoso/chinh-sua"
          class="bg-white text-blue-700 px-4 py-2 rounded-lg font-semibold shadow hover:bg-gray-100 transition"
        >
          ✏️ Chỉnh sửa
        </router-link>
      </div>
    </div>

    <!-- MAIN CONTENT -->
    <div class="grid md:grid-cols-3 gap-6">

      <!-- LEFT SIDE – CONTACT INFO -->
      <div class="md:col-span-1 space-y-6">
        
        <!-- CONTACT CARD -->
        <div class="bg-white p-6 rounded-2xl shadow border border-gray-100">
          <h3 class="font-semibold text-gray-900 mb-4 flex items-center gap-2">
            📞 Thông tin liên hệ
          </h3>

          <div class="space-y-3 text-sm">

            <p class="flex items-center gap-2">
              <span class="text-gray-500 w-6 text-center">
                <i class="fas fa-globe"></i>
              </span>
              <span>
                <strong>Website:</strong><br />
                <a
                  v-if="user.thongTinDoanhNghiep.website"
                  :href="normalizeWebsite(user.thongTinDoanhNghiep.website)"
                  target="_blank"
                  class="text-indigo-600 hover:underline"
                >
                  {{ user.thongTinDoanhNghiep.website }}
                </a>
                <span v-else>—</span>
              </span>
            </p>

            <p class="flex items-center gap-2">
              <span class="text-gray-500 w-6 text-center">
                <i class="fas fa-phone"></i>
              </span>
              <strong>{{ user.thongTinDoanhNghiep.soDienThoaiLienHe || "—" }}</strong>
            </p>

            <p class="flex items-center gap-2">
              <span class="text-gray-500 w-6 text-center">
                <i class="fas fa-envelope"></i>
              </span>
              {{ user.thongTinDoanhNghiep.emailLienHe || "—" }}
            </p>

            <p class="flex items-center gap-2">
              <span class="text-gray-500 w-6 text-center">
                <i class="fas fa-user-tie"></i>
              </span>
              {{ user.thongTinDoanhNghiep.nguoiLienHe || "—" }}
            </p>

            <p class="flex items-center gap-2">
              <span class="text-gray-500 w-6 text-center">
                <i class="fas fa-briefcase"></i>
              </span>
              {{ user.thongTinDoanhNghiep.chucVuNguoiLienHe || "—" }}
            </p>

          </div>
        </div>

        <!-- ADDRESS -->
        <div class="bg-white p-6 rounded-2xl shadow border border-gray-100">
          <h3 class="font-semibold text-gray-900 mb-3 flex items-center gap-2">
            📍 Địa chỉ làm việc
          </h3>
          <p class="text-gray-700 text-sm">
            {{ user.thongTinDoanhNghiep.diaChiLamViec || "Chưa cập nhật" }}
          </p>
        </div>

      </div>

      <!-- RIGHT SIDE – COMPANY INTRO -->
      <div class="md:col-span-2 bg-white p-6 rounded-2xl shadow border border-gray-100">
        <h3 class="font-semibold text-gray-900 mb-4 flex items-center gap-2">
          💬 Giới thiệu doanh nghiệp
        </h3>

        <div
          class="text-gray-700 leading-relaxed text-sm whitespace-pre-line min-h-[120px]"
        >
          {{ user.thongTinDoanhNghiep.gioiThieu || "Chưa có mô tả doanh nghiệp." }}
        </div>
      </div>

    </div>

  </div>
</template>

<script setup>
defineProps({ user: Object });

function getAvatarUrl(path) {
  return path?.startsWith("http") ? path : `https://localhost:7248${path}`;
}

function normalizeWebsite(url) {
  return url.startsWith("http") ? url : `https://${url}`;
}
</script>

<style scoped>
/* Hover effect cho card */
.bg-white {
  transition: transform 0.2s ease, box-shadow 0.2s ease;
}
.bg-white:hover {
  transform: translateY(-2px);
  box-shadow: 0 8px 24px rgba(0, 0, 0, 0.08);
}
</style>
