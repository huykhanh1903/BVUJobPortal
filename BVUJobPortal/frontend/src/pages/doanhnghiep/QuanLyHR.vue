<template>
  <div class="min-h-screen bg-gray-100 p-6">
    <h1 class="text-3xl font-bold text-gray-800 mb-6">👥 Quản lý Nhân sự (HR)</h1>

    <div class="flex justify-end mb-4">
      <button
        @click="showCreateModal = true"
        class="px-5 py-2 bg-green-600 text-white rounded-xl shadow hover:bg-green-700 transition"
      >
        ➕ Tạo HR mới
      </button>
    </div>

    <div class="bg-white shadow-md rounded-2xl p-5 mb-6 border border-gray-100">
      <div class="w-full">
        <label class="block text-sm text-gray-600 mb-2 font-medium">
          Tìm theo tên / email
        </label>

        <div class="relative">
          <span class="absolute left-3 top-1/2 -translate-y-1/2 text-gray-400">
            🔍
          </span>

          <input
            v-model="keyword"
            type="text"
            placeholder="Nhập từ khóa..."
            class="pl-10 pr-4 py-2 w-full border rounded-xl shadow-sm 
                  focus:ring-2 focus:ring-indigo-300 focus:border-indigo-500 
                  transition bg-gray-50"
          />
        </div>
      </div>
    </div>

    <div class="flex gap-4 mb-6">
      <button @click="tab = 'cho'"
        :class="tabBtn('cho')">
        ⏳ Chờ xác thực ({{ hrChoXacThuc.length }})
      </button>

      <button @click="tab = 'da'"
        :class="tabBtn('da')">
        ✔ Đã xác thực ({{ hrDaXacThuc.length }})
      </button>
    </div>

    <div class="bg-white shadow-xl rounded-2xl overflow-hidden border border-gray-100">
      <table v-if="!loading && currentList.length > 0" class="min-w-full border-collapse">
        <thead class="bg-indigo-600/95 text-white text-sm">
          <tr>
            <th class="px-4 py-3">Họ tên</th>
            <th class="px-4 py-3">Email</th>
            <th class="px-4 py-3">Số điện thoại</th>
            <th class="px-4 py-3">Công ty</th>
            <th class="px-4 py-3 text-center">Trạng thái</th>
            <th class="px-4 py-3 text-center w-52">Thao tác</th>
          </tr>
        </thead>

        <tbody>
          <tr v-for="hr in currentList" :key="hr.id"
            class="border-b hover:bg-gray-50 text-sm transition">
            <td class="px-4 py-3 font-medium text-gray-800">{{ hr.hoTen }}</td>
            <td class="px-4 py-3">{{ hr.email }}</td>
            <td class="px-4 py-3">{{ hr.sdt }}</td>
            <td class="px-4 py-3">{{ hr.tenCongTy || "—" }}</td>

            <td class="px-4 py-3 text-center">
              <span
                class="px-3 py-1 rounded-full text-xs font-semibold shadow"
                :class="hr.daDuocCongTyXacThuc
                  ? 'bg-green-100 text-green-700'
                  : 'bg-yellow-100 text-yellow-700'"
              >
                {{ hr.daDuocCongTyXacThuc ? "Đã xác thực" : "Chờ xác thực" }}
              </span>
            </td>

            <td class="px-3 py-2 text-center flex justify-center gap-2">
              <button @click="xemChiTiet(hr)" class="icon-btn bg-blue-500 hover:bg-blue-600">👁️</button>

              <button v-if="!hr.daDuocCongTyXacThuc"
                @click="openXacThucModal(hr)" class="icon-btn bg-green-600 hover:bg-green-700">
                ✔
              </button>

              <button v-if="hr.daDuocCongTyXacThuc"
                @click="openHuyModal(hr)" class="icon-btn bg-yellow-500 hover:bg-yellow-600">
                🚫
              </button>
            </td>
          </tr>
        </tbody>
      </table>

      <div v-if="loading" class="p-6 text-center text-gray-500 animate-pulse">
        ⏳ Đang tải dữ liệu...
      </div>

      <div v-if="!loading && currentList.length === 0" class="p-6 text-center text-gray-400">
        🚫 Không có HR nào.
      </div>
    </div>

    <div v-if="showDetailModal" class="modal-backdrop">
      <div class="modal-box">
        <div class="flex justify-center">
          <img
            :src="selectedHR.avatarUrl ? baseURL + selectedHR.avatarUrl : '/default-avatar.png'"
            class="w-28 h-28 rounded-full border object-cover shadow"
          />
        </div>

        <h2 class="text-xl font-bold text-indigo-700 text-center mt-3">
          {{ selectedHR.hoTen }}
        </h2>

        <div class="space-y-1 mt-4 text-gray-700">
          <p><b>Email:</b> {{ selectedHR.email }}</p>
          <p><b>Số điện thoại:</b> {{ selectedHR.sdt }}</p>
          <p><b>Công ty:</b> {{ selectedHR.tenCongTy }}</p>
          <p><b>Ngày tạo:</b> {{ formatDate(selectedHR.ngayTao) }}</p>

          <p v-if="selectedHR.lyDoXinXacThuc">
            <b>Lý do:</b> {{ selectedHR.lyDoXinXacThuc }}
          </p>

          <template v-if="selectedHR.daDuocCongTyXacThuc">
            <p><b>Ngày xác thực:</b> {{ formatDate(selectedHR.ngayXacThuc) }}</p>
            <p><b>Người xác thực:</b> {{ selectedHR.nguoiXacThuc }}</p>
          </template>
        </div>

        <div class="flex justify-end mt-5">
          <button @click="showDetailModal=false" class="btn-gray">Đóng</button>
        </div>
      </div>
    </div>

    <div v-if="showXacThucModal" class="modal-backdrop">
      <div class="modal-box">
        <h3 class="modal-title">✔ Xác thực HR</h3>

        <p class="text-gray-700 mb-1">
          Xác thực <b>{{ selectedHR.hoTen }}</b>?
        </p>

        <textarea v-model="lyDo" rows="3"
          class="w-full border rounded-xl p-3 bg-gray-50 focus:ring-2 focus:ring-indigo-300"
          placeholder="Nhập lý do xác thực..."></textarea>

        <div class="flex justify-end gap-3 mt-4">
          <button @click="showXacThucModal=false" class="btn-gray">Hủy</button>
          <button @click="xacThucHR" class="btn-green">Xác thực</button>
        </div>
      </div>
    </div>

    <div v-if="showHuyModal" class="modal-backdrop">
      <div class="modal-box">
        <h3 class="modal-title text-red-600">🚫 Hủy xác thực</h3>

        <p class="text-gray-700 mb-4">
          Bạn muốn hủy xác thực <b>{{ selectedHR.hoTen }}</b>?
        </p>

        <div class="flex justify-end gap-3">
          <button @click="showHuyModal=false" class="btn-gray">Hủy</button>
          <button @click="huyXacThucHR" class="btn-yellow">Đồng ý</button>
        </div>
      </div>
    </div>

    <div v-if="showCreateModal" class="modal-backdrop">
      <div class="modal-box max-w-md">
        <h3 class="modal-title">➕ Tạo tài khoản HR</h3>

        <div class="space-y-3">
          <div>
            <label class="block text-sm text-gray-700 mb-1">Họ và tên *</label>
            <input v-model="createForm.hoTen" class="px-4 py-2 border rounded-xl w-full focus:ring-2 focus:ring-indigo-300" />
          </div>

          <div>
            <label class="block text-sm text-gray-700 mb-1">Email đăng nhập *</label>
            <input v-model="createForm.email" type="email" class="px-4 py-2 border rounded-xl w-full focus:ring-2 focus:ring-indigo-300" />
          </div>

          <div>
            <label class="block text-sm text-gray-700 mb-1">Số điện thoại</label>
            <input v-model="createForm.sdt" class="px-4 py-2 border rounded-xl w-full focus:ring-2 focus:ring-indigo-300" />
          </div>

          <div>
            <label class="block text-sm text-gray-700 mb-1">Mật khẩu *</label>
            <div class="relative">
            <input
              :type="showPass ? 'text' : 'password'"
              v-model="createForm.matKhau"
              class="px-4 py-2 border rounded-xl w-full focus:ring-2 focus:ring-indigo-300 pr-10"
            />

            <button
              type="button"
              class="absolute right-3 top-1/2 -translate-y-1/2 text-gray-500 hover:text-gray-700"
              @click="showPass = !showPass"
            >
              {{ showPass ? "👁️" : "👁️‍🗨" }}
            </button>
            </div>
          </div>
          <p v-if="createError" class="text-red-600 text-sm">{{ createError }}</p>
        </div>

        <div class="flex justify-end gap-3 mt-5">
          <button @click="showCreateModal=false" class="btn-gray">Hủy</button>

          <button @click="submitCreateHR" class="btn-green">
            ✔ Tạo HR
          </button>
        </div>
      </div>
    </div>
  </div>
