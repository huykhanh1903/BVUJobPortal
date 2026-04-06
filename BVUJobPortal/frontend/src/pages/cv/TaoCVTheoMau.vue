<template>
  <div class="min-h-screen bg-gray-100 flex">

    <aside class="w-96 bg-white border-r p-6 overflow-y-auto shadow-lg">
      <h2 class="text-2xl font-bold mb-5 text-gray-800">📝 Nhập nội dung CV</h2>

      <div
        v-for="block in blocks"
        :key="block.id"
        class="mb-6 p-4 rounded-xl border bg-gray-50 shadow-sm"
      >
        <h3 class="text-gray-700 font-semibold mb-3 text-lg">
          {{ blockTitle(block.type) }}
        </h3>

        <div v-if="block.type === 'header'" class="space-y-2">
          <input v-model="form[block.id].text" class="input" placeholder="Họ tên..." />
          <input v-model="form[block.id].subText" class="input" placeholder="Vị trí ứng tuyển..." />
        </div>

        <div v-else-if="['text','target','extra'].includes(block.type)">
          <textarea v-model="form[block.id].text" class="input" rows="4" placeholder="Nội dung..."></textarea>
        </div>

        <div v-else-if="block.type === 'contact'" class="space-y-2">
          <input v-model="form[block.id].email" class="input" placeholder="Email" />
          <input v-model="form[block.id].phone" class="input" placeholder="Số điện thoại" />
          <input v-model="form[block.id].address" class="input" placeholder="Địa chỉ" />
          <input v-model="form[block.id].website" class="input" placeholder="Website" />
        </div>

        <div v-else-if="block.type === 'skills'" class="space-y-2">
          <div class="flex gap-2">
            <input v-model="tempSkill" class="input flex-1" placeholder="Thêm kỹ năng..."
                   @keyup.enter="addSkill(block.id)" />
            <button @click="addSkill(block.id)" class="px-3 bg-blue-600 text-white rounded-lg">+</button>
          </div>

          <div class="flex flex-wrap gap-2 mt-2">
            <span
              v-for="(skill, i) in form[block.id].items"
              :key="i"
              class="px-2 py-1 bg-blue-100 text-blue-700 rounded-full text-sm flex items-center gap-1"
            >
              {{ skill }}
              <button @click="removeSkill(block.id, i)" class="text-red-600">×</button>
            </span>
          </div>
        </div>

        <div v-else-if="block.type === 'education'" class="space-y-3">
          <div
            v-for="(edu, i) in form[block.id].items"
            :key="i"
            class="p-3 border rounded-lg bg-white shadow-sm"
          >
            <input v-model="edu.school" class="input" placeholder="Trường" />
            <input v-model="edu.major" class="input" placeholder="Chuyên ngành" />
            <input v-model="edu.time" class="input" placeholder="Thời gian" />

            <button @click="removeEdu(block.id, i)" class="text-red-600 text-sm mt-1">Xóa</button>
          </div>

          <button @click="addEdu(block.id)" class="btn-add">➕ Thêm học vấn</button>
        </div>

        <div v-else-if="block.type === 'experience'" class="space-y-3">
          <div
            v-for="(exp, i) in form[block.id].items"
            :key="i"
            class="p-3 border rounded bg-white shadow-sm"
          >
            <input v-model="exp.company" class="input" placeholder="Công ty" />
            <input v-model="exp.position" class="input" placeholder="Vị trí" />
            <input v-model="exp.time" class="input" placeholder="Thời gian" />
            <textarea v-model="exp.desc" class="input" rows="3" placeholder="Mô tả"></textarea>

            <button @click="removeExperience(block.id, i)" class="text-red-600 text-sm mt-1">Xóa</button>
          </div>

          <button @click="addExperience(block.id)" class="btn-add">➕ Thêm kinh nghiệm</button>
        </div>

        <div v-else-if="block.type === 'project'" class="space-y-3">
          <div
            v-for="(pj, i) in form[block.id].items"
            :key="i"
            class="p-3 border rounded bg-white shadow-sm"
          >
            <input v-model="pj.name" class="input" placeholder="Tên dự án" />
            <input v-model="pj.role" class="input" placeholder="Vai trò" />
            <input v-model="pj.tech" class="input" placeholder="Công nghệ" />
            <textarea v-model="pj.desc" class="input" rows="3" placeholder="Mô tả"></textarea>

            <button @click="removeProject(block.id, i)" class="text-red-600 text-sm mt-1">Xóa</button>
          </div>

          <button @click="addProject(block.id)" class="btn-add">➕ Thêm dự án</button>
        </div>

        <div v-else-if="block.type === 'certificate'" class="space-y-3">
          <div
            v-for="(cc, i) in form[block.id].items"
            :key="i"
            class="p-3 border rounded bg-white shadow-sm"
          >
            <input v-model="cc.name" class="input" placeholder="Tên chứng chỉ" />
            <input v-model="cc.issuer" class="input" placeholder="Nơi cấp" />
            <input v-model="cc.date" type="date" class="input" placeholder="Ngày cấp" />

            <button @click="removeCertificate(block.id, i)" class="text-red-600 text-sm mt-1">Xóa</button>
          </div>

          <button @click="addCertificate(block.id)" class="btn-add">➕ Thêm chứng chỉ</button>
        </div>

        <div v-else-if="block.type === 'award'" class="space-y-3">
          <div
            v-for="(aw, i) in form[block.id].items"
            :key="i"
            class="p-3 border rounded bg-white shadow-sm"
          >
            <input v-model="aw.name" class="input" placeholder="Tên giải thưởng" />
            <input v-model="aw.time" class="input" placeholder="Năm" />
            <textarea v-model="aw.desc" class="input" rows="3" placeholder="Mô tả"></textarea>

            <button @click="removeAward(block.id, i)" class="text-red-600 text-sm mt-1">Xóa</button>
          </div>

          <button @click="addAward(block.id)" class="btn-add">➕ Thêm giải thưởng</button>
        </div>

        <div v-else-if="block.type === 'reference'" class="space-y-3">
          <div
            v-for="(rf, i) in form[block.id].items"
            :key="i"
            class="p-3 border rounded bg-white shadow-sm"
          >
            <input v-model="rf.name" class="input" placeholder="Họ tên" />
            <input v-model="rf.position" class="input" placeholder="Chức vụ" />
            <input v-model="rf.company" class="input" placeholder="Công ty" />
            <input v-model="rf.phone" class="input" placeholder="Số điện thoại" />
            <input v-model="rf.email" class="input" placeholder="Email" />

            <button @click="removeReference(block.id, i)" class="text-red-600 text-sm mt-1">Xóa</button>
          </div>

          <button @click="addReference(block.id)" class="btn-add">➕ Thêm người tham chiếu</button>
        </div>
        <div v-else-if="block.type === 'avatar'" class="space-y-3">
          <label class="font-medium">Ảnh đại diện</label>

          <input
            type="file"
            accept="image/*"
            class="input"
            @change="e => onAvatarChange(e, block.id)"
          />

          <div v-if="form[block.id].url" class="mt-3">
            <img
              :src="form[block.id].url"
              class="w-24 h-24 object-cover rounded-full border"
            />
          </div>
        </div>
        <div v-else-if="block.type === 'hobby'" class="space-y-3">
          <div
            v-for="(hb, i) in form[block.id].items"
            :key="i"
            class="flex items-center gap-2"
          >
            <input v-model="hb.value" class="input flex-1" placeholder="Sở thích..." />
            <button @click="removeHobby(block.id, i)" class="text-red-600">×</button>
          </div>

          <button @click="addHobby(block.id)" class="btn-add">➕ Thêm sở thích</button>
        </div>
      </div>

      <button @click="luuCV" class="w-full bg-green-600 text-white py-3 rounded-xl shadow-lg">
        💾 Lưu CV
      </button>
    </aside>

    <main class="flex-1 p-6 overflow-auto flex justify-center">
      <div
        class="relative bg-white shadow-2xl border transform scale-90 origin-top rounded-xl"
        :style="{ width: A4.width + 'px', height: A4.height + 'px' }"
      >

        <div
          v-for="block in blocks"
          :key="block.id"
          class="absolute overflow-hidden"
          :style="{
            left: block.x + 'px',
            top: block.y + 'px',
            width: block.width + 'px',
            height: block.height + 'px'
          }"
        >

          <div v-if="block.type === 'header'">
            <h1
              class="font-bold"
              :style="{
                fontSize: block.props.fontSize + 'px',
                color: block.props.color,
                textAlign: block.props.align
              }"
            >
              {{ form[block.id].text || 'HỌ VÀ TÊN' }}
            </h1>
            <p class="text-gray-500">{{ form[block.id].subText }}</p>
          </div>
          

          <div v-else-if="['text','target','extra'].includes(block.type)"
               class="text-gray-700 whitespace-pre-line"
               :style="{ fontSize: block.props.fontSize + 'px' }">
            {{ form[block.id].text }}
          </div>

          <div v-else-if="block.type === 'contact'" class="text-sm space-y-1">
            <p v-if="form[block.id].email">📧 {{ form[block.id].email }}</p>
            <p v-if="form[block.id].phone">📞 {{ form[block.id].phone }}</p>
            <p v-if="form[block.id].address">📍 {{ form[block.id].address }}</p>
            <p v-if="form[block.id].website">🌐 {{ form[block.id].website }}</p>
          </div>

          <div v-else-if="block.type === 'skills'" class="text-sm">
            <h3 class="font-semibold mb-1">{{ block.props.title || '🛠 Kỹ năng' }}</h3>
            <div class="flex flex-wrap gap-2">
              <span
                v-for="(skill, i) in form[block.id].items"
                :key="i"
                class="px-2 py-1 bg-gray-100 rounded text-xs border"
              >
                {{ skill }}
              </span>
            </div>
          </div>

          <div v-else-if="block.type === 'education'" class="text-sm">
            <h3 class="font-semibold mb-1">🎓 Học vấn</h3>
            <div v-for="(edu, i) in form[block.id].items" :key="i">
              <b>{{ edu.school }}</b>
              <p>{{ edu.major }} — {{ edu.time }}</p>
            </div>
          </div>

          <div v-else-if="block.type === 'experience'" class="text-sm space-y-1">
            <h3 class="font-semibold mb-1">💼 Kinh nghiệm</h3>
            <div v-for="(exp, i) in form[block.id].items" :key="i">
              <b>{{ exp.company }}</b>
              <p>{{ exp.position }} — {{ exp.time }}</p>
              <p>{{ exp.desc }}</p>
            </div>
          </div>

          <div v-else-if="block.type === 'project'" class="text-sm space-y-1">
            <h3 class="font-semibold mb-1">🚀 Dự án</h3>
            <div v-for="(pj, i) in form[block.id].items" :key="i">
              <b>{{ pj.name }}</b> — {{ pj.role }}
              <p class="italic">🛠 {{ pj.tech }}</p>
              <p>{{ pj.desc }}</p>
            </div>
          </div>

          <div v-else-if="block.type === 'certificate'" class="text-sm space-y-1">
            <h3 class="font-semibold mb-1">📜 Chứng chỉ</h3>
            <div v-for="(cc, i) in form[block.id].items" :key="i">
              <b>{{ cc.name }}</b>
              <p>{{ cc.issuer }} — {{ cc.date }}</p>
            </div>
          </div>

          <div v-else-if="block.type === 'award'" class="text-sm space-y-1">
            <h3 class="font-semibold mb-1">🏆 Giải thưởng</h3>
            <div v-for="(aw, i) in form[block.id].items" :key="i">
              <b>{{ aw.name }}</b>
              <p>{{ aw.time }}</p>
              <p>{{ aw.desc }}</p>
            </div>
          </div>

          <div v-else-if="block.type === 'reference'" class="text-sm space-y-1">
            <h3 class="font-semibold mb-1">📞 Người tham chiếu</h3>
            <div v-for="(rf, i) in form[block.id].items" :key="i">
              <b>{{ rf.name }}</b> — {{ rf.position }}
              <p>{{ rf.company }}</p>
              <p>📱 {{ rf.phone }}</p>
              <p>📧 {{ rf.email }}</p>
            </div>
          </div>

          <div v-else-if="block.type === 'hobby'" class="text-sm">
            <h3 class="font-semibold mb-1">🎯 Sở thích</h3>
            <ul class="list-disc ml-4">
              <li v-for="(hb, i) in form[block.id].items" :key="i">
                {{ hb.value }}
              </li>
            </ul>
          </div>

          <img
            v-else-if="block.type === 'avatar'"
            :src="form[block.id].url"
            class="w-full h-full object-cover"
            :style="{
              borderRadius: block.props.borderRadius + '%',
              objectFit: block.props.objectFit
            }"
          />

        </div>

      </div>
    </main>
  </div>
