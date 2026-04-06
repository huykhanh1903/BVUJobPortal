<template>
  <div class="min-h-screen bg-gradient-to-br from-blue-50 to-white py-8 px-3">
    <div class="max-w-7xl mx-auto flex flex-col lg:flex-row gap-8">

      <div class="flex-1 bg-white shadow rounded-xl border overflow-hidden">
        <form @submit.prevent="capNhatTin" class="divide-y">

          <section class="p-6">
            <h2 class="section-title">🧾 Thông tin cơ bản</h2>

            <div class="grid grid-cols-1 md:grid-cols-2 gap-6 mt-4">
              <div class="md:col-span-2">
                <label class="label">Tiêu đề tuyển dụng *</label>
                <input v-model="form.tieuDe" class="input" required />
              </div>

              <div>
                <label class="label">Số lượng tuyển *</label>
                <input type="number" min="1" v-model.number="form.soLuongTuyen" class="input" />
              </div>

              <div>
                <label class="label">Loại công việc *</label>
                <select v-model="form.loaiCongViecId" class="input">
                  <option value="">-- Chọn --</option>
                  <option v-for="x in loaiCongViecs" :key="x.id" :value="x.id">{{ x.ten }}</option>
                </select>
              </div>

              <div>
                <label class="label">Cấp bậc *</label>
                <select v-model="form.capBacId" class="input">
                  <option value="">-- Chọn --</option>
                  <option v-for="x in capBacs" :key="x.id" :value="x.id">{{ x.ten }}</option>
                </select>
              </div>

              <div>
                <label class="label">Kinh nghiệm *</label>
                <select v-model="form.mucKinhNghiemId" class="input">
                  <option value="">-- Chọn --</option>
                  <option v-for="x in kinhNghiems" :key="x.id" :value="x.id">{{ x.ten ?? x.tenMucKinhNghiem }}</option>
                </select>
              </div>
