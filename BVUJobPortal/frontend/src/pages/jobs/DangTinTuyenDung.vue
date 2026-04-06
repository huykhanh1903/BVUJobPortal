<template>
  <div class="max-w-4xl mx-auto bg-white p-8 shadow rounded-xl">
    <h1 class="text-2xl font-bold mb-6 text-gray-800">
      📝 {{ isEdit ? "Chỉnh sửa tin tuyển dụng" : "Đăng tin tuyển dụng" }}
    </h1>

    <form @submit.prevent="submitForm" class="space-y-6">

      <!-- THÔNG TIN CƠ BẢN -->
      <div class="section-box">
        <h2 class="section-title">📌 Thông tin cơ bản</h2>

        <div class="grid grid-cols-2 gap-4">
          <div>
            <label class="label">Tiêu đề</label>
            <input v-model="form.tieuDe" class="input" />
          </div>

          <div>
            <label class="label">Vị trí tuyển dụng</label>
            <input v-model="form.viTri" class="input" />
          </div>

          <div>
            <label class="label">Lĩnh vực</label>
            <input v-model.number="form.linhVucId" type="number" class="input" placeholder="Nhập ID lĩnh vực" />
          </div>

          <div>
            <label class="label">Loại công việc</label>
            <input v-model="form.loaiCongViec" class="input" placeholder="Full-time / Part-time" />
          </div>
        </div>
      </div>

      <!-- SỐ LƯỢNG & LƯƠNG -->
      <div class="section-box">
        <h2 class="section-title">💵 Số lượng & Mức lương</h2>

        <div class="grid grid-cols-3 gap-4">
          <div>
            <label class="label">Số lượng tuyển</label>
            <input v-model.number="form.soLuongTuyen" type="number" class="input" />
          </div>

          <div>
            <label class="label">Mức lương</label>
            <input v-model="form.mucLuong" class="input" />
          </div>

          <div>
            <label class="label">Hình thức trả lương</label>
            <input v-model="form.hinhThucTraLuong" class="input" placeholder="Theo tháng / Theo giờ" />
          </div>
        </div>
      </div>

      <!-- THÔNG TIN CÔNG VIỆC -->
      <div class="section-box">
        <h2 class="section-title">🧾 Chi tiết công việc</h2>

        <label class="label">Thời gian làm việc</label>
        <input v-model="form.thoiGianLamViec" class="input mb-4" placeholder="VD: T2 - T6 (8h - 17h)" />

        <label class="label">Mô tả công việc</label>
        <textarea v-model="form.moTaCongViec" class="textarea"></textarea>

        <label class="label">Yêu cầu ứng viên</label>
        <textarea v-model="form.yeuCauUngVien" class="textarea"></textarea>
      </div>

      <!-- YÊU CẦU BẰNG CẤP -->
      <div class="section-box">
        <h2 class="section-title">🎓 Yêu cầu & kỹ năng</h2>

        <div class="grid grid-cols-2 gap-4">
          <div>
            <label class="label">Trình độ học vấn</label>
            <input v-model="form.trinhDoHocVan" class="input" />
          </div>

          <div>
            <label class="label">Kinh nghiệm</label>
            <input v-model="form.kinhNghiem" class="input" />
          </div>
        </div>

        <div class="grid grid-cols-2 gap-4 mt-4">
          <div>
            <label class="label">Kỹ năng chuyên môn</label>
            <textarea v-model="form.kyNangChuyenMon" class="textarea"></textarea>
          </div>

          <div>
            <label class="label">Kỹ năng mềm</label>
            <textarea v-model="form.kyNangMem" class="textarea"></textarea>
          </div>
        </div>

        <label class="label">Ngành học phù hợp</label>
        <input v-model="form.nganhHocPhuHop" class="input" />

        <label class="label">Độ tuổi / Giới tính</label>
        <input v-model="form.doTuoiGioiTinh" class="input" />
      </div>

      <!-- ĐÃI NGỘ -->
      <div class="section-box">
        <h2 class="section-title">🎁 Đãi ngộ</h2>
        <textarea v-model="form.cheDoDaiNgo" class="textarea"></textarea>
      </div>

      <!-- ỨNG TUYỂN -->
      <div class="section-box">
        <h2 class="section-title">📮 Thông tin ứng tuyển</h2>

        <label class="label">Hình thức ứng tuyển</label>
        <input v-model="form.hinhThucUngTuyen" class="input" placeholder="VD: Gửi email / Nộp CV trực tiếp" />

        <label class="label">Email nhận hồ sơ</label>
        <input v-model="form.emailNhanHoSo" class="input" />

        <label class="label">Ghi chú</label>
        <textarea v-model="form.ghiChu" class="textarea"></textarea>

        <label class="label">Hạn nộp hồ sơ</label>
        <input type="date" v-model="form.hanNopHoSo" class="input" />
      </div>

      <!-- BUTTON -->
      <div class="flex justify-end gap-3 pt-4">
        <router-link to="/jobs" class="px-4 py-2 bg-gray-100 rounded">Hủy</router-link>
        <button type="submit" class="px-4 py-2 bg-blue-600 text-white rounded hover:bg-blue-700">
          💾 {{ isEdit ? "Cập nhật" : "Đăng tin" }}
        </button>
      </div>

    </form>
  </div>
