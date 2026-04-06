<template>
  <div class="p-6">
  <div class="flex items-center justify-between mb-6">
    <h1 class="text-2xl font-extrabold text-gray-800 flex items-center gap-2">
      💼 Danh sách công việc
    </h1>
  </div>
    <div class="flex gap-3 mb-6">
      <button
        @click="activeTab = 'cho-duyet'"
        :class="tabBtn(activeTab === 'cho-duyet')"
      >
        ⏳ Chờ duyệt
      </button>

      <button
        @click="activeTab = 'da-duyet'"
        :class="tabBtn(activeTab === 'da-duyet')"
      >
        ✔️ Đã duyệt
      </button>
    </div>

    <div class="bg-white rounded-xl border shadow overflow-hidden">
      <div v-if="loading" class="p-6 text-center text-gray-500">
        ⏳ Đang tải dữ liệu...
      </div>

      <table v-else-if="jobs.length" class="min-w-full text-sm">
        <thead class="bg-gray-100 text-gray-700 font-semibold text-xs">
          <tr>
            <th class="px-4 py-3 text-left">Công việc</th>
            <th class="px-4 py-3 text-center">Số lượng</th>
            <th class="px-4 py-3">Lương</th>
            <th class="px-4 py-3">Địa điểm</th>
            <th class="px-4 py-3">Hạn nộp</th>
            <th class="px-4 py-3 text-center">Trạng thái</th>
            <th class="px-4 py-3 text-center">Thao tác</th>
          </tr>
        </thead>

        <tbody>
          <tr
            v-for="job in jobs"
            :key="job.id"
            class="border-b hover:bg-gray-50 transition"
          >

            <td class="px-4 py-3 flex items-center gap-3">
              <img :src="getLogo(job.logoUrl)" class="h-10 w-10 rounded-lg border object-cover" />
              <div>
                <p class="font-semibold text-blue-600">{{ job.tieuDe }}</p>
                <p class="text-gray-500 text-xs">🏢 {{ job.tenCongTy }}</p>

                <p v-if="job.linhVucs?.length" class="text-gray-400 text-xs">
                  🌐 {{ job.linhVucs.join(', ') }}
                </p>

                <p class="text-gray-400 text-xs">
                  {{ job.tenLoaiCongViec }} • {{ job.tenCapBac }} • {{ job.tenKinhNghiem }}
                </p>
              </div>
            </td>

            <td class="px-4 py-3 text-center font-semibold">{{ job.soLuongTuyen }}</td>

            <td class="px-4 py-3">{{ formatLuong(job) }}</td>

            <td class="px-4 py-3">
              <span
                v-for="kv in job.khuVucLamViec"
                :key="kv"
                class="px-2 py-1 bg-blue-50 text-blue-700 text-xs rounded-md mr-1"
              >
                {{ kv }}
              </span>
              <span v-if="!job.khuVucLamViec?.length" class="text-gray-300 text-xs">—</span>
            </td>

            <td class="px-4 py-3">{{ formatDate(job.hanNopHoSo) }}</td>

            <td class="px-4 py-3 text-center">
              <span
                :class="job.daDuyet ? badgeGreen : badgeYellow"
                class="px-2 py-1 rounded-full text-xs font-semibold"
              >
                {{ job.daDuyet ? "Đã duyệt" : "Chờ duyệt" }}
              </span>
            </td>

            <td class="px-4 py-3 text-center">
              <button
                @click="xemChiTiet(job.id)"
                class="px-3 py-1 rounded-lg bg-blue-600 text-white hover:bg-blue-700 text-xs"
              >
                👁 Xem
              </button>
            </td>
          </tr>
        </tbody>
      </table>

      <p v-else class="p-6 text-center text-gray-400">Không có công việc nào.</p>
    </div>

    <div v-if="showModal" class="modal-backdrop">
      <div class="modal-box max-w-4xl max-h-[85vh] flex flex-col">

        <div class="pb-3 border-b">
          <h2 class="text-2xl font-extrabold text-indigo-700">{{ jobDetail.tieuDe }}</h2>
          <p class="text-gray-600">🏢 {{ jobDetail.tenCongTy }}</p>
        </div>

        <div class="flex-1 overflow-y-auto pr-2 mt-4 space-y-6">

          <div class="grid grid-cols-2 gap-x-8 gap-y-3 text-gray-700 text-sm">

            <p><b>Cấp bậc:</b> {{ jobDetail.tenCapBac }}</p>

            <p><b>Loại công việc:</b> {{ jobDetail.tenLoaiCongViec }}</p>
            <p><b>Kinh nghiệm:</b> {{ jobDetail.tenKinhNghiem }}</p>

            <p><b>Số lượng:</b> {{ jobDetail.soLuongTuyen }}</p>
            <p><b>Giới tính:</b> {{ jobDetail.gioiTinh }}</p>

            <p><b>Mức lương:</b> {{ formatLuong(jobDetail) }}</p>

            <p><b>Ngày đăng:</b> {{ formatDate(jobDetail.ngayDang) }}</p>
            <p><b>Hạn nộp:</b> {{ formatDate(jobDetail.hanNopHoSo) }}</p>
          </div>

          <div class="space-y-3">

            <!-- <div v-if="jobDetail.khuVucLamViec?.length">
              <h4 class="font-semibold text-gray-700">📍 Khu vực</h4>
              <span
                v-for="kv in jobDetail.khuVucLamViec"
                :key="kv"
                class="px-2 py-1 bg-blue-50 text-blue-700 rounded-md text-xs mr-1"
              >
                {{ kv }}
              </span>
            </div> -->

            <div v-if="jobDetail.khuVucs?.length">
              <h4 class="font-semibold text-gray-700">📌 Địa điểm cụ thể</h4>

              <div class="space-y-2">
                <div
                  v-for="(kv, index) in jobDetail.khuVucs"
                  :key="index"
                  class="p-3 bg-gray-50 border rounded-lg"
                >
                  <p><b>Địa chỉ:</b> {{ kv.diaChiCuThe }}</p>
                </div>
              </div>
            </div>


            <div v-if="jobDetail.linhVucs?.length">
              <h4 class="font-semibold text-gray-700">🌐 Lĩnh vực</h4>
              <span
                v-for="x in jobDetail.linhVucs"
                :key="x"
                class="px-2 py-1 bg-purple-50 text-purple-700 rounded-md text-xs mr-1"
              >
                {{ x }}
              </span>
            </div>

            <div v-if="jobDetail.nganhNghieps?.length">
              <h4 class="font-semibold text-gray-700">🧩 Ngành nghề</h4>
              <span
                v-for="x in jobDetail.nganhNghieps"
                :key="x"
                class="px-2 py-1 bg-orange-50 text-orange-700 rounded-md text-xs mr-1"
              >
                {{ x }}
              </span>
            </div>

            <div v-if="jobDetail.chuyenNganhs?.length">
              <h4 class="font-semibold text-gray-700">🎯 Chuyên ngành</h4>
              <span
                v-for="x in jobDetail.chuyenNganhs"
                :key="x"
                class="px-2 py-1 bg-green-50 text-green-700 rounded-md text-xs mr-1"
              >
                {{ x }}
              </span>
            </div>

          </div>
