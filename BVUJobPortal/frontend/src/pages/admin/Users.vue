<template>
  <div class="min-h-screen bg-gray-50 p-6">
      <div class="flex justify-between items-center mb-6 border-b pb-3">
    <h1 class="text-2xl font-bold text-gray-800 flex items-center gap-2">
      👤 Quản lý tài khoản
    </h1>
    <router-link
      v-if="auth.user?.vaiTro==='SuperAdmin'"
      to="/admin/create-user"
      class="px-4 py-2 bg-gradient-to-r from-green-500 to-emerald-600 text-white rounded-lg shadow hover:opacity-90 transition"
    >
      ➕ Tạo tài khoản
    </router-link>
  </div>

    <div class="bg-white shadow rounded-xl p-4 mb-6 grid md:grid-cols-6 gap-4 items-end">
      <div>
        <label class="block text-sm text-gray-600 mb-1">Vai trò</label>
        <select v-model="role" class="px-3 py-2 border rounded-lg bg-white w-full">
          <option value="">Tất cả</option>
          <option value="SinhVien">Sinh viên</option>
          <option value="NhaTuyenDung">Nhà tuyển dụng</option>
          <option value="DoanhNghiep">Doanh nghiệp</option>
          <option value="Admin">Admin</option>
          <option value="SuperAdmin">Super Admin</option>
        </select>
      </div>
      <div>
        <label class="block text-sm text-gray-600 mb-1">Trạng thái</label>
        <select v-model="status" class="px-3 py-2 border rounded-lg bg-white w-full">
          <option value="">Tất cả</option>
          <option value="hoatdong">Hoạt động</option>
          <option value="khoa">Đã khóa</option>
        </select>
      </div>
      <div>
        <label class="block text-sm text-gray-600 mb-1">Từ ngày</label>
        <input v-model="fromDate" type="date" class="px-3 py-2 border rounded-lg bg-white w-full" />
      </div>
      <div>
        <label class="block text-sm text-gray-600 mb-1">Đến ngày</label>
        <input v-model="toDate" type="date" class="px-3 py-2 border rounded-lg bg-white w-full" />
      </div>
      <div class="md:col-span-2">
        <label class="block text-sm text-gray-600 mb-1">Tìm theo tên/email</label>
        <input
          v-model="keyword"
          type="text"
          placeholder="Nhập từ khóa..."
          class="px-3 py-2 border rounded-lg w-full"
        />
      </div>
      <div class="md:col-span-6 flex gap-2 justify-end">
        <button
          @click="resetFilter"
          class="px-4 py-2 bg-gray-300 text-gray-700 rounded-lg hover:bg-gray-400"
        >
          Reset
        </button>
      </div>
    </div>

    <div class="hidden md:block bg-white shadow rounded-xl overflow-hidden">
      <table class="min-w-full border-collapse" v-if="!loading && users.length > 0">
        <thead>
          <tr class="bg-indigo-600 text-white text-left text-sm">
            <th class="px-4 py-3 w-16">ID</th>
            <th class="px-4 py-3">Mã</th>
            <th class="px-4 py-3">Họ tên</th>
            <th class="px-4 py-3">Email</th>
            <th class="px-4 py-3">Vai trò</th>
            <th class="px-4 py-3">SĐT</th>
            <th class="px-4 py-3">Ngày tạo</th>
            <th class="px-4 py-3">Trạng thái</th>
            <th class="px-4 py-3 text-center w-40">Thao tác</th>
          </tr>
        </thead>
        <tbody>
          <tr v-for="u in users" :key="u.id" class="border-b hover:bg-gray-50 text-sm">
            <td class="px-4 py-3 font-mono text-gray-600">{{ u.id }}</td>
            <td class="px-4 py-3 font-semibold text-indigo-700">{{ u.ma }}</td>
            <td class="px-4 py-3 font-medium" v-html="highlight(u.hoTen, keyword)"></td>
            <td class="px-4 py-3 text-gray-600" v-html="highlight(u.email, keyword)"></td>
            <td class="px-4 py-3">
              <span
                class="px-2 py-1 rounded-full text-xs font-semibold"
                :class="{
                  'bg-blue-100 text-blue-700': u.vaiTro==='SinhVien',
                  'bg-green-100 text-green-700': u.vaiTro==='NhaTuyenDung',
                  'bg-orange-100 text-orange-700': u.vaiTro==='DoanhNghiep',
                  'bg-red-100 text-red-700': u.vaiTro==='Admin',
                  'bg-purple-100 text-purple-700': u.vaiTro==='SuperAdmin'
                }"
              >
                {{ u.vaiTro }}
              </span>
            </td>
            <td class="px-4 py-3">{{ u.soLienHe || u.sdt || "—" }}</td>
            <td class="px-4 py-3 text-gray-500">{{ new Date(u.ngayTao).toLocaleDateString("vi-VN") }}</td>
            <td class="px-4 py-3">
              <span
                class="flex items-center gap-1 px-2 py-1 rounded-full text-xs font-semibold w-fit"
                :class="{
                  'bg-green-100 text-green-700': !u.biKhoa,
                  'bg-red-100 text-red-700': u.biKhoa
                }"
              >
                {{ u.biKhoa ? "🔒 Đã khóa" : " Hoạt động" }}

              </span>
            </td>
            <td class="py-3 px-4 text-center">
              <button
                @click="openUserDetail(u)"
                class="px-3 py-1.5 bg-indigo-500 text-white rounded-lg hover:bg-indigo-600 text-xs"
              >
                👁 Xem
              </button>
            </td>
          </tr>
        </tbody>
      </table>

      <div v-if="loading" class="p-6 text-center text-gray-500">⏳ Đang tải dữ liệu...</div>
      <div v-if="!loading && users.length === 0" class="p-6 text-center text-gray-500">
        🚫 Không có tài khoản nào phù hợp với bộ lọc.
      </div>
    </div>

    <div v-if="!loading && users.length > 0" class="md:hidden space-y-4">
      <div
        v-for="u in users"
        :key="u.id"
        class="bg-white rounded-xl shadow p-4 border hover:shadow-md transition"
      >
        <div class="flex items-center gap-3 mb-3">
          <img
            :src="getAvatarUrl(u.avatarUrl)"
            class="w-12 h-12 rounded-full border"
            :class="getAvatarBorder(u.vaiTro)"
          />
          <div class="flex-1">
            <p class="font-semibold text-gray-800">{{ u.hoTen }}</p>
            <p class="text-sm text-gray-500">{{ u.email }}</p>
          </div>
          <button
            @click="openUserDetail(u)"
            class="px-2 py-1 bg-indigo-500 text-white rounded-lg text-sm hover:bg-indigo-600"
          >
            Xem
          </button>
        </div>
        <div class="grid grid-cols-2 gap-2 text-sm text-gray-600">
          <p><b>Mã:</b> {{ u.ma }}</p>
          <p><b>SĐT:</b> {{ u.sdt || '—' }}</p>
          <p><b>Vai trò:</b> {{ u.vaiTro }}</p>
          <p><b>Ngày tạo:</b> {{ new Date(u.ngayTao).toLocaleDateString('vi-VN') }}</p>
        </div>
        <div class="mt-2">
          <span
            class="inline-block px-2 py-1 rounded-full text-xs font-semibold"
            :class="{
              'bg-green-100 text-green-700': !u.biKhoa,
              'bg-red-100 text-red-700': u.biKhoa
            }"
          >
            {{ u.biKhoa ? '🔒 Đã khóa' : '✅ Hoạt động' }}
          </span>
        </div>
      </div>
    </div>

    <div v-if="loading" class="md:hidden p-6 text-center text-gray-500">⏳ Đang tải dữ liệu...</div>
    <div v-if="!loading && users.length === 0" class="md:hidden p-6 text-center text-gray-500">
      🚫 Không có tài khoản nào phù hợp.
    </div>

    <div v-if="!loading && totalPages > 1" class="flex justify-center items-center gap-2 mt-6 flex-wrap">
      <button @click="prevPage" :disabled="page===1" class="px-3 py-1 rounded bg-gray-200 disabled:opacity-50">←</button>
      <button
        v-for="p in totalPages"
        :key="p"
        @click="goToPage(p)"
        :class="['px-3 py-1 rounded', page===p ? 'bg-indigo-600 text-white':'bg-gray-200']"
      >
        {{ p }}
      </button>
      <button @click="nextPage" :disabled="page===totalPages" class="px-3 py-1 rounded bg-gray-200 disabled:opacity-50">→</button>
    </div>

    <div v-if="showDetailModal" class="fixed inset-0 bg-black/50 flex items-center justify-center z-50">
      <div
        class="bg-white rounded-2xl shadow-xl p-6 w-full max-w-5xl animate-fade-in overflow-y-auto"
      >
        <div class="flex justify-between items-center mb-4">
          <h2 class="text-xl font-bold text-gray-800 flex items-center gap-2">
            👤 Thông tin chi tiết tài khoản
          </h2>
          <button
            @click="showDetailModal = false"
            class="text-gray-600 hover:text-gray-900 text-2xl leading-none"
          >
            ×
          </button>
        </div>

        <div class="bg-gray-50 border rounded-lg p-4 text-sm mb-4 space-y-2">
          <div class="flex items-center gap-3 mb-3">
            <img
              :src="getAvatarUrl(selectedUser?.avatarUrl)"
              alt="Avatar"
              class="w-12 h-12 rounded-full object-cover border-2 shadow-sm"
              :class="getAvatarBorder(selectedUser?.vaiTro)"
            />
            <div>
              <p class="text-base font-semibold text-gray-800">{{ selectedUser?.hoTen }}</p>
              <p class="text-sm text-gray-500">{{ selectedUser?.email }}</p>
            </div>
          </div>

          <template v-if="selectedUser?.vaiTro === 'SinhVien'">
            <hr class="my-4" />
            <div class="bg-white border rounded-xl shadow-sm p-5">
              <h3 class="text-lg font-bold text-indigo-700 mb-3 flex items-center gap-2">
                🎓 Thông tin sinh viên
              </h3>
              <div class="grid md:grid-cols-2 gap-4 text-sm text-gray-700">
                <p><b>🆔 Mã tài khoản:</b> {{ selectedUser.ma }}</p>
                <p><b>📧 Email:</b> {{ selectedUser.email }}</p>
                <p><b>📱 SĐT:</b> {{ selectedUser.sdt || "—" }}</p>
                <p><b>🏫 Lớp học:</b> {{ selectedUser.lopHoc || "—" }}</p>
                <p><b>🎓 Khóa học:</b> {{ selectedUser.khoaHoc || "—" }}</p>
                <p>
                  <b>🔒 Trạng thái:</b>
                  <span
                    :class="selectedUser.biKhoa ? 'text-red-600 font-semibold' : 'text-green-600 font-semibold'"
                  >
                    {{ selectedUser.biKhoa ? 'Đã khóa' : 'Hoạt động' }}
                  </span>
                </p>
              </div>

              <div
                v-if="selectedUser.chiTietSinhVien"
                class="grid sm:grid-cols-2 gap-4 mt-3 text-sm"
              >
                <div
                  class="bg-indigo-50 border border-indigo-100 rounded-lg p-3 flex justify-between items-center"
                >
                  <span class="font-medium text-indigo-700">📄 Số lượng CV</span>
                  <span class="font-bold text-indigo-800 text-lg">
                    {{ selectedUser.chiTietSinhVien.soLuongCV ?? 0 }}
                  </span>
                </div>
                <div
                  class="bg-green-50 border border-green-100 rounded-lg p-3 flex justify-between items-center"
                >
                  <span class="font-medium text-green-700">📨 Đơn ứng tuyển</span>
                  <span class="font-bold text-green-800 text-lg">
                    {{ selectedUser.chiTietSinhVien.soLuongDonUngTuyen ?? 0 }}
                  </span>
                </div>
              </div>

              <p class="mt-4 text-sm text-gray-500">
                🗓️ Ngày tạo tài khoản:
                <b>{{ new Date(selectedUser.ngayTao).toLocaleDateString("vi-VN") }}</b>
              </p>
            </div>
          </template>

          <template v-else-if="selectedUser?.vaiTro === 'NhaTuyenDung'">
            <hr class="my-4" />
            <div class="bg-white border rounded-xl shadow-sm p-5">
              <h3 class="text-lg font-bold text-green-700 mb-3 flex items-center gap-2">
                🧑‍💼 Thông tin nhà tuyển dụng
              </h3>

              <div class="grid md:grid-cols-2 gap-4 text-sm text-gray-700">
                <p><b>🆔 Mã tài khoản:</b> {{ selectedUser.ma }}</p>
                <p><b>📧 Email:</b> {{ selectedUser.email }}</p>
                <p><b>📱 SĐT:</b> {{ selectedUser.sdt || "—" }}</p>
                <p><b>🔒 Trạng thái:</b>
                  <span
                    :class="selectedUser.biKhoa ? 'text-red-600 font-semibold' : 'text-green-600 font-semibold'"
                  >
                    {{ selectedUser.biKhoa ? 'Đã khóa' : 'Hoạt động' }}
                  </span>
                </p>
                <p><b>🗓️ Ngày tạo:</b> {{ new Date(selectedUser.ngayTao).toLocaleDateString('vi-VN') }}</p>
              </div>

              <hr class="my-3" />

              <div class="mt-2 text-sm">
                <h4 class="font-semibold text-indigo-700 mb-2">🏢 Thông tin công ty</h4>
                <template v-if="selectedUser.congTy">
                  <p><b>🏷️ Tên công ty:</b> {{ selectedUser.congTy.tenCongTy }}</p>
                  <p><b>📍 Địa chỉ:</b> {{ selectedUser.congTy.diaChiLamViec }}</p>
                  <p><b>📧 Email liên hệ:</b> {{ selectedUser.congTy.emailLienHe }}</p>
                  <p><b>📞 SĐT liên hệ:</b> {{ selectedUser.congTy.soDienThoaiLienHe }}</p>
                </template>
                <template v-else>
                  <p class="text-gray-500 italic">⚠️ Chưa được gán vào công ty nào.</p>
                </template>
              </div>
            </div>
          </template>

          <template v-else-if="selectedUser?.vaiTro === 'DoanhNghiep' && selectedUser?.congTy">
            <div class="bg-white border rounded-2xl shadow-md overflow-hidden max-w-4xl mx-auto">
              <div class="p-6 grid md:grid-cols-2 gap-6 text-sm text-gray-700">
                <div class="space-y-2 pr-4 border-gray-200 md:border-r">
                  <h4 class="text-lg font-semibold text-indigo-700 mb-3 flex items-center gap-1">
                    🏢 Thông tin công ty
                  </h4>
                  <p><b>🏷️ Tên công ty:</b> {{ selectedUser.congTy.tenCongTy }}</p>
                  <p><b>📍 Địa chỉ làm việc:</b> {{ selectedUser.congTy.diaChiLamViec }}</p>
                  <p><b>🏙️ Tỉnh/Thành phố:</b> {{ selectedUser.congTy.tinhThanhPho }}</p>
                  <p><b>📧 Email liên hệ:</b> {{ selectedUser.congTy.emailLienHe }}</p>
                  <p><b>📞 SĐT liên hệ:</b> {{ selectedUser.congTy.soDienThoaiLienHe }}</p>
                </div>
                <div class="space-y-2 pl-4">
                  <h4 class="text-lg font-semibold text-green-700 mb-3 flex items-center gap-1">
                    👤 Người đại diện
                  </h4>
                  <p><b>Họ tên:</b> {{ selectedUser.hoTen }}</p>
                  <p><b>Email:</b> {{ selectedUser.email }}</p>
                  <p><b>Điện thoại:</b> {{ selectedUser.sdt || "—" }}</p>
                  <p>
                    <b>Trạng thái:</b>
                    <span
                      :class="selectedUser.biKhoa ? 'text-red-600 font-semibold' : 'text-green-600 font-semibold'"
                    >
                      {{ selectedUser.biKhoa ? '🔒 Đã khóa' : '✅ Hoạt động' }}
                    </span>
                  </p>
                </div>
              </div>
              <div v-if="selectedUser.congTy.gioiThieu" class="border-t p-6 bg-gray-50 text-sm">
                <h4 class="text-lg font-semibold text-gray-800 mb-2">📄 Giới thiệu doanh nghiệp</h4>
                <p class="leading-relaxed whitespace-pre-line text-gray-700">
                  {{ selectedUser.congTy.gioiThieu }}
                </p>
              </div>
            </div>
          </template>

          <template v-else-if="selectedUser?.vaiTro === 'Admin' || selectedUser?.vaiTro === 'SuperAdmin'">
            <hr class="my-4" />
            <div class="bg-white border rounded-xl shadow-sm p-5">
              <h3
                class="text-lg font-bold mb-3 flex items-center gap-2"
                :class="selectedUser.vaiTro === 'SuperAdmin' ? 'text-purple-700' : 'text-red-700'"
              >
                {{ selectedUser.vaiTro === 'SuperAdmin' ? '👑 Thông tin Super Admin' : '🛠️ Thông tin Admin' }}
              </h3>

              <div class="grid md:grid-cols-2 gap-4 text-sm text-gray-700">
                <p><b>🆔 Mã tài khoản:</b> {{ selectedUser.ma }}</p>
                <p><b>📧 Email:</b> {{ selectedUser.email }}</p>
                <p><b>📞 Số điện thoại:</b> {{ selectedUser.sdt || "—" }}</p>
                <p><b>🎭 Vai trò:</b> {{ selectedUser.vaiTro }}</p>
                <p>
                  <b>🔒 Trạng thái:</b>
                  <span
                    :class="selectedUser.biKhoa ? 'text-red-600 font-semibold' : 'text-green-600 font-semibold'"
                  >
                    {{ selectedUser.biKhoa ? 'Đã khóa' : 'Hoạt động' }}
                  </span>
                </p>
                <p><b>🗓️ Ngày tạo:</b> {{ new Date(selectedUser.ngayTao).toLocaleDateString('vi-VN') }}</p>
              </div>

              <p v-if="selectedUser.lyDoKhoa" class="mt-3 text-sm text-red-600 italic">
                ⚠️ Lý do khóa: {{ selectedUser.lyDoKhoa }}
              </p>
            </div>
          </template>
        </div>
