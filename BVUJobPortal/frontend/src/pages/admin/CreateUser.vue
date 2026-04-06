<template>
  <div class="min-h-screen bg-gray-50 p-6">
    <div class="max-w-3xl mx-auto bg-white shadow rounded-xl p-6">
      <h1 class="text-xl font-bold text-gray-800 mb-6">➕ Tạo tài khoản mới</h1>

      <form @submit.prevent="createUser" class="space-y-4">
        <div>
          <label class="block text-sm mb-1 text-gray-600">Vai trò</label>
          <select v-model="form.vaiTro" class="w-full border px-3 py-2 rounded-lg" required>
            <option value="">-- Chọn vai trò --</option>
            <option value="SinhVien">Sinh viên</option>
            <option value="NhaTuyenDung">Nhà tuyển dụng</option>
            <option value="DoanhNghiep">Doanh nghiệp</option>
            <option value="Admin">Admin</option>
            <option value="SuperAdmin">Super Admin</option>
          </select>
        </div>

        <template v-if="form.vaiTro && form.vaiTro !== 'DoanhNghiep'">
          <div>
            <label class="block text-sm mb-1 text-gray-600">Họ tên</label>
            <input v-model="form.hoTen" type="text" class="w-full border px-3 py-2 rounded-lg" required />
          </div>

          <div>
            <label class="block text-sm mb-1 text-gray-600">Email đăng nhập</label>
            <input v-model="form.email" type="email" class="w-full border px-3 py-2 rounded-lg" required />
          </div>

          <div>
            <label class="block text-sm mb-1 text-gray-600">Số điện thoại</label>
            <input v-model="form.sdt" type="text" class="w-full border px-3 py-2 rounded-lg" />
          </div>

          <div>
            <label class="block text-sm mb-1 text-gray-600">Mật khẩu</label>
            <div class="flex items-center gap-2">
              <input v-model="form.matKhau" type="text" class="w-full border px-3 py-2 rounded-lg" required />
              <button
                type="button"
                class="bg-gray-100 hover:bg-gray-200 border rounded-lg py-2 px-3 text-sm"
                @click="form.matKhau = generatePassword(); copyToClipboard(form.matKhau)"
                title="Tạo và sao chép mật khẩu"
              >
                🔁📋
              </button>
            </div>
          </div>

          <div>
            <label class="block text-sm mb-1 text-gray-600">Xác nhận mật khẩu</label>
            <input
              v-model="form.xacNhanMatKhau"
              type="password"
              class="w-full border px-3 py-2 rounded-lg"
              required
            />
          </div>
        </template>

        <template v-if="form.vaiTro === 'DoanhNghiep'">
          <h2 class="text-lg font-bold text-indigo-700 mt-4 mb-3 flex items-center gap-2">🏢 Thông tin công ty</h2>

          <div class="space-y-4">
            <div>
              <label class="block text-sm text-gray-600 mb-1">Tên công ty</label>
              <input v-model="company.tenCongTy" type="text" class="w-full border px-3 py-2 rounded-lg" required />
            </div>

            <div>
              <label class="block text-sm text-gray-600 mb-1">Giới thiệu</label>
              <textarea
                v-model="company.gioiThieu"
                rows="3"
                placeholder="Mô tả ngắn về công ty..."
                class="w-full border px-3 py-2 rounded-lg"
              ></textarea>
            </div>

            <div>
              <label class="block text-sm text-gray-600 mb-1">Địa chỉ làm việc</label>
              <input
                v-model="company.diaChiLamViec"
                type="text"
                placeholder="VD: Tầng 2, Toà nhà Giao Châu, 102A Lê Hồng Phong..."
                class="w-full border px-3 py-2 rounded-lg"
              />
            </div>

            <div class="relative">
              <label class="block text-sm text-gray-600 mb-1">Tỉnh/Thành phố</label>
              <input
                v-model="company.tinhThanhPho"
                @focus="showSuggestions = true"
                @blur="hideSuggestions"
                @input="filterTinhThanh"
                placeholder="Nhập tỉnh/thành phố..."
                class="w-full border px-3 py-2 rounded-lg"
              />
              <ul
                v-if="showSuggestions && filteredTinhThanh.length > 0"
                class="absolute z-50 bg-white border rounded-lg mt-1 w-full max-h-48 overflow-y-auto shadow"
              >
                <li
                  v-for="(item, index) in filteredTinhThanh"
                  :key="index"
                  @mousedown.prevent="selectTinhThanh(item)"
                  class="px-3 py-2 hover:bg-indigo-100 cursor-pointer text-gray-700 text-sm"
                >
                  {{ item }}
                </li>
              </ul>
            </div>

            <div class="grid md:grid-cols-2 gap-4">
              <div>
                <label class="block text-sm text-gray-600 mb-1">Email liên hệ (công ty)</label>
                <input
                  v-model="company.emailLienHe"
                  type="email"
                  placeholder="info@truetech.com.vn"
                  class="w-full border px-3 py-2 rounded-lg"
                />
              </div>
              <div>
                <label class="block text-sm text-gray-600 mb-1">SĐT liên hệ (công ty)</label>
                <input
                  v-model="company.soDienThoaiLienHe"
                  type="text"
                  placeholder="+84 (24) 3776 5087"
                  class="w-full border px-3 py-2 rounded-lg"
                />
              </div>
            </div>

            <div>
              <label class="block text-sm text-gray-600 mb-1">Website</label>
              <input
                v-model="company.website"
                type="url"
                placeholder="https://truetech.com.vn"
                class="w-full border px-3 py-2 rounded-lg"
              />
            </div>
          </div>

          <h2 class="text-lg font-bold text-indigo-700 mt-8 mb-3 flex items-center gap-2">👤 Người đại diện</h2>

          <div class="space-y-4">
            <div>
              <label class="block text-sm text-gray-600 mb-1">Họ tên người đại diện</label>
              <input
                v-model="company.hoTenNguoiDaiDien"
                type="text"
                placeholder="Nguyễn Văn Minh"
                class="w-full border px-3 py-2 rounded-lg"
                required
              />
            </div>

            <div>
              <label class="block text-sm text-gray-600 mb-1">Email đăng nhập</label>
              <input
                v-model="company.emailNguoiDaiDien"
                type="email"
                placeholder="minh.nguyen@truetech.com.vn"
                class="w-full border px-3 py-2 rounded-lg"
                required
              />
            </div>

            <div>
              <label class="block text-sm text-gray-600 mb-1">SĐT người đại diện</label>
              <input
                v-model="company.sdtNguoiDaiDien"
                type="text"
                placeholder="0905123456"
                class="w-full border px-3 py-2 rounded-lg"
              />
            </div>

            <div>
              <label class="block text-sm mb-1 text-gray-600">Mật khẩu đăng nhập</label>
              <div class="flex items-center gap-2">
                <input v-model="company.matKhau" type="text" class="w-full border px-3 py-2 rounded-lg" required />
                <button
                  type="button"
                  class="bg-gray-100 hover:bg-gray-200 border rounded-lg py-2 px-3 text-sm"
                  @click="company.matKhau = generatePassword(); copyToClipboard(company.matKhau)"
                >
                  🔁📋
                </button>
              </div>
            </div>
          </div>
        </template>

        <div class="flex justify-end gap-2 mt-6">
          <router-link to="/admin/users" class="px-4 py-2 bg-gray-300 rounded-lg hover:bg-gray-400">Hủy</router-link>
          <button type="submit" class="px-4 py-2 bg-indigo-600 text-white rounded-lg hover:bg-indigo-700">
            💾 Lưu
          </button>
        </div>
      </form>
    </div>
  </div>
