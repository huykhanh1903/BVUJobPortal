import axios from "axios";
import { useAuthStore } from "@/store/auth";

const instance = axios.create({
  baseURL: "https://localhost:7248/api",
  headers: { "Content-Type": "application/json" }
});

instance.interceptors.request.use(config => {
  const publicApis = [
    "/DiaChi/tinh-thanh",
    "/DiaChi/quan-huyen",
    "/DiaChi/phuong-xa"
  ];

  if (publicApis.some(url => config.url.includes(url))) {
    return config;
  }

  const auth = useAuthStore();
  if (auth.token) {
    config.headers.Authorization = `Bearer ${auth.token}`;
  }

  return config;
});

export default instance;
