<template>
  <div class="flex flex-col items-center bg-gray-100 py-12">

    <button
      @click="exportPDFTemplate"
      class="mb-4 px-5 py-2 bg-green-600 text-white rounded-lg shadow hover:bg-green-700"
    >
      ⬇️ Tải PDF
    </button>

    <div
      id="cv-preview"
      v-if="!loading"
      class="relative bg-white shadow-2xl border rounded overflow-hidden"
      :style="{
        width: '794px',
        height: '1123px',
        fontFamily: style.font || 'Inter',
        position: 'relative'
      }"
    >
      <div
        v-if="style.backgroundColor"
        class="absolute inset-0"
        :style="{ backgroundColor: style.backgroundColor, opacity: 0.15 }"
      ></div>

      <div
        v-for="block in blocks"
        :key="block.id"
        class="absolute"
        :style="{
          left: block.x + 'px',
          top: block.y + 'px',
          width: block.width + 'px',
          height: block.height + 'px',
          overflow: 'hidden'
        }"
      >

        <template v-if="block.type === 'header'">
          <div class="h-full flex flex-col justify-center">
            <div
              class="font-bold"
              :style="{
                fontSize: (block.props.fontSize || 28) + 'px',
                color: block.props.color || '#111',
                textAlign: block.props.align || 'left'
              }"
            >
              {{ block.props.text }}
            </div>
            <div class="text-gray-500 text-xs">{{ block.props.subText }}</div>
          </div>
        </template>

        <template v-else-if="block.type === 'avatar'">
          <div class="w-full h-full flex items-center justify-center">
            <img
              v-if="block.props.url"
              :src="block.props.url"
              class="w-full h-full"
              :style="{ borderRadius: (block.props.borderRadius || 50) + '%',
                        objectFit: block.props.objectFit || 'cover' }"
            />
            <div v-else class="text-gray-400 text-xs">(Không có ảnh)</div>
          </div>
        </template>

        <template v-else-if="block.type === 'contact'">
          <div class="text-[12px] space-y-1">
            <div class="font-semibold uppercase" :style="{ color: style.primaryColor }">
              📇 Thông tin liên hệ
            </div>
            <div v-if="block.props.email">📧 {{ block.props.email }}</div>
            <div v-if="block.props.phone">📱 {{ block.props.phone }}</div>
            <div v-if="block.props.address">📍 {{ block.props.address }}</div>
            <div v-if="block.props.website">🌐 {{ block.props.website }}</div>
          </div>
        </template>

        <template v-else-if="block.type === 'target'">
          <div class="text-[12px] whitespace-pre-line">
            <div class="font-semibold uppercase mb-1" :style="{ color: style.primaryColor }">
              🎯 Mục tiêu nghề nghiệp
            </div>
            {{ block.props.text }}
          </div>
        </template>

        <template v-else-if="block.type === 'education'">
          <div class="text-[12px]">
            <div class="font-semibold uppercase mb-1" :style="{ color: style.primaryColor }">
              🎓 Học vấn
            </div>
            <div v-for="(edu, i) in block.props.items" :key="i" class="mb-2">
              <div class="font-medium">{{ edu.school }}</div>
              <div class="text-gray-600">{{ edu.major }} · {{ edu.time }}</div>
              <div class="text-gray-500">{{ edu.desc }}</div>
            </div>
          </div>
        </template>

        <template v-else-if="block.type === 'experience'">
          <div class="text-[12px]">
            <div class="font-semibold uppercase mb-1" :style="{ color: style.primaryColor }">
              💼 Kinh nghiệm làm việc
            </div>

            <div v-for="(exp, i) in block.props.items" :key="i" class="mb-2">
              <div class="font-medium">{{ exp.position }} – {{ exp.company }}</div>
              <div class="text-gray-500">{{ exp.time }}</div>
              <div>- {{ exp.desc }}</div>
            </div>
          </div>
        </template>

        <template v-else-if="block.type === 'skills'">
          <div class="text-[12px]">
            <div class="font-semibold uppercase mb-1" :style="{ color: style.primaryColor }">
              🛠 Kỹ năng
            </div>

            <div class="flex flex-wrap gap-1">
              <span
                v-for="(s, i) in block.props.items"
                :key="i"
                class="px-2 py-1 border rounded bg-gray-100"
              >
                {{ s }}
              </span>
            </div>
          </div>
        </template>

        <template v-else-if="block.type === 'project'">
          <div class="text-[12px]">
            <div class="font-semibold uppercase mb-1" :style="{ color: style.primaryColor }">
              📂 Dự án
            </div>

            <div v-for="(p, i) in block.props.items" :key="i" class="mb-2">
              <div class="font-medium">{{ p.name }}</div>
              <div class="text-gray-500 text-xs">Vai trò: {{ p.role }}</div>
              <div class="text-gray-500 text-xs">Công nghệ: {{ p.tech }}</div>
              <div>- {{ p.desc }}</div>
            </div>
          </div>
        </template>

        <template v-else-if="block.type === 'certificate'">
          <div class="text-[12px]">
            <div class="font-semibold uppercase mb-1" :style="{ color: style.primaryColor }">
              📜 Chứng chỉ
            </div>

            <div v-for="(c, i) in block.props.items" :key="i" class="mb-1">
              <div class="font-medium">{{ c.name }}</div>
              <div class="text-gray-500">{{ c.issuer }} · {{ c.date }}</div>
            </div>
          </div>
        </template>

        <template v-else-if="block.type === 'award'">
          <div class="text-[12px]">
            <div class="font-semibold uppercase mb-1" :style="{ color: style.primaryColor }">
              🏆 Giải thưởng
            </div>

            <div v-for="(a, i) in block.props.items" :key="i">
              <div class="font-medium">{{ a.name }}</div>
              <div class="text-gray-500">{{ a.time }}</div>
            </div>
          </div>
        </template>

        <template v-else-if="block.type === 'reference'">
          <div class="text-[12px]">
            <div class="font-semibold uppercase mb-1" :style="{ color: style.primaryColor }">
              👤 Người tham chiếu
            </div>

            <div v-for="(r, i) in block.props.items" :key="i">
              <div class="font-medium">{{ r.name }}</div>
              <div class="text-gray-500 text-xs">{{ r.position }} – {{ r.company }}</div>
              <div class="text-gray-500 text-xs">☎ {{ r.phone }} · ✉ {{ r.email }}</div>
            </div>
          </div>
        </template>

        <template v-else-if="block.type === 'hobby'">
          <div class="text-[12px]">
            <div class="font-semibold uppercase" :style="{ color: style.primaryColor }">
              🎯 Sở thích
            </div>

            <ul class="ml-4 list-disc">
              <li v-for="(h, i) in block.props.items" :key="i">{{ h }}</li>
            </ul>
          </div>
        </template>

        <template v-else-if="block.type === 'extra'">
          <div class="text-[12px] whitespace-pre-line">
            <div class="font-semibold uppercase mb-1" :style="{ color: style.primaryColor }">
              📌 Thông tin thêm
            </div>
            {{ block.props.text }}
          </div>
        </template>

      </div>
    </div>

    <div v-else class="text-gray-500 py-10">⏳ Đang tải CV...</div>
  </div>