</template>

<script setup>
import { ref, computed, onMounted } from "vue";
import api from "@/api/axios";
import { useRoute, useRouter } from "vue-router";
import { useAuthStore } from "@/store/auth";
import { useToast } from "vue-toastification";

const auth = useAuthStore();
const route = useRoute();
const router = useRouter();
const toast = useToast();

const isEdit = computed(() => !!route.params.id);

const form = ref({
  tieuDe: "",
  viTri: "",
  linhVucId: null,
  loaiCongViec: "",
  soLuongTuyen: 1,
  mucLuong: "",
  hinhThucTraLuong: "",
  thoiGianLamViec: "",
  hanNopHoSo: "",
  moTaCongViec: "",
  yeuCauUngVien: "",
  trinhDoHocVan: "",
  kinhNghiem: "",
  kyNangChuyenMon: "",
  kyNangMem: "",
  nganhHocPhuHop: "",
  doTuoiGioiTinh: "",
  cheDoDaiNgo: "",
  hinhThucUngTuyen: "",
  emailNhanHoSo: "",
  ghiChu: ""
});

// LOAD DATA FOR EDIT
onMounted(async () => {
  if (isEdit.value) {
    try {
      const res = await api.get(`/CongViec/${route.params.id}`, {
        headers: { Authorization: `Bearer ${auth.token}` }
      });

      Object.assign(form.value, res.data);

      if (res.data.hanNopHoSo)
        form.value.hanNopHoSo = res.data.hanNopHoSo.split("T")[0];

    } catch (err) {
      toast.error("Không thể tải dữ liệu công việc!");
    }
  }
});

// SUBMIT
async function submitForm() {
  try {
    const payload = { ...form.value };

    // convert ngày về đúng ISO
    if (payload.hanNopHoSo)
      payload.hanNopHoSo = new Date(payload.hanNopHoSo).toISOString();

    if (isEdit.value) {
      await api.put(`/CongViec/cap-nhat/${route.params.id}`, payload, {
        headers: { Authorization: `Bearer ${auth.token}` }
      });
      toast.success("✅ Cập nhật tin thành công!");
    } else {
      await api.post("/CongViec/dang-tin", payload, {
        headers: { Authorization: `Bearer ${auth.token}` }
      });
      toast.success("🎉 Đăng tin thành công!");
    }

    router.push("/jobs");

  } catch (err) {
    console.error(err);
    toast.error("❌ Lưu tin thất bại!");
  }
}
</script>

<style scoped>
.label {
  @apply font-semibold block mb-1;
}

.input {
  @apply w-full border rounded p-2;
}

.textarea {
  @apply w-full border rounded p-2 min-h-[90px];
}

.section-box {
  @apply bg-gray-50 p-4 rounded-xl border;
}

.section-title {
  @apply text-lg font-bold text-blue-600 mb-2;
}
</style>