</template>

<script setup>
import { ref, reactive, onMounted } from "vue";
import { useRoute, useRouter } from "vue-router";
import api from "@/api/axios";
import { useAuthStore } from "@/store/auth";
import { useToast } from "vue-toastification";

const route = useRoute();
const router = useRouter();
const auth = useAuthStore();
const toast = useToast();

const A4 = { width: 794, height: 1123 };
const template = ref(null);
const blocks = ref([]);
const form = reactive({});
const tempSkill = ref("");
const tempHobby = ref("");

function blockTitle(type) {
  return {
    header: "Tiêu đề CV",
    text: "Đoạn mô tả",
    target: "Mục tiêu nghề nghiệp",
    contact: "Thông tin liên hệ",
    skills: "Kỹ năng",
    education: "Học vấn",
    experience: "Kinh nghiệm",
    avatar: "Ảnh đại diện",
    project: "Dự án",
    certificate: "Chứng chỉ",
    award: "Giải thưởng",
    hobby: "Sở thích",
    reference: "Người tham chiếu",
    extra: "Thông tin thêm"
  }[type] || "Khối nội dung";
}

async function loadTemplate() {
  try {
    const res = await api.get(`/admin/cv-templates/${route.params.id}`);
    template.value = res.data;

    const layout = JSON.parse(res.data.layoutJson);
    blocks.value = layout.blocks;

    blocks.value.forEach(b => {
      if (b.type === "header") {
        form[b.id] = { text: "", subText: "" };
      }
      else if (b.type === "avatar") {
        form[b.id] = { url: "" };
      }
      else if (b.type === "text" || b.type === "target" || b.type === "extra") {
        form[b.id] = { text: "" };
      }
      else if (b.type === "contact") {
        form[b.id] = { email: "", phone: "", address: "", website: "" };
      }
      else if (b.type === "avatar") {
        form[b.id] = { url: "" };
      }
      else if (b.type === "skills" || b.type === "hobby") {
        form[b.id] = { items: [] };
      }
      else if (b.type === "education") {
        form[b.id] = { items: [{ school: "", major: "", time: "" }] };
      }
      else if (b.type === "experience") {
        form[b.id] = { items: [{ company: "", position: "", time: "", desc: "" }] };
      }
      else if (b.type === "project") {
        form[b.id] = { items: [{ name: "", role: "", tech: "", desc: "" }] };
      }
      else if (b.type === "certificate") {
        form[b.id] = { items: [{ name: "", issuer: "", date: "" }] };
      }
      else if (b.type === "award") {
        form[b.id] = { items: [{ name: "", time: "", desc: "" }] };
      }
      else if (b.type === "reference") {
        form[b.id] = {
          items: [
            { name: "", position: "", company: "", phone: "", email: "" }
          ]
        };
      }
      else {
        form[b.id] = {};
      }
    });

  } catch (err) {
    console.error(err);
    toast.error("Không thể load template!");
  }
}

