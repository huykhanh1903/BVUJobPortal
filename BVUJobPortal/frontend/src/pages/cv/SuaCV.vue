<template>
  <div class="min-h-screen bg-gray-100 flex">

    <aside class="w-96 bg-white border-r p-6 overflow-y-auto shadow-lg">
      <h2 class="text-2xl font-bold mb-5 text-gray-800">📝 Chỉnh sửa CV</h2>

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
          <textarea v-model="form[block.id].text" class="input" rows="4"></textarea>
        </div>

        <div v-else-if="block.type === 'contact'" class="space-y-2">
          <input v-model="form[block.id].email" class="input" placeholder="Email" />
          <input v-model="form[block.id].phone" class="input" placeholder="SĐT" />
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
            <textarea v-model="edu.desc" class="input" rows="2" placeholder="Mô tả"></textarea>

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
            <input v-model="cc.date" type="date" class="input" />
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
            <button @click="removeAward(block.id, i)" class="text-red-600">Xóa</button>
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

        <div v-else-if="block.type === 'avatar'">
          <input type="file" accept="image/*" @change="e => onAvatarChange(e, block.id)" />
        </div>

      </div>

      <button @click="updateCV" class="w-full bg-green-600 text-white py-3 rounded-xl shadow-lg">
        💾 Cập nhật CV
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
              {{ form[block.id].text }}
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
            <h3 class="font-semibold mb-1">🛠 Kỹ năng</h3>
            <div class="flex flex-wrap gap-2">
              <span
                v-for="(skill, i) in form[block.id].items"
                :key="i"
                class="px-2 py-1 bg-gray-100 rounded text-xs border"
              >{{ skill }}</span>
            </div>
          </div>

          <div v-else-if="block.type === 'education'" class="text-sm">
            <h3 class="font-semibold mb-1">🎓 Học vấn</h3>
            <div
              v-for="(edu, i) in form[block.id].items"
              :key="i"
            >
              <b>{{ edu.school }}</b>
              <p>{{ edu.major }} – {{ edu.time }}</p>
              <p v-if="edu.desc">{{ edu.desc }}</p>
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
            <div
              v-for="(pj, i) in form[block.id].items"
              :key="i"
            >
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
            <ul class="ml-4 list-disc">
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
import { useAuthStore } from "@/store/auth";
import api from "@/api/axios";
import { useToast } from "vue-toastification";

const route = useRoute();
const router = useRouter();
const toast = useToast();
const auth = useAuthStore();


const A4 = { width: 794, height: 1123 };
const blocks = ref([]);
const template = ref(null);

const form = reactive({});
const tempSkill = ref("");

function blockTitle(type) {
  return {
    header: "Tiêu đề CV",
    text: "Đoạn nội dung",
    target: "Mục tiêu nghề nghiệp",
    contact: "Liên hệ",
    skills: "Kỹ năng",
    education: "Học vấn",
    experience: "Kinh nghiệm",
    project: "Dự án",
    certificate: "Chứng chỉ",
    award: "Giải thưởng",
    reference: "Người tham chiếu",
    hobby: "Sở thích",
    extra: "Thông tin thêm",
    avatar: "Ảnh đại diện"
  }[type] || "Khối nội dung";
}

const currentCV = ref(null);

