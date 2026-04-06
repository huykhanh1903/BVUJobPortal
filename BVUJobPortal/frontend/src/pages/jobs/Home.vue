<template>
  <div class="min-h-screen bg-slate-50">

    <section class="hero-bg py-10 px-4">
      <div class="max-w-6xl mx-auto space-y-8">

        <div class="text-center text-white space-y-2">
          <h1 class="text-2xl md:text-3xl font-bold tracking-tight">
            BVU Job Portal – Kết nối cơ hội việc làm cho sinh viên
          </h1>
          <p class="text-sm md:text-base text-blue-100">
            Tìm kiếm công việc, thực tập, part-time phù hợp với chuyên ngành của bạn.
          </p>
        </div>

        <div
          class="hero-search flex flex-col md:flex-row gap-3 md:items-center px-4 py-3 rounded-2xl bg-white/95"
        >
          <div class="relative flex-1">
            <div
              class="flex items-center gap-3 px-3 py-2 rounded-xl border border-slate-200 bg-slate-50"
            >
              <i class="fa-solid fa-magnifying-glass text-blue-500"></i>
              <input
                v-model="keyword"
                @input="fetchSuggestions"
                @keyup.enter="doSearch"
                class="flex-1 bg-transparent outline-none text-slate-800 text-sm md:text-base"
                placeholder="Vị trí tuyển dụng, kỹ năng, tên công ty..."
              />
              <select
                v-model="searchMode"
                class="px-3 py-2 rounded-lg border text-sm bg-slate-50"
              >
                <option value="job">Việc làm</option>
                <option value="company">Công ty</option>
              </select>

            </div>

            <div
              v-if="suggestions.length > 0"
              class="absolute top-full left-0 right-0 mt-2 bg-white rounded-xl shadow-xl border border-slate-200 z-50 overflow-hidden"
            >
              <div
                v-for="item in suggestions"
                :key="item"
                @click="selectSuggestion(item)"
                class="px-4 py-2 flex items-center gap-2 cursor-pointer hover:bg-blue-50 text-slate-700 text-sm transition"
              >
                <i class="fa-solid fa-magnifying-glass text-blue-500 text-xs"></i>
                <span class="truncate">{{ item }}</span>
              </div>
            </div>
          </div>

          <button
            @click="searchJobs"
            class="px-6 py-2.5 rounded-xl bg-blue-500 text-white font-semibold text-sm md:text-base shadow-md hover:bg-blue-600 active:bg-blue-700 transition"
          >
            Tìm kiếm
          </button>
        </div>

        <div
          class="hero-card relative w-full min-h-[320px] overflow-hidden rounded-2xl bg-white shadow-md p-4 md:p-5"
          @mouseleave="hidePanel"
        >
          <div class="flex w-full h-full">

            <div class="w-[260px] pr-4 border-r border-slate-100 h-[280px] overflow-hidden">
              <h3 class="text-base font-semibold text-slate-800 mb-1 flex items-center gap-2">
                <i class="fa-solid fa-layer-group text-blue-500"></i>
                Ngành nghề phổ biến
              </h3>

              <div
                v-for="lv in fixedLinhVuc"
                :key="lv.id"
                @mouseenter="lv.empty ? null : showPanel(lv)"
                @click="chonLinhVuc(lv)"
              :class="[
                'lv-item group h-[38px] flex items-center justify-between px-3 rounded-md',
                lv.empty ? 'opacity-0 pointer-events-none' : ''
              ]"
            >
                <span class="truncate block text-sm font-medium text-slate-700">
                  {{ lv.empty ? '' : lv.tenLinhVuc }}
                </span>

                <i
                  v-if="!lv.empty"
                  class="fa-solid fa-chevron-right text-[10px] text-slate-400 group-hover:text-blue-500 transition"
                ></i>
              </div>

              <div class="flex justify-between items-center text-xs text-slate-500 pt-2">
                <button @click="prevLvPage" :disabled="lvPage === 1" class="disabled:opacity-30">
                  <i class="fa-solid fa-chevron-left"></i>
                </button>
                <span>{{ lvPage }} / {{ totalLvPages }}</span>
                <button @click="nextLvPage" :disabled="lvPage === totalLvPages" class="disabled:opacity-30">
                  <i class="fa-solid fa-chevron-right"></i>
                </button>
              </div>
            </div>

            <div class="flex-1 pl-4 relative panel-wrapper min-w-[500px] h-[280px] overflow-hidden">

              <div
                class="absolute inset-0 transition-all duration-300"
                :class="panelVisible ? 'opacity-100 pointer-events-auto' : 'opacity-0 pointer-events-none'"
              >
                <div class="h-full flex flex-col">

                  <div class="flex items-center justify-between mb-4">
                    <h3 class="text-lg font-semibold text-slate-900">
                      {{ activeLinhVucName }}
                    </h3>

                    <span class="inline-flex items-center gap-1 text-xs px-3 py-1 rounded-full bg-blue-50 text-blue-700">
                      <i class="fa-solid fa-fire text-[10px]"></i>
                      Được sinh viên BVU quan tâm
                    </span>
                  </div>

                  <div v-if="hotTags.length > 0" class="mb-4">
                    <h3 class="text-sm font-semibold text-slate-800 flex items-center gap-2">
                      <i class="fa-solid fa-fire text-red-500 text-xs"></i>
                      Được tìm kiếm nhiều
                    </h3>

                    <div class="flex flex-wrap gap-2 mt-2">
                      <span
                        v-for="tag in hotTags"
                        :key="tag"
                        class="px-3 py-1.5 text-xs font-medium rounded-full flex items-center gap-1
                              bg-red-50 border border-red-200 text-red-600 hover:bg-red-100 transition cursor-pointer"
                      >
                        <i class="fa-solid fa-fire text-[11px]"></i>
                        {{ tag }}
                      </span>
                    </div>
                  </div>

                  <div class="space-y-4 overflow-y-auto pr-1">
                    <div
                      v-for="nghe in ngheData"
                      :key="nghe.tenNghe"
                      class="pb-3 border-b border-slate-200 last:border-none"
                    >
                      <h4
                        class="text-sm font-semibold text-blue-700 cursor-pointer"
                        @click="chonNghe(nghe)"
                      >
                        {{ nghe.tenNghe }}
                      </h4>

                      <div class="flex flex-wrap gap-1.5 mt-1">
                        <span
                          class="tag-chip cursor-pointer"
                          v-for="cn in nghe.chuyenNganhs"
                          :key="cn.id"
                          @click="chonChuyenNganh(cn)"
                        >
                          {{ cn.tenChuyenNganh }}
                        </span>
                      </div>
                    </div>
                  </div>
                </div>
              </div>

              <div
                class="absolute inset-0 transition-all duration-300"
                :class="!panelVisible ? 'opacity-100 pointer-events-auto' : 'opacity-0 pointer-events-none'"
              >
                <div class="panel-banner h-full rounded-2xl text-white p-6 md:p-8 flex flex-col justify-between">

                  <div class="space-y-3">
                    <p class="text-xs uppercase tracking-[0.2em] text-blue-100">
                      BVU Job Portal
                    </p>

                    <h3 class="text-2xl md:text-3xl font-bold leading-snug">
                      Tìm đúng ngành, <br />
                      mở lối thành công
                    </h3>

                    <p class="text-sm md:text-base text-blue-100/90 max-w-md">
                      Khám phá các lĩnh vực việc làm được thiết kế riêng cho sinh viên BVU,
                      từ thực tập đến vị trí full-time.
                    </p>
                  </div>

                  <div class="mt-6 flex flex-wrap items-center gap-4 text-sm">
                    <div class="flex items-center gap-2">
                      <span
                        class="h-8 w-8 flex items-center justify-center rounded-full bg-blue-500/30"
                      >
                        <i class="fa-solid fa-briefcase"></i>
                      </span>
                      <div>
                        <p class="text-xs text-blue-100/80">Việc làm đang đăng</p>
                        <p class="font-semibold">
                          {{ jobs.length || 0 }}+
                        </p>
                      </div>
                    </div>

                    <div class="flex items-center gap-2">
                      <span
                        class="h-8 w-8 flex items-center justify-center rounded-full bg-blue-500/30"
                      >
                        <i class="fa-solid fa-user-graduate"></i>
                      </span>
                      <div>
                        <p class="text-xs text-blue-100/80">Dành cho sinh viên BVU</p>
                        <p class="font-semibold">Thực tập · Part-time · Full-time</p>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>

    <section class="bg-white border-y border-slate-200">
      <div class="max-w-6xl mx-auto px-4 py-6 grid grid-cols-2 md:grid-cols-4 gap-6 text-center">
        
        <div>
          <p class="text-2xl font-bold text-blue-600">3.200+</p>
          <p class="text-sm text-slate-500">Sinh viên đã ứng tuyển</p>
        </div>

        <div>
          <p class="text-2xl font-bold text-blue-600">480+</p>
          <p class="text-sm text-slate-500">Doanh nghiệp tham gia</p>
        </div>

        <div>
          <p class="text-2xl font-bold text-blue-600">1.200+</p>
          <p class="text-sm text-slate-500">Công việc đang mở</p>
        </div>

        <div>
          <p class="text-2xl font-bold text-blue-600">98%</p>
          <p class="text-sm text-slate-500">Sinh viên hài lòng</p>
        </div>

      </div>
    </section>

    <section class="max-w-6xl mx-auto px-4 md:px-6 py-10">
      <h2 class="text-xl md:text-2xl font-bold mb-6 text-slate-800">
        🔥 Top 10 lĩnh vực được quan tâm nhất
      </h2>

      <div class="grid grid-cols-2 sm:grid-cols-3 lg:grid-cols-5 gap-4 md:gap-6">

        <div
          v-for="cat in categories"
          :key="cat.id"
          class="bg-white border border-slate-200 rounded-2xl p-5 shadow-sm 
                hover:shadow-lg hover:-translate-y-1 transition cursor-pointer group"
          @click="chonLinhVuc(cat)"
        >
          <!-- ICON -->
          <div
            class="h-14 w-14 mx-auto flex items-center justify-center rounded-full 
                  bg-blue-50 group-hover:bg-blue-100 transition mb-3"
          >
            <component :is="cat.icon" class="h-7 w-7 text-blue-600" />
          </div>

          <h3
            class="font-semibold text-sm md:text-base text-slate-900 text-center 
                  group-hover:text-blue-600 transition leading-tight line-clamp-1"
          >
            {{ cat.ten }}
          </h3>
        </div>

      </div>
    </section>

    <section class="max-w-6xl mx-auto px-4 py-12">
      <h2 class="text-2xl font-bold text-slate-800 mb-8 text-center">
        🌱 Vì sao sinh viên BVU chọn chúng tôi?
      </h2>

      <div class="grid sm:grid-cols-2 lg:grid-cols-4 gap-6">
        
        <div class="bg-white rounded-2xl p-6 border shadow-sm text-center hover:shadow-lg transition">
          <i class="fa-solid fa-graduation-cap text-blue-500 text-3xl mb-3"></i>
          <h3 class="font-semibold mb-1">Dành riêng cho BVU</h3>
          <p class="text-sm text-slate-500">
            Công việc phù hợp ngành học & sinh viên BVU
          </p>
        </div>

        <div class="bg-white rounded-2xl p-6 border shadow-sm text-center hover:shadow-lg transition">
          <i class="fa-solid fa-shield-check text-blue-500 text-3xl mb-3"></i>
          <h3 class="font-semibold mb-1">Doanh nghiệp xác thực</h3>
          <p class="text-sm text-slate-500">
            Admin kiểm duyệt – tránh lừa đảo
          </p>
        </div>

        <div class="bg-white rounded-2xl p-6 border shadow-sm text-center hover:shadow-lg transition">
          <i class="fa-solid fa-bolt text-blue-500 text-3xl mb-3"></i>
          <h3 class="font-semibold mb-1">Ứng tuyển nhanh</h3>
          <p class="text-sm text-slate-500">
            Chỉ 1 click – CV online
          </p>
        </div>

        <div class="bg-white rounded-2xl p-6 border shadow-sm text-center hover:shadow-lg transition">
          <i class="fa-solid fa-robot text-blue-500 text-3xl mb-3"></i>
          <h3 class="font-semibold mb-1">AI hỗ trợ</h3>
          <p class="text-sm text-slate-500">
            Gợi ý công việc thông minh
          </p>
        </div>
      </div>
    </section>

    <section class="max-w-6xl mx-auto px-4 py-12">
      <h2 class="text-2xl font-bold text-slate-800 mb-8 text-center">
        🧭 Lộ trình nghề nghiệp cho sinh viên
      </h2>

      <div class="grid md:grid-cols-4 gap-6">
        <div class="relative bg-white rounded-2xl p-6 border shadow-sm hover:shadow-lg transition">
          <span class="absolute -top-3 left-6 bg-blue-500 text-white text-xs px-3 py-1 rounded-full">Năm 1–2</span>
          <h3 class="font-semibold mb-2 mt-2">Khám phá</h3>
          <p class="text-sm text-slate-500">Part-time, CLB, thực tập sớm</p>
        </div>

        <div class="relative bg-white rounded-2xl p-6 border shadow-sm hover:shadow-lg transition">
          <span class="absolute -top-3 left-6 bg-blue-500 text-white text-xs px-3 py-1 rounded-full">Năm 3</span>
          <h3 class="font-semibold mb-2 mt-2">Thực tập</h3>
          <p class="text-sm text-slate-500">Internship đúng ngành</p>
        </div>

        <div class="relative bg-white rounded-2xl p-6 border shadow-sm hover:shadow-lg transition">
          <span class="absolute -top-3 left-6 bg-purple-500 text-white text-xs px-3 py-1 rounded-full">Năm 4</span>
          <h3 class="font-semibold mb-2 mt-2">Ứng tuyển</h3>
          <p class="text-sm text-slate-500">Junior / Fresher</p>
        </div>

        <div class="relative bg-white rounded-2xl p-6 border shadow-sm hover:shadow-lg transition">
          <span class="absolute -top-3 left-6 bg-orange-500 text-white text-xs px-3 py-1 rounded-full">Sau tốt nghiệp</span>
          <h3 class="font-semibold mb-2 mt-2">Phát triển</h3>
          <p class="text-sm text-slate-500">Career growth</p>
        </div>
      </div>
    </section>

    <section class="max-w-7xl mx-auto px-4 md:px-6 py-10 pb-16">
      <h2 class="text-2xl font-bold mb-6 text-slate-800">
        💼 Công việc mới nhất
      </h2>

      <div v-if="paginatedJobs.length === 0" class="text-slate-500 text-center py-12 text-lg">
        Không có công việc nào phù hợp
      </div>

      <div v-else class="grid grid-cols-1 sm:grid-cols-2 lg:grid-cols-3 gap-6">
        <div
          v-for="job in paginatedJobs"
          :key="job.id"
          class="bg-white rounded-2xl p-6 shadow-sm border border-slate-200
                hover:shadow-lg hover:-translate-y-1 transition-all duration-300 cursor-pointer"
        > 
          <div class="flex items-start gap-4">
            <img
              v-if="job.logoUrl"
              :src="job.logoUrl.startsWith('http')
                    ? job.logoUrl
                    : 'https://localhost:7248' + job.logoUrl"
              class="w-14 h-14 rounded-xl object-cover border"
            />
            <div
              v-else
              class="w-14 h-14 rounded-xl bg-blue-50 border flex items-center justify-center text-blue-500 text-xl"
            >
              <i class="fa-solid fa-building"></i>
            </div>

            <div class="flex-1 min-w-0">
              <h3
                class="font-semibold text-slate-900 text-base md:text-lg leading-snug 
                      line-clamp-1 overflow-hidden text-ellipsis"
              >
                {{ job.tieuDe }}
              </h3>

              <p class="text-sm text-slate-500 mt-1 truncate">
                🏢 {{ job.tenCongTy || "Đang cập nhật" }}
              </p>

              <p class="text-sm text-blue-600 font-semibold mt-2">
                💰 {{ job.mucLuong || "Thoả thuận" }}
              </p>
            </div>
          </div>

          <div class="border-t mt-4 mb-4"></div>

          <div class="flex flex-wrap gap-2 mt-2">
            <span
              v-for="kv in job.khuVucLamViec"
              :key="kv"
              class="px-2.5 py-1 text-xs font-medium bg-blue-50 text-blue-700 border border-blue-200 rounded-full"
            >
              {{ kv }}
            </span>

            <span
              v-if="!job.khuVucLamViec || job.khuVucLamViec.length === 0"
              class="text-slate-500 text-sm"
            >
              Địa điểm đang cập nhật
            </span>
          </div>

          <router-link
            v-if="auth.isAuthenticated && auth.user?.vaiTro === 'SinhVien'"
            :to="`/viec-lam/${job.id}`"
            class="mt-5 py-2.5 text-center rounded-lg bg-blue-500 text-white
                  text-sm md:text-base font-semibold hover:bg-blue-600 active:bg-blue-700 transition block"
            @click.native="applySuccess(job.tieuDe)"
          >
            Xem chi tiết & Ứng tuyển
          </router-link>

          <button
            v-else
            @click="showLoginWarning"
            class="mt-5 py-2.5 w-full text-sm md:text-base rounded-lg bg-blue-50 text-blue-700
                  hover:bg-blue-100 transition font-medium"
          >
            Ứng tuyển
          </button>
        </div>
      </div>

      <div v-if="totalPages > 1" class="flex justify-center items-center gap-4 mt-10 text-slate-700">
        <button
          @click="prevPage"
          :disabled="currentPage === 1"
          class="px-4 py-2 rounded-lg border border-slate-300 hover:bg-slate-100 disabled:opacity-40"
        >
          ← Trang trước
        </button>

        <span class="font-semibold">
          Trang {{ currentPage }} / {{ totalPages }}
        </span>

        <button
          @click="nextPage"
          :disabled="currentPage === totalPages"
          class="px-4 py-2 rounded-lg border border-slate-300 hover:bg-slate-100 disabled:opacity-40"
        >
          Trang sau →
        </button>
      </div>
    </section>

    <section class="max-w-6xl mx-auto px-4 md:px-6 py-12">
      <h2 class="text-2xl font-bold mb-6 text-slate-800 flex items-center gap-2">
        🏢 Top 10 doanh nghiệp tiêu biểu
      </h2>
      <div class="grid grid-cols-2 sm:grid-cols-3 lg:grid-cols-5 gap-5">
        <div
          v-for="dn in topDoanhNghiep"
          :key="dn.id"
          class="card-3d glow-hover p-5 cursor-pointer flex flex-col items-center text-center"
          @click="xemDoanhNghiep(dn)"
        >
          <img
            :src="dn.logoUrl.startsWith('http') ? dn.logoUrl : 'https://localhost:7248' + dn.logoUrl"
            class="w-14 h-14 rounded-xl object-cover border mb-3"
          />

          <h3 class="font-semibold text-slate-900 text-sm line-clamp-2">
            {{ dn.tenCongTy }}
          </h3>

          <p class="text-xs text-blue-600 mt-1">
            {{ dn.soLuongCongViec }} việc đang tuyển
          </p>

          <span v-if="dn.daDuocAdminXacMinh"
            class="inline-flex items-center gap-1 text-[11px] mt-2 text-emerald-600 font-medium">
            <i class="fa-solid fa-circle-check"></i> Verified
          </span>
        </div>
      </div>
    </section>

    <section class="max-w-6xl mx-auto px-4 py-12">
      <h2 class="text-2xl font-bold text-center text-slate-800 mb-8">
        💬 Sinh viên BVU nói gì?
      </h2>

      <div class="grid md:grid-cols-3 gap-6">
        <div class="bg-white p-6 rounded-2xl border shadow-sm">
          <p class="text-sm text-slate-600 italic">
            “Nhờ BVU Job Portal mà mình tìm được chỗ thực tập đúng ngành CNTT.”
          </p>
          <div class="mt-4 flex items-center gap-3">
            <div class="w-10 h-10 rounded-full bg-blue-500 text-white flex items-center justify-center font-bold">
              T
            </div>
            <div>
              <p class="font-semibold text-sm">Trường</p>
              <p class="text-xs text-slate-500">Sinh viên CNTT</p>
            </div>
          </div>
        </div>

        <div class="bg-white p-6 rounded-2xl border shadow-sm">
          <p class="text-sm text-slate-600 italic">
            “Giao diện dễ dùng, doanh nghiệp rõ ràng, không bị job rác.”
          </p>
          <div class="mt-4 flex items-center gap-3">
            <div class="w-10 h-10 rounded-full bg-blue-500 text-white flex items-center justify-center font-bold">
              M
            </div>
            <div>
              <p class="font-semibold text-sm">Minh</p>
              <p class="text-xs text-slate-500">Sinh viên Kinh tế</p>
            </div>
          </div>
        </div>

        <div class="bg-white p-6 rounded-2xl border shadow-sm">
          <p class="text-sm text-slate-600 italic">
            “Ứng tuyển nhanh, theo dõi trạng thái rất tiện.”
          </p>
          <div class="mt-4 flex items-center gap-3">
            <div class="w-10 h-10 rounded-full bg-purple-500 text-white flex items-center justify-center font-bold">
              H
            </div>
            <div>
              <p class="font-semibold text-sm">Hà</p>
              <p class="text-xs text-slate-500">Sinh viên Marketing</p>
            </div>
          </div>
        </div>
      </div>
    </section>

    <section class="max-w-5xl mx-auto px-4 py-12">
      <h2 class="text-2xl font-bold text-center text-slate-800 mb-8">
        ❓ Câu hỏi thường gặp
      </h2>

      <div class="space-y-4">
        <details class="bg-white rounded-xl p-4 border shadow-sm">
          <summary class="font-semibold cursor-pointer">
            Làm sao để ứng tuyển công việc?
          </summary>
          <p class="mt-2 text-sm text-slate-600">
            Đăng nhập tài khoản Sinh viên → chọn công việc → nhấn “Ứng tuyển”.
          </p>
        </details>

        <details class="bg-white rounded-xl p-4 border shadow-sm">
          <summary class="font-semibold cursor-pointer">
            Doanh nghiệp có được xác thực không?
          </summary>
          <p class="mt-2 text-sm text-slate-600">
            Các doanh nghiệp đều được Admin kiểm duyệt trước khi hiển thị.
          </p>
        </details>

        <details class="bg-white rounded-xl p-4 border shadow-sm">
          <summary class="font-semibold cursor-pointer">
            AI Assistant dùng để làm gì?
          </summary>
          <p class="mt-2 text-sm text-slate-600">
            AI giúp gợi ý công việc, ngành nghề phù hợp với hồ sơ của bạn.
          </p>
        </details>
      </div>
    </section>

    <div class="fixed bottom-6 right-6 z-50">
      <button
        class="relative w-16 h-16 rounded-full bg-gradient-to-br from-blue-500 to-teal-500 
              shadow-2xl text-white text-2xl flex items-center justify-center 
              hover:scale-110 transition"
      >
        🤖
        <span class="absolute inset-0 rounded-full animate-ping bg-blue-400 opacity-40"></span>
      </button>

      <div class="absolute bottom-20 right-0 bg-white shadow-lg rounded-xl px-4 py-2 text-sm text-slate-700">
        AI gợi ý việc làm cho bạn 👋
      </div>
    </div>
  </div>