function onAvatarChange(e, blockId) {
  const file = e.target.files?.[0];
  if (!file) return;

  const reader = new FileReader();
  reader.onload = () => {
    form[blockId].url = reader.result;
  };
  reader.readAsDataURL(file);
}

function addSkill(blockId) {
  if (!tempSkill.value.trim()) return;
  form[blockId].items.push(tempSkill.value.trim());
  tempSkill.value = "";
}
function removeSkill(blockId, index) {
  form[blockId].items.splice(index, 1)
}

function addHobby(blockId) {
  if (!tempHobby.value.trim()) return;
  form[blockId].items.push(tempHobby.value.trim());
  tempHobby.value = "";
}
function removeHobby(blockId, i) {
  form[blockId].items.splice(i, 1);
}

function addEdu(blockId) {
  form[blockId].items.push({ school: "", major: "", time: "" });
}
function removeEdu(blockId, index) {
  form[blockId].items.splice(index, 1);
}

function addExperience(blockId) {
  form[blockId].items.push({ company: "", position: "", time: "", desc: "" });
}
function removeExperience(blockId, index) {
  form[blockId].items.splice(index, 1);
}

function addProject(blockId) {
  form[blockId].items.push({ name: "", role: "", tech: "", desc: "" });
}
function removeProject(blockId, index) {
  form[blockId].items.splice(index, 1);
}

