<template>
  <div class="min-h-screen bg-gray-50 py-10 px-6">

    <div v-if="loading" class="text-center text-gray-600 py-20 text-lg animate-pulse">
      ⏳ Đang tải thông tin công việc...
    </div>

    <div v-else-if="!job" class="text-center bg-white rounded-2xl shadow p-10 max-w-3xl mx-auto">
      🚫 Không tìm thấy tin tuyển dụng này.
      <div class="mt-4">
        <router-link
          to="/nha-tuyen-dung/tin-tuyen-dung"
          class="px-4 py-2 bg-blue-600 text-white rounded-lg hover:bg-blue-700"
        >
          ← Quay lại danh sách
        </router-link>
      </div>
    </div>

    <div
      v-else
      class="max-w-5xl mx-auto bg-white rounded-2xl shadow-lg p-10 space-y-10"
    >

      <div class="flex flex-wrap justify-between items-start gap-6 pb-6 border-b">
        <div class="flex items-start gap-4">
          <div
            class="w-20 h-20 rounded-xl border bg-white shadow flex items-center justify-center overflow-hidden"
          >
            <img
              v-if="job.logoUrl"
              :src="job.logoUrl.startsWith('http') 
                ? job.logoUrl 
                : 'https://localhost:7248' + job.logoUrl"
              class="w-full h-full object-cover"
              @error="job.logoUrl = ''"
            />
            <span v-else class="text-xs text-gray-400 text-center px-2">
              Company<br />Logo
            </span>
          </div>
