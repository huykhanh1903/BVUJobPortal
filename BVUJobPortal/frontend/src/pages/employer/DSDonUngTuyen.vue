<template>
  <div class="min-h-screen bg-gray-100 py-10 px-4">

    <div class="max-w-6xl mx-auto bg-white shadow-xl rounded-2xl p-8">
      <h1 class="text-3xl font-bold text-gray-800 mb-8 flex items-center gap-3">
        <i class="fa-solid fa-envelope-open-text text-indigo-600"></i>
        Danh sách đơn ứng tuyển
      </h1>

      <div class="bg-gray-50 p-4 rounded-xl border mb-6 flex flex-col md:flex-row gap-4">

        <div class="flex-1">
          <input
            v-model="keyword"
            placeholder="🔍 Tìm theo tên công việc hoặc nội dung thư..."
            class="w-full px-4 py-2 rounded-lg border focus:ring focus:ring-indigo-300"
          />
        </div>

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

      <div v-if="loading" class="text-center py-10 text-gray-500">
        ⏳ Đang tải dữ liệu...
      </div>

      <div v-else-if="filteredList.length === 0" class="text-center py-14 text-gray-500 text-lg">
        😢 Không tìm thấy đơn ứng tuyển phù hợp.
      </div>

      <div v-else class="space-y-5">
        
        <div
          v-for="don in filteredList"
          :key="don.id"
          class="p-5 rounded-2xl border bg-white shadow-sm hover:shadow-lg transition cursor-pointer"
          @click="goToDetail(don.id)"
        >
          <div class="flex justify-between items-center">

            <div>
              <h2 class="text-lg font-bold text-gray-800">
                {{ don.tieuDeCongViec }}
              </h2>

              <p class="text-gray-600 text-sm mt-1">
                📝 Thư giới thiệu: {{ shorten(don.thuGioiThieu) }}
              </p>

              <p class="text-gray-500 text-xs mt-2">
                🗓 Ngày ứng tuyển: {{ formatDate(don.ngayUngTuyen) }}
              </p>
            </div>

            <span
              class="px-4 py-2 rounded-xl font-semibold text-sm"
              :class="getStatusColor(don.trangThai)"
            >
              {{ don.trangThai }}
            </span>

          </div>
        </div>

      </div>

    </div>

  </div>
</template>

<script setup>
import { ref, computed, onMounted } from "vue";
import api from "@/api/axios";
import { useRouter } from "vue-router";

const router = useRouter();
const loading = ref(true);
const list = ref([]);

const keyword = ref("");
const filterStatus = ref("");

const loadData = async () => {
  try {
    const res = await api.get("/UngTuyen/ntd/danh-sach");
    list.value = res.data ?? [];
  } catch (err) {
    console.error("Lỗi tải danh sách:", err);
  } finally {
    loading.value = false;
  }
};

const normalize = (str) =>
  (str || "")
    .normalize("NFD")
    .replace(/[\u0300-\u036f]/g, "")
    .toLowerCase();

const filteredList = computed(() => {
  return list.value.filter((don) => {
    const matchSearch =
      normalize(don.tieuDeCongViec).includes(normalize(keyword.value)) ||
      normalize(don.thuGioiThieu).includes(normalize(keyword.value));

    const matchStatus = filterStatus.value
      ? don.trangThai === filterStatus.value
      : true;

    return matchSearch && matchStatus;
  });
});

const goToDetail = (id) => {
  router.push(`/nha-tuyen-dung/don-ung-tuyen/${id}`);
};

const shorten = (text) => {
  if (!text) return "";
  return text.length > 50 ? text.slice(0, 50) + "..." : text;
};

const formatDate = (str) =>
  new Date(str).toLocaleString("vi-VN");

const getStatusColor = (status) => {
  switch (status) {
    case "Đang chờ":
      return "bg-yellow-100 text-yellow-700";
    case "Đã xem":
      return "bg-blue-100 text-blue-700";
    case "Từ chối":
      return "bg-red-100 text-red-700";
    case "Đạt":
      return "bg-green-100 text-green-700";
    default:
      return "bg-gray-200 text-gray-700";
  }
};

onMounted(loadData);
</script>
