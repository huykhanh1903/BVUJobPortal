<template>
  <div class="min-h-screen bg-gray-50 p-6">
    <h1 class="text-2xl font-bold text-gray-800 mb-6">🏢 Danh sách công ty</h1>

    <div class="bg-white shadow rounded-xl p-4 mb-6 grid md:grid-cols-3 gap-4 items-end">
      <div class="md:col-span-2">
        <label class="block text-sm text-gray-600 mb-1">🔍 Tìm kiếm</label>
        <input
          v-model="keyword"
          type="text"
          placeholder="Nhập tên công ty..."
          class="px-3 py-2 border rounded-lg w-full"
        />
      </div>
      <div class="flex gap-2 justify-end">
        <button
          @click="applyFilter"
          class="px-4 py-2 bg-indigo-600 text-white rounded-lg hover:bg-indigo-700"
        >
          Lọc
        </button>
        <button
          @click="resetFilter"
          class="px-4 py-2 bg-gray-300 text-gray-700 rounded-lg hover:bg-gray-400"
        >
          Reset
        </button>
      </div>
    </div>

    <div class="bg-white shadow rounded-xl overflow-hidden">
      <table class="min-w-full border-collapse" v-if="!loading && companies.length > 0">
        <thead>
          <tr class="bg-indigo-600 text-white text-left text-sm">
            <th class="px-4 py-3 w-16">ID</th>
            <th class="px-4 py-3">Tên công ty</th>
            <th class="px-4 py-3">Tỉnh/TP</th>
            <th class="px-4 py-3">Email liên hệ</th>
            <th class="px-4 py-3">SĐT liên hệ</th>
            <th class="px-4 py-3 text-center w-32">Thao tác</th>
          </tr>
        </thead>
        <tbody>
          <tr
            v-for="c in companies"
            :key="c.id"
            class="border-b hover:bg-gray-50 text-sm"
          >
            <td class="px-4 py-3 font-mono text-gray-600">{{ c.id }}</td>
            <td class="px-4 py-3 font-semibold text-indigo-700">{{ c.tenCongTy }}</td>
            <td class="px-4 py-3">{{ c.tinhThanhPho || "—" }}</td>
            <td class="px-4 py-3">{{ c.emailLienHe || "—" }}</td>
            <td class="px-4 py-3">{{ c.soDienThoaiLienHe || "—" }}</td>
            <td class="px-3 py-2 text-center">
              <button
                @click="openDetailModal(c)"
                class="p-2 bg-indigo-500 text-white rounded hover:bg-indigo-600"
                title="Xem thông tin chi tiết"
              >
                👁️ Xem
              </button>
            </td>
          </tr>
        </tbody>
      </table>

      <div v-if="loading" class="p-6 text-center text-gray-500">⏳ Đang tải dữ liệu...</div>
      <div
        v-if="!loading && companies.length === 0"
        class="p-6 text-center text-gray-500"
      >
        🚫 Không có công ty nào phù hợp.
      </div>
    </div>

    <div
      v-if="showDetailModal"
      class="fixed inset-0 bg-black/50 flex items-center justify-center z-50"
    >
      <div
        class="bg-white rounded-2xl shadow-xl p-6 w-full max-w-3xl overflow-y-auto max-h-[90vh]"
      >
        <div class="flex justify-between items-center mb-4">
          <h2 class="text-xl font-bold text-gray-800 flex items-center gap-2">
            🏢 Thông tin chi tiết
          </h2>
          <button
            @click="closeDetailModal"
            class="text-2xl text-gray-500 hover:text-gray-800"
          >
            ×
          </button>
        </div>

        <div class="grid sm:grid-cols-2 gap-4 text-gray-700 text-sm">
          <div class="sm:col-span-2 flex items-center gap-3 mb-2">
            <img
              v-if="selectedCompany?.logoUrl"
              :src="getLogoUrl(selectedCompany.logoUrl)"
              alt="Logo"
              class="h-16 w-16 object-contain border rounded-lg shadow-sm"
            />
            <div>
              <h3 class="text-lg font-bold text-indigo-700">
                {{ selectedCompany.tenCongTy }}
              </h3>
              <p class="text-xs text-gray-500">Mã: {{ selectedCompany.ma }}</p>
            </div>
          </div>

          <p><b>🏙️ Tỉnh/Thành phố:</b> {{ selectedCompany.tinhThanhPho }}</p>
          <p><b>📍 Địa chỉ:</b> {{ selectedCompany.diaChiLamViec }}</p>
          <p><b>📧 Email liên hệ:</b> {{ selectedCompany.emailLienHe }}</p>
          <p><b>📞 SĐT liên hệ:</b> {{ selectedCompany.soDienThoaiLienHe }}</p>
          <p class="sm:col-span-2">
            <b>🌐 Website:</b>
            <a
              v-if="selectedCompany.website"
              :href="selectedCompany.website"
              target="_blank"
              class="text-indigo-600 hover:underline"
            >
              {{ selectedCompany.website.replace(/^https?:\/\//, "") }}
            </a>
            <span v-else>—</span>
          </p>

          <p><b>👤 Người đại diện:</b> {{ selectedCompany.hoTenNguoiDaiDien }}</p>
          <p><b>📧 Email đại diện:</b> {{ selectedCompany.emailNguoiDaiDien || "—" }}</p>
          <p><b>📞 SĐT đại diện:</b> {{ selectedCompany.sdtNguoiDaiDien || "—" }}</p>

          <p><b>📅 Ngày tạo:</b>
            {{ new Date(selectedCompany.ngayTao).toLocaleDateString("vi-VN") }}
          </p>
          <p>
            <b>Xác minh: </b>
            <span
              :class="selectedCompany.daDuocAdminXacMinh ? 'text-green-600' : 'text-red-600'"
            >
              {{ selectedCompany.daDuocAdminXacMinh ? "✔️Đã xác minh" : "❌Chưa xác minh" }}
            </span>
          </p>

          <div
            v-if="selectedCompany.gioiThieu"
            class="sm:col-span-2 bg-gray-50 border rounded-lg p-3 mt-2"
          >
            <h4 class="font-semibold mb-1">📄 Giới thiệu doanh nghiệp</h4>
            <p class="text-gray-700 whitespace-pre-line">
              {{ selectedCompany.gioiThieu }}
            </p>
          </div>
        </div>

        <div class="mt-6 text-right">
          <button
            @click="closeDetailModal"
            class="px-4 py-2 bg-gray-300 rounded-lg hover:bg-gray-400"
          >
            Đóng
          </button>
        </div>
      </div>
    </div>
  </div>
</template>

<script setup>
import { ref, onMounted } from "vue";
import api from "@/api/axios";
import { useAuthStore } from "@/store/auth";
import { useToast } from "vue-toastification";

const auth = useAuthStore();
const toast = useToast();

const companies = ref([]);
const loading = ref(false);
const keyword = ref("");

const showDetailModal = ref(false);
const selectedCompany = ref(null);

const baseURL = "https://localhost:7248";
const getLogoUrl = (path) =>
  path
    ? path.startsWith("http")
      ? path
      : `${baseURL}${path}`
    : "https://cdn-icons-png.flaticon.com/512/847/847969.png";

const fetchCompanies = async () => {
  loading.value = true;
  try {
    const res = await api.get("/Admin/cong-ty", {
      headers: { Authorization: `Bearer ${auth.token}` },
    });
    companies.value = res.data;
  } catch (err) {
    console.error("Lỗi tải công ty:", err);
    toast.error("Không thể tải danh sách công ty!");
  } finally {
    loading.value = false;
  }
};

const openDetailModal = (c) => {
  selectedCompany.value = c;
  showDetailModal.value = true;
};
const closeDetailModal = () => {
  selectedCompany.value = null;
  showDetailModal.value = false;
};

const applyFilter = () => {
  if (!keyword.value.trim()) return fetchCompanies();
  companies.value = companies.value.filter((c) =>
    c.tenCongTy.toLowerCase().includes(keyword.value.toLowerCase())
  );
};
const resetFilter = () => {
  keyword.value = "";
  fetchCompanies();
};

onMounted(fetchCompanies);
</script>
