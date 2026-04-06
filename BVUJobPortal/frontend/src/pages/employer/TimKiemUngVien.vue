<template>
  <div class="max-w-7xl mx-auto px-6 py-8">
    <h1 class="text-2xl font-bold mb-6 flex items-center gap-2">
      🔍 Tìm kiếm ứng viên
    </h1>

    <div class="bg-white rounded-2xl shadow p-5 grid md:grid-cols-5 gap-4 mb-6">
      <input
        v-model="filter.keyword"
        placeholder="Tên, ngành, kỹ năng (.NET...)"
        class="input"
      />

      <select v-model="filter.capBac" class="input">
        <option value="">Cấp bậc</option>
        <option>Thực tập</option>
        <option>Nhân viên</option>
        <option>Senior</option>
      </select>

      <input
        type="number"
        v-model="filter.luongToiDa"
        placeholder="Lương tối đa"
        class="input"
      />

      <input
        v-model="kyNangText"
        @keyup.enter="themKyNang"
        placeholder="Nhập kỹ năng + Enter"
        class="input"
      />

      <button
        @click="timKiemUngVien"
        class="bg-indigo-600 text-white rounded-xl hover:bg-indigo-700 transition"
      >
        🔍 Tìm
      </button>
    </div>

    <div class="flex flex-wrap gap-2 mb-8">
      <span
        v-for="(k, i) in filter.kyNang"
        :key="i"
        class="px-3 py-1 bg-indigo-100 text-indigo-700 rounded-full text-sm flex items-center gap-1"
      >
        {{ k }}
        <button @click="filter.kyNang.splice(i, 1)">✕</button>
      </span>
    </div>

    <div v-if="loading" class="text-center py-10 text-gray-500">
      Đang tìm ứng viên...
    </div>
    <div
      v-else-if="ungViens.length"
      class="grid md:grid-cols-3 gap-6 mb-14"
    >
      <div
        v-for="uv in ungViens"
        :key="uv.sinhVienId"
        class="bg-white rounded-2xl shadow hover:shadow-lg transition p-5"
      >

        <div class="flex items-center gap-4">
          <img
            :src="getAvatar(uv.avatarUrl)"
            class="w-14 h-14 rounded-full object-cover"
          />
          <div>
            <p class="font-semibold">{{ uv.hoTen }}</p>
            <p class="text-sm text-gray-500">{{ uv.capBac }}</p>
          </div>
        </div>

        <div class="mt-4 text-sm space-y-1">
          <p>🎓 {{ uv.nganhNghe }}</p>
          <p>
            💰 {{ formatLuong(uv.mucLuongTu) }} -
            {{ formatLuong(uv.mucLuongDen) }}
          </p>
        </div>

        <div class="flex flex-wrap gap-2 mt-3">
          <span
            v-for="k in uv.kyNangs"
            :key="k"
            class="px-2 py-1 bg-gray-100 rounded text-xs"
          >
            {{ k }}
          </span>
        </div>

        <button
          @click="xemHoSo(uv.sinhVienId)"
          class="mt-4 w-full border border-indigo-600 text-indigo-600 rounded-xl py-2 hover:bg-indigo-50 transition"
        >
          👀 Xem hồ sơ
        </button>
      </div>
    </div>

    <div
      v-else-if="daTimKiem && !ungViens.length"
      class="text-center text-gray-400 py-10"
    >
      ❌ Không tìm thấy ứng viên phù hợp
    </div>

    <div v-if="!daTimKiem" class="mt-10">
      <h2 class="text-xl font-bold mb-6 flex items-center gap-2">
        🟢 Ứng viên đang tìm việc
      </h2>

      <div v-if="loadingDangTimViec" class="text-center py-8 text-gray-500">
        Đang tải danh sách ứng viên...
      </div>

      <div
        v-else-if="!ungVienDangTimViec.length"
        class="text-center py-8 text-gray-400"
      >
        Chưa có ứng viên nào đang tìm việc
      </div>

      <div v-else class="grid md:grid-cols-3 gap-6">
        <div
          v-for="uv in ungVienDangTimViec"
          :key="uv.sinhVienId"
          class="bg-white rounded-2xl shadow hover:shadow-lg transition p-5 border-l-4 border-green-500"
        >
          <div class="flex items-center gap-4">
            <img
              :src="getAvatar(uv.avatarUrl)"
              class="w-14 h-14 rounded-full object-cover"
            />
            <div>
              <p class="font-semibold">{{ uv.hoTen }}</p>
              <p class="text-sm text-green-700 font-medium">
                {{ uv.capBacMongMuon }}
              </p>
            </div>
          </div>

          <div class="mt-4 text-sm space-y-1">
            <p>🎓 {{ uv.nganhNgheMongMuon }}</p>
            <p>📍 {{ uv.noiLamViecMongMuon }}</p>
          </div>

          <div class="flex flex-wrap gap-2 mt-3">
            <span
              v-for="k in uv.kyNangs"
              :key="k"
              class="px-2 py-1 bg-green-100 text-green-700 rounded text-xs"
            >
              {{ k }}
            </span>
          </div>

          <div class="mt-4 grid grid-cols-1 gap-1">
            <button
              @click="xemHoSo(uv.sinhVienId)"
              class="border border-gray-300 rounded-xl py-2 hover:bg-gray-50 transition"
            >
              👀 Hồ sơ
            </button>
          </div>
        </div>
      </div>
    </div>

  </div>