</template>

<script setup>
import { ref, onMounted, computed } from "vue";
import api from "../../api/axios";
import { useAuthStore } from "@/store/auth";
import { useToast } from "vue-toastification";

import {
  BuildingOfficeIcon,
  ComputerDesktopIcon,
  MegaphoneIcon,
  BriefcaseIcon,
  TruckIcon,
  WrenchScrewdriverIcon,
  AcademicCapIcon,
  BeakerIcon,
  PaintBrushIcon,
  GlobeAsiaAustraliaIcon,
} from "@heroicons/vue/24/solid";

const auth = useAuthStore();
const toast = useToast();
const searchMode = ref("job");

const hotTags = ref([]);
const fetchTopKeywordByLinhVuc = async (id) => {
  try {
    const res = await api.get(`/api/TuKhoa/top-linhvuc/${id}`);
    hotTags.value = res.data || [];
  } catch (err) {
    console.error("Lỗi tải top từ khóa:", err);
    hotTags.value = [];
  }
};

const linhVuc = ref([]);
const lvPage = ref(1);
const lvPerPage = 6;

const totalLvPages = computed(() =>
  Math.ceil(linhVuc.value.length / lvPerPage)
);

const paginatedLinhVuc = computed(() => {
  const start = (lvPage.value - 1) * lvPerPage;
  return linhVuc.value.slice(start, start + lvPerPage);
});