async function loadData() {
  try {
    const cvRes = await api.get(`/CV/${route.params.id}`);
    const cv = cvRes.data;
    currentCV.value = cv;

    if (!cv.templateId) {
      toast.error("CV này chưa có Template! Vui lòng chọn Template trước.");
      router.push("/cv/chon-template");
      return;
    }

    const tplRes = await api.get(`/admin/cv-templates/${cv.templateId}`);
    template.value = tplRes.data;

    blocks.value = JSON.parse(template.value.layoutJson).blocks;

    blocks.value.forEach((b) => {
      if (b.type === "header")
        form[b.id] = { text: cv.hoTen, subText: cv.viTriUngTuyen };

      else if (["text", "target", "extra"].includes(b.type))
        form[b.id] = { text: cv.mucTieuNgheNghiep };

      else if (b.type === "contact")
        form[b.id] = {
          email: cv.email,
          phone: cv.soDienThoai,
          address: cv.diaChi,
          website: cv.website
        };

      else if (b.type === "avatar")
        form[b.id] = { url: cv.avatarUrl };

      else if (b.type === "skills")
        form[b.id] = { items: cv.kyNang.map((k) => k.tenKyNang) };

      else if (b.type === "education")
        form[b.id] = {
          items: cv.hocVan.map((x) => ({
            school: x.truong,
            major: x.chuyenNganh,
            time: x.thoiGian,
            desc: x.moTa
          }))
        };

      else if (b.type === "experience")
        form[b.id] = {
          items: cv.kinhNghiem.map((x) => ({
            company: x.congTy,
            position: x.viTri,
            time: x.thoiGianLamViec,
            desc: x.moTaCongViec
          }))
        };

      else if (b.type === "project")
        form[b.id] = {
          items: cv.duAn.map((x) => ({
            name: x.ten,
            role: x.vaiTro,
            tech: x.congNghe,
            desc: x.moTa
          }))
        };

      else if (b.type === "certificate")
        form[b.id] = {
          items: cv.chungChi.map((x) => ({
            name: x.tenChungChi,
            issuer: x.noiCap,
            date: x.ngayCap ? x.ngayCap.substring(0, 10) : ""
          }))
        };

      else if (b.type === "award")
        form[b.id] = {
          items: cv.giaiThuong.map((x) => ({
            name: x.tenGiaiThuong,
            time: x.thoiGian,
            desc: x.moTa
          }))
        };

      else if (b.type === "reference")
        form[b.id] = {
          items: cv.nguoiThamChieu.map((x) => ({
            name: x.ten,
            position: x.chucVu,
            company: x.congTy,
            phone: x.soDienThoai,
            email: x.email
          }))
        };

      else if (b.type === "hobby")
        form[b.id] = {
          items: cv.soThich.map((x) => ({ value: x.noiDung }))
        };
    });
  } catch (err) {
    console.error(err);
    toast.error("Lỗi load dữ liệu!");
  }
}

function onAvatarChange(e, blockId) {
  const file = e.target.files[0];
  if (!file) return;

  const reader = new FileReader();
  reader.onload = () => {
    form[blockId].url = reader.result;
  };
  reader.readAsDataURL(file);
}

async function updateCV() {
  const payload = {};
  payload.templateId = currentCV.value.templateId;

  blocks.value.forEach((b) => {
    const f = form[b.id];

    switch (b.type) {
      case "header":
        payload.hoTen = f.text;
        payload.viTriUngTuyen = f.subText;
        break;

      case "text":
      case "target":
      case "extra":
        payload.mucTieuNgheNghiep = f.text;
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

      case "skills":
        payload.kyNang = f.items.map((x) => ({
          tenKyNang: x,
          loai: "Chung",
          thuTu: 1
        }));
        break;

      case "education":
        payload.hocVan = f.items.map((x) => ({
          truong: x.school,
          chuyenNganh: x.major,
          thoiGian: x.time,
          moTa: x.desc
        }));
        break;

      case "experience":
        payload.kinhNghiem = f.items.map((x) => ({
          congTy: x.company,
          viTri: x.position,
          thoiGianLamViec: x.time,
          moTaCongViec: x.desc
        }));
        break;

      case "project":
        payload.duAn = f.items.map((x) => ({
          ten: x.name,
          vaiTro: x.role,
          congNghe: x.tech,
          moTa: x.desc
        }));
        break;

      case "certificate":
        payload.chungChi = f.items.map((x) => ({
          tenChungChi: x.name,
          noiCap: x.issuer,
          ngayCap: x.date
        }));
        break;

      case "award":
        payload.giaiThuong = f.items.map((x) => ({
          tenGiaiThuong: x.name,
          thoiGian: x.time,
          moTa: x.desc
        }));
        break;

      case "reference":
        payload.nguoiThamChieu = f.items.map((x) => ({
          ten: x.name,
          chucVu: x.position,
          congTy: x.company,
          soDienThoai: x.phone,
          email: x.email
        }));
        break;

      case "hobby":
        payload.soThich = f.items.map((x) => ({ noiDung: x.value }));
        break;
    }
  });

  try {
    await api.put(`/CV/${route.params.id}`, payload, {
      headers: { Authorization: `Bearer ${auth.token}` }
    });
    toast.success("Cập nhật CV thành công!");
    router.push("/cv");
  } catch (err) {
    console.error(err);
    toast.error("Không thể cập nhật CV!");
  }
}

onMounted(loadData);
</script>

<style scoped>
.input {
  @apply border rounded w-full p-2 text-sm outline-none;
}
.btn-add {
  @apply w-full border py-2 rounded bg-gray-100 hover:bg-gray-200;
}
</style>