function addCertificate(blockId) {
  form[blockId].items.push({ name: "", issuer: "", date: "" });
}
function removeCertificate(blockId, index) {
  form[blockId].items.splice(index, 1);
}

function addAward(blockId) {
  form[blockId].items.push({ name: "", time: "", desc: "" });
}
function removeAward(blockId, index) {
  form[blockId].items.splice(index, 1);
}

function addReference(blockId) {
  form[blockId].items.push({
    name: "",
    position: "",
    company: "",
    phone: "",
    email: ""
  });
}
function removeReference(blockId, index) {
  form[blockId].items.splice(index, 1);
}

function buildPayload() {
  const payload = {
    templateId: template.value.id,
    hoTen: "",
    viTriUngTuyen: "",
    avatarUrl: "",
    email: "",
    soDienThoai: "",
    diaChi: "",
    website: "",
    mucTieuNgheNghiep: "",
    hocVan: [],
    kinhNghiem: [],
    duAn: [],
    kyNang: [],
    chungChi: [],
    hoatDong: [],
    giaiThuong: [],
    nguoiThamChieu: [],
    soThich: [],
    thongTinThem: "",
  };

  blocks.value.forEach(b => {
    const f = form[b.id];

    switch (b.type) {
      case "header":
        payload.hoTen = f.text;
        payload.viTriUngTuyen = f.subText;
        break;

      case "contact":
        payload.email = f.email;
        payload.soDienThoai = f.phone;
        payload.diaChi = f.address;
        payload.website = f.website;
        break;

      case "avatar":
        payload.avatarUrl = f.url;
        break;

      case "target":
        payload.mucTieuNgheNghiep = f.text;
        break;

      case "skills":
        payload.kyNang = f.items.map((x, i) => ({
          tenKyNang: x,
          loai: "Chuyên môn",
          thuTu: i + 1,
        }));
        break;

      case "education":
        payload.hocVan = f.items.map((x, i) => ({
          truong: x.school,
          chuyenNganh: x.major,
          thoiGian: x.time,
          moTa: "",
          thuTu: i + 1
        }));
        break;

      case "experience":
        payload.kinhNghiem = f.items.map((x, i) => ({
          congTy: x.company,
          viTri: x.position,
          thoiGianLamViec: x.time,
          moTaCongViec: x.desc,
          thuTu: i + 1
        }));
        break;

      case "project":
        payload.duAn = f.items.map((x, i) => ({
          ten: x.name,
          vaiTro: x.role,
          moTa: x.desc,
          congNghe: x.tech,
          thuTu: i + 1
        }));
        break;

      case "certificate":
        payload.chungChi = f.items.map((x, i) => ({
          tenChungChi: x.name,
          noiCap: x.issuer,
          ngayCap: x.date,
          thuTu: i + 1
        }));
        break;

      case "award":
        payload.giaiThuong = f.items.map((x, i) => ({
          tenGiaiThuong: x.name,
          thoiGian: x.time,
          moTa: x.desc,
          thuTu: i + 1
        }));
        break;

      case "hobby":
        payload.soThich = f.items.map((x, i) => ({
          noiDung: x,
          thuTu: i + 1
        }));
        break;

      case "reference":
        payload.nguoiThamChieu = f.items.map((x, i) => ({
          ten: x.name,
          chucVu: x.position,
          congTy: x.company,
          soDienThoai: x.phone,
          email: x.email,
          thuTu: i + 1
        }));
        break;

      case "extra":
        payload.thongTinThem = f.text;
        break;
    }
  });

  return payload;
}