->
        <div class="flex justify-end gap-3 mt-4">
          <button
            class="px-4 py-2 rounded-lg bg-gray-300 text-gray-800 hover:bg-gray-400"
            @click="showDetailModal = false"
          >
            Đóng
          </button>

          <template v-if="auth.user?.vaiTro === 'Admin' || auth.user?.vaiTro === 'SuperAdmin'">
            <button
              v-if="!selectedUser?.biKhoa"
              @click="openConfirmModal(selectedUser, 'ban')"
              class="px-4 py-2 rounded-lg bg-orange-600 text-white hover:bg-orange-700"
            >
              🔒 Khóa tài khoản
            </button>
            <button
              v-if="selectedUser?.biKhoa"
              @click="confirmUnban(selectedUser)"
              class="px-4 py-2 rounded-lg bg-green-600 text-white hover:bg-green-700"
            >
              🔓 Mở khóa
            </button>
            <button
              v-if="auth.user?.vaiTro === 'SuperAdmin'"
              @click="openConfirmModal(selectedUser, 'delete')"
              class="px-4 py-2 rounded-lg bg-red-600 text-white hover:bg-red-700"
            >
              🗑 Xóa tài khoản
            </button>
          </template>
        </div>
      </div>
    </div>
    <div
      v-if="showConfirmModal"
      class="fixed inset-0 bg-black/50 flex items-center justify-center z-[60]"
    >
      <div
        class="bg-white rounded-2xl shadow-xl p-6 w-full max-w-md animate-fade-in"
      >
        <h2 class="text-lg font-bold mb-4 text-gray-800 flex items-center gap-2">
          <span v-if="actionType === 'delete'">🗑️ Xác nhận xóa tài khoản</span>
          <span v-else-if="actionType === 'ban'">🔒 Xác nhận khóa tài khoản</span>
        </h2>

        <p class="text-sm text-gray-700 mb-4 leading-relaxed">
          <template v-if="actionType === 'delete'">
            Bạn có chắc chắn muốn <b class="text-red-600">xóa vĩnh viễn</b> tài khoản
            <b>{{ selectedUser?.hoTen }}</b> ({{ selectedUser?.email }}) không?<br />
            Hành động này không thể hoàn tác.
          </template>

          <template v-else-if="actionType === 'ban'">
            Bạn có chắc chắn muốn <b class="text-orange-600">khóa</b> tài khoản
            <b>{{ selectedUser?.hoTen }}</b> ({{ selectedUser?.email }}) không?
          </template>
        </p>

        <div v-if="actionType === 'ban'" class="mb-4">
          <label class="block text-sm font-medium mb-1">Lý do khóa</label>
          <textarea
            v-model="banReason"
            rows="2"
            placeholder="Nhập lý do khóa tài khoản..."
            class="w-full border rounded-lg p-2 text-sm"
          ></textarea>
        </div>

        <div class="flex justify-end gap-3">
          <button
            class="px-4 py-2 rounded-lg bg-gray-300 text-gray-800 hover:bg-gray-400"
            @click="showConfirmModal = false"
          >
            Hủy
          </button>
          <button
            v-if="actionType === 'delete'"
            @click="confirmDelete(selectedUser)"
            class="px-4 py-2 rounded-lg bg-red-600 text-white hover:bg-red-700"
          >
            Xóa
          </button>
          <button
            v-else-if="actionType === 'ban'"
            @click="confirmBan(selectedUser)"
            class="px-4 py-2 rounded-lg bg-orange-600 text-white hover:bg-orange-700"
          >
            Khóa
          </button>
        </div>
      </div>
    </div>


  </div>
