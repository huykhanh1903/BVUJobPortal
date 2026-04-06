<template>
  <div class="min-h-screen bg-gradient-to-br from-blue-50 to-white py-8 px-3">
    <div class="max-w-7xl mx-auto flex flex-col lg:flex-row gap-8">

      <div class="flex-1 bg-white shadow rounded-xl border overflow-hidden">

        <form @submit.prevent="dangTin" class="divide-y">

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

              <div>
                <label class="label">Giới tính *</label>
                <select v-model="form.gioiTinh" class="input">
                  <option value="">-- Chọn giới tính --</option>
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
              <input
                type="text"
                class="input"
                v-model="searchLinhVuc"
                placeholder="Nhập tên lĩnh vực..."
                @focus="showLinhVuc = true"
                @input="showLinhVuc = true"
                @blur="closeLinhVuc"
              />

              <ul v-if="showLinhVuc" class="dropdown-box">
                <li
                  v-for="lv in filteredLinhVuc"
                  :key="lv.id"
                  class="dropdown-item"
                  @mousedown.prevent="selectLinhVuc(lv)"
                >
                  {{ lv.tenLinhVuc }}
                </li>
                <li v-if="filteredLinhVuc.length === 0" class="dropdown-empty">
                  Không tìm thấy lĩnh vực
                </li>
              </ul>
            </div>

            <div class="relative mt-5" v-if="selectedLinhVuc">
              <label class="label">Ngành nghề *</label>

              <input
                type="text"
                class="input"
                v-model="searchNghe"
                placeholder="Nhập tên nghề..."
                @focus="showNghe = true"
                @input="showNghe = true"
                @blur="closeNghe"
              />

              <ul v-if="showNghe" class="dropdown-box">
                <li
                  v-for="n in filteredNghe"
                  :key="n.id"
                  class="dropdown-item"
                  @mousedown.prevent="selectNghe(n)"
                >
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
                <div
                  v-for="cn in chuyenNganhs"
                  :key="cn.id"
                  @click="toggleChuyenNganh(cn.id)"
                  class="cn-card"
                  :class="form.chuyenNganhIds.includes(cn.id) ? 'cn-active' : ''"
                >
                  <p class="font-medium text-sm">{{ cn.tenChuyenNganh }}</p>
                  <div v-if="form.chuyenNganhIds.includes(cn.id)" class="check-icon">✔</div>
                </div>
              </div>
            </div>
          </section>