>
          <div class="space-y-6">
            <div v-if="jobDetail.moTaCongViec">
              <h3 class="font-semibold text-indigo-600">Mô tả công việc</h3>
              <div class="prose max-w-none text-gray-700" v-html="jobDetail.moTaCongViec"></div>
            </div>

            <div v-if="jobDetail.yeuCauUngVien">
              <h3 class="font-semibold text-indigo-600">Yêu cầu ứng viên</h3>
              <p class="text-gray-700 whitespace-pre-wrap">{{ jobDetail.yeuCauUngVien }}</p>
            </div>

            <div v-if="jobDetail.quyenLoiUngVien">
              <h3 class="font-semibold text-indigo-600">Quyền lợi</h3>
              <div class="prose max-w-none text-gray-700" v-html="jobDetail.quyenLoiUngVien"></div>
            </div>

            <div v-if="jobDetail.lyDo1 || jobDetail.lyDo2 || jobDetail.lyDo3">
              <h3 class="font-semibold text-indigo-600">Lý do nên ứng tuyển</h3>
              <ul class="list-disc ml-5 text-gray-700">
                <li v-if="jobDetail.lyDo1">{{ jobDetail.lyDo1 }}</li>
                <li v-if="jobDetail.lyDo2">{{ jobDetail.lyDo2 }}</li>
                <li v-if="jobDetail.lyDo3">{{ jobDetail.lyDo3 }}</li>
              </ul>
            </div>

            <div>
              <h3 class="font-semibold text-indigo-600">Thông tin liên hệ</h3>
              <p><b>Email:</b> {{ jobDetail.emailLienHe || "—" }}</p>
              <p><b>Điện thoại:</b> {{ jobDetail.soDienThoaiLienHe || "—" }}</p>
              <p><b>Website:</b> {{ jobDetail.website || "—" }}</p>
              <p><b>Chức vụ:</b> {{ jobDetail.chucVuNguoiLienHe || "—" }}</p>
            </div>
          </div>

        </div>

        <div class="flex justify-end gap-3 pt-4 border-t">
          <button class="btn-gray" @click="showModal = false">Đóng</button>

          <button v-if="!jobDetail.daDuyet" class="btn-green" @click="duyetCongViec(jobDetail.id)">
            ✔ Duyệt
          </button>

          <button v-if="!jobDetail.daDuyet" class="btn-yellow" @click="openTuChoiModal()">
            🚫 Từ chối
          </button>
        </div>

      </div>
    </div>

    <div v-if="showTuChoiModal" class="modal-backdrop">
      <div class="modal-box max-w-md">
        <h2 class="text-lg font-semibold text-red-600 mb-3">🚫 Từ chối công việc</h2>

        <textarea
          v-model="lyDo"
          rows="3"
          class="w-full border rounded-xl p-3 bg-gray-50 focus:ring-2 focus:ring-red-300"
          placeholder="Nhập lý do từ chối..."
        ></textarea>

        <div class="flex justify-end gap-3 mt-4">
          <button class="btn-gray" @click="showTuChoiModal = false">Hủy</button>
          <button class="btn-yellow" @click="tuChoiCongViec(jobDetail.id)">Từ chối</button>
        </div>
      </div>
    </div>

  </div>