</template>

<script setup>
import { ref, onMounted, watch } from "vue";
import api from "@/api/axios";
import { useAuthStore } from "@/store/auth";
import { useToast } from "vue-toastification";
import { LockClosedIcon, LockOpenIcon, TrashIcon } from "@heroicons/vue/24/solid";

const auth = useAuthStore();
const users = ref([]);
const toast = useToast();

const baseURL = "https://localhost:7248";

const getAvatarUrl = (path) => {
  if (!path) return "https://cdn-icons-png.flaticon.com/512/847/847969.png";

  path = path.replaceAll("/uploads/avatars//uploads/avatars/", "/uploads/avatars/");

  if (path.startsWith("http")) {
    if (path.includes("https://localhost:7248/https://localhost:7248/")) {
      path = path.replace("https://localhost:7248/https://localhost:7248/", "https://localhost:7248/");
    }
    return path;
  }

  return `${baseURL}${path.startsWith("/") ? "" : "/"}${path}`;
};

const getAvatarBorder = (role) => {
  switch (role) {
    case "SinhVien": return "border-blue-400";
    case "NhaTuyenDung": return "border-green-400";
    case "DoanhNghiep": return "border-orange-400";
    case "Admin": return "border-red-400";
    case "SuperAdmin": return "border-purple-400";
    default: return "border-gray-300";
  }
};