->
          <div>
            <h1 class="text-2xl md:text-3xl font-bold text-gray-900 leading-snug">
              {{ job.tieuDe }}
            </h1>

            <p class="text-gray-700 font-medium mt-1">
              🏢 {{ job.tenCongTy || "Chưa cập nhật" }}
            </p>

            <p class="text-sm text-gray-500 mt-1">
              📅 Ngày đăng: {{ formatDate(job.ngayDang) }}
              &nbsp; | &nbsp;
              ⏰ Hạn nộp: {{ formatDate(job.hanNopHoSo) }}
            </p>

            <p class="text-sm text-blue-600 mt-1" v-if="job.website">
              🌐 <a :href="job.website" target="_blank" class="hover:underline">
                {{ job.website }}
              </a>
            </p>
          </div>
        </div>

        <span
          class="px-4 py-1 rounded-full text-sm font-semibold whitespace-nowrap"
          :class="job.daDuyet
            ? 'bg-green-100 text-green-700'
            : 'bg-yellow-100 text-yellow-700'"
        >
          {{ job.daDuyet ? "Đã duyệt" : "Chờ duyệt" }}
        </span>
      </div>

      <div class="bg-gray-50 p-6 rounded-xl border">
        <h2 class="section-title">🏛️ Giới thiệu công ty</h2>
        <p class="content-text">
          {{ job.gioiThieuCongTy || "Chưa có giới thiệu." }}
        </p>

        <div class="grid md:grid-cols-2 gap-4 mt-4 text-gray-700">
          <p><strong>📞 Hotline:</strong> {{ job.soDienThoaiLienHe }}</p>
          <p><strong>📧 Email:</strong> {{ job.emailLienHe }}</p>
        </div>
      </div>

      <div>
        <h2 class="section-title">📋 Mô tả công việc</h2>
        <div
          class="prose prose-blue max-w-none content-html"
          v-html="job.moTaCongViec"
        ></div>
      </div>

      <div>
        <h2 class="section-title">💎 Quyền lợi</h2>
        <div
          class="prose prose-blue max-w-none content-html"
          v-html="job.quyenLoiUngVien"
        ></div>
      </div>

      <div v-if="job.lyDo1 || job.lyDo2 || job.lyDo3">
        <h2 class="section-title">💡 Vì sao nên làm việc tại công ty?</h2>
        <ul class="list-disc pl-6 text-gray-800 space-y-1">
          <li v-if="job.lyDo1">{{ job.lyDo1 }}</li>
          <li v-if="job.lyDo2">{{ job.lyDo2 }}</li>
          <li v-if="job.lyDo3">{{ job.lyDo3 }}</li>
        </ul>
      </div>

      <div class="bg-gray-50 p-6 rounded-xl border grid md:grid-cols-2 gap-6">

        <div>
          <h3 class="info-title">💰 Mức lương</h3>
          <p class="info-value">
            <span v-if="job.kieuLuong === 'TuDen'">
              {{ job.luongTu.toLocaleString() }} – {{ job.luongDen.toLocaleString() }} {{ job.loaiTienTe }}
            </span>
            <span v-else>Thỏa thuận</span>
          </p>
        </div>

        <div>
          <h3 class="info-title">🧩 Loại công việc</h3>
          <p class="info-value">{{ job.tenLoaiCongViec }}</p>
        </div>

        <div>
          <h3 class="info-title">🎓 Kinh nghiệm</h3>
          <p class="info-value">{{ job.tenKinhNghiem }}</p>
        </div>

        <div>
          <h3 class="info-title">📌 Cấp bậc</h3>
          <p class="info-value">{{ job.tenCapBac }}</p>
        </div>

        <div>
          <h3 class="info-title">👥 Số lượng tuyển</h3>
          <p class="info-value">{{ job.soLuongTuyen }}</p>
        </div>

        <div class="md:col-span-2">
          <h3 class="info-title">🌐 Lĩnh vực liên quan</h3>
          <div class="flex flex-wrap gap-2">
            <span
              v-for="(lv, index) in job.linhVucs"
              :key="index"
              class="px-3 py-1 bg-blue-100 text-blue-700 rounded-full text-sm font-medium"
            >
              {{ lv }}
            </span>
          </div>
        </div>

        <div class="md:col-span-2">
          <h3 class="info-title">🧭 Ngành nghề phù hợp</h3>
          <div class="flex flex-wrap gap-2">
            <span
              v-for="(nn, index) in job.nganhNghieps"
              :key="index"
              class="px-3 py-1 bg-green-100 text-green-700 rounded-full text-sm font-medium"
            >
              {{ nn }}
            </span>
          </div>
        </div>

        <div class="md:col-span-2">
          <h3 class="info-title">📚 Chuyên ngành phù hợp</h3>
          <div class="flex flex-wrap gap-2">
            <span
              v-for="(cn, i) in job.chuyenNganhs"
              :key="i"
              class="px-3 py-1 bg-purple-100 text-purple-700 rounded-full text-sm font-medium"
            >
              {{ cn }}
            </span>
          </div>
        </div>

      </div>
      <div class="bg-gray-50 p-6 rounded-xl border">
        <h2 class="section-title">📍 Khu vực làm việc</h2>

        <div class="space-y-2 text-gray-800">
          <div v-for="(kv, i) in job.khuVucs" :key="i">
            <strong>{{ job.khuVucLamViec[i] }}</strong>
            — {{ kv.diaChiCuThe }}
          </div>
        </div>
      </div>

      <div class="bg-gray-50 p-6 rounded-xl border">
        <h2 class="section-title">📨 Liên hệ nộp hồ sơ</h2>

        <p><strong>👤 Người nhận:</strong> {{ job.nguoiNhanCV_HoTen }}</p>
        <p><strong>📞 Số điện thoại:</strong> {{ job.nguoiNhanCV_SDT }}</p>
        <p><strong>📧 Email:</strong> {{ job.nguoiNhanCV_Email }}</p>
      </div>

      <div class="flex justify-end gap-3 border-t pt-6">

        <router-link
          to="/nha-tuyen-dung/tin-tuyen-dung"
          class="px-5 py-2 bg-gray-200 rounded-lg hover:bg-gray-300"
        >
          ← Quay lại
        </router-link>

        <router-link
          v-if="!job.daDuyet"
          :to="`/nha-tuyen-dung/sua-tin/${job.id}`"
          class="px-5 py-2 bg-yellow-500 text-white rounded-lg hover:bg-yellow-600"
        >
          ✏️ Sửa
        </router-link>

        <button
          v-if="!job.daDuyet"
          @click="showDeleteConfirm = true"
          class="px-5 py-2 bg-red-500 text-white rounded-lg hover:bg-red-600"
        >
          🗑️ Xóa tin
        </button>

        <router-link
          v-if="job.daDuyet"
          :to="`/cong-viec/${job.id}`"
          class="px-5 py-2 bg-green-600 text-white rounded-lg hover:bg-green-700"
        >
          👀 Xem bài đăng công khai
        </router-link>
      </div>

    </div>

    <div
      v-if="showDeleteConfirm"
      class="fixed inset-0 bg-black/40 flex items-center justify-center z-50"
    >
      <div class="bg-white p-6 rounded-xl shadow-xl max-w-sm w-full text-center">
        <h3 class="text-lg font-bold mb-3">⚠️ Xác nhận xóa tin</h3>
        <p class="text-gray-600 mb-6">
          Bạn có chắc chắn muốn xoá tin <b>{{ job?.tieuDe }}</b> này không?
        </p>

        <div class="flex justify-center gap-3">
          <button
            @click="showDeleteConfirm = false"
            class="px-4 py-2 bg-gray-200 rounded-lg hover:bg-gray-300"
          >
            Hủy
          </button>

          <button
            @click="xoaTin"
            class="px-4 py-2 bg-red-600 text-white rounded-lg hover:bg-red-700"
          >
            Xác nhận
          </button>
        </div>
      </div>
    </div>

  </div>