->
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

            <div
              v-for="(kv, index) in form.khuVucs"
              :key="index"
              class="grid grid-cols-1 md:grid-cols-2 gap-4 mt-4"
            >
              <div class="relative">
                <label class="label">Tỉnh / thành phố</label>
                <input
                  type="text"
                  class="input"
                  v-model="kv._tinhSearch"
                  placeholder="Nhập tên tỉnh / thành phố..."
                  @focus="kv.showTinhDropdown = true"
                  @input="kv.showTinhDropdown = true"
                  @blur="() => closeTinhDropdown(kv)"
                />

                <ul
                  v-if="kv.showTinhDropdown"
                  class="tinh-dropdown"
                >
                  <li
                    v-for="t in filteredTinhThanhs(kv._tinhSearch)"
                    :key="t.id"
                    class="tinh-option"
                    @click="chonTinhThanh(kv, t)"
                  >
                    {{ t.tenTinh }}
                  </li>
                  <li
                    v-if="filteredTinhThanhs(kv._tinhSearch).length === 0"
                    class="px-3 py-2 text-sm text-gray-400"
                  >
                    Không tìm thấy tỉnh phù hợp
                  </li>
                </ul>
              </div>

              <div class="flex gap-2 items-end">
                <div class="flex-1">
                  <label class="label">Địa chỉ cụ thể</label>
                  <input
                    class="input"
                    placeholder="VD: Số 1 Võ Văn Ngân, Thủ Đức..."
                    v-model="kv.diaChiCuThe"
                  />
                </div>

                <button
                  v-if="form.khuVucs.length > 1"
                  @click="xoaKhuVuc(index)"
                  type="button"
                  class="btn-remove h-10 mt-6"
                >
                  ✖
                </button>
              </div>
            </div>
          </section>

          <section class="p-6">
            <h2 class="section-title">🧠 Mô tả & Yêu cầu</h2>

            <label class="label">Mô tả công việc *</label>
            <p class="help-text">
              Sử dụng thanh công cụ phía trên để in đậm, in nghiêng, gạch đầu dòng… Nội dung này sẽ hiển thị cho ứng viên.
            </p>
            <div class="editor-wrapper">
              <QuillEditor
                v-model:content="form.moTaCongViec"
                content-type="html"
                theme="snow"
                class="quill-editor"
              />
            </div>

            <label class="label mt-4">Quyền lợi *</label>
            <p class="help-text">
              Liệt kê rõ các quyền lợi: lương thưởng, phụ cấp, môi trường làm việc, cơ hội thăng tiến…
            </p>
            <div class="editor-wrapper">
              <QuillEditor
                v-model:content="form.quyenLoiUngVien"
                content-type="html"
                theme="snow"
                class="quill-editor"
              />
            </div>

            <div class="flex flex-col gap-4 mt-4">
              <div>
                <label class="label">Lý do 1</label>
                <input
                  class="input"
                  v-model="form.lyDo1"
                  placeholder="VD: Môi trường năng động, đồng nghiệp thân thiện"
                />
              </div>

              <div>
                <label class="label">Lý do 2</label>
                <input
                  class="input"
                  v-model="form.lyDo2"
                  placeholder="VD: Lương thưởng cạnh tranh, xét tăng lương định kỳ"
                />
              </div>

              <div>
                <label class="label">Lý do 3</label>
                <input
                  class="input"
                  v-model="form.lyDo3"
                  placeholder="VD: Cơ hội học hỏi & thăng tiến rõ ràng"
                />
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
            <p class="text-gray-600 text-sm">Điền đủ các mục để đăng tin tuyển dụng.</p>
          </div>

          <div class="sidebar-card">
            <h3 class="font-bold text-gray-800 mb-3">⚡ Hành động</h3>

            <button @click="dangTin" class="btn-blue w-full">🚀 Đăng tin</button>
            <!-- <button class="btn-gray w-full mt-2">💾 Lưu nháp</button> -->
          </div>

          <div class="sidebar-card">
            <h3 class="font-bold text-gray-800 mb-3">💡 Mẹo viết tin hấp dẫn</h3>
            <ul class="text-sm text-gray-600 space-y-2">
              <li>• Tiêu đề rõ ràng, dễ hiểu</li>
              <li>• Mô tả cụ thể công việc</li>
              <li>• Thêm quyền lợi nổi bật</li>
              <li>• Để hạn nộp rõ ràng</li>
            </ul>
          </div>

        </div>
      </div>

    </div>
  </div>
</template>

<script setup>
import { ref, onMounted, computed } from "vue";
import api from "@/api/axios";
import { useToast } from "vue-toastification";
import { useAuthStore } from "@/store/auth";
import { useRouter } from "vue-router";
import { QuillEditor } from "@vueup/vue-quill";
import "@vueup/vue-quill/dist/vue-quill.snow.css";

const toast = useToast();
const auth = useAuthStore();
const router = useRouter();

const form = ref({
  tieuDe: "",
  chuyenNganhIds: [],

  soLuongTuyen: 1,
  loaiCongViecId: 0,
  capBacId: 0,
  mucKinhNghiemId: 0,

  loaiTienTe: "VND",
  kieuLuong: "",
  luongTu: 0,
  luongDen: 0,

  gioiTinh: "",

  lyDo1: "",
  lyDo2: "",
  lyDo3: "",

  moTaCongViec: "",
  quyenLoiUngVien: "",

  khuVucs: [{ tinhThanhId: 0, diaChiCuThe: "", _tinhSearch: "", showTinhDropdown: false }],

  hanNopHoSo: "",
  nguoiNhanCV_HoTen: "",
  nguoiNhanCV_SDT: "",
  nguoiNhanCV_Email: ""
});

const linhVucs = ref([]);
const ngheNghieps = ref([]);
const chuyenNganhs = ref([]);

const selectedLinhVuc = ref("");
const selectedNghe = ref("");

async function loadLinhVuc() {
  try {
    const res = await api.get("/Admin/linh-vuc");
    linhVucs.value = res.data;
  } catch (err) {
    console.error("Lỗi load lĩnh vực:", err);
  }
}