</template>

<script setup>
import { ref, watch, onMounted } from "vue";
import api from "@/api/axios";
import { useAuthStore } from "@/store/auth";
import { useToast } from "vue-toastification";
import { useRouter } from "vue-router";

const auth = useAuthStore();
const toast = useToast();
const router = useRouter();

const form = ref({
  hoTen: "",
  email: "",
  sdt: "",
  vaiTro: "",
  matKhau: "",
  xacNhanMatKhau: ""
});

const company = ref({
  tenCongTy: "",
  gioiThieu: "",
  diaChiLamViec: "",
  tinhThanhPho: "",
  website: "",
  emailLienHe: "",
  soDienThoaiLienHe: "",
  hoTenNguoiDaiDien: "",
  emailNguoiDaiDien: "",
  sdtNguoiDaiDien: "",
  matKhau: ""
});

const tinhThanhList = ref([]);
const filteredTinhThanh = ref([]);
const showSuggestions = ref(false);
const loadingTinh = ref(false);

const loadTinhThanh = async () => {
  try {
    loadingTinh.value = true;
    const res = await api.get("/DiaChi/tinh-thanh");
    tinhThanhList.value = res.data.map(t => t.tenTinh);

    filteredTinhThanh.value = [...tinhThanhList.value];
  } catch (err) {
    console.error("❌ Lỗi tải tỉnh/thành:", err);
  } finally {
    loadingTinh.value = false;
  }
};