</template>

<script setup>
import { ref, reactive, onMounted } from "vue"
import { useRouter } from "vue-router"
import api from "@/api/axios"

const filter = reactive({
  keyword: "",
  capBac: "",
  luongToiDa: null,
  kyNang: []
})

const kyNangText = ref("")
const ungViens = ref([])
const ungVienDangTimViec = ref([])

const loading = ref(false)
const loadingDangTimViec = ref(false)
const daTimKiem = ref(false)

const router = useRouter()

function themKyNang() {
  if (kyNangText.value.trim()) {
    filter.kyNang.push(kyNangText.value.trim())
    kyNangText.value = ""
  }
}

function xemHoSo(id) {
  router.push({
    name: "XemCVTemplate",
    query: {
      sinhVienId: id
    }
  })
}


function getAvatar(url) {
  if (!url) return "/avatar-default.png"

  if (url.startsWith("http")) return url

  return `https://localhost:7248${url}`
}


function formatLuong(v) {
  return v ? v.toLocaleString("vi-VN") + " đ" : "Thỏa thuận"
}

// async function timKiemUngVien() {
//   loading.value = true
//   daTimKiem.value = true
//   try {
//     const res = await api.post("/ung-vien/tim-kiem", filter)
//     ungViens.value = res.data
//   } finally {
//     loading.value = false
//   }
// }

async function timKiemUngVien() {
  loading.value = true
  daTimKiem.value = true

  try {
    if (USE_MOCK) {
      await new Promise(r => setTimeout(r, 600))

      ungViens.value = mockUngViens.filter(u => {
        const matchKeyword =
          !filter.keyword ||
          u.hoTen.toLowerCase().includes(filter.keyword.toLowerCase()) ||
          u.kyNangs.some(k =>
            k.toLowerCase().includes(filter.keyword.toLowerCase())
          )

        const matchCapBac =
          !filter.capBac || u.capBac === filter.capBac

        return matchKeyword && matchCapBac
      })
    } else {
      const res = await api.post("/ung-vien/tim-kiem", filter)
      ungViens.value = res.data
    }
  } finally {
    loading.value = false
  }
}

// async function layUngVienDangTimViec() {
//   loadingDangTimViec.value = true
//   try {
//     const res = await api.get("/ung-vien/dang-tim-viec")
//     ungVienDangTimViec.value = res.data
//   } finally {
//     loadingDangTimViec.value = false
//   }
// }

async function layUngVienDangTimViec() {
  loadingDangTimViec.value = true

  try {
    if (USE_MOCK) {
      await new Promise(r => setTimeout(r, 600))
      ungVienDangTimViec.value = mockUngVienDangTimViec
    } else {
      const res = await api.get("/ung-vien/dang-tim-viec")
      ungVienDangTimViec.value = res.data
    }
  } finally {
    loadingDangTimViec.value = false
  }
}