const page = ref(1), pageSize = ref(10), total = ref(0), totalPages = ref(1);
const sortBy = ref("NgayTao"), order = ref("desc");
const loading = ref(false);
const role = ref(""), status = ref(""), keyword = ref(""), fromDate = ref(""), toDate = ref("");

let keywordTimeout = null;

const fetchUsers = async () => {
  loading.value = true;
  try {
    const endpoint = keyword.value ? "/Admin/nguoi-dung/tim-kiem" : "/Admin/nguoi-dung";
    const res = await api.get(endpoint, {
      headers: { Authorization: `Bearer ${auth.token}` },
      params: {
        trang: page.value,
        soLuongMoiTrang: pageSize.value,
        sapXepTheo: sortBy.value,
        thuTu: order.value,
        tuKhoa: keyword.value || null,
        vaiTro: role.value || null,
        tuNgay: fromDate.value || null,
        denNgay: toDate.value || null,
        biKhoa: status.value==="khoa" ? true : status.value==="hoatdong" ? false : null,
      },
    });
    users.value = res.data.duLieu || res.data;
    total.value = res.data.tongSo || res.data.length || 0;
    totalPages.value = Math.ceil(total.value / pageSize.value);
  } catch (err) {
    console.error("Lỗi tải user:", err);
    toast.error("Không thể tải danh sách tài khoản!");
  } finally {
    loading.value = false;
  }
};