>
              <div>
                <label class="label">Giới tính *</label>
                <select v-model="form.gioiTinh" class="input">
                  <option value="">-- Chọn --</option>
                  <option value="Nam">Nam</option>
                  <option value="Nữ">Nữ</option>
                  <option value="Không yêu cầu">Không yêu cầu</option>
                </select>
              </div>
            </div>
          </section>

          <section class="p-6">
            <h2 class="section-title">🎯 Lĩnh vực – Nghề – Chuyên ngành</h2>

            <div class="relative mt-2">
              <label class="label">Lĩnh vực *</label>
              <input type="text" class="input"
                v-model="searchLinhVuc" placeholder="Nhập tên lĩnh vực..."
                @focus="showLinhVuc = true" @input="showLinhVuc = true" @blur="closeLinhVuc" />

              <ul v-if="showLinhVuc" class="dropdown-box">
                <li v-for="lv in filteredLinhVuc" :key="lv.id" class="dropdown-item"
                  @mousedown.prevent="selectLinhVuc(lv)">
                  {{ lv.tenLinhVuc }}
                </li>
                <li v-if="filteredLinhVuc.length === 0" class="dropdown-empty">
                  Không tìm thấy lĩnh vực
                </li>
              </ul>
            </div>

            <div class="relative mt-5" v-if="selectedLinhVuc">
              <label class="label">Ngành nghề *</label>
              <input type="text" class="input"
                v-model="searchNghe" placeholder="Nhập tên nghề..."
                @focus="showNghe = true" @input="showNghe = true" @blur="closeNghe" />

              <ul v-if="showNghe" class="dropdown-box">
                <li v-for="n in filteredNghe" :key="n.id" class="dropdown-item"
                  @mousedown.prevent="selectNghe(n)">
                  {{ n.tenNghe }}
                </li>
                <li v-if="filteredNghe.length === 0" class="dropdown-empty">
                  Không tìm thấy ngành nghề
                </li>
              </ul>
            </div>

            <div v-if="selectedNghe" class="mt-6">
              <label class="label">Chuyên ngành (nhiều) *</label>
              <div class="grid grid-cols-1 sm:grid-cols-2 lg:grid-cols-3 gap-4 mt-3">
                <div v-for="cn in chuyenNganhs" :key="cn.id"
                  @click="toggleChuyenNganh(cn.id)"
                  class="cn-card"
                  :class="form.chuyenNganhIds.includes(cn.id) ? 'cn-active' : ''">
                  <p class="font-medium text-sm">{{ cn.tenChuyenNganh }}</p>
                  <div v-if="form.chuyenNganhIds.includes(cn.id)" class="check-icon">✔</div>
                </div>
              </div>
            </div>
          </section>

          <section class="p-6">
            <h2 class="section-title">💰 Mức lương</h2>

            <div class="grid grid-cols-1 md:grid-cols-3 gap-6 mt-4">
              <div>
                <label class="label">Kiểu lương *</label>
                <select v-model="form.kieuLuong" class="input">
                  <option value="">-- Chọn --</option>
                  <option value="TuDen">Từ - Đến</option>
                  <option value="Thoathuan">Thỏa thuận</option>
                </select>
              </div>

              <div v-if="form.kieuLuong === 'TuDen'">
                <label class="label">Lương từ *</label>
                <input type="number" v-model.number="form.luongTu" class="input" />
              </div>

              <div v-if="form.kieuLuong === 'TuDen'">
                <label class="label">Lương đến *</label>
                <input type="number" v-model.number="form.luongDen" class="input" />
              </div>

              <div>
                <label class="label">Tiền tệ *</label>
                <select v-model="form.loaiTienTe" class="input">
                  <option value="VND">VND</option>
                  <option value="USD">USD</option>
                </select>
              </div>
            </div>
          </section>

          <section class="p-6">
            <div class="flex justify-between items-center mb-3">
              <h2 class="section-title">📍 Khu vực làm việc</h2>
              <button type="button" @click="themKhuVuc" class="btn-add">+ Thêm</button>
            </div>

            <div v-for="(kv, index) in form.khuVucs" :key="index"
              class="grid grid-cols-1 md:grid-cols-2 gap-4 mt-4">

              <div class="relative">
                <label class="label">Tỉnh / thành phố</label>
                <input type="text" class="input"
                  v-model="kv._tinhSearch"
                  @focus="kv.showTinhDropdown = true"
                  @input="kv.showTinhDropdown = true"
                  @blur="() => closeTinhDropdown(kv)"
                  placeholder="Nhập tên tỉnh..." />

                <ul v-if="kv.showTinhDropdown" class="tinh-dropdown">
                  <li v-for="t in filteredTinhThanhs(kv._tinhSearch)"
                    :key="t.id" class="tinh-option"
                    @click="chonTinhThanh(kv, t)">
                    {{ t.tenTinh }}
                  </li>
                </ul>
              </div>

              <div class="flex gap-2 items-end">
                <div class="flex-1">
                  <label class="label">Địa chỉ cụ thể</label>
                  <input class="input" v-model="kv.diaChiCuThe" />
                </div>

                <button v-if="form.khuVucs.length > 1"
                  @click="xoaKhuVuc(index)" type="button"
                  class="btn-remove h-10 mt-6">
                  ✖
                </button>
              </div>

            </div>
          </section>

          <section class="p-6">
            <h2 class="section-title">🧠 Mô tả & Yêu cầu</h2>

            <label class="label">Mô tả công việc *</label>
            <div class="editor-wrapper">
              <QuillEditor v-model:content="form.moTaCongViec"
                theme="snow" content-type="html" class="quill-editor" />
            </div>

            <label class="label mt-4">Quyền lợi *</label>
            <div class="editor-wrapper">
              <QuillEditor v-model:content="form.quyenLoiUngVien"
                theme="snow" content-type="html" class="quill-editor" />
            </div>

            <div class="flex flex-col gap-4 mt-4">
              <div>
                <label class="label">Lý do 1</label>
                <input class="input" v-model="form.lyDo1" />
              </div>
              <div>
                <label class="label">Lý do 2</label>
                <input class="input" v-model="form.lyDo2" />
              </div>
              <div>
                <label class="label">Lý do 3</label>
                <input class="input" v-model="form.lyDo3" />
              </div>
            </div>
          </section>

          <section class="p-6">
            <h2 class="section-title">📬 Hạn nộp & Người nhận CV</h2>

            <div class="grid grid-cols-1 md:grid-cols-2 gap-6 mt-4">
              <div>
                <label class="label">Hạn nộp *</label>
                <input type="date" class="input" v-model="form.hanNopHoSo" />
              </div>

              <div>
                <label class="label">Người nhận *</label>
                <input class="input" v-model="form.nguoiNhanCV_HoTen" />
              </div>

              <div>
                <label class="label">Số điện thoại</label>
                <input class="input" v-model="form.nguoiNhanCV_SDT" />
              </div>

              <div>
                <label class="label">Email *</label>
                <input type="email" class="input" v-model="form.nguoiNhanCV_Email" />
              </div>
            </div>
          </section>

        </form>
      </div>

      <div class="w-full lg:w-80">
        <div class="sticky top-6 space-y-6">
          <div class="sidebar-card">
            <h3 class="font-bold text-gray-800 mb-2">📌 Trạng thái</h3>
            <p class="text-gray-600 text-sm">Bạn đang chỉnh sửa tin tuyển dụng.</p>
          </div>

          <div class="sidebar-card">
            <h3 class="font-bold text-gray-800 mb-3">⚡ Hành động</h3>
            <button @click="capNhatTin" class="btn-blue w-full">💾 Cập nhật</button>

            <button @click="quayLai" class="btn-gray w-full mt-2">← Quay lại</button>
          </div>

        </div>
      </div>

    </div>
  </div>