</template>

<script setup>
import { ref, watch, onMounted } from "vue";
import api from "@/api/axios";
import { useAuthStore } from "@/store/auth";

const auth = useAuthStore();

const jobs = ref([]);
const loading = ref(false);
const activeTab = ref("cho-duyet");

const showModal = ref(false);
const showTuChoiModal = ref(false);
const jobDetail = ref({});
const lyDo = ref("");

const baseURL = "https://localhost:7248";

const tabBtn = (active) =>
  `px-4 py-2 rounded-lg font-medium ${
    active ? "bg-blue-600 text-white" : "bg-gray-200 text-gray-700 hover:bg-gray-300"
  }`;

const formatDate = (d) => (d ? new Date(d).toLocaleDateString("vi-VN") : "—");

const getLogo = (path) => {
  if (!path) return "/no-logo.png";
  if (path.startsWith("http")) return path;
  return baseURL + path;
};

const formatLuong = (job) => {
  if (!job) return "—";
  if (job.kieuLuong === "ThoaThuan") return "Thoả thuận";

  if (job.kieuLuong === "TuDen")
    return `${job.luongTu?.toLocaleString()} - ${job.luongDen?.toLocaleString()} ${job.loaiTienTe}`;

  if (job.luongTu && !job.luongDen) return `${job.luongTu.toLocaleString()} ${job.loaiTienTe}`;

  return "—";
};

const fetchJobs = async () => {
  loading.value = true;
  const endpoint =
    activeTab.value === "cho-duyet"
      ? "DoanhNghiep/cong-viec-cho-duyet"
      : "DoanhNghiep/cong-viec-da-duyet";

  try {
    const res = await api.get(endpoint, {
      headers: { Authorization: `Bearer ${auth.token}` },
    });
    jobs.value = res.data?.duLieu ?? [];
  } finally {
    loading.value = false;
  }
};

const xemChiTiet = async (id) => {
  try {
    const res = await api.get(`CongViec/${id}`, {
      headers: { Authorization: `Bearer ${auth.token}` },
    });

    jobDetail.value = res.data;
    showModal.value = true;
  } catch {
    alert("Không tải được chi tiết công việc");
  }
};