</template>

<script setup>
import { ref, onMounted } from "vue";
import api from "@/api/axios";
import { useRoute } from "vue-router";

const route = useRoute();

const cv = ref(null);
const blocks = ref([]);
const style = ref({});
const loading = ref(true);

onMounted(async () => {
  try {
    const res = await api.get(`/CV/${route.params.id}`);
    cv.value = res.data;

    const resTpl = await api.get(`/admin/cv-templates/${cv.value.templateId}`);
    const tpl = resTpl.data;

    blocks.value = JSON.parse(tpl.layoutJson).blocks;
    style.value = JSON.parse(tpl.styleJson);

    applyCVToBlocks();
  } catch (e) {
    console.error(e);
  } finally {
    loading.value = false;
  }
});

function applyCVToBlocks() {
  blocks.value = blocks.value.map(b => {
    switch (b.type) {
      case "header":
        b.props.text = cv.value.hoTen;
        b.props.subText = cv.value.viTriUngTuyen;
        break;

      case "avatar":
        b.props.url = cv.value.avatarUrl;
        break;

      case "contact":
        b.props.email = cv.value.email;
        b.props.phone = cv.value.soDienThoai;
        b.props.address = cv.value.diaChi;
        b.props.website = cv.value.website;
        break;

      case "target":
        b.props.text = cv.value.mucTieuNgheNghiep;
        break;

      case "education":
        b.props.items = cv.value.hocVan.map(x => ({
          school: x.truong,
          major: x.chuyenNganh,
          time: x.thoiGian,
          desc: x.moTa
        }));
        break;

      case "experience":
        b.props.items = cv.value.kinhNghiem.map(x => ({
          company: x.congTy,
          position: x.viTri,
          time: x.thoiGianLamViec,
          desc: x.moTaCongViec
        }));
        break;

      case "project":
        b.props.items = cv.value.duAn.map(x => ({
          name: x.ten,
          role: x.vaiTro,
          tech: x.congNghe,
          desc: x.moTa
        }));
        break;

      case "skills":
        b.props.items = cv.value.kyNang.map(x => x.tenKyNang);
        break;

      case "certificate":
        b.props.items = cv.value.chungChi.map(x => ({
          name: x.tenChungChi,
          issuer: x.noiCap,
          date: x.ngayCap
        }));
        break;

      case "award":
        b.props.items = cv.value.giaiThuong.map(x => ({
          name: x.tenGiaiThuong,
          time: x.thoiGian
        }));
        break;

      case "reference":
        b.props.items = cv.value.nguoiThamChieu.map(x => ({
          name: x.ten,
          position: x.chucVu,
          company: x.congTy,
          phone: x.soDienThoai,
          email: x.email
        }));
        break;

      case "hobby":
        b.props.items = cv.value.soThich.map(x => x.noiDung);
        break;

      case "extra":
        b.props.text = cv.value.thongTinThem;
        break;
    }
    return b;
  });
}