</template>

<script setup>
import { ref, computed, onMounted } from "vue";
import { useToast } from "vue-toastification";
import api from "@/api/axios";

const toast = useToast();

const baseURL = "https://localhost:7248";

const formatDate = (d) => {
  if (!d) return "—";
  return new Date(d).toLocaleString("vi-VN");
};

const tab = ref("cho");
const hrChoXacThuc = ref([]);
const hrDaXacThuc = ref([]);
const loading = ref(false);
const keyword = ref("");
const showDetailModal = ref(false);
const showXacThucModal = ref(false);
const showHuyModal = ref(false);

const selectedHR = ref(null);
const lyDo = ref("");

const currentList = computed(() => {
  const k = keyword.value.trim().toLowerCase();

  const src =
    tab.value === "cho" ? hrChoXacThuc.value : hrDaXacThuc.value;

  if (!k) return src;

  return src.filter((x) => {
    const hoTen = x.hoTen || "";
    const email = x.email || "";
    const sdt = x.sdt || "";
    const cty = x.tenCongTy || "";

    return (
      fuzzyMatch(hoTen, k) ||
      fuzzyMatch(email, k) ||
      fuzzyMatch(sdt, k) ||
      fuzzyMatch(cty, k)
    );
  });
});

const showPass = ref(false);

