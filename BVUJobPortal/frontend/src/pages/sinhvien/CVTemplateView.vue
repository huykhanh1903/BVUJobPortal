<template>
  <div
    v-if="sv && !isNTD"
    class="max-w-6xl mx-auto mb-5 px-2 sticky top-20 z-30"
  >
    <button
      @click="goBack"
      class="inline-flex items-center gap-3
            px-5 py-2 rounded-full
            bg-white border border-gray-300
            text-gray-700 text-sm font-semibold
            hover:bg-indigo-50 hover:border-indigo-400
            transition shadow-md"
    >
      ⬅ Quay lại
    </button>
  </div>

  <div class="w-full">

    <!-- CV CONTENT -->
    <div
      v-if="sv"
      :class="isNTD ? 'flex justify-center' : 'min-h-screen bg-gray-100 py-10 px-4 flex justify-center'"
    >
      <div 
        ref="cvContent"
        class="a4 bg-white shadow-2xl rounded-2xl overflow-hidden flex border"
        :class="isNTD ? 'shadow-none rounded-none border-none' : ''"
      >

        <!-- ========== SIDEBAR ========== -->
        <aside class="w-1/3 bg-indigo-700 text-white p-7 flex flex-col items-center">
          <img
            v-if="sv?.avatarUrl"
            :src="getAvatarUrl(sv.avatarUrl)"
            class="h-32 w-32 rounded-full object-cover border-4 border-white mb-5"
          />

          <div
            v-else
            class="h-32 w-32 rounded-full bg-white/20 flex items-center justify-center text-4xl font-bold shadow mb-5"
          >
            {{ sv?.hoTen?.charAt(0) || "?" }}
          </div>

          <h2 class="text-2xl font-bold text-center">{{ sv?.hoTen }}</h2>
          <p class="text-indigo-200 text-sm">{{ sv?.nganhNgheMongMuon }}</p>

          <hr class="border-white/20 my-6 w-full" />

          <div class="w-full space-y-2 text-sm">
            <h3 class="sidebar-title">📞 Liên hệ</h3>
            <p>✉️ {{ sv?.emailLienHe }}</p>
            <p>📱 {{ sv?.dienThoai }}</p>
            <p>📍 {{ sv?.diaChi }}</p>
          </div>

          <hr class="border-white/20 my-6 w-full" />

          <h3 class="sidebar-title">🛠 Kỹ năng</h3>
          <div class="w-full space-y-3">
            <div v-for="(k, i) in sv?.kyNangs || []" :key="i">
              <p class="text-sm font-medium">{{ k.tenKyNang }}</p>
              <div class="h-2 bg-white/20 rounded-full overflow-hidden">
                <div class="h-full bg-white rounded-full" :style="{ width: k.mucDo * 20 + '%' }"></div>
              </div>
            </div>
          </div>

          <hr class="border-white/20 my-6 w-full" />

          <h3 class="sidebar-title">🌐 Ngoại ngữ</h3>
          <ul class="list-disc ml-5 text-sm space-y-1">
            <li v-for="(n, i) in sv?.ngoaiNgus || []" :key="i">
              {{ n.tenNgoaiNgu }} – {{ n.trinhDo }}
            </li>
          </ul>
        </aside>

        <!-- ========== MAIN CONTENT ========== -->
        <main class="w-2/3 p-10 space-y-8 text-gray-800">

          <section>
            <h2 class="section-title">🎯 Mục tiêu nghề nghiệp</h2>
            <p class="text-gray-700 leading-relaxed">{{ sv?.mucTieuNgheNghiep }}</p>
          </section>

          <section>
            <h2 class="section-title">🎓 Học vấn</h2>
            <div
              v-for="(hv, i) in sv?.hocVans || []"
              :key="i"
              class="cv-box"
            >
              <p class="font-bold text-gray-900 text-lg">
                {{ hv.bangCap }} – {{ hv.truongHoacKhoaHoc }}
              </p>
              <p class="text-sm text-gray-500">📅 Tốt nghiệp: {{ hv.thangNamTotNghiep }}</p>
              <p class="text-gray-700 mt-2 text-sm">{{ hv.moTaChiTiet }}</p>
            </div>
          </section>

          <section>
            <h2 class="section-title">💼 Kinh nghiệm làm việc</h2>
            <div
              v-for="(exp, i) in sv?.kinhNghiems || []"
              :key="i"
              class="cv-box"
            >
              <p class="font-bold text-gray-900 text-lg">
                {{ exp.viTriChucDanh }} – {{ exp.tenCongTy }}
              </p>
              <p class="text-sm text-gray-500">
                {{ formatDate(exp.ngayBatDau) }} →
                {{ exp.dangLamHienTai ? "Hiện tại" : formatDate(exp.ngayKetThuc) }}
              </p>
              <p class="text-gray-700 mt-2 text-sm">{{ exp.moTaCongViec }}</p>
            </div>
          </section>

          <section>
            <h2 class="section-title">📜 Chứng chỉ</h2>
            <ul class="ml-5 list-disc text-gray-700 text-sm space-y-1">
              <li v-for="(cc, i) in sv?.chungChis || []" :key="i">
                <strong>{{ cc.tenChungChi }}</strong> – {{ cc.capBoi }}
                <br />
                📅 {{ formatDate(cc.ngayCap) }}
              </li>
            </ul>
          </section>

          <section>
            <h2 class="section-title">🤝 Hoạt động</h2>
            <div
              v-for="(hd, i) in sv?.hoatDongs || []"
              :key="i"
              class="cv-box"
            >
              <p class="font-bold text-gray-900">{{ hd.vaiTro }} – {{ hd.toChuc }}</p>
              <p class="text-sm text-gray-500">
                {{ formatDate(hd.ngayBatDau) }} →
                {{ hd.dangHoatDong ? "Hiện tại" : formatDate(hd.ngayKetThuc) }}
              </p>
              <p class="text-gray-700 mt-2 text-sm">{{ hd.moTaHoatDong }}</p>
            </div>
          </section>

          <section>
            <h2 class="section-title">👥 Người tham chiếu</h2>
            <ul class="ml-5 list-disc text-gray-700 text-sm space-y-1">
              <li v-for="(r, i) in sv?.nguoiThamChieus || []" :key="i">
                <strong>{{ r.hoVaTen }}</strong> – {{ r.chucVu }} tại {{ r.congTy }}  
                <br />📞 {{ r.dienThoai }}  
                <br />✉️ {{ r.email }}
              </li>
            </ul>
          </section>

        </main>
      </div>
    </div>

    <!-- LOADING -->
    <div v-else class="text-center text-gray-500 py-20">
      ⏳ Đang tải CV...
    </div>

    <!-- DOWNLOAD BUTTON -->
    <div v-if="sv && !isNTD" class="flex justify-center mt-5">
      <button
        @click="downloadPDF"
        class="px-6 py-3 bg-indigo-600 text-white rounded-lg shadow-lg hover:bg-indigo-700 transition font-medium flex items-center gap-2"
      >
        ⬇️ Tải CV PDF
      </button>
    </div>

  </div>
