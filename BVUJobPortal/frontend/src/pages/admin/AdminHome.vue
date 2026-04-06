<template>
  <div class="min-h-screen bg-gray-50 p-6 space-y-8">
    <section>
      <h2 class="text-xl font-bold text-gray-700 mb-4">📊 Tổng quan hệ thống</h2>
      <div class="grid md:grid-cols-5 gap-6">
        <div
          v-for="c in overviewCards"
          :key="c.label"
          class="bg-white shadow rounded-xl p-4 flex flex-col items-center justify-center"
        >
          <div :class="['w-12 h-12 flex items-center justify-center rounded-full mb-3', c.bg]">
            <component :is="c.icon" class="w-6 h-6 text-white" />
          </div>
          <p class="text-gray-500 text-sm">{{ c.label }}</p>
          <p :class="['text-2xl font-bold', c.color]">{{ c.value }}</p>
          <p class="text-xs text-gray-400">{{ c.sub }}</p>
        </div>
      </div>
    </section>

    <section>
      <h2 class="text-xl font-bold text-gray-700 mb-4">📈 Phân tích người dùng & công việc</h2>
      <div class="grid md:grid-cols-2 gap-6">
        <div class="bg-white rounded-xl shadow p-6">
          <h3 class="font-semibold mb-3">Người dùng theo vai trò</h3>
          <BarChart v-if="userChartData" :data="userChartData" :options="chartOptions" />
        </div>
        <div class="bg-white rounded-xl shadow p-6">
          <h3 class="font-semibold mb-3">Công việc theo trạng thái</h3>
          <PieChart v-if="jobChartData" :data="jobChartData" :options="chartOptions" />
        </div>
      </div>
    </section>

    <!-- <section>
      <h2 class="text-xl font-bold text-gray-700 mb-4">📝 Thống kê ứng tuyển</h2>
      <div class="bg-white rounded-xl shadow p-6">
        <BarChart v-if="applyChartData" :data="applyChartData" :options="chartOptions" />
      </div>
    </section> -->

    <section>
      <h2 class="text-xl font-bold text-gray-700 mb-4">📅 Công việc mới trong 7 ngày</h2>
      <div class="grid md:grid-cols-2 gap-6">
        <div class="bg-white rounded-xl shadow p-6">
          <LineChart v-if="jobLineChartData" :data="jobLineChartData" :options="lineChartOptions" />
        </div>
        <div class="bg-white rounded-xl shadow p-6">
          <h3 class="font-semibold mb-3">Top 5 công việc mới nhất</h3>
          <table class="min-w-full text-sm">
            <thead>
              <tr class="text-gray-600 border-b">
                <th class="text-left py-2">Tiêu đề</th>
                <th class="text-left py-2">Công ty</th>
                <th class="text-left py-2">Ngày đăng</th>
              </tr>
            </thead>
            <tbody>
              <tr
                v-for="job in latestJobs"
                :key="job.id"
                class="border-b hover:bg-gray-50"
              >
                <td class="py-2 font-medium">{{ job.tieuDe }}</td>
                <td class="py-2 text-gray-500">{{ job.tenCongTy || "—" }}</td>
                <td class="py-2 text-gray-400">
                  {{ new Date(job.ngayDang).toLocaleDateString("vi-VN") }}
                </td>
              </tr>
              <tr v-if="latestJobs.length === 0">
                <td colspan="3" class="py-3 text-center text-gray-500">🚫 Không có dữ liệu</td>
              </tr>
            </tbody>
          </table>
        </div>
      </div>
    </section>
  </div>
</template>

<script setup>
import { ref, onMounted } from "vue";
import api from "@/api/axios";
import { useAuthStore } from "@/store/auth";
import { useToast } from "vue-toastification";
import {
  Chart as ChartJS,
  Title,
  Tooltip,
  Legend,
  BarElement,
  ArcElement,
  LineElement,
  PointElement,
  CategoryScale,
  LinearScale,
} from "chart.js";
import { Bar, Pie, Line } from "vue-chartjs";
import {
  UserGroupIcon,
  BuildingOfficeIcon,
  BriefcaseIcon,
  ExclamationTriangleIcon,
  EnvelopeIcon,
} from "@heroicons/vue/24/solid";

