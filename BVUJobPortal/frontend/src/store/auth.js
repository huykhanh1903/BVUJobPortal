// src/stores/auth.js
import { defineStore } from "pinia";
import api from "@/api/axios";

export const useAuthStore = defineStore("auth", {
  state: () => ({
    token: localStorage.getItem("token") || null,
    user: JSON.parse(localStorage.getItem("user")) || null,
    banReason: localStorage.getItem("banReason") || null,
    loading: true,
  }),

  getters: {
    isAuthenticated: (state) => !!state.token,
    isAdmin: (state) =>
      ["Admin", "SuperAdmin"].includes(state.user?.vaiTro),
  },

  actions: {
    setToken(token, user = null) {
      this.token = token;
      localStorage.setItem("token", token);

      if (user) {
        this.user = user;
        localStorage.setItem("user", JSON.stringify(user));
      }

      api.defaults.headers.common["Authorization"] = `Bearer ${token}`;
    },

    async fetchUser() {
      if (!this.token) {
        this.loading = false;
        return null;
      }

      try {
        const res = await api.get("/TaiKhoan/thong-tin");

        this.user = res.data;
        localStorage.setItem("user", JSON.stringify(res.data));

        return res.data;
      } catch (err) {
        console.error("fetchUser failed:", err);
        this.logout();
        return null;
      } finally {
        this.loading = false;
      }
    },

    // 🧩 Đăng nhập
    async login(email, matKhau) {
      try {
        const res = await api.post("/TaiKhoan/dang-nhap", {
          email,
          matKhau,
        });

        const msgServer = res.data.thongBao || res.data.message || "";

        if (res.data.canXacThucEmail === true ||
            msgServer.includes("Email chưa được xác thực")) {

          // FE tự gửi lại OTP
          await api.post("/TaiKhoan/gui-lai-otp", { email });

          return {
            success: false,
            requireVerify: true,
            email: res.data.email || email,
            message: "Email chưa được xác thực. OTP đã được gửi lại!",
          };
        }

        if (res.data.biKhoa) {
          const banReason = res.data.lyDoKhoa || res.data.lyDo || null;

            if (res.data.token) {
              this.setToken(res.data.token, res.data.nguoiDung);
            }

          this.banReason = banReason;
          localStorage.setItem("banReason", banReason);

          return {
            success: false,
            biKhoa: true,
            lyDo: banReason,
            message: res.data.message || "Tài khoản đã bị khóa.",
          };
        }

        if (res.data.success === false) {
          return {
            success: false,
            message: msgServer || "Sai email hoặc mật khẩu!",
          };
        }

        this.setToken(res.data.token);
        await this.fetchUser();

        this.banReason = null;
        localStorage.removeItem("banReason");

        return {
          success: true,
          message: msgServer || "Đăng nhập thành công!",
        };

      } catch (err) {
        const data = err.response?.data || {};
        const msgErr = data.thongBao || data.message || "";

        if (msgErr.includes("Email chưa được xác thực")) {
          await api.post("/TaiKhoan/gui-lai-otp", { email });

          return {
            success: false,
            requireVerify: true,
            email,
            message: "Email chưa được xác thực. OTP mới đã được gửi!",
          };
        }

        const banReason = data.lyDoKhoa || data.lyDo || null;

        if (banReason) {
          this.banReason = banReason;
          localStorage.setItem("banReason", banReason);
        }

        return {
          success: false,
          message: msgErr || "Sai email hoặc mật khẩu!",
          banReason,
        };
      }
    },

    // 🧩 Đăng ký
    async register(data) {
      try {
        const res = await api.post("/TaiKhoan/dang-ky", data);

        const nguoiDung = res.data.nguoiDung;

        return {
          success: true,
          message: res.data.thongBao || "Đăng ký thành công!",
          user: nguoiDung,
        };
      } catch (err) {
        const data = err.response?.data || {};

        return {
          success: false,
          message: data.thongBao || "Đăng ký thất bại!",
        };
      }
    },

    // 🧩 Xác thực email bằng OTP (nếu cần dùng chỗ khác)
    async verifyEmail(email, otp) {
      try {
        const res = await api.post("/TaiKhoan/xac-thuc-email", {
          email,
          otp,
        });

        return {
          success: true,
          message: res.data.thongBao || "Xác thực email thành công!",
        };
      } catch (err) {
        const data = err.response?.data || {};

        return {
          success: false,
          message: data.thongBao || "Mã OTP không hợp lệ hoặc đã hết hạn!",
        };
      }
    },

    // 🧩 Đăng xuất
    logout() {
      this.token = null;
      this.user = null;
      this.banReason = null;

      localStorage.removeItem("token");
      localStorage.removeItem("user");
      localStorage.removeItem("banReason");

      delete api.defaults.headers.common["Authorization"];
    },

    // 🧩 Khôi phục session khi reload
    loadFromStorage() {
      this.token = localStorage.getItem("token");
      this.user = JSON.parse(localStorage.getItem("user"));
      this.banReason = localStorage.getItem("banReason");

      if (this.token) {
        api.defaults.headers.common["Authorization"] = `Bearer ${this.token}`;
      }

      this.loading = false;
    },
  },
});