const filterTinhThanh = () => {
  const keyword = company.value.tinhThanhPho.toLowerCase().trim();
  filteredTinhThanh.value = tinhThanhList.value.filter(t =>
    t.toLowerCase().includes(keyword)
  );
};

const selectTinhThanh = (val) => {
  company.value.tinhThanhPho = val;
  showSuggestions.value = false;
};

const hideSuggestions = () => {
  setTimeout(() => (showSuggestions.value = false), 120);
};

onMounted(() => loadTinhThanh());

const generatePassword = () => {
  const chars =
    "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*";
  return Array.from({ length: 10 }, () =>
    chars[Math.floor(Math.random() * chars.length)]
  ).join("");
};

const copyToClipboard = async (text) => {
  try {
    await navigator.clipboard.writeText(text);
    toast.success("📋 Mật khẩu đã được sao chép!");
  } catch {
    toast.error("❌ Không thể sao chép mật khẩu!");
  }
};

watch(
  () => form.value.vaiTro,
  (role) => {
    if (role === "DoanhNghiep" && !company.value.matKhau) {
      company.value.matKhau = generatePassword();
    }
  }
);
const createUser = async () => {
  try {
    let endpoint = "";
    let payload = {};

    if (form.value.vaiTro === "DoanhNghiep") {
      endpoint = "/Admin/tao-tai-khoan-cong-ty";
      payload = company.value;
    } else {
      if (form.value.matKhau !== form.value.xacNhanMatKhau) {
        toast.error("⚠️ Mật khẩu xác nhận không khớp!");
        return;
      }

      payload = form.value;

      if (form.value.vaiTro === "Admin") endpoint = "/Admin/tao-admin";
      else if (form.value.vaiTro === "SuperAdmin")
        endpoint = "/Admin/tao-superadmin";
      else if (form.value.vaiTro === "SinhVien")
        endpoint = "/Admin/tao-sinhvien";
      else if (form.value.vaiTro === "NhaTuyenDung")
        endpoint = "/Admin/tao-nhatuyendung";
    }

    const res = await api.post(endpoint, payload, {
      headers: { Authorization: `Bearer ${auth.token}` }
    });

    if (form.value.vaiTro === "DoanhNghiep" && res.data?.thanhCong) {
      toast.success(`🏢 Đã tạo công ty ${res.data.tenCongTy} (${res.data.maCongTy})
📧 Email đăng nhập: ${res.data.emailDangNhap}
🔑 Mật khẩu mặc định: ${res.data.matKhauMacDinh}`);
    } else {
      toast.success("✅ Tạo tài khoản thành công!");
    }

    router.push("/admin/users");
  } catch (err) {
    console.error(err);
    toast.error(err.response?.data?.thongBao || "❌ Không thể tạo tài khoản!");
  }
};
</script>