</template>

<script setup>
import { ref, computed, onMounted } from "vue";
import { useRoute, useRouter } from "vue-router";
import api from "@/api/axios";
import { useToast } from "vue-toastification";
import { useAuthStore } from "@/store/auth";
import { QuillEditor } from "@vueup/vue-quill";
import "@vueup/vue-quill/dist/vue-quill.snow.css";

const route = useRoute();
const router = useRouter();
const toast = useToast();
const auth = useAuthStore();

const form = ref({
  tieuDe: "",
  soLuongTuyen: 1,
  loaiCongViecId: null,
  capBacId: null,
  mucKinhNghiemId: null,
  gioiTinh: "",
  kieuLuong: "",
  luongTu: 0,
  luongDen: 0,
  loaiTienTe: "VND",
  lyDo1: "",
  lyDo2: "",
  lyDo3: "",
  moTaCongViec: "",
  quyenLoiUngVien: "",
  khuVucs: [],
  hanNopHoSo: "",
  nguoiNhanCV_HoTen: "",
  nguoiNhanCV_SDT: "",
  nguoiNhanCV_Email: "",
  chuyenNganhIds: []
});

const loaiCongViecs = ref([]);
const capBacs = ref([]);
const kinhNghiems = ref([]);
const tinhThanhs = ref([]);

const linhVucs = ref([]);
const ngheNghieps = ref([]);
const chuyenNganhs = ref([]);

const selectedLinhVuc = ref("");
const selectedNghe = ref("");

const searchLinhVuc = ref("");
const showLinhVuc = ref(false);

const searchNghe = ref("");
const showNghe = ref(false);

const filteredLinhVuc = computed(() =>
  linhVucs.value.filter(x =>
    x.tenLinhVuc.toLowerCase().includes(searchLinhVuc.value.toLowerCase())
  )
);

const filteredNghe = computed(() =>
  ngheNghieps.value.filter(x =>
    x.tenNghe.toLowerCase().includes(searchNghe.value.toLowerCase())
  )
);

