<template>
  <div class="min-h-screen bg-gray-100 py-10 px-4">

    <div class="max-w-4xl mx-auto bg-white shadow-xl rounded-2xl p-8">

      <h1 class="text-3xl font-bold text-gray-800 mb-8 flex items-center gap-3">
        <i class="fa-solid fa-clock-rotate-left text-indigo-600"></i>
        Lịch sử ứng tuyển
      </h1>

      <!-- ===================== FILTER BAR ===================== -->
      <div class="bg-gray-50 p-4 rounded-xl border mb-6 flex flex-col md:flex-row gap-4">

        <!-- Search -->
        <div class="flex-1">
          <input
            v-model="keyword"
            type="text"
            placeholder="🔍 Tìm theo tên công việc hoặc công ty..."
            class="w-full px-4 py-2 rounded-lg border focus:ring focus:ring-indigo-300"
          />
        </div>

        <!-- Status filter -->
        <div>
          <select
            v-model="filterStatus"
            class="px-4 py-2 rounded-lg border focus:ring focus:ring-indigo-300"
          >
            <option value="">Tất cả trạng thái</option>
            <option value="Đang chờ">Đang chờ</option>
            <option value="Đã xem">Đã xem</option>
            <option value="Từ chối">Từ chối</option>
            <option value="Đã chấp nhận">Đã chấp nhận</option>
          </select>
        </div>

      </div>

      <!-- Loading -->
      <div v-if="loading" class="text-center py-10 text-gray-500">
        ⏳ Đang tải dữ liệu...
      </div>

      <!-- Empty -->
      <div
        v-else-if="filteredList.length === 0"
        class="text-center py-14 text-gray-500 text-lg"
      >
        😢 Không tìm thấy kết quả phù hợp.
      </div>

      <!-- ===================== LIST ===================== -->
      <div v-else class="space-y-5">
        <div
          v-for="don in filteredList"
          :key="don.id"
          class="p-5 rounded-2xl border bg-white shadow-sm hover:shadow-lg transition"
        >
          <h2 class="text-lg font-bold text-gray-800">
            {{ don.tieuDeCongViec }}
          </h2>

          <p class="text-gray-600 text-sm mt-1">
            <i class="fa-solid fa-building mr-1"></i>
            {{ don.tenCongTy }}
          </p>

          <p class="text-gray-500 text-xs mt-2">
            🗓 Ngày ứng tuyển: {{ formatDate(don.ngayUngTuyen) }}
          </p>

          <!-- STATUS -->
          <span
            class="mt-3 inline-block px-4 py-2 rounded-xl font-semibold text-sm"
            :class="getStatusColor(don.trangThai)"
          >
            {{ don.trangThai }}
          </span>
        </div>
      </div>

    </div>
  </div>
</template>

<script setup>
import { ref, computed, onMounted } from "vue";
import api from "@/api/axios";

const loading = ref(true);
const donUngTuyen = ref([]);

const keyword = ref("");
const filterStatus = ref("");

// Fetch data
const loadData = async () => {
  try {
    const res = await api.get("/UngTuyen/lich-su");
    donUngTuyen.value = res.data ?? [];
  } catch (err) {
    console.error("Lỗi tải lịch sử:", err);
  } finally {
    loading.value = false;
  }
};

// Normalize string for search (bỏ dấu tiếng Việt)
const normalize = (str) => {
  return (str || "")
    .normalize("NFD")
    .replace(/[\u0300-\u036f]/g, "")
    .toLowerCase();
};

// Filtered list
const filteredList = computed(() => {
  return donUngTuyen.value.filter((don) => {
    const searchMatch =
      normalize(don.tieuDeCongViec).includes(normalize(keyword.value)) ||
      normalize(don.tenCongTy).includes(normalize(keyword.value));

    const statusMatch = filterStatus.value
      ? don.trangThai === filterStatus.value
      : true;

    return searchMatch && statusMatch;
  });
});

const formatDate = (str) => {
  if (!str) return "";
  return new Date(str).toLocaleString("vi-VN");
};

const getStatusColor = (status) => {
  switch (status) {
    case "Đang chờ":
      return "bg-yellow-100 text-yellow-700";
    case "Đã xem":
      return "bg-blue-100 text-blue-700";
    case "Từ chối":
      return "bg-red-100 text-red-700";
    case "Đã chấp nhận":
      return "bg-green-100 text-green-700";
    default:
      return "bg-gray-200 text-gray-700";
  }
};

onMounted(loadData);
</script>

<style scoped></style>