onMounted(() => {
  layUngVienDangTimViec()
})
const mockUngViens = [
  {
    sinhVienId: 1,
    hoTen: "Nguyễn Văn A",
    avatarUrl: null,
    capBac: "Nhân viên",
    nganhNghe: "Công nghệ thông tin",
    mucLuongTu: 8000000,
    mucLuongDen: 12000000,
    kyNangs: ["Vue.js", ".NET", "SQL Server"]
  },
  {
    sinhVienId: 2,
    hoTen: "Trần Thị B",
    avatarUrl: null,
    capBac: "Thực tập",
    nganhNghe: "Kỹ thuật phần mềm",
    mucLuongTu: null,
    mucLuongDen: null,
    kyNangs: ["HTML", "CSS", "JavaScript"]
  },
  {
    sinhVienId: 3,
    hoTen: "Lê Hoàng C",
    avatarUrl: null,
    capBac: "Senior",
    nganhNghe: "Hệ thống thông tin",
    mucLuongTu: 18000000,
    mucLuongDen: 30000000,
    kyNangs: ["ASP.NET Core", "Docker", "Azure"]
  },
  {
    sinhVienId: 4,
    hoTen: "Phạm Minh D",
    avatarUrl: null,
    capBac: "Nhân viên",
    nganhNghe: "Khoa học máy tính",
    mucLuongTu: 10000000,
    mucLuongDen: 15000000,
    kyNangs: ["React", "Node.js", "MongoDB"]
  },
  {
    sinhVienId: 5,
    hoTen: "Võ Thanh E",
    avatarUrl: null,
    capBac: "Thực tập",
    nganhNghe: "CNTT",
    mucLuongTu: null,
    mucLuongDen: null,
    kyNangs: ["C#", ".NET", "EF Core"]
  },
  {
    sinhVienId: 6,
    hoTen: "Ngô Quốc F",
    avatarUrl: null,
    capBac: "Nhân viên",
    nganhNghe: "Kỹ thuật phần mềm",
    mucLuongTu: 9000000,
    mucLuongDen: 14000000,
    kyNangs: ["Java", "Spring Boot", "MySQL"]
  },
  {
    sinhVienId: 7,
    hoTen: "Đặng Thị G",
    avatarUrl: null,
    capBac: "Senior",
    nganhNghe: "Công nghệ thông tin",
    mucLuongTu: 22000000,
    mucLuongDen: 35000000,
    kyNangs: ["System Design", "Microservices", "Kubernetes"]
  },
  {
    sinhVienId: 8,
    hoTen: "Bùi Văn H",
    avatarUrl: null,
    capBac: "Nhân viên",
    nganhNghe: "Hệ thống thông tin",
    mucLuongTu: 11000000,
    mucLuongDen: 16000000,
    kyNangs: ["Python", "Django", "PostgreSQL"]
  },
  {
    sinhVienId: 9,
    hoTen: "Huỳnh Thị I",
    avatarUrl: null,
    capBac: "Thực tập",
    nganhNghe: "CNTT",
    mucLuongTu: null,
    mucLuongDen: null,
    kyNangs: ["UI/UX", "Figma", "Photoshop"]
  },
  {
    sinhVienId: 10,
    hoTen: "Lý Quốc J",
    avatarUrl: null,
    capBac: "Nhân viên",
    nganhNghe: "Khoa học dữ liệu",
    mucLuongTu: 12000000,
    mucLuongDen: 18000000,
    kyNangs: ["Python", "Pandas", "Machine Learning"]
  },

  {
    sinhVienId: 11,
    hoTen: "Nguyễn Thị K",
    avatarUrl: null,
    capBac: "Senior",
    nganhNghe: "An toàn thông tin",
    mucLuongTu: 25000000,
    mucLuongDen: 40000000,
    kyNangs: ["Pentest", "Security", "Linux"]
  },
  {
    sinhVienId: 12,
    hoTen: "Phan Văn L",
    avatarUrl: null,
    capBac: "Nhân viên",
    nganhNghe: "CNTT",
    mucLuongTu: 9500000,
    mucLuongDen: 13000000,
    kyNangs: ["Laravel", "PHP", "MySQL"]
  },
  {
    sinhVienId: 13,
    hoTen: "Trương Thị M",
    avatarUrl: null,
    capBac: "Thực tập",
    nganhNghe: "Kỹ thuật phần mềm",
    mucLuongTu: null,
    mucLuongDen: null,
    kyNangs: ["Testing", "Manual Test", "Jira"]
  },
  {
    sinhVienId: 14,
    hoTen: "Lâm Quốc N",
    avatarUrl: null,
    capBac: "Nhân viên",
    nganhNghe: "Công nghệ phần mềm",
    mucLuongTu: 13000000,
    mucLuongDen: 19000000,
    kyNangs: ["Flutter", "Firebase", "Mobile App"]
  },
  {
    sinhVienId: 15,
    hoTen: "Mai Thị O",
    avatarUrl: null,
    capBac: "Senior",
    nganhNghe: "AI",
    mucLuongTu: 30000000,
    mucLuongDen: 45000000,
    kyNangs: ["Deep Learning", "TensorFlow", "NLP"]
  },
  {
    sinhVienId: 16,
    hoTen: "Đỗ Văn P",
    avatarUrl: null,
    capBac: "Nhân viên",
    nganhNghe: "CNTT",
    mucLuongTu: 10000000,
    mucLuongDen: 15000000,
    kyNangs: ["DevOps", "Docker", "CI/CD"]
  },
  {
    sinhVienId: 17,
    hoTen: "Tạ Thị Q",
    avatarUrl: null,
    capBac: "Thực tập",
    nganhNghe: "Hệ thống thông tin",
    mucLuongTu: null,
    mucLuongDen: null,
    kyNangs: ["Data Analysis", "Excel", "Power BI"]
  },
  {
    sinhVienId: 18,
    hoTen: "Hoàng Quốc R",
    avatarUrl: null,
    capBac: "Nhân viên",
    nganhNghe: "CNTT",
    mucLuongTu: 11000000,
    mucLuongDen: 17000000,
    kyNangs: ["Angular", "TypeScript", "RxJS"]
  },
  {
    sinhVienId: 19,
    hoTen: "Nguyễn Thị S",
    avatarUrl: null,
    capBac: "Senior",
    nganhNghe: "Công nghệ phần mềm",
    mucLuongTu: 20000000,
    mucLuongDen: 32000000,
    kyNangs: ["Backend", "ASP.NET", "Clean Architecture"]
  },
  {
    sinhVienId: 20,
    hoTen: "Phạm Văn T",
    avatarUrl: null,
    capBac: "Nhân viên",
    nganhNghe: "CNTT",
    mucLuongTu: 9000000,
    mucLuongDen: 14000000,
    kyNangs: ["Support IT", "Networking", "Windows Server"]
  }
]