const fixedLinhVuc = computed(() => {
  const result = [...paginatedLinhVuc.value];
  while (result.length < lvPerPage) {
    result.push({
      id: "empty-" + result.length,
      tenLinhVuc: "",
      empty: true,
    });
  }
  return result;
});

const nextLvPage = () => {
  if (lvPage.value < totalLvPages.value) lvPage.value++;
};
const prevLvPage = () => {
  if (lvPage.value > 1) lvPage.value--;
};

const fetchLinhVuc = async () => {
  try {
    const res = await api.get("Admin/linh-vuc");
    linhVuc.value = res.data;
  } catch (err) {
    console.error("Lỗi tải lĩnh vực:", err);
  }
};

const suggestions = ref([]);

const fetchSuggestions = async () => {
  const text = keyword.value.trim();

  if (!text) {
    suggestions.value = [];
    return;
  }

  try {
    const res = await api.get(`/api/TuKhoa/goi-y?keyword=${encodeURIComponent(text)}`);
    suggestions.value = res.data || [];
  } catch {
    suggestions.value = [];
  }
};

const selectSuggestion = (item) => {
  keyword.value = item;
  suggestions.value = [];
  searchJobs();
};

const topDoanhNghiep = ref([]);

const fetchTopDoanhNghiep = async () => {
  try {
    const res = await api.get("/Admin/cong-ty");

    topDoanhNghiep.value = res.data
      .sort((a, b) => b.soLuongCongViec - a.soLuongCongViec)
      .slice(0, 10);

  } catch (err) {
    console.error("Lỗi tải top doanh nghiệp:", err);
  }
};