ChartJS.register(
  Title,
  Tooltip,
  Legend,
  BarElement,
  ArcElement,
  LineElement,
  PointElement,
  CategoryScale,
  LinearScale
);

const auth = useAuthStore();
const toast = useToast();

const stats = ref({});
const latestJobs = ref([]);

const userChartData = ref(null);
const jobChartData = ref(null);
const applyChartData = ref(null);
const jobLineChartData = ref(null);

const chartOptions = { responsive: true, plugins: { legend: { position: "bottom" } } };
const lineChartOptions = {
  responsive: true,
  plugins: { legend: { display: false } },
  scales: {
    x: { title: { display: true, text: "Ngày" } },
    y: { title: { display: true, text: "Số công việc" }, beginAtZero: true },
  },
};

const fetchStats = async () => {
  try {
    const res = await api.get("/Admin/thong-ke", {
      headers: { Authorization: `Bearer ${auth.token}` },
    });
    stats.value = res.data;

    userChartData.value = {
      labels: ["Sinh viên", "Nhà tuyển dụng", "Admin", "Super Admin"],
      datasets: [
        {
          label: "Số lượng",
          data: [res.data.sinhVien, res.data.nhaTuyenDung, res.data.admin, res.data.superAdmin],
          backgroundColor: ["#4F46E5", "#16A34A", "#F59E0B", "#8B5CF6"],
        },
      ],
    };

    jobChartData.value = {
      labels: ["Đã duyệt", "Chưa duyệt", "Mới 7 ngày"],
      datasets: [
        {
          label: "Công việc",
          data: [res.data.congViecDaDuyet, res.data.congViecChuaDuyet, res.data.congViecMoi7Ngay],
          backgroundColor: ["#10B981", "#EF4444", "#6366F1"],
        },
      ],
    };

    applyChartData.value = {
      labels: ["Đang chờ", "Đã duyệt", "Từ chối"],
      datasets: [
        {
          label: "Ứng tuyển",
          data: [res.data.ungTuyenCho, res.data.ungTuyenDuyet, res.data.ungTuyenTuChoi],
          backgroundColor: ["#F59E0B", "#10B981", "#EF4444"],
        },
      ],
    };

    jobLineChartData.value = {
      labels: ["T-6", "T-5", "T-4", "T-3", "T-2", "T-1", "Hôm nay"],
      datasets: [
        {
          label: "Công việc mới",
          data: Array(7).fill(0).map(() => Math.floor(Math.random() * 5)),
          borderColor: "#4F46E5",
          backgroundColor: "rgba(79,70,229,0.2)",
          tension: 0.3,
          fill: true,
        },
      ],
    };
  } catch (err) {
    console.error("Lỗi tải thống kê:", err);
    toast.error("Không thể tải thống kê!");
  }
};

const fetchLatestJobs = async () => {
  try {
    const res = await api.get("/Admin/cong-viec", {
      headers: { Authorization: `Bearer ${auth.token}` },
    });
    latestJobs.value = (res.data.duLieu || res.data).slice(0, 5);
  } catch (err) {
    console.error("Lỗi tải công việc mới:", err);
  }
};

onMounted(() => {
  fetchStats();
  fetchLatestJobs();
});

const overviewCards = [
  { label: "Người dùng", icon: UserGroupIcon, color: "text-indigo-600", bg: "bg-indigo-500", value: stats.value.tongNguoiDung, sub: "Đang hoạt động" },
  { label: "Công ty", icon: BuildingOfficeIcon, color: "text-green-600", bg: "bg-green-500", value: stats.value.tongCongTy, sub: "Đăng ký mới" },
  { label: "Công việc", icon: BriefcaseIcon, color: "text-purple-600", bg: "bg-purple-500", value: stats.value.tongCongViec, sub: "Mới 7 ngày" },
  { label: "Báo cáo", icon: ExclamationTriangleIcon, color: "text-red-600", bg: "bg-red-500", value: stats.value.tongBaoCao, sub: "Đang xử lý" },
  { label: "Khiếu nại", icon: EnvelopeIcon, color: "text-orange-600", bg: "bg-orange-500", value: stats.value.tongKhieuNai, sub: "Chưa xử lý" },
];

const BarChart = Bar;
const PieChart = Pie;
const LineChart = Line;
</script>