</template>

<script setup>
import { ref, onMounted } from "vue";
import { useRoute, useRouter } from "vue-router";
import api from "@/api/axios";
import { useToast } from "vue-toastification";
import { useAuthStore } from "@/store/auth";

const auth = useAuthStore();
const route = useRoute();
const router = useRouter();
const toast = useToast();

const job = ref(null);
const loading = ref(true);
const showDeleteConfirm = ref(false);

function formatDate(dateStr) {
  if (!dateStr || dateStr === "0001-01-01T00:00:00") return "—";
  return new Date(dateStr).toLocaleDateString("vi-VN");
}

async function fetchJob() {
  loading.value = true;

  try {
    const id = route.params.id;
    const res = await api.get(`/CongViec/${id}`, {
      headers: { Authorization: `Bearer ${auth.token}` },
    });

    job.value = {
      ...res.data,

      linhVucs: Array.isArray(res.data.linhVucs)
        ? res.data.linhVucs
        : [],

      nganhNghieps: Array.isArray(res.data.nganhNghieps)
        ? res.data.nganhNghieps
        : [],

      chuyenNganhs: Array.isArray(res.data.chuyenNganhs)
        ? res.data.chuyenNganhs
        : [],

      daDuyet:
        res.data.daDuyet === true ||
        res.data.daDuyet === 1 ||
        String(res.data.daDuyet).toLowerCase() === "true",
    };

  } catch (err) {
    console.error("Lỗi tải công việc:", err);
    toast.error("Không thể tải chi tiết công việc!");
  } finally {
    loading.value = false;
  }
}

async function xoaTin() {
  try {
    await api.delete(`/CongViec/xoa/${job.value.id}`, {
      headers: { Authorization: `Bearer ${auth.token}` },
    });

    toast.success("🗑️ Đã xoá tin tuyển dụng!");
    router.push("/nha-tuyen-dung/tin-tuyen-dung");
  } catch {
    toast.error("Xoá tin thất bại!");
  } finally {
    showDeleteConfirm.value = false;
  }
}

onMounted(fetchJob);
</script>

<style scoped>
.section-title {
  @apply text-xl font-bold text-blue-700 mb-3;
}
.info-title {
  @apply font-semibold text-gray-600 mb-1;
}
.info-value {
  @apply text-gray-900;
}
.content-text {
  @apply text-gray-700 leading-relaxed;
}
.content-html :deep(p),
.content-html :deep(li),
.content-html :deep(span) {
  @apply text-gray-800 leading-relaxed;
}
</style>