const xemDoanhNghiep = (dn) => {
  router.push(`/cong-ty/${dn.id}`);
};



const activeLinhVucId = ref(null);
const activeLinhVucName = computed(() => {
  const item = linhVuc.value.find((x) => x.id === activeLinhVucId.value);
  return item?.tenLinhVuc || "Được tìm kiếm nhiều";
});

const categories = ref([]);

const fetchCategories = async () => {
  try {
    const res = await api.get("/Admin/linh-vuc");

      categories.value = res.data
        .sort((a, b) => b.soLuongCongViec - a.soLuongCongViec)
        .slice(0, 10)
        .map(x => ({
          id: x.id,
          ten: x.tenLinhVuc,
          soLuong: x.soLuongCongViec,
          icon: iconMap[x.id] || BriefcaseIcon
        }));

  } catch (err) {
    console.error("Lỗi tải lĩnh vực:", err);
  }
};

const iconMap = {
  1: BriefcaseIcon,
  2: MegaphoneIcon,
  3: BuildingOfficeIcon,
  4: BuildingOfficeIcon,
  5: ComputerDesktopIcon,
  6: WrenchScrewdriverIcon,
  7: GlobeAsiaAustraliaIcon,
  8: TruckIcon,
  9: BuildingOfficeIcon,
  10: AcademicCapIcon,
  11: BuildingOfficeIcon,
  12: AcademicCapIcon,
  13: BuildingOfficeIcon,
  14: PaintBrushIcon,
  15: WrenchScrewdriverIcon,
  16: TruckIcon,
  17: BriefcaseIcon,
  18: BeakerIcon,
  19: PaintBrushIcon,
  20: GlobeAsiaAustraliaIcon,
  21: GlobeAsiaAustraliaIcon,
  22: TruckIcon,
  23: AcademicCapIcon,
  24: BuildingOfficeIcon,
  25: GlobeAsiaAustraliaIcon,
};