watch([role, status, fromDate, toDate], () => {
  page.value = 1;
  fetchUsers();
});

watch(keyword, () => {
  clearTimeout(keywordTimeout);
  keywordTimeout = setTimeout(() => {
    page.value = 1;
    fetchUsers();
  }, 500);
});

const resetFilter = () => {
  role.value = "";
  status.value = "";
  keyword.value = "";
  fromDate.value = "";
  toDate.value = "";
  page.value = 1;
  fetchUsers();
};

const goToPage = (p) => { page.value = p; fetchUsers(); };
const nextPage = () => { if (page.value < totalPages.value) { page.value++; fetchUsers(); } };
const prevPage = () => { if (page.value > 1) { page.value--; fetchUsers(); } };

const highlight = (text, keyword) => {
  if (!keyword || !text) return text;
  const regex = new RegExp(`(${keyword})`, "gi");
  return text.replace(regex, `<mark class='bg-yellow-300'>$1</mark>`);
};

const showConfirmModal = ref(false);
const showDetailModal = ref(false);
const selectedUser = ref(null);
const actionType = ref("");
const banReason = ref("");

const openUserDetail = async (user) => {
  try {
    const res = await api.get(`/Admin/nguoi-dung/${user.id}`, {
      headers: { Authorization: `Bearer ${auth.token}` },
    });
    selectedUser.value = res.data;
    showDetailModal.value = true;
  } catch (err) {
    console.error("Lỗi tải chi tiết:", err);
    toast.error("Không thể tải chi tiết tài khoản!");
  }
};

