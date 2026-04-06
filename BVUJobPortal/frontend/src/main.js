// src/main.js
import { createApp } from "vue";
import App from "./App.vue";
import router from "./router";
import { createPinia } from "pinia";
import "./index.css";

// 🔔 Toast
import Toast from "vue-toastification";
import "vue-toastification/dist/index.css";

// 🔧 Import Auth Store & API
import { useAuthStore } from "@/store/auth";
import api from "@/api/axios";

const app = createApp(App);
const pinia = createPinia();
app.use(pinia);

// // ======================
// // 🧹 Reset login khi chạy DEV
// // ======================
// if (import.meta.env.MODE === "development") {
//   console.log("🧹 Development mode: clearing login state...");
//   localStorage.removeItem("token");
//   localStorage.removeItem("user");
//   localStorage.removeItem("banReason");
// }

const auth = useAuthStore();
auth.loadFromStorage();

// ✅ Nếu có token, gắn vào mọi request axios
if (auth.token) {
  api.defaults.headers.common["Authorization"] = `Bearer ${auth.token}`;
}

app.use(router);
app.use(Toast, {
  position: "top-right",
  timeout: 3000,
  closeOnClick: true,
  pauseOnHover: true,
  draggable: true,
  hideProgressBar: false,
  closeButton: "button",
  icon: true,
});

// ======================
// 🚀 Mount App
// ======================
app.mount("#app");
