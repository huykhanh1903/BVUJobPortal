// src/router/index.js
import { createRouter, createWebHistory } from "vue-router";
import { useAuthStore } from "@/store/auth";

// Layouts
import AdminLayout from "@/pages/admin/AdminLayout.vue";

// User pages
import Home from "@/pages/jobs/Home.vue";
import Login from "@/pages/auth/Login.vue";
import Register from "@/pages/auth/Register.vue";
import ApplyJob from "@/pages/jobs/GuiUngTuyen.vue";
import CVList from "@/pages/cv/CVList.vue";
import Profile from "@/pages/profile/Profile.vue";
import EditProfile from "@/pages/profile/EditProfile.vue";
import XacThucEmail from "@/pages/auth/XacThucEmail.vue";


// Admin pages
import AdminHome from "@/pages/admin/AdminHome.vue";
import AdminUsers from "@/pages/admin/Users.vue";
import AdminJobs from "@/pages/admin/Jobs.vue";
import AdminCategories from "@/pages/admin/Categories.vue";
import AdminCompanies from "@/pages/admin/Companies.vue";
import AdminReports from "@/pages/admin/Reports.vue";
import AdminNotifications from "@/pages/admin/Notifications.vue";
import CreateUser from "@/pages/admin/CreateUser.vue";