function closeLinhVuc() {
  setTimeout(() => (showLinhVuc.value = false), 150);
}

function closeNghe() {
  setTimeout(() => (showNghe.value = false), 150);
}

function selectLinhVuc(lv) {
  searchLinhVuc.value = lv.tenLinhVuc;
  selectedLinhVuc.value = lv.id;
  showLinhVuc.value = false;
  loadNgheNghiep();
}

function selectNghe(n) {
  searchNghe.value = n.tenNghe;
  selectedNghe.value = n.id;
  showNghe.value = false;
  loadChuyenNganh();
}

function toggleChuyenNganh(id) {
  if (form.value.chuyenNganhIds.includes(id)) {
    form.value.chuyenNganhIds = form.value.chuyenNganhIds.filter(x => x !== id);
  } else {
    form.value.chuyenNganhIds.push(id);
  }
}

async function loadDropdowns() {
  const resLoai = await api.get("/Admin/loai-cong-viec");
  loaiCongViecs.value = resLoai.data || [];

  const resCapBac = await api.get("/Admin/cap-bac");
  capBacs.value = resCapBac.data || [];

  const resKN = await api.get("/Admin/muc-kinh-nghiem");
  kinhNghiems.value = resKN.data || [];

  const resTinh = await api.get("/DiaChi/tinh-thanh");
  tinhThanhs.value = resTinh.data || [];
}



async function loadLinhVuc() {
  linhVucs.value = (await api.get("/Admin/linh-vuc")).data;
}

async function loadNgheNghiep() {
  if (!selectedLinhVuc.value) return;
  ngheNghieps.value = (
    await api.get(`/Admin/linh-vuc/${selectedLinhVuc.value}/nghe-nghiep`)
  ).data;
}

async function loadChuyenNganh() {
  if (!selectedNghe.value) return;
  chuyenNganhs.value = (
    await api.get(`/Admin/nghe-nghiep/${selectedNghe.value}/chuyen-nganh`)
  ).data;
}

async function loadOldData() {
  try {
    const id = route.params.id;
    const job = (
      await api.get(`/CongViec/${id}`, {
        headers: { Authorization: `Bearer ${auth.token}` }
      })
    ).data;

    form.value.tieuDe = job.tieuDe;
    form.value.soLuongTuyen = job.soLuongTuyen;

    form.value.loaiCongViecId = Number(job.loaiCongViecId);
    form.value.capBacId = Number(job.capBacId);
    form.value.mucKinhNghiemId = Number(job.mucKinhNghiemId);
    form.value.gioiTinh = job.gioiTinh;

    form.value.kieuLuong = job.kieuLuong;
    form.value.luongTu = job.luongTu;
    form.value.luongDen = job.luongDen;
    form.value.loaiTienTe = job.loaiTienTe;

    form.value.lyDo1 = job.lyDo1;
    form.value.lyDo2 = job.lyDo2;
    form.value.lyDo3 = job.lyDo3;

    form.value.moTaCongViec = job.moTaCongViec;
    form.value.quyenLoiUngVien = job.quyenLoiUngVien;

    form.value.hanNopHoSo = job.hanNopHoSo?.substring(0, 10);

    form.value.nguoiNhanCV_HoTen = job.nguoiNhanCV_HoTen;
    form.value.nguoiNhanCV_SDT = job.nguoiNhanCV_SDT;
    form.value.nguoiNhanCV_Email = job.nguoiNhanCV_Email;

    form.value.khuVucs = job.khuVucs.map((x, i) => ({
      tinhThanhId: x.tinhThanhId,
      diaChiCuThe: x.diaChiCuThe,
      _tinhSearch: job.khuVucLamViec[i],
      showTinhDropdown: false
    }));

    if (job.linhVucs.length > 0) {
      const lv = linhVucs.value.find(x => x.tenLinhVuc === job.linhVucs[0]);
      if (lv) {
        searchLinhVuc.value = lv.tenLinhVuc;
        selectedLinhVuc.value = lv.id;
        await loadNgheNghiep();
      }
    }

    if (job.nganhNghieps.length > 0) {
      const ngh = ngheNghieps.value.find(
        x => x.tenNghe === job.nganhNghieps[0]
      );
      if (ngh) {
        searchNghe.value = ngh.tenNghe;
        selectedNghe.value = ngh.id;
        await loadChuyenNganh();
      }
    }

    form.value.chuyenNganhIds = [];
    for (const cnName of job.chuyenNganhs) {
      const cn = chuyenNganhs.value.find(
        x => x.tenChuyenNganh === cnName
      );
      if (cn) form.value.chuyenNganhIds.push(cn.id);
    }

  } catch (err) {
    console.error(err);
    toast.error("Không thể tải dữ liệu cũ!");
  }
}