onMounted(() => {
  fetchCategories();
  fetchJobs();
  fetchLinhVuc();
  fetchTopDoanhNghiep();
});

const ngheData = ref([]);

const fetchNgheTheoLinhVuc = async (id) => {
  try {
    const res = await api.get(`Admin/linh-vuc/${id}/nghe-nghiep`);
    return res.data;
  } catch (err) {
    console.error("Lỗi tải nghề:", err);
    return [];
  }
};

const fetchChuyenNganhTheoNghe = async (ngheId) => {
  try {
    const res = await api.get(`Admin/nghe-nghiep/${ngheId}/chuyen-nganh`);
    return res.data;
  } catch (err) {
    console.error("Lỗi tải chuyên ngành:", err);
    return [];
  }
};

const panelVisible = ref(false);

const showPanel = async (lv) => {
  if (lv.empty) return;

  activeLinhVucId.value = lv.id;
  panelVisible.value = true;

  await fetchTopKeywordByLinhVuc(lv.id);

  const nghes = await fetchNgheTheoLinhVuc(lv.id);

  const merged = [];
  for (const nghe of nghes) {
    const chuyenNganhs = await fetchChuyenNganhTheoNghe(nghe.id);
    merged.push({
      id: nghe.id,
      tenNghe: nghe.tenNghe,
      chuyenNganhs,
    });
  }

  ngheData.value = merged;
};