const routes = [
  // User routes
  { path: "/", component: Home },
  { path: "/dang-nhap", component: Login },
  { path: "/dang-ky", component: Register },
  { path: "/ung-tuyen/:id", component: ApplyJob, meta: { requiresAuth: true } },
  { path: "/xac-thuc-email", name: "XacThucEmail", component: XacThucEmail },
  { path: "/quen-mat-khau",component: () => import("@/pages/auth/QuenMatKhau.vue")},
  { path: "/dat-lai-mat-khau",component: () => import("@/pages/auth/DatLaiMatKhau.vue")},
  { path: "/chon-vai-tro",name: "ChonVaiTro",component: () => import("@/pages/auth/ChonVaiTro.vue"),meta: { requiresAuth: true }},
  { path: "/tai-khoan-bi-khoa", name: "Taikhoankhoa",component: () => import("@/pages/auth/TaiKhoanKhoa.vue"),meta: { layout: "auth" }},

    // CV routes
  { path: "/cv", component: CVList, meta: { requiresAuth: true } },
  { path: "/cv", name: "CVList", component: CVList, meta: { requiresAuth: true } },
  { path: "/cv/tao", name: "TaoCV", component: () => import("@/pages/cv/TaoCV.vue"), meta: { requiresAuth: true } },
  { path: "/cv/sua/:id", name: "SuaCV", component: () => import("@/pages/cv/SuaCV.vue"), meta: { requiresAuth: true }, props: true },
  { path: "/cv/xem/:id", name: "XemCV", component: () => import("@/pages/cv/XemCV.vue"), meta: { requiresAuth: true }, props: true },

  { path: "/cv/chon-mau", component: () => import("@/pages/cv/ChonMauCV.vue"), meta: { requiresAuth: true } },
  { path: "/cv/xem-mau/:id", component: () => import("@/pages/cv/XemMauCV.vue"), meta: { requiresAuth: true } },
  { path: "/cv/tao-theo-mau/:id", component: () => import("@/pages/cv/TaoCVTheoMau.vue"), meta: { requiresAuth: true } },


  { path: "/hoso", component: Profile, meta: { requiresAuth: true } },
  { path: "/hoso/chinh-sua", name: "ChinhSuaHoSo", component: EditProfile, meta: { requiresAuth: true } },

  {
    path: "/admin",
    component: AdminLayout,
    meta: { requiresAuth: true, requiresRole: ["Admin", "SuperAdmin"] },
    children: [
      { path: "", name: "AdminHome", component: AdminHome },
      { path: "users", name: "AdminUsers", component: AdminUsers },
      { path: "jobs", name: "AdminJobs", component: AdminJobs },
      { path: "categories", name: "AdminCategories", component: AdminCategories },
      { path: "companies", name: "AdminCompanies", component: AdminCompanies },
      { path: "reports", name: "AdminReports", component: AdminReports },
      { path: "notifications", name: "AdminNotifications", component: AdminNotifications },
      {path: "create-user", name: "CreateUser", component: () => import("@/pages/admin/CreateUser.vue"), meta: { requiresAuth: true, requiresRole: ["Admin", "SuperAdmin"] } },
      {path: "cv-templates",name: "AdminCVTemplates",component: () => import("@/pages/admin/AdminCVTemplates.vue"),meta: { requiresAuth: true, requiresRole: ["Admin", "SuperAdmin"] }},
      {path: "cv-templates/edit/:id?",name: "EditCVTemplate",component: () => import("@/pages/admin/EditCVTemplate.vue"),meta: { requiresAuth: true, requiresRole: ["Admin", "SuperAdmin"] }},
      {path: '/admin/nghe-nghiep', name: 'AdminNgheNghiep', component: () => import('@/pages/admin/NgheNghiepQuanLy.vue'), meta: { requiresAuth: true, requiresRole: ["Admin", "SuperAdmin"] }},
      {path: "cv-templates-new",name: "AdminCVTemplates-New",component: () => import("@/pages/admin/cv-template/AdminCVTemplates.vue"),meta: { requiresAuth: true, requiresRole: ["Admin", "SuperAdmin"] },},
      {path: '/admin/chuyen-nganh', name: 'AdminChuyenNganh', component: () => import('@/pages/admin/ChuyenNganhQuanLy.vue'), meta: { requiresAuth: true, requiresRole: ["Admin", "SuperAdmin"] }},
      {path: "cv-template/builder", name: "CVTemplateBuilder",component: () => import("@/pages/admin/cv-template/CVTemplateBuilder.vue"),meta: { requiresAuth: true, requiresRole: ["Admin", "SuperAdmin"] },},
      {path: "cv-template/builder/:id",name: "CVTemplateBuilderEdit",component: () => import("@/pages/admin/cv-template/CVTemplateBuilder.vue"),props: true,},
      {path: "chat",name: "AdminChat",component: () => import("@/pages/admin/AdminChat.vue"),meta: { requiresAuth: true, requiresRole: ["Admin", "SuperAdmin"] }},
      {path: "khieu-nai",name: "AdminKhieuNai",component: () => import("@/pages/admin/AdminKhieuNai.vue"),meta: { requiresAuth: true, requiresRole: ["Admin", "SuperAdmin"] }},
    ],
  },

{
  path: "/nha-tuyen-dung",
  meta: { requiresAuth: true, requiresRole: ["NhaTuyenDung"] },
  children: [
    {
      path: "tin-tuyen-dung",
      name: "JobList",
      // component: () => import("@/pages/jobs/JobList.vue"),
      component: () => import("@/pages/employer/DSTinDang.vue"),
    },
    {
      path: "/nha-tuyen-dung/dang-tin",
      name: "DangTin",
      component: () => import("@/pages/employer/DangTin.vue"),
      meta: { requiresAuth: true, requiresRole: ["NhaTuyenDung"] },
    },
    {
      path: "tin-tuyen-dung/:id",
      name: "ChiTietTinDang",
      component: () => import("@/pages/employer/ChiTietTinDang.vue"),
      meta: { requiresAuth: true, requiresRole: ["NhaTuyenDung"] },
    },
    {
      path: "sua-tin/:id",
      name: "EmployerEdit",
      component: () =>
      import("@/pages/employer/ChinhSuaTinDang.vue"),
      props: true,
    },
    {
      path: "/nha-tuyen-dung/don-ung-tuyen",
      name: "NTD_DonUngTuyen",
      component: () => import("@/pages/employer/DSDonUngTuyen.vue"),
      meta: { requiresAuth: true, requiresRole: ["NhaTuyenDung"] }
    },
    {
      path: "/nha-tuyen-dung/don-ung-tuyen/:id",
      name: "NTD_ChiTietDon",
      component: () => import("@/pages/employer/ChiTietDonUngTuyen.vue"),
      meta: { requiresAuth: true, requiresRole: ["NhaTuyenDung"] }
    },
        {
      path: "tim-ung-vien",
      name: "NTD_TimUngVien",
      component: () =>
        import("@/pages/employer/TimKiemUngVien.vue"),
    },
  ],
},

//Doanhnghiep
{
  path: "/doanh-nghiep",
  meta: { requiresAuth: true, requiresRole: ["DoanhNghiep"] },
  children: [
    {
      path: "nhan-su",
      name: "QuanLyNhanSu",
      component: () => import("@/pages/doanhnghiep/QuanLyHR.vue"),
    },
    {
      path: "viec-lam",
      name: "DN_DanhSachCongViec",
      component: () => import("@/pages/doanhnghiep/DSCongViecDN.vue"),
    },
  ],
},

//--Sinh viên---
{
  path: "/viec-lam",
  name: "DanhSachCongViec",
  component: () => import("@/pages/sinhvien/DSCongViec.vue"),
},
{
  path: "/viec-lam/:id",
  name: "ChiTietCongViec",
  component: () => import("@/pages/sinhvien/ChiTietCongViec.vue"),
  props: true,
},
{
  path: "/cong-ty",
  name: "DanhSachCongTy",
  component: () => import("@/pages/sinhvien/DSCongTy.vue")
},
{
  path: "/cong-ty/:id",
  name: "CongTyProfile",
  component: () => import("@/pages/sinhvien/CongTyProfile.vue")
},
{
  path: "/lich-su-ung-tuyen",
  name: "LichSuUngTuyen",
  component: () => import("@/pages/sinhvien/LichSuUngTuyen.vue"),
  meta: { requiresAuth: true }
},

{
  path: "/cv/xem",
  name: "XemCVTemplate",
  component: () => import("@/pages/sinhvien/CVTemplateView.vue")
},

  { path: "/:pathMatch(.*)*", redirect: "/" },
];

const router = createRouter({
  history: createWebHistory(),
  routes,
});

router.beforeEach((to, from, next) => {
  const auth = useAuthStore();

  if (
    auth.isAuthenticated &&
    auth.user?.biKhoa &&
    to.path !== "/tai-khoan-bi-khoa"
  ) {
    return next({
      name: "AccountLocked",
      query: {
        lyDo: auth.user.lyDoKhoa || "Tài khoản đã bị khóa"
      }
    });
  }

  if (["/dang-nhap", "/dang-ky"].includes(to.path)) return next();

  if (to.meta.requiresAuth && !auth.isAuthenticated) {
    return next("/dang-nhap");
  }

  if (to.meta.requiresRole) {
    const allowedRoles = Array.isArray(to.meta.requiresRole)
      ? to.meta.requiresRole
      : [to.meta.requiresRole];
    if (!allowedRoles.includes(auth.user?.vaiTro)) {
      return next("/");
    }
  }

  next();
});

export default router;