async function exportPDFTemplate() {
  try {
    const el = document.getElementById("cv-preview");
    if (!el) return;

    const html = el.outerHTML;

    let css = "";

    for (const sheet of document.styleSheets) {
      try {
        for (const rule of sheet.cssRules) {
          css += rule.cssText;
        }
      } catch (err) {
        const href = sheet.href;
        if (href) {
          try {
            const r = await fetch(href);
            css += await r.text();
          } catch (e) {
            console.warn("Không load được CSS:", href);
          }
        }
      }
    }

    const res = await api.post(
      "/CV/export-html",
      {
        html,
        css,
        width: 794,
        height: 1123
      },
      { responseType: "blob" }
    );

    const url = URL.createObjectURL(new Blob([res.data]));
    const a = document.createElement("a");
    a.href = url;
    a.download = `CV_${route.params.id}.pdf`;
    a.click();
    URL.revokeObjectURL(url);

  } catch (err) {
    console.error("Export PDF lỗi:", err);
    alert("Xuất PDF thất bại!");
  }
}
async function taiPdfTemplate(id) {
  try {

    const resCv = await api.get(`/CV/${id}`, {
      headers: { Authorization: `Bearer ${auth.token}` }
    });
    const cv = resCv.data;

    const resTpl = await api.get(`/admin/cv-templates/${cv.templateId}`);
    const tpl = resTpl.data;

    const blocks = JSON.parse(tpl.layoutJson).blocks;
    const style = JSON.parse(tpl.styleJson);

    const processedBlocks = blocks.map(b => {
      switch (b.type) {
        case "header":
          b.props.text = cv.hoTen;
          b.props.subText = cv.viTriUngTuyen;
          break;

        case "avatar":
          b.props.url = cv.avatarUrl;
          break;

        case "contact":
          b.props.email = cv.email;
          b.props.phone = cv.soDienThoai;
          b.props.address = cv.diaChi;
          b.props.website = cv.website;
          break;

        case "target":
          b.props.text = cv.mucTieuNgheNghiep;
          break;

        case "education":
          b.props.items = cv.hocVan.map(x => ({
            school: x.truong,
            major: x.chuyenNganh,
            time: x.thoiGian,
            desc: x.moTa
          }));
          break;

        case "experience":
          b.props.items = cv.kinhNghiem.map(x => ({
            company: x.congTy,
            position: x.viTri,
            time: x.thoiGianLamViec,
            desc: x.moTaCongViec
          }));
          break;

        case "project":
          b.props.items = cv.duAn.map(x => ({
            name: x.ten,
            role: x.vaiTro,
            tech: x.congNghe,
            desc: x.moTa
          }));
          break;

        case "skills":
          b.props.items = cv.kyNang.map(x => x.tenKyNang);
          break;

        case "certificate":
          b.props.items = cv.chungChi.map(x => ({
            name: x.tenChungChi,
            issuer: x.noiCap,
            date: x.ngayCap
          }));
          break;

        case "award":
          b.props.items = cv.giaiThuong.map(x => ({
            name: x.tenGiaiThuong,
            time: x.thoiGian
          }));
          break;

        case "reference":
          b.props.items = cv.nguoiThamChieu.map(x => ({
            name: x.ten,
            position: x.chucVu,
            company: x.congTy,
            phone: x.soDienTho,
            email: x.email
          }));
          break;

        case "hobby":
          b.props.items = cv.soThich.map(x => x.noiDung);
          break;

        case "extra":
          b.props.text = cv.thongTinThem;
          break;
      }
      return b;
    });

    let html = `
      <div style="position: relative; width: 794px; height: 1123px; font-family: ${style.font}">
        <div style="position:absolute; inset:0; background:${style.backgroundColor}22"></div>
    `;

    for (const b of processedBlocks) {
      html += `
        <div style="
          position:absolute;
          left:${b.x}px;
          top:${b.y}px;
          width:${b.width}px;
          height:${b.height}px;
          overflow:hidden;
        ">
          ${renderBlock(b)}
        </div>
      `;
    }

    html += "</div>";

    let css = "";
    for (const sheet of document.styleSheets) {
      try {
        for (const rule of sheet.cssRules) css += rule.cssText;
      } catch {}
    }

    const res = await api.post(
      "/CV/export-html",
      {
        html,
        css,
        width: 794,
        height: 1123
      },
      { responseType: "blob" }
    );

    const url = URL.createObjectURL(new Blob([res.data]));
    const a = document.createElement("a");
    a.href = url;
    a.download = `CV_${id}_template.pdf`;
    a.click();
    URL.revokeObjectURL(url);

    toast.success("Xuất PDF Template thành công!");

  } catch (err) {
    console.error(err);
    toast.error("Lỗi xuất PDF Template!");
  }
}

function renderBlock(b) {
  switch (b.type) {
    case "header":
      return `
        <div style="font-size:${b.props.fontSize}px; font-weight:bold; color:${
        b.props.color
      }; text-align:${b.props.align}">
          ${b.props.text}
        </div>
        <div style="font-size:12px; color:#666">${b.props.subText}</div>
      `;

    case "avatar":
      return `
        <img src="${b.props.url}" style="width:100%;height:100%;object-fit:cover;border-radius:${b.props.borderRadius}%;" />
      `;

    case "contact":
      return `
        <div style="font-size:12px;">
          <div><b>📧</b> ${b.props.email}</div>
          <div><b>📱</b> ${b.props.phone}</div>
          <div><b>📍</b> ${b.props.address}</div>
          <div><b>🌐</b> ${b.props.website}</div>
        </div>
      `;

    case "skills":
      return `
        <div style="font-size:12px; display:flex; flex-wrap:wrap; gap:4px;">
          ${b.props.items
            .map(x => `<span style="padding:2px 6px;border:1px solid #ccc;border-radius:4px;">${x}</span>`)
            .join("")}
        </div>
      `;

    default:
      return `<div style="font-size:12px;">${JSON.stringify(b.props)}</div>`;
  }
}


</script>

<style>
</style>