const hidePanel = () => {
  panelVisible.value = false;
};

const jobs = ref([]);

const topNghes = ref([]);

const extractTopNghes = () => {
  const allNghes = [];

  jobs.value.forEach(job => {
    if (job.nganhNghieps && job.nganhNghieps.length > 0) {
      job.nganhNghieps.forEach(n => {
        allNghes.push({ id: n.id, ten: n.ten });
      });
    }
  });

  const unique = [];
  const set = new Set();
  allNghes.forEach(n => {
    if (!set.has(n.id)) {
      set.add(n.id);
      unique.push(n);
    }
  });

  topNghes.value = unique.slice(0, 6);
};
const keyword = ref("");

const fetchJobs = async () => {
  try {
    const res = await api.get("CongViec/tat-ca");

    const all = res.data
      .filter(j => j.daDuyet === true)
      .sort((a, b) => new Date(b.ngayDang) - new Date(a.ngayDang))
      .slice(0, 60);

    jobs.value = all;

  } catch (err) {
    console.error("Lỗi tải danh sách công việc:", err);
  }
};

const searchJobs = () => {
  const text = keyword.value.trim();
  if (!text) return;

  if (searchMode.value === "job") {
    router.push({
      name: "DanhSachCongViec",
      query: { keyword: text }
    });
  } else {
    router.push({
      name: "DanhSachCongTy",
      query: { keyword: text }
    });
  }
};