const getTinhThanhName = (id) => {
  const t = tinhThanhs.value.find(x => x.id === id);
  return t ? t.tenTinh : `Mã ${id}`;
};


const duyetCongViec = async (id) => {
  try {
    await api.put(
      "/DoanhNghiep/duyet-cong-viec",
      {
        congViecId: id,
        dongY: true,
        ghiChu: "",
      },
      {
        headers: { Authorization: `Bearer ${auth.token}` },
      }
    );

    alert("✔ Công việc đã được duyệt!");
    showModal.value = false;
    fetchJobs();
  } catch {
    alert("❌ Không duyệt được công việc!");
  }
};

const openTuChoiModal = () => {
  lyDo.value = "";
  showTuChoiModal.value = true;
};

const tuChoiCongViec = async (id) => {
  try {
    await api.put(
      "/DoanhNghiep/tu-choi-cong-viec",
      {
        congViecId: id,
        lyDo: lyDo.value,
      },
      {
        headers: { Authorization: `Bearer ${auth.token}` },
      }
    );

    alert("🚫 Đã từ chối công việc!");
    showTuChoiModal.value = false;
    showModal.value = false;
    fetchJobs();
  } catch {
    alert("❌ Không từ chối được công việc!");
  }
};
const showAddHrModal = ref(false);
const hrLoading = ref(false);
const hrError = ref("");

const hrForm = ref({
  hoTen: "",
  email: "",
  soDienThoai: "",
  gioiTinh: "Khac",
  chucVu: "",
  matKhau: "",
  nhapLaiMatKhau: "",
});

const resetHrForm = () => {
  hrForm.value = {
    hoTen: "",
    email: "",
    soDienThoai: "",
    gioiTinh: "Khac",
    chucVu: "",
    matKhau: "",
    nhapLaiMatKhau: "",
  };
  hrError.value = "";
};

const submitAddHR = async () => {
  hrError.value = "";
  hrLoading.value = true;

  try {
    await api.post(
      "/DoanhNghiep/them-hr",
      {
        hoTen: hrForm.value.hoTen,
        email: hrForm.value.email,
        soDienThoai: hrForm.value.soDienThoai,
        matKhau: hrForm.value.matKhau,
      },
      {
        headers: {
          Authorization: `Bearer ${auth.token}`,
        },
      }
    );

    alert("✔ Tạo HR thành công!");

    resetHrForm();
    showAddHrModal.value = false;
  } catch (err) {
    console.error(err);
    const msg =
      err.response?.data?.thongBao ||
      err.response?.data?.message ||
      "Không thể tạo HR mới!";
    hrError.value = msg;
  } finally {
    hrLoading.value = false;
  }
};


watch(activeTab, fetchJobs);
onMounted(fetchJobs);
</script>

<style scoped>
.modal-backdrop {
  @apply fixed inset-0 bg-black/40 backdrop-blur-sm flex items-center justify-center z-50;
}
.modal-box {
  @apply bg-white p-6 rounded-2xl shadow-xl border border-gray-200;
}
.btn-gray {
  @apply px-4 py-2 rounded-xl bg-gray-200 hover:bg-gray-300 transition;
}
.btn-green {
  @apply px-4 py-2 rounded-xl bg-green-600 text-white hover:bg-green-700 transition;
}
.btn-yellow {
  @apply px-4 py-2 rounded-xl bg-yellow-600 text-white hover:bg-yellow-700 transition;
}
.modal-box {
  @apply bg-white p-6 rounded-2xl shadow-xl border border-gray-200;
}

.modal-box::-webkit-scrollbar {
  width: 8px;
}

.modal-box::-webkit-scrollbar-thumb {
  background: #bfbfbf;
  border-radius: 6px;
}
.input {
  @apply px-3 py-2 border rounded-lg focus:ring-2 focus:ring-blue-400 outline-none;
}
.label {
  @apply text-sm font-medium text-gray-700 mb-1 block;
}

.spinner {
  @apply animate-spin h-4 w-4 border-2 border-white border-t-transparent rounded-full inline-block;
}


</style>