const openConfirmModal = async (user, type) => {
  try {

    const res = await api.get(`/Admin/nguoi-dung/${user.id}`, {
      headers: { Authorization: `Bearer ${auth.token}` },
    });
    selectedUser.value = res.data;
    actionType.value = type;
    showConfirmModal.value = true;
  } catch (err) {
    console.error("Lỗi tải chi tiết tài khoản:", err);
    toast.error("Không thể tải chi tiết tài khoản!");
  }
};

const confirmDelete = async (user) => {
  try {
    showConfirmModal.value = false;
    showDetailModal.value = false;
    if (user.vaiTro === "DoanhNghiep") await deleteCompany(user);
    else await deleteUser(user);
  } catch (err) {
    console.error("Lỗi xóa:", err);
    toast.error("Không thể xóa tài khoản!");
  }
};

const confirmBan = async (user) => {
  try {
    await api.put(
      `/Admin/nguoi-dung/${user.id}/khoa`,
      { lyDo: banReason.value || "Không ghi rõ lý do" },
      { headers: { Authorization: `Bearer ${auth.token}` } }
    );
    toast.success("🔒 Đã khóa tài khoản thành công!");
    showConfirmModal.value = false;
    showDetailModal.value = false;
    fetchUsers();
    console.error("Lỗi khóa tài khoản:", err);
    toast.error("Không thể khóa tài khoản!");
  } finally {
    banReason.value = "";
  }
};

