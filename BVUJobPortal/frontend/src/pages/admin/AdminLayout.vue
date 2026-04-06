<template>
  <div class="flex min-h-screen bg-gray-100">
    <aside
      class="fixed md:static inset-y-0 left-0 transform transition-all duration-300 ease-in-out
             bg-indigo-800 text-white flex flex-col shadow-xl z-20"
      :class="[
        sidebarOpen ? 'translate-x-0' : '-translate-x-full',
        collapsed ? 'w-20' : 'w-64',
        'md:translate-x-0'
      ]"
    >
      <div class="h-16 flex items-center justify-between px-4 border-b border-indigo-700">
        <span
          class="font-bold text-lg truncate transition-all duration-300"
          :class="collapsed ? 'opacity-0 w-0' : 'opacity-100 w-auto'"
        >
          ⚙️ Admin Panel
        </span>

        <button
          class="md:hidden text-indigo-200 hover:text-white"
          @click="sidebarOpen = false"
        >
          ✖
        </button>
      </div>

      <nav class="flex-1 p-4 overflow-y-auto space-y-8">
        <div v-for="(group, idx) in menu" :key="idx">

          <div
            class="px-3 py-1 text-xs tracking-widest text-indigo-300 font-semibold uppercase mb-1"
            :class="collapsed ? 'hidden' : ''"
          >
            {{ group.header }}
          </div>

          <div class="space-y-1">
            <router-link
              v-for="item in group.items"
              :key="item.to"
              :to="item.to"
              class="menu-link flex items-center gap-3"
              active-class="active-link"
            >
              <span class="text-lg">{{ item.icon }}</span>

              <span
                class="transition-all duration-200 origin-left"
                :class="collapsed ? 'opacity-0 scale-0 w-0' : 'opacity-100 scale-100 w-auto'"
              >
                {{ item.label }}
              </span>
            </router-link>
          </div>
        </div>
      </nav>

      <div
        class="p-4 border-t border-indigo-700 text-xs text-indigo-200 text-center transition-all duration-300 space-y-3"
        :class="collapsed ? 'opacity-0 scale-0 h-0' : 'opacity-100 scale-100 h-auto'"
      >
        <button
          @click="goHome"
          class="w-full py-2 bg-indigo-600 hover:bg-indigo-700 text-white rounded-lg transition text-sm font-medium"
        >
          🏠 Về trang người dùng
        </button>

        <p class="text-[11px] text-indigo-300 mt-2">© 2025 BVU Job Portal</p>
      </div>
    </aside>

    <div
      v-if="sidebarOpen"
      class="fixed inset-0 bg-black bg-opacity-40 md:hidden z-10"
      @click="sidebarOpen = false"
    ></div>

    <div class="flex-1 flex flex-col">
      <header
        class="h-16 bg-white shadow flex items-center justify-between px-6 sticky top-0 z-10"
      >
        <div class="flex items-center gap-3">
          <button
            class="md:hidden text-2xl text-indigo-700"
            @click="sidebarOpen = true"
          >
            ☰
          </button>

          <button
            class="hidden md:block text-indigo-700 text-xl hover:scale-110 transition"
            @click="collapsed = !collapsed"
          >
            📏
          </button>
        </div>

        <div class="flex items-center gap-4 ml-auto">
          <span class="text-gray-700 font-medium hidden sm:block">
            👋 Xin chào, <b>{{ auth.user?.hoTen }}</b>
          </span>

          <button
            @click="logout"
            class="text-sm bg-red-500 text-white px-3 py-1 rounded hover:bg-red-600 transition duration-200"
          >
            Đăng xuất
          </button>
        </div>
      </header>

      <main class="p-6 flex-1 overflow-y-auto">
        <transition name="fade-slide" mode="out-in">
          <router-view />
        </transition>
      </main>
    </div>
  </div>
</template>

<script setup>
import { ref } from "vue";
import { useAuthStore } from "@/store/auth";
import { useRouter } from "vue-router";

const auth = useAuthStore();
const router = useRouter();

const sidebarOpen = ref(false);
const collapsed = ref(false);

const logout = () => {
  auth.logout();
  router.push("/dang-nhap");
};

function goHome() {
  router.push("/");
}

const menu = [
  {
    header: "HỆ THỐNG",
    items: [
      { to: "/admin", label: "Dashboard", icon: "📊" },
      { to: "/admin/users", label: "Người dùng", icon: "👤" },
      { to: "/admin/notifications", label: "Thông báo", icon: "🔔" },
      { to: "/admin/chat", label: "Chat hỗ trợ", icon: "💬" },
      { to: "/admin/khieu-nai", label: "Khiếu nại", icon: "⚠️"}
    ],
  },
  {
    header: "TUYỂN DỤNG",
    items: [
      { to: "/admin/companies", label: "Công ty", icon: "🏢" },
      { to: "/admin/jobs", label: "Công việc", icon: "💼" },
    ],
  },
  {
    header: "DỮ LIỆU NGHỀ NGHIỆP",
    items: [
      { to: "/admin/nghe-nghiep", label: "Nghề nghiệp", icon: "🛠️" },
      { to: "/admin/chuyen-nganh", label: "Chuyên ngành", icon: "🎓" },
      { to: "/admin/categories", label: "Lĩnh vực", icon: "📚" },
    ],
  },
  // {
  //   header: "CẤU HÌNH",
  //   items: [
  //     { to: "/admin/cv-templates-new", label: "Mẫu CV", icon: "🖼️" },
  //     { to: "/admin/reports", label: "Báo cáo", icon: "📝" }
  //   ],
  // },
  
];
</script>

<style scoped>
.fade-slide-enter-active,
.fade-slide-leave-active {
  transition: all 0.3s ease;
}
.fade-slide-enter-from {
  opacity: 0;
  transform: translateY(10px);
}
.fade-slide-leave-to {
  opacity: 0;
  transform: translateY(-10px);
}

.menu-link {
  padding: 10px 14px;
  border-radius: 8px;
  transition: all 0.2s ease;
  white-space: nowrap;
}
.menu-link:hover {
  background: linear-gradient(to right, #6366f1, #4338ca);
  transform: translateX(4px);
}
.active-link {
  background: #4338ca;
  font-weight: bold;
  transform: scale(1.02);
}
</style>