async function loadNgheNghiep() {
  selectedNghe.value = "";
  searchNghe.value = "";
  searchChuyenNganh.value = "";
  chuyenNganhs.value = [];
  form.value.chuyenNganhIds = [];

  if (!selectedLinhVuc.value) return;

  try {
    const res = await api.get(`/Admin/linh-vuc/${selectedLinhVuc.value}/nghe-nghiep`);
    ngheNghieps.value = res.data;
  } catch (err) {
    console.error("Lỗi load ngành nghề:", err);
  }
}

async function loadChuyenNganh() {
  form.value.chuyenNganhIds = [];
  searchChuyenNganh.value = "";

  if (!selectedNghe.value) return;

  try {
    const res = await api.get(`/Admin/nghe-nghiep/${selectedNghe.value}/chuyen-nganh`);
    chuyenNganhs.value = res.data;
  } catch (err) {
    console.error("Lỗi load chuyên ngành:", err);
  }
}

function toggleChuyenNganh(id) {
  const ids = form.value.chuyenNganhIds;
  if (ids.includes(id)) {
    form.value.chuyenNganhIds = ids.filter(x => x !== id);
  } else {
    form.value.chuyenNganhIds.push(id);
  }
}

const searchLinhVuc = ref("");
const showLinhVuc = ref(false);

const filteredLinhVuc = computed(() =>
  linhVucs.value.filter(x =>
    (x.tenLinhVuc || "").toLowerCase().includes(searchLinhVuc.value.toLowerCase())
  )
);

function selectLinhVuc(lv) {
  searchLinhVuc.value = lv.tenLinhVuc;
  selectedLinhVuc.value = lv.id;
  showLinhVuc.value = false;
  loadNgheNghiep();
}

function closeLinhVuc() {
  setTimeout(() => (showLinhVuc.value = false), 150);
}

const searchNghe = ref("");
const showNghe = ref(false);

const filteredNghe = computed(() =>
  ngheNghieps.value.filter(x =>
    (x.tenNghe || "").toLowerCase().includes(searchNghe.value.toLowerCase())
  )
);

function selectNghe(n) {
  searchNghe.value = n.tenNghe;
  selectedNghe.value = n.id;
  showNghe.value = false;
  loadChuyenNganh();
}

function closeNghe() {
  setTimeout(() => (showNghe.value = false), 150);
}

const searchChuyenNganh = ref("");

const filteredChuyenNganh = computed(() =>
  chuyenNganhs.value.filter(x =>
    (x.tenChuyenNganh || "").toLowerCase().includes(searchChuyenNganh.value.toLowerCase())
  )
);

const loaiCongViecs = ref([]);
const capBacs = ref([]);
const kinhNghiems = ref([]);
const tinhThanhs = ref([]);

async function loadDropdowns() {
  try {
    loaiCongViecs.value = (await api.get("/Admin/loai-cong-viec")).data;
    capBacs.value = (await api.get("/Admin/cap-bac")).data;

    try {
      kinhNghiems.value = (await api.get("/Admin/muc-kinh-nghiem")).data;
    } catch {
      kinhNghiems.value = [];
    }

    tinhThanhs.value = (await api.get("/DiaChi/tinh-thanh")).data;
  } catch (err) {
    console.error(err);
    toast.error("Không thể tải danh sách!");
  }
}

function filteredTinhThanhs(query) {
  const q = (query || "").toLowerCase().trim();
  if (!q) return tinhThanhs.value;
  return tinhThanhs.value.filter(t =>
    (t.tenTinh || "").toLowerCase().includes(q)
  );
}

function chonTinhThanh(kv, tinh) {
  kv.tinhThanhId = tinh.id;
  kv._tinhSearch = tinh.tenTinh;
  kv.showTinhDropdown = false;
}

function closeTinhDropdown(kv) {
  setTimeout(() => {
    kv.showTinhDropdown = false;
  }, 150);
}

async function dangTin() {
  try {
    if (!form.value.hanNopHoSo) {
      toast.error("❌ Vui lòng chọn hạn nộp hồ sơ!");
      return;
    }

    const ngay = new Date(form.value.hanNopHoSo);
    if (isNaN(ngay.getTime())) {
      toast.error("❌ Ngày không hợp lệ!");
      return;
    }

    const payload = {
      ...form.value,
      khuVucs: form.value.khuVucs.map(kv => ({
        tinhThanhId: Number(kv.tinhThanhId) || 0,
        diaChiCuThe: kv.diaChiCuThe
      })),
      hanNopHoSo: ngay.toISOString()
    };

    await api.post("/CongViec/dang-tin", payload, {
      headers: { Authorization: `Bearer ${auth.token}` }
    });

    toast.success("🎉 Đăng tin thành công!");
    router.push("/nha-tuyen-dung/tin-tuyen-dung");

  } catch (err) {
    console.error(err);
    toast.error("❌ Dữ liệu không hợp lệ!");
  }
}