const confirmUnban = async (user) => {
  loading.value = true;
  try {
    await api.put(`/Admin/nguoi-dung/${user.id}/mo-khoa`, null, {
      headers: { Authorization: `Bearer ${auth.token}` },
    });
    toast.success("✅ Đã mở khóa tài khoản!");
    if (selectedUser.value?.id === user.id) {
      selectedUser.value.biKhoa = false;
      selectedUser.value.lyDoKhoa = null;
    }
    fetchUsers();
  } catch (err) {
    console.error(err);
    toast.error("Không thể mở khóa tài khoản!");
  } finally {
    loading.value = false;
  }
};

const deleteCompany = async (user) => {
  const congTyId = user.congTyId || user.congTy?.id || user.id;
  try {
    await api.delete(`/Admin/cong-ty/${congTyId}`, {
      headers: { Authorization: `Bearer ${auth.token}` },
    });
    toast.success("🗑️ Đã xóa công ty thành công!");
    fetchUsers();
  } catch (err) {
    console.error(err);
    toast.error("Xóa công ty thất bại!");
  }
};

const deleteUser = async (user) => {
  try {
    await api.delete(`/Admin/nguoi-dung/${user.id}`, {
      headers: { Authorization: `Bearer ${auth.token}` },
    });
    toast.success("🗑️ Đã xóa tài khoản thành công!");
    fetchUsers();
  } catch (err) {
    console.error(err);
    toast.error("Xóa tài khoản thất bại!");
  }
};

onMounted(fetchUsers);
</script>

<style scoped>
@keyframes fade-in {
  from { opacity: 0; transform: scale(0.95); }
  to { opacity: 1; transform: scale(1); }
}
.animate-fade-in {
  animation: fade-in 0.2s ease-out;
}
.icon-btn {
  display: flex;
  align-items: center;
  justify-content: center;
  padding: 6px;
  border-radius: 8px;
  color: white;
  transition: 0.2s;
}

@media (max-width: 768px) {
  .min-h-screen {
    padding: 1rem !important;
  }
  h1 {
    font-size: 1.25rem;
    flex-direction: column;
    align-items: flex-start !important;
    gap: 0.5rem;
  }
  .grid.md\\:grid-cols-6 {
    grid-template-columns: 1fr !important;
    gap: 1rem;
  }
  .max-w-5xl {
    width: 95%;
    max-height: 90vh;
    overflow-y: auto;
  }
  .icon-btn {
    padding: 4px;
    font-size: 0.9rem;
  }
}

</style>