async function capNhatTin() {
  try {
    const id = route.params.id;

    const payload = {
      ...form.value,
      mucKinhNghiemId: form.value.mucKinhNghiemId,
      khuVucs: form.value.khuVucs.map(kv => ({
        tinhThanhId: kv.tinhThanhId,
        diaChiCuThe: kv.diaChiCuThe
      })),
      hanNopHoSo: new Date(form.value.hanNopHoSo).toISOString()
    };
    
    await api.put(`/CongViec/chinh-sua/${id}`, payload, {
      headers: { Authorization: `Bearer ${auth.token}` }
    });

    toast.success("🎉 Cập nhật tin thành công!");
    router.push("/nha-tuyen-dung/tin-tuyen-dung");
  } catch {
    toast.error("Cập nhật thất bại!");
  }
}

function quayLai() {
  router.push("/nha-tuyen-dung/tin-tuyen-dung");
}

onMounted(async () => {
  await loadDropdowns();
  await loadLinhVuc();
  await loadOldData();
});


</script>

<style scoped>

.section-title { @apply text-xl font-bold text-blue-700 mb-4; }
.label { @apply font-medium mb-1 block; }
.input { @apply w-full border border-gray-300 rounded-lg p-3 text-sm focus:ring-2 focus:ring-blue-500; }

.cn-card { @apply p-4 border rounded-xl cursor-pointer bg-white relative hover:border-blue-400 transition; }
.cn-active { @apply border-blue-600 bg-blue-50; }
.check-icon { @apply absolute top-2 right-2 w-5 h-5 bg-blue-600 text-white flex items-center justify-center rounded-full text-xs; }

.btn-blue { @apply bg-blue-700 hover:bg-blue-800 text-white py-2 px-4 rounded-lg font-semibold transition; }
.btn-gray { @apply bg-gray-200 hover:bg-gray-300 text-gray-700 py-2 px-4 rounded-lg transition; }
.btn-add { @apply px-3 py-1 bg-blue-100 text-blue-600 rounded-md hover:bg-blue-200; }
.btn-remove { @apply px-3 bg-red-100 text-red-500 rounded-md hover:bg-red-200; }

.sidebar-card { @apply bg-white border shadow-sm rounded-xl p-4; }

.dropdown-box { @apply absolute z-40 top-full left-0 right-0 bg-white rounded-lg border max-h-60 overflow-y-auto shadow-md; }
.dropdown-item { @apply px-4 py-2 cursor-pointer hover:bg-blue-50 text-sm; }
.dropdown-empty { @apply px-4 py-2 text-gray-400 text-sm; }

.tinh-dropdown { @apply absolute z-40 top-full left-0 right-0 bg-white rounded-lg border max-h-60 overflow-y-auto shadow-md; }
.tinh-option { @apply px-4 py-2 cursor-pointer hover:bg-blue-50 text-sm; }

.editor-wrapper { border: 1px solid #d1d5db; border-radius: 12px; overflow: hidden; }
</style>