function themKhuVuc() {
  form.value.khuVucs.push({
    tinhThanhId: 0,
    diaChiCuThe: "",
    _tinhSearch: "",
    showTinhDropdown: false
  });
}

function xoaKhuVuc(index) {
  form.value.khuVucs.splice(index, 1);
}

onMounted(() => {
  loadLinhVuc();
  loadDropdowns();
});
</script>


<style scoped>
.section-title {
  @apply text-xl font-bold text-blue-700 mb-4;
}
.label {
  @apply font-medium mb-1 block;
}
.input {
  @apply w-full border border-gray-300 rounded-lg p-3 text-sm focus:ring-2 focus:ring-blue-500;
}

.help-text {
  @apply text-xs text-gray-500 mb-2;
}

.cn-card {
  @apply p-4 border rounded-xl cursor-pointer bg-white relative hover:border-blue-400 transition;
}
.cn-active {
  @apply border-blue-600 bg-blue-50;
}
.check-icon {
  @apply absolute top-2 right-2 w-5 h-5 bg-blue-600 text-white flex items-center justify-center rounded-full text-xs;
}

.btn-blue {
  @apply bg-blue-700 hover:bg-blue-800 text-white py-2 px-4 rounded-lg font-semibold transition;
}
.btn-gray {
  @apply bg-gray-200 hover:bg-gray-300 text-gray-700 py-2 px-4 rounded-lg transition;
}
.btn-add {
  @apply px-3 py-1 bg-blue-100 text-blue-600 rounded-md hover:bg-blue-200;
}
.btn-remove {
  @apply px-3 bg-red-100 text-red-500 rounded-md hover:bg-red-200;
}

.sidebar-card {
  @apply bg-white border shadow-sm rounded-xl p-4;
}

.editor-wrapper {
  border: 1px solid #d1d5db;
  border-radius: 12px;
  background: #ffffff;
  overflow: hidden;
  margin-top: 0.25rem;
}
:deep(.quill-editor) {
  border: none !important;
}
:deep(.quill-editor .ql-toolbar) {
  border: none;
  border-bottom: 1px solid #e2e8f0;
  padding: 12px;
}
:deep(.quill-editor .ql-container) {
  border: none;
  min-height: 300px !important;
}
:deep(.quill-editor .ql-editor) {
  min-height: 160px !important;
  padding: 20px;
  font-size: 15px;
  line-height: 1.7;
}

.tinh-dropdown {
  @apply absolute z-20 mt-1 max-h-60 w-full bg-white border border-gray-200 rounded-lg shadow;
}
.tinh-option {
  @apply px-3 py-2 text-sm cursor-pointer hover:bg-blue-50;
}

.tinh-dropdown {
  position: absolute;
  top: 100%;
  left: 0;
  right: 0;
  margin-top: 4px;
  max-height: 220px;
  overflow-y: auto; 
  background: #ffffff;
  border: 1px solid #e5e7eb;
  border-radius: 0.75rem;
  box-shadow: 0 10px 25px rgba(15, 23, 42, 0.08);
  z-index: 30;
}

.tinh-option {
  padding: 8px 12px;
  font-size: 14px;
  line-height: 1.4;
  cursor: pointer;
  color: #111827; 
}

.tinh-option:hover {
  background-color: #eff6ff;
}

.dropdown-box {
  position: absolute;
  top: 100%;
  left: 0;
  right: 0;
  z-index: 40;
  max-height: 220px;
  overflow-y: auto;
  background: white;
  border: 1px solid #e5e7eb;
  border-radius: 12px;
  box-shadow: 0 8px 20px rgba(0,0,0,0.07);
  margin-top: 4px;
}

.dropdown-item {
  padding: 10px 14px;
  cursor: pointer;
  font-size: 14px;
}

.dropdown-item:hover {
  background: #eff6ff;
}

.dropdown-empty {
  padding: 10px 14px;
  font-size: 13px;
  color: #9ca3af;
}

</style>