</template>

<script setup>
import { ref, onMounted } from "vue"
import { useRoute } from "vue-router"
import { useAuthStore } from "@/store/auth"
import api from "@/api/axios"
import { useRouter } from "vue-router"

const route = useRoute()
const auth = useAuthStore()
const router = useRouter()

const sv = ref(null)
const cvContent = ref(null)
const isNTD = ref(false)

const base = "https://localhost:7248"

if (!auth.user) {
  const u = localStorage.getItem("user")
  if (u) auth.user = JSON.parse(u)
}

onMounted(async () => {
  isNTD.value = auth.user?.vaiTro === "NhaTuyenDung"

  if (isNTD.value && route.query.sinhVienId) {
    try {
      const res = await api.get(
        `/ung-vien/${route.query.sinhVienId}/chi-tiet`
      )
      sv.value = res.data
    } catch (err) {
      console.error("Không tải được CV ứng viên", err)
    }
    return
  }

  const data = sessionStorage.getItem("cvSinhVien")
  if (data) {
    sv.value = JSON.parse(data)
  }
})

function getAvatarUrl(path) {
  return path?.startsWith("http") ? path : base + path
}

function formatDate(date) {
  if (!date) return "—"
  const d = new Date(date)
  if (isNaN(d)) return "—"
  return d.toLocaleDateString("vi-VN", {
    day: "2-digit",
    month: "2-digit",
    year: "numeric"
  })
}

async function downloadPDF() {
  const html2pdf = window.html2pdf
  const element = cvContent.value

  html2pdf()
    .set({
      margin: 0,
      filename: `CV-${sv.value.hoTen}.pdf`,
      image: { type: "jpeg", quality: 1 },
      html2canvas: { scale: 2, useCORS: true },
      jsPDF: { unit: "mm", format: "a4", orientation: "portrait" }
    })
    .from(element)
    .save()
}
const goBack = () => {
  if (window.history.length > 1) {
    window.history.back()
  } else {
    router.push("/sinh-vien/profile")
  }
}

</script>

<style scoped>
.a4 {
  width: 794px;
  min-height: 1123px;
  background: white;
}

.section-title {
  @apply text-2xl font-bold text-gray-900 mb-3 border-b pb-1;
}

.sidebar-title {
  @apply text-lg font-semibold mb-2 text-white;
}

.cv-box {
  @apply bg-gray-100 p-4 rounded-xl border border-gray-200 shadow-sm mt-3;
}
</style>