const currentPage = ref(1);
const pageSize = 6;

const paginatedJobs = computed(() => {
  const start = (currentPage.value - 1) * pageSize;
  return jobs.value.slice(start, start + pageSize);
});

const totalPages = computed(() => {
  const p = Math.ceil(jobs.value.length / pageSize);
  return Math.min(p, 10);
});

const nextPage = () => {
  if (currentPage.value < totalPages.value) currentPage.value++;
};
const prevPage = () => {
  if (currentPage.value > 1) currentPage.value--;
};

const showLoginWarning = () => {
  if (!auth.isAuthenticated) {
    toast.warning("⚠️ Vui lòng đăng nhập để ứng tuyển công việc này!");
  } else if (auth.user?.vaiTro !== "SinhVien") {
    toast.error("❌ Chỉ tài khoản Sinh viên mới có thể ứng tuyển công việc!");
  }
};

import { useRouter } from "vue-router";
const router = useRouter();

const chonLinhVuc = (lv) => {
  if (!lv || lv.empty) return;

  router.push({
    name: "DanhSachCongViec",
    query: {
      linhVucId: lv.id,
      tenLinhVuc: lv.tenLinhVuc
    }
  });
};

const chonNghe = (nghe) => {
  if (!nghe) return;

  router.push({
    name: "DanhSachCongViec",
    query: {
      ngheId: nghe.id,
      tenNghe: nghe.tenNghe
    }
  });
};

const chonChuyenNganh = (cn) => {
  if (!cn) return;

  router.push({
    name: "DanhSachCongViec",
    query: {
      chuyenNganhId: cn.id,
      tenChuyenNganh: cn.tenChuyenNganh
    }
  });
};