const mockUngVienDangTimViec = mockUngViens
  .slice(0, 9)
  .map((u, index) => ({
    sinhVienId: u.sinhVienId,
    hoTen: u.hoTen,
    avatarUrl: u.avatarUrl ?? [
      "https://e7.pngegg.com/pngimages/358/473/png-clipart-computer-icons-user-profile-person-child-heroes.png",
      "https://cdn-media.sforum.vn/storage/app/media/anh-nguoi-mau-16.jpg",
      "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS2_NyG0xOnKjySG81qOJJfdSty0gE2YlP5lQ&s",
      "https://hoanghamobile.com/tin-tuc/wp-content/uploads/2024/04/anh-trai-dep-Viet-Nam-77.jpg"
    ][index % 4],

    capBacMongMuon: u.capBac,
    nganhNgheMongMuon: u.nganhNghe,
    noiLamViecMongMuon: [
      "TP. Hồ Chí Minh",
      "Hà Nội",
      "Bà Rịa – Vũng Tàu",
      "Đà Nẵng"
    ][index % 4],

    kyNangs: u.kyNangs
  }))


const USE_MOCK = false 

</script>

<style scoped>
.input {
  @apply border rounded-xl px-3 py-2 focus:ring focus:ring-indigo-300 outline-none;
}
</style>