async function luuCV() {
  const payload = buildPayload();
  console.log("PAYLOAD:", payload);

  try {
    const res = await api.post("/CV/tao", payload, {
      headers: { Authorization: `Bearer ${auth.token}` },
    });

    toast.success("Tạo CV thành công!");
    router.push(`/cv/xem/${res.data.cv.id}`);

  } catch (err) {
    console.error(err);
    toast.error("Không thể lưu CV!");
  }
}

onMounted(loadTemplate);
</script>

<style scoped>
.input {
  @apply border rounded w-full p-2 text-sm outline-none focus:ring-2 focus:ring-blue-400;
}

aside {
  border-right: 1px solid #e5e7eb;
}

aside h2 {
  @apply text-lg font-bold text-gray-800;
}

aside h3 {
  @apply text-sm font-semibold text-gray-700;
}

.preview-block {
  @apply absolute overflow-hidden;
}

.cv-page {
  width: 794px;
  height: 1123px;
  background: white;
  border: 1px solid #d1d5db;
  box-shadow: 0 10px 30px rgba(0,0,0,0.15);
  position: relative;
  transform-origin: top center;
  padding: 0;
}

.cv-preview-wrapper {
  @apply flex-1 flex justify-center items-start overflow-auto bg-gray-100 px-8 py-10;
}

.block-card {
  @apply mb-6 p-3 border rounded-lg bg-gray-50 shadow-sm;
}

.block-card:hover {
  @apply shadow-md;
}

.btn-primary {
  @apply w-full bg-green-600 text-white py-2 rounded-lg hover:bg-green-700 transition font-semibold;
}

.btn-add {
  @apply border py-1 rounded bg-gray-100 w-full text-sm hover:bg-gray-200;
}

.skill-tag {
  @apply px-2 py-1 bg-gray-200 rounded text-sm flex items-center gap-1;
}

.edu-item {
  @apply border p-2 rounded bg-white shadow-sm;
}

.preview-header-title {
  font-weight: 700;
}

.preview-sub {
  @apply text-gray-600 text-sm;
}

.preview-section-title {
  @apply font-semibold mb-1 text-gray-800 uppercase tracking-wide;
}

::-webkit-scrollbar {
  width: 8px;
  height: 8px;
}

::-webkit-scrollbar-thumb {
  background: #cbd5e1;
  border-radius: 4px;
}

::-webkit-scrollbar-thumb:hover {
  background: #94a3b8;
}
</style>