onMounted(() => {
  fetchJobs();
  fetchLinhVuc();
});

</script>

<style>
:root {
  --bg: #f3f5f9;

  --text: #0f172a;
  --muted: #64748b;
  --border: #e2e8f0;

  --blue-1: #0077cc;
  --blue-2: #005fa3;
  --blue-3: #003f73;
  --blue-4: #001a30;

  --accent: #2563eb;
  --accent-soft: rgba(37, 99, 235, 0.12);

  --r-sm: 12px;
  --r-md: 16px;
  --r-lg: 18px;
  --r-xl: 20px;

  --sh-1: 0 8px 20px rgba(15, 23, 42, 0.06);
  --sh-2: 0 14px 32px rgba(15, 23, 42, 0.10);
  --sh-hero: 0 18px 40px rgba(16, 185, 129, 0.24);

  --glow: 0 0 0 1px #34d399, 0 10px 30px rgba(16, 185, 129, 0.35);
}

body, .min-h-screen {
  background: var(--bg) !important;
  color: var(--text);
}

.line-clamp-2 {
  display: -webkit-box;
  -webkit-line-clamp: 2;
  -webkit-box-orient: vertical;
  overflow: hidden;
}

#scroll-progress {
  position: fixed;
  top: 0;
  left: 0;
  height: 4px;
  background: linear-gradient(to right, #34d399, #06b6d4);
  z-index: 100;
}

.hero-bg {
  background: radial-gradient(circle at top left,
      #005f9e 0%,
      #004576 35%,
      #002f52 70%,
      #001a30 100%);
}

.panel-banner {
  background: radial-gradient(circle at top left,
      #0077cc 0%,
      #005fa3 30%,
      #003f73 65%,
      #001a30 100%);
  box-shadow: 0 20px 40px rgba(0, 51, 102, 0.35);
  border-radius: var(--r-md);
}

.panel-wrapper {
  position: relative;
  height: 290px;
}

.card {
  background: #fff;
  border: 1px solid var(--border);
  border-radius: var(--r-lg);
  transition: transform .22s ease, box-shadow .22s ease, border-color .22s ease;
  transform: translateZ(0);
}

.card:hover {
  transform: translateY(-3px);
  box-shadow: var(--sh-2);
}

.card-hero {
  box-shadow: var(--sh-hero);
  border-radius: var(--r-lg);
}

.card-3d {
  border-radius: var(--r-xl);
  background: #fff;
  border: 1px solid var(--border);
  box-shadow:
    0 4px 8px rgba(0, 0, 0, 0.08),
    0 8px 20px rgba(0, 0, 0, 0.06),
    inset 0 0 0 1px rgba(255,255,255,0.6);
  transform: translateZ(0);
  transition: transform .25s ease, box-shadow .25s ease, border-color .25s ease;
}

.card-3d:hover {
  transform: translateY(-6px) scale(1.02);
  box-shadow:
    0 10px 30px rgba(0, 170, 255, 0.25),
    0 0 25px rgba(0, 180, 255, 0.35);
}

.glow-hover:hover {
  box-shadow: var(--glow);
}

.hero-search {
  box-shadow: 0 10px 28px rgba(16, 185, 129, 0.30);
}

.lv-item {
  background: #ffffff;
  border-radius: 999px;
  padding: 7px 12px;
  display: flex;
  align-items: center;
  justify-content: space-between;
  border: 1px solid transparent;
  cursor: pointer;
  transition: .2s ease;
}

.lv-item:hover {
  background: rgba(37, 99, 235, 0.10);
  border-color: rgba(37, 99, 235, 0.35);
  color: #003f73;
}

.tag-chip {
  padding: 3px 10px;
  border-radius: 999px;
  font-size: 11px;
  background: rgba(37, 99, 235, 0.10);
  color: #004b8d;
  border: 1px solid rgba(37, 99, 235, 0.30);
}

.hero-card { 
  border-radius: var(--r-lg);
  box-shadow: var(--sh-hero);
}

.trend-card {
  background: #ffffff;
  border-radius: var(--r-md);
  border: 1px solid var(--border);
  transition: .2s ease;
}
.trend-card:hover {
  transform: translateY(-2px);
  box-shadow: 0 10px 24px rgba(16, 185, 129, 0.18);
}

.job-card {
  background: #ffffff;
  border-radius: var(--r-lg);
  border: 1px solid var(--border);
  transition: .2s ease;
}
.job-card:hover {
  transform: translateY(-3px);
  box-shadow: 0 14px 32px rgba(16, 185, 129, 0.15);
}

.dn-card {
  transition: transform .25s ease, box-shadow .25s ease;
}
.dn-card:hover {
  transform: translateY(-3px);
  box-shadow: 0 16px 34px rgba(0,0,0,0.08);
}
</style>