const tabBtn = (t) =>
  `px-4 py-2 rounded-lg border ${tab.value === t
    ? "bg-indigo-600 text-white"
    : "bg-white text-gray-700 border-gray-300 hover:bg-gray-100"
  }`;

const fetchHR = async () => {
  loading.value = true;
  try {
    const [cho, da] = await Promise.all([
      api.get("/DoanhNghiep/hr-cho-xac-thuc"),
      api.get("/DoanhNghiep/hr-da-xac-thuc"),
    ]);

    hrChoXacThuc.value = cho.data?.duLieu ?? [];
    hrDaXacThuc.value = da.data?.duLieu ?? [];

  } catch (err) {
    toast.error("Không thể tải danh sách HR!");
  } finally {
    loading.value = false;
  }
};

const removeVietnamese = (str) => {
  return str
    .normalize("NFD")
    .replace(/[\u0300-\u036f]/g, "")
    .replace(/đ/g, "d")
    .replace(/Đ/g, "D")
    .toLowerCase();
};
const fuzzyMatch = (text, keyword) => {
  text = removeVietnamese(text);
  keyword = removeVietnamese(keyword);

  let i = 0, j = 0;

  while (i < text.length && j < keyword.length) {
    if (text[i] === keyword[j]) {
      j++;
    }
    i++;
  }

  return j === keyword.length;
};



onMounted(fetchHR);

const applyFilter = () => fetchHR();
const resetFilter = () => {
  keyword.value = "";
  fetchHR();
};

const xemChiTiet = async (hr) => {
  try {
    const res = await api.get(`/DoanhNghiep/hr/${hr.id}`);

    selectedHR.value = res.data.duLieu;
    showDetailModal.value = true;
  } catch {
    toast.error("Không thể tải chi tiết HR!");
  }
};

const openXacThucModal = (hr) => {
  selectedHR.value = hr;
  lyDo.value = "";
  showXacThucModal.value = true;
};

const xacThucHR = async () => {
  await api.put("/DoanhNghiep/xac-thuc-hr", {
    hrId: selectedHR.value.id,
    xacThuc: true,
    lyDo: lyDo.value,
  });

  toast.success("✔ Đã xác thực HR!");
  showXacThucModal.value = false;
  fetchHR();
};

const openHuyModal = (hr) => {
  selectedHR.value = hr;
  showHuyModal.value = true;
};

const huyXacThucHR = async () => {
  await api.put("/DoanhNghiep/hr/huy-xac-thuc", {
    hrId: selectedHR.value.id,
    xoaKhoiCongTy: true,
  });

  toast.info("🚫 Đã hủy xác thực HR");
  showHuyModal.value = false;
  fetchHR();
};
const showCreateModal = ref(false);

const createForm = ref({
  hoTen: "",
  email: "",
  sdt: "",
  matKhau: "",
});

const createError = ref("");

const submitCreateHR = async () => {
  createError.value = "";

  if (!createForm.value.hoTen || !createForm.value.email || !createForm.value.matKhau) {
    createError.value = "Vui lòng nhập đầy đủ thông tin bắt buộc.";
    return;
  }

  try {
    await api.post("/DoanhNghiep/them-hr", createForm.value);

    toast.success("✔ Tạo HR thành công!");

    createForm.value = { hoTen: "", email: "", sdt: "", matKhau: "" };

    showCreateModal.value = false;

    fetchHR();

  } catch (err) {
    createError.value =
      err.response?.data?.message ||
      "Không thể tạo HR!";
  }
};

</script>

<style scoped>
.icon-btn {
  @apply p-2 w-9 h-9 flex justify-center items-center rounded-full text-white shadow transition;
}
.modal-backdrop {
  @apply fixed inset-0 bg-black/40 backdrop-blur-sm flex items-center justify-center z-50;
}

.modal-box {
  @apply bg-white w-full max-w-md p-6 rounded-2xl shadow-xl border border-gray-200;
}

.modal-title {
  @apply text-lg font-bold mb-3 text-gray-800;
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
</style>

