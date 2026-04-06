<template>
  <div class="max-w-6xl mx-auto mt-10 bg-white rounded-2xl shadow-lg border border-gray-200 overflow-hidden">

    <!-- ================= HEADER ================ -->
    <header class="bg-gradient-to-r from-indigo-600 via-purple-600 to-pink-500 text-white p-8 flex flex-col md:flex-row items-center gap-6">
      
      <!-- Avatar -->
      <div class="relative">
        <img
          v-if="user?.avatarUrl"
          :src="getAvatarUrl(user.avatarUrl)"
          class="h-28 w-28 rounded-full object-cover border-4 border-white shadow-lg"
        />
        <div
          v-else
          class="h-28 w-28 rounded-full bg-white/20 flex items-center justify-center text-4xl font-bold shadow-lg"
        >
          {{ user?.hoTen?.charAt(0) || "?" }}
        </div>
      </div>

      <!-- Basic Info -->
      <div class="flex-1 text-center md:text-left">
        <h1 class="text-3xl font-bold tracking-tight">{{ user?.hoTen }}</h1>
        <p class="text-indigo-100 text-sm">{{ user?.email }}</p>
        <p class="text-indigo-200 text-sm mt-1">
          📅 Tham gia ngày:
          <span class="font-medium text-white">
            {{ formatDate(user?.ngayTao || user?.thongTinCongTy?.ngayTao) }}
          </span>
        </p>
      </div>

      <!-- Vai trò -->
      <div>
        <span class="px-5 py-2 rounded-full text-sm font-semibold shadow bg-white/20 backdrop-blur-sm">
          {{ roleLabel(user?.vaiTro) }}
        </span>
      </div>
    </header>

    <!-- ================= LOADING ================= -->
    <div v-if="loading" class="p-10 text-center text-gray-500 animate-pulse">
      ⏳ Đang tải thông tin người dùng...
    </div>

    <!-- ================= NOT FOUND ================= -->
    <div v-else-if="!user" class="p-8 text-center text-gray-600">
      ⚠️ Không tìm thấy thông tin người dùng.
    </div>

    <!-- ================= CONTENT ================= -->
    <div v-else class="p-8 grid md:grid-cols-10 gap-6">

      <!-- ===================================================== -->
      <!--                       SIDEBAR                        -->
      <!-- ===================================================== -->
      <aside class="md:col-span-3 bg-gray-50 border border-gray-200 rounded-2xl p-5 shadow-sm">
        <h2 class="font-semibold text-gray-800 mb-3 flex items-center gap-2">👤 Thông tin cá nhân</h2>

        <div class="space-y-2 text-sm text-gray-700">
          <p><strong>Họ tên:</strong> {{ user?.hoTen }}</p>
          <p><strong>Email:</strong> {{ user?.email }}</p>
          <p><strong>SĐT:</strong> {{ user?.sdt || "—" }}</p>
          <p>
            <strong>Trạng thái:</strong>
            <span :class="user?.biKhoa ? 'text-red-600' : 'text-green-600 font-medium'">
              {{ user?.biKhoa ? "Đã khóa" : "Đang hoạt động" }}
            </span>
          </p>
        </div>

        <hr class="my-4 border-gray-300">

        <router-link
          to="/hoso/chinh-sua"
          class="block w-full text-center px-4 py-2 bg-indigo-600 text-white rounded-lg font-medium hover:bg-indigo-700 transition text-sm"
        >
          ✏️ Chỉnh sửa hồ sơ
        </router-link>
      </aside>

      <!-- ===================================================== -->
      <!--                MAIN CONTENT THEO VAI TRÒ             -->
      <!-- ===================================================== -->
      <main class="md:col-span-7 space-y-8">

        <!-- ========== DOANH NGHIỆP ========== -->
        <template v-if="user?.vaiTro === 'DoanhNghiep'">
          <div class="card-2 space-y-5">
            <!-- TITLE + STATUS -->
            <div class="flex items-center justify-between gap-3">
              <h2 class="card-2-title flex items-center gap-2">
                🏢 Thông tin doanh nghiệp
              </h2>

              <div class="flex flex-wrap gap-2 justify-end">
                <!-- Admin verify -->
                <span
                  v-if="user.thongTinCongTy?.daDuocAdminXacMinh"
                  class="px-3 py-1 rounded-full text-xs font-semibold bg-green-50 text-green-700 border border-green-200 flex items-center gap-1"
                >
                  ✅ Admin đã xác minh
                </span>
                <span
                  v-else
                  class="px-3 py-1 rounded-full text-xs font-semibold bg-yellow-50 text-yellow-700 border border-yellow-200 flex items-center gap-1"
                >
                  ⏳ Đang chờ Admin xác minh
                </span>    
              </div>
            </div>

            <!-- HEADER CÔNG TY -->
            <div class="flex flex-col sm:flex-row sm:items-center gap-4">
              <img
                v-if="user.thongTinCongTy?.logoUrl"
                :src="getAvatarUrl(user.thongTinCongTy.logoUrl)"
                class="h-16 w-16 object-cover rounded-lg border shadow-sm"
              />
              <div
                v-else
                class="h-16 w-16 bg-gray-200 rounded-lg flex items-center justify-center text-xl font-bold text-gray-600"
              >
                {{ user.thongTinCongTy?.tenCongTy?.charAt(0) || 'C' }}
              </div>

              <div class="flex-1">
                <p class="font-semibold text-lg text-gray-900">
                  {{ user.thongTinCongTy?.tenCongTy || 'Chưa cập nhật tên công ty' }}
                </p>
                <p class="text-gray-500 text-sm">
                  📍 {{ user.thongTinCongTy?.diaChiLamViec || 'Địa chỉ làm việc chưa cập nhật' }}
                </p>
                <p class="text-gray-500 text-xs mt-1" v-if="user.thongTinCongTy?.ngayTao">
                  🗓️ Tham gia hệ thống: {{ formatDate(user.thongTinCongTy.ngayTao) }}
                </p>
              </div>
            </div>

            <!-- BADGE TÓM TẮT -->
            <div class="grid sm:grid-cols-3 gap-3 text-xs">
              <div class="bg-indigo-50 border border-indigo-100 rounded-xl px-3 py-2">
                <p class="text-gray-500">Mã công ty</p>
                <p class="font-semibold text-indigo-700">
                  {{ user.thongTinCongTy?.ma || '—' }}
                </p>
              </div>
              <div class="bg-emerald-50 border border-emerald-100 rounded-xl px-3 py-2">
                <p class="text-gray-500">Số lượng HR</p>
                <p class="font-semibold text-emerald-700">
                  {{ user.thongTinCongTy?.soLuongHR ?? 0 }}
                </p>
              </div>
              <div class="bg-purple-50 border border-purple-100 rounded-xl px-3 py-2">
                <p class="text-gray-500">Tin tuyển dụng đã đăng</p>
                <p class="font-semibold text-purple-700">
                  {{ user.thongTinCongTy?.soLuongCongViec ?? 0 }}
                </p>
              </div>
            </div>

            <!-- THÔNG TIN LIÊN HỆ CÔNG TY -->
            <div class="grid sm:grid-cols-2 gap-4 text-sm mt-2">
              <InfoRow label="Website"
                      :value="user.thongTinCongTy?.website || '—'"
              />
              <InfoRow label="Email liên hệ"
                      :value="user.thongTinCongTy?.emailLienHe || '—'"
              />
              <InfoRow label="Điện thoại công ty"
                      :value="user.thongTinCongTy?.soDienThoaiLienHe || '—'"
              />
              <InfoRow label="Email hệ thống (tài khoản đăng nhập)"
                      :value="user.email || '—'"
              />
            </div>

            <!-- GIỚI THIỆU -->
            <div v-if="user.thongTinCongTy?.gioiThieu" class="mt-4">
              <h3 class="text-sm font-semibold text-gray-800 mb-1">💬 Giới thiệu doanh nghiệp</h3>
              <p class="text-gray-700 whitespace-pre-line leading-relaxed text-sm">
                {{ user.thongTinCongTy.gioiThieu }}
              </p>
            </div>
          </div>
        </template>

          <!-- NHÀ TUYỂN DỤNG -->
        <template v-if="user?.vaiTro === 'NhaTuyenDung'">
          <div class="grid grid-cols-1 md:grid-cols-8 gap-6">

            <section class="md:col-span-7 text-gray-800">

              <!-- 🟢 ĐÃ XÁC MINH -->
              <div v-if="user?.thongTinCongTy && user?.thongTinCongTy?.daDuocAdminXacMinh">
                <h2 class="text-base font-semibold flex items-center gap-2 text-green-700">
                  🏢 Thông tin công ty trực thuộc
                </h2>
                <hr class="my-3 border-t-2 border-green-500 rounded-full shadow-sm" />

                <div class="space-y-3 text-sm">
                  <p>🌐 <strong>Website:</strong> {{ user.thongTinCongTy.website }}</p>
                  <p>✉️ <strong>Email:</strong> {{ user.thongTinCongTy.emailLienHe }}</p>
                  <p>📞 <strong>SĐT:</strong> {{ user.thongTinCongTy.soDienThoaiLienHe }}</p>
                  <p>📍 <strong>Địa chỉ:</strong> {{ user.thongTinCongTy.diaChiLamViec }}</p>
                </div>
              </div>

              <!-- 🟡 ĐÃ GỬI YÊU CẦU -->
              <div
                v-else-if="daGuiYeuCau"
                class="bg-yellow-50 border border-yellow-300 text-yellow-800 p-6 rounded-2xl text-center shadow-sm"
              >
                <div class="text-4xl animate-pulse">⏳</div>
                <p class="font-semibold mt-2">Yêu cầu xác thực đã được gửi.</p>
                <p class="text-sm text-yellow-700">
                  Vui lòng chờ admin phê duyệt. Bạn không thể gửi yêu cầu mới.
                </p>
              </div>

              <!-- 📨 CHƯA GỬI — FORM XÁC THỰC -->
              <div v-else>
                <h2 class="text-base font-semibold flex items-center gap-2">
                  🏢 Xác thực công ty
                </h2>
                <hr class="my-3 border-t-2 border-indigo-500 rounded-full shadow-sm" />

                <div class="bg-gray-50 border border-gray-200 p-6 rounded-2xl space-y-4">

                  <!-- Nhập mã công ty -->
                  <div class="flex flex-col sm:flex-row gap-3 items-start sm:items-center">
                    <input
                      v-model="maCongTy"
                      :disabled="daGuiYeuCau"
                      type="text"
                      placeholder="Nhập mã công ty (VD: CT-4)"
                      class="border border-gray-300 rounded-lg px-3 py-2 w-full sm:w-60
                            focus:outline-none focus:ring-2 focus:ring-indigo-500
                            disabled:opacity-60 disabled:cursor-not-allowed"
                    />

                    <button
                      @click="kiemTraCongTy"
                      :disabled="dangKiemTra || daGuiYeuCau"
                      class="px-4 py-2 bg-indigo-600 text-white rounded-lg hover:bg-indigo-700 transition font-medium text-sm shadow
                            disabled:opacity-60 disabled:cursor-not-allowed"
                    >
                      <span v-if="dangKiemTra">⏳ Đang kiểm tra...</span>
                      <span v-else>🔍 Kiểm tra</span>
                    </button>
                  </div>

                  <!-- Kết quả công ty -->
                  <div
                    v-if="thongTinCongTy"
                    class="mt-6 bg-white border border-gray-200 rounded-2xl shadow-sm overflow-hidden"
                  >
                    <div
                      class="flex items-center gap-5 p-5 border-b bg-gradient-to-r from-indigo-600 to-purple-600 text-white"
                    >
                      <img
                        :src="thongTinCongTy.logoUrl ? getAvatarUrl(thongTinCongTy.logoUrl) : '/default-company.png'"
                        alt="Logo công ty"
                        class="h-16 w-16 rounded-xl object-cover border border-white shadow-md"
                      />
                      <div>
                        <h3 class="text-xl font-bold tracking-tight">{{ thongTinCongTy.tenCongTy }}</h3>
                      </div>
                    </div>

                    <div class="p-5 space-y-3 text-sm text-gray-800">
                      <p><strong>Email:</strong> {{ thongTinCongTy.emailLienHe || "—" }}</p>
                      <p><strong>Điện thoại:</strong> {{ thongTinCongTy.soDienThoaiLienHe || "—" }}</p>

                      <label class="block text-sm font-medium text-gray-700 mb-1 mt-3">
                        📝 Lý do xin xác thực
                      </label>
                      <textarea
                        v-model="lyDoXinXacThuc"
                        :disabled="daGuiYeuCau"
                        rows="3"
                        placeholder="Nhập lý do..."
                        class="w-full border border-gray-300 rounded-lg px-3 py-2
                              focus:ring-2 focus:ring-indigo-500 focus:outline-none text-sm
                              disabled:bg-gray-100 disabled:opacity-60"
                      ></textarea>

                      <div class="flex justify-end">
                        <button
                          @click="guiYeuCauXacThuc"
                          :disabled="dangGuiYeuCau || daGuiYeuCau"
                          class="mt-3 px-5 py-2 bg-green-600 text-white rounded-lg hover:bg-green-700 transition text-sm font-medium shadow
                                disabled:opacity-60 disabled:cursor-not-allowed"
                        >
                          <span v-if="dangGuiYeuCau">⏳ Đang gửi...</span>
                          <span v-else>📤 Gửi yêu cầu</span>
                        </button>
                      </div>
                    </div>
                  </div>

                  <p v-if="daKiemTra && !thongTinCongTy" class="text-red-600 text-sm">
                    ❌ Không tìm thấy công ty với mã: <strong>{{ maCongTy }}</strong>
                  </p>
                </div>
              </div>
            </section>
          </div>
        </template>

        <section
          v-else-if="user?.vaiTro === 'SinhVien'"
          class="md:col-span-7 text-gray-800 space-y-10"
        >
          <div class="profile-card">
            <h3 class="profile-title">🟢 Trạng thái tìm việc</h3>

            <div class="space-y-5">

              <!-- ĐANG TÌM VIỆC -->
              <div class="flex items-center justify-between">
                <div>
                  <p class="font-semibold text-gray-800">
                    Tôi đang tìm việc
                  </p>
                  <p class="text-sm text-gray-500">
                    Hồ sơ sẽ hiển thị trong danh sách ứng viên đang tìm việc
                  </p>
                </div>

                <!-- TOGGLE -->
                <button
                  @click="dangTimViec = !dangTimViec; capNhatTrangThaiTimViec()"
                  :class="dangTimViec ? 'bg-indigo-600' : 'bg-gray-300'"
                  class="relative inline-flex h-6 w-11 items-center rounded-full transition"
                >
                  <span
                    :class="dangTimViec ? 'translate-x-6' : 'translate-x-1'"
                    class="inline-block h-4 w-4 transform rounded-full bg-white transition"
                  />
                </button>
              </div>

              <!-- CHO PHÉP NTD TÌM -->
              <div
                class="flex items-center justify-between"
                :class="!dangTimViec && 'opacity-50 pointer-events-none'"
              >
                <div>
                  <p class="font-semibold text-gray-800">
                    Cho phép nhà tuyển dụng tìm thấy hồ sơ
                  </p>
                  <p class="text-sm text-gray-500">
                    Nhà tuyển dụng có thể chủ động xem CV và liên hệ
                  </p>
                </div>

                <!-- TOGGLE -->
                <button
                  @click="choPhepNhaTuyenDungTim = !choPhepNhaTuyenDungTim; capNhatTrangThaiTimViec()"
                  :class="choPhepNhaTuyenDungTim ? 'bg-green-600' : 'bg-gray-300'"
                  class="relative inline-flex h-6 w-11 items-center rounded-full transition"
                >
                  <span
                    :class="choPhepNhaTuyenDungTim ? 'translate-x-6' : 'translate-x-1'"
                    class="inline-block h-4 w-4 transform rounded-full bg-white transition"/>
                </button>
              </div>

            </div>
          </div>

          <!-- HEADER -->
          <div class="flex items-center justify-between">
            <div>
              <h2 class="text-3xl font-bold text-indigo-700 flex items-center gap-2">
                🎓 Hồ sơ sinh viên
              </h2>
              <p class="text-gray-500 text-sm mt-1">
                Thông tin được lấy từ hồ sơ cá nhân & quá trình học tập
              </p>
            </div>

            <div class="flex gap-2">
              <button
                @click="viewCV"
                class="px-4 py-2 bg-indigo-600 text-white rounded-lg shadow hover:bg-indigo-700 transition text-sm font-medium"
              >
                📄 Xem CV
              </button>

              <button
                @click="downloadProfile"
                class="px-4 py-2 bg-emerald-600 text-white rounded-lg shadow hover:bg-emerald-700 transition text-sm font-medium"
              >
                ⬇️ Tải hồ sơ
              </button>
            </div>
          </div>

          <div class="profile-card">
            <h3 class="profile-title">👤 Thông tin cơ bản</h3>

            <div class="profile-grid">

              <div class="profile-field">
                <p class="profile-label">Họ và tên</p>
                <p class="profile-value">{{ sinhVien?.hoTen || "—" }}</p>
              </div>

              <div class="profile-field">
                <p class="profile-label">Giới tính</p>
                <p class="profile-value">{{ sinhVien?.gioiTinh || "—" }}</p>
              </div>

              <div class="profile-field">
                <p class="profile-label">Ngày sinh</p>
                <p class="profile-value">{{ formatDate(sinhVien?.ngaySinh) }}</p>
              </div>

              <div class="profile-field">
                <p class="profile-label">Tỉnh / Thành phố</p>
                <p class="profile-value">{{ tenTinhThanh }}</p>
              </div>

              <div class="profile-field">
                <p class="profile-label">Địa chỉ</p>
                <p class="profile-value">{{ sinhVien?.diaChi || "—" }}</p>
              </div>

              <div class="profile-field">
                <p class="profile-label">Lớp</p>
                <p class="profile-value">{{ sinhVien?.lopHoc || "—" }}</p>
              </div>

              <div class="profile-field">
                <p class="profile-label">Khoá</p>
                <p class="profile-value">{{ sinhVien?.khoaHoc || "—" }}</p>
              </div>

            </div>
          </div>

          <div class="card-2 hover:shadow-lg transition-all">
            <h3 class="card-2-title">🎯 Mục tiêu nghề nghiệp</h3>
            <p class="value leading-relaxed">
              {{ sinhVien.mucTieuNgheNghiep || "— Chưa cập nhật —" }}
            </p>
          </div>

          <div class="profile-card">
            <h3 class="profile-title">💼 Nguyện vọng công việc</h3>

            <div class="profile-grid">

              <div class="profile-field">
                <p class="profile-label">Cấp bậc mong muốn</p>
                <p class="profile-value">{{ sinhVien?.capBacMongMuon || "—" }}</p>
              </div>

              <div class="profile-field">
                <p class="profile-label">Mức lương mong muốn</p>
                <p class="profile-value">
                  {{
                    sinhVien?.mucLuongTu && sinhVien?.mucLuongDen
                      ? `${sinhVien.mucLuongTu.toLocaleString()} - ${sinhVien.mucLuongDen.toLocaleString()} ${sinhVien?.donViTienTe || ""}`
                      : "—"
                  }}
                </p>
              </div>

              <div class="profile-field">
                <p class="profile-label">Hình thức làm việc</p>
                <p class="profile-value">{{ sinhVien?.hinhThucLamViec || "—" }}</p>
              </div>

              <div class="profile-field">
                <p class="profile-label">Ngành nghề mong muốn</p>
                <p class="profile-value">{{ sinhVien?.nganhNgheMongMuon || "—" }}</p>
              </div>

              <div class="profile-field">
                <p class="profile-label">Nơi làm việc mong muốn</p>
                <p class="profile-value">{{ sinhVien?.noiLamViecMongMuon || "—" }}</p>
              </div>

              <div class="profile-field profile-full">
                <p class="profile-label">Phúc lợi mong muốn</p>
                <p class="profile-value">
                  {{
                    sinhVien?.phucLoiMongMuon?.length
                      ? sinhVien.phucLoiMongMuon.join(", ")
                      : "—"
                  }}
                </p>
              </div>

            </div>
          </div>

          <div class="card-2 hover:shadow-lg transition-all">
            <h3 class="card-2-title">🎓 Học vấn</h3>

            <div v-if="sinhVien.hocVans?.length" class="timeline">
              <div v-for="(hv, i) in sinhVien.hocVans" :key="i" class="timeline-item">
                <div class="dot"></div>
                <p class="leading-relaxed">
                  <strong>{{ hv.bangCap }}</strong> – {{ hv.truongHoacKhoaHoc }}  
                  <br />
                  📅 Tốt nghiệp: {{ hv.thangNamTotNghiep }}
                  <br />
                  📝 {{ hv.moTaChiTiet }}
                </p>
              </div>
            </div>

            <p v-else class="empty">— Chưa có thông tin học vấn —</p>
          </div>

          <div class="card-2 hover:shadow-lg transition-all">
            <h3 class="card-2-title">💼 Kinh nghiệm làm việc</h3>

            <div v-if="sinhVien.kinhNghiems?.length" class="timeline">
              <div v-for="(kn, i) in sinhVien.kinhNghiems" :key="i" class="timeline-item">
                <div class="dot"></div>
                <p class="leading-relaxed">
                  <strong>{{ kn.viTriChucDanh }}</strong> – {{ kn.tenCongTy }}  
                  <br />
                  📅 {{ formatDate(kn.ngayBatDau) }} → 
                  {{ kn.dangLamHienTai ? "Hiện tại" : formatDate(kn.ngayKetThuc) }}
                  <br />
                  📝 {{ kn.moTaCongViec }}
                </p>
              </div>
            </div>

            <p v-else class="empty">— Chưa có kinh nghiệm —</p>
          </div>

          <div class="card-2 hover:shadow-lg transition-all">
            <h3 class="card-2-title">🛠️ Kỹ năng chuyên môn</h3>

            <div v-if="sinhVien.kyNangs?.length" class="space-y-4">
              <div v-for="(k, i) in sinhVien.kyNangs" :key="i">
                <p class="font-medium text-sm">{{ k.tenKyNang }}</p>
                <p class="text-gray-500 text-xs mb-1 italic">{{ k.moTaKyNang }}</p>
                <div class="skill-bar">
                  <div class="skill-level" :style="{ width: `${k.mucDo * 20}%` }"></div>
                </div>
              </div>
            </div>

            <p v-else class="empty">— Chưa có kỹ năng —</p>
          </div>

          <div class="card-2 hover:shadow-lg transition-all">
            <h3 class="card-2-title">🌐 Ngoại ngữ</h3>

            <ul class="list ml-5 list-disc">
              <li v-for="(n, i) in sinhVien.ngoaiNgus" :key="i">
                <strong>{{ n.tenNgoaiNgu }}</strong> – {{ n.trinhDo }}  
                <br />
                📜 Chứng chỉ: {{ n.chungChiNgoaiNgu }}
              </li>
              <li v-if="!sinhVien.ngoaiNgus?.length" class="empty">— Chưa cập nhật —</li>
            </ul>
          </div>

          <div class="card-2 hover:shadow-lg transition-all">
            <h3 class="card-2-title">📜 Chứng chỉ</h3>

            <ul class="list ml-5 list-disc">
              <li v-for="(c, i) in sinhVien.chungChis" :key="i">
                <strong>{{ c.tenChungChi }}</strong> – {{ c.capBoi }}  
                <br />
                📅 Cấp ngày: {{ formatDate(c.ngayCap) }}
              </li>
              <li v-if="!sinhVien.chungChis?.length" class="empty">— Chưa cập nhật —</li>
            </ul>
          </div>

          <div class="card-2 hover:shadow-lg transition-all">
            <h3 class="card-2-title">🤝 Hoạt động nổi bật</h3>

            <ul class="list ml-5 list-disc">
              <li v-for="(h, i) in sinhVien.hoatDongs" :key="i">
                <strong>{{ h.vaiTro }}</strong> – {{ h.toChuc }}
                <br />
                📅 {{ formatDate(h.ngayBatDau) }} →
                {{ h.dangHoatDong ? "Hiện tại" : formatDate(h.ngayKetThuc) }}
              </li>
              <li v-if="!sinhVien.hoatDongs?.length" class="empty">— Chưa cập nhật —</li>
            </ul>
          </div>

          <div class="card-2 hover:shadow-lg transition-all">
            <h3 class="card-2-title">👥 Người tham chiếu</h3>

            <ul class="list ml-5 list-disc">
              <li v-for="(r, i) in sinhVien.nguoiThamChieus" :key="i">
                <strong>{{ r.hoVaTen }}</strong> – {{ r.chucVu }} tại {{ r.congTy }}   
                <br />
                📞 {{ r.dienThoai }}  
                <br />
                ✉️ {{ r.email }}
              </li>
              <li v-if="!sinhVien.nguoiThamChieus?.length" class="empty">— Chưa có —</li>
            </ul>
          </div>
        </section>
      </main>
    </div>
  </div>
</template>


<script setup>
import { ref, computed, onMounted } from "vue";
import api from "@/api/axios";
import { useAuthStore } from "@/store/auth";
import { useRouter } from "vue-router";
import { useToast } from "vue-toastification";
import InfoRow from "@/components/common/InfoRow.vue";

const auth = useAuthStore();
const router = useRouter();
const toast = useToast();

const user = ref(null);
const sinhVien = ref(null);
const loading = ref(true);
const baseURL = "https://localhost:7248";

const maCongTy = ref("");
const thongTinCongTy = ref(null);
const lyDoXinXacThuc = ref("");
const daKiemTra = ref(false);
const dangKiemTra = ref(false);
const dangGuiYeuCau = ref(false);

const daGuiYeuCau = ref(false);
const tinhThanhs = ref([]);

const dangTimViec = ref(false)
const choPhepNhaTuyenDungTim = ref(false)


onMounted(async () => {
  await loadProfile();

  if (user.value?.vaiTro === "SinhVien") {
    await Promise.all([
      loadSinhVienProfile(),
      loadTinhThanh()
    ]);
  }
});

async function loadTinhThanh() {
  try {
    const res = await api.get("/DiaChi/tinh-thanh", {
      headers: { Authorization: `Bearer ${auth.token}` },
    });



    tinhThanhs.value = res.data || [];
  } catch (e) {
    console.error(e);
    toast.error("Không thể tải danh sách tỉnh / thành phố");
  }
}

const tenTinhThanh = computed(() => {
  if (!sinhVien.value || !sinhVien.value.tinhThanhId) return "—";
  if (!tinhThanhs.value.length) return "—";

  const found = tinhThanhs.value.find(
    x => x.id === sinhVien.value.tinhThanhId
  );

  return found?.tenTinh || "—";
});




async function loadProfile() {
  try {
    loading.value = true;

    const res = await api.get("/TaiKhoan/thong-tin", {
      headers: { Authorization: `Bearer ${auth.token}` },
    });

    user.value = res.data;
    auth.user = res.data;
    localStorage.setItem("user", JSON.stringify(res.data));

    if (user.value.vaiTro === "NhaTuyenDung") {

      if (user.value.congTyDangChoXacThuc) {
        daGuiYeuCau.value = true;
      }

      if (
        user.value.thongBao &&
        user.value.thongBao.toLowerCase().includes("đã gửi yêu cầu")
      ) {
        daGuiYeuCau.value = true;
      }
    }

    if (user.value.vaiTro === "SinhVien") {
      await loadSinhVienProfile();
    }

  } catch (err) {
    toast.error("Không thể tải thông tin tài khoản!");

    if (err.response?.status === 401) {
      auth.logout();
      router.push("/login");
    }

  } finally {
    loading.value = false;
  }
}

function viewCV() {
  sessionStorage.setItem("cvSinhVien", JSON.stringify(sinhVien.value));
  router.push("/cv/xem");
}

async function loadSinhVienProfile() {
  try {
    const res = await api.get("/sinhvien/profile", {
      headers: { Authorization: `Bearer ${auth.token}` }
    });

    sinhVien.value = res.data;
    dangTimViec.value = sinhVien.value?.dangTimViec ?? false
    choPhepNhaTuyenDungTim.value = sinhVien.value?.choPhepNhaTuyenDungTim ?? false

  } catch (e) {
    console.error(e);
    toast.error("Không thể tải hồ sơ sinh viên!");
  }
}

async function kiemTraCongTy() {
  try {
    if (!maCongTy.value.trim()) {
      toast.warning("Vui lòng nhập mã công ty (VD: CT-4)");
      return;
    }

    dangKiemTra.value = true;
    thongTinCongTy.value = null;

    const res = await api.get(
      `/DoanhNghiep/kiem-tra-cong-ty/${maCongTy.value}`,
      { headers: { Authorization: `Bearer ${auth.token}` } }
    );

    if (res.data?.thanhCong && res.data?.thongTinCongTy) {
      thongTinCongTy.value = res.data.thongTinCongTy;
      toast.success("✅ Đã tìm thấy công ty!");
    } else {
      thongTinCongTy.value = null;
      toast.warning("Không tìm thấy công ty phù hợp.");
    }

    daKiemTra.value = true;

  } catch {
    thongTinCongTy.value = null;
    daKiemTra.value = true;
    toast.error("Không tìm thấy công ty.");
  } finally {
    dangKiemTra.value = false;
  }
}

async function capNhatTrangThaiTimViec() {
  try {
    if (!dangTimViec.value) {
      choPhepNhaTuyenDungTim.value = false
    }

    await api.put(
      "/sinhvien/profile/tim-viec",
      {
        dangTimViec: dangTimViec.value,
        choPhepNhaTuyenDungTim: choPhepNhaTuyenDungTim.value
      },
      { headers: { Authorization: `Bearer ${auth.token}` } }
    )

    toast.success("✅ Đã cập nhật trạng thái tìm việc")

  } catch (e) {
    toast.error("❌ Không thể cập nhật trạng thái")
    console.error(e)
  }
}


async function guiYeuCauXacThuc() {
  try {
    if (!thongTinCongTy.value) {
      toast.warning("Vui lòng kiểm tra công ty trước khi gửi!");
      return;
    }

    if (!lyDoXinXacThuc.value.trim()) {
      toast.warning("Vui lòng nhập lý do xác thực!");
      return;
    }

    dangGuiYeuCau.value = true;

    await api.post(
      "/DoanhNghiep/hr/xin-xac-thuc",
      { maCongTy: maCongTy.value, lyDoXinXacThuc: lyDoXinXacThuc.value },
      { headers: { Authorization: `Bearer ${auth.token}` } }
    );

    toast.success("📩 Đã gửi yêu cầu xác thực. Vui lòng chờ phản hồi!");

    // Reset input UI
    thongTinCongTy.value = null;
    lyDoXinXacThuc.value = "";
    maCongTy.value = "";

    // KHÓA FORM NGAY
    daGuiYeuCau.value = true;

  } catch {
    toast.error("Không thể gửi yêu cầu xác thực.");
  } finally {
    dangGuiYeuCau.value = false;
  }
}

function getAvatarUrl(path) {
  if (!path) return "/default-avatar.png";
  return path.startsWith("http") ? path : `${baseURL}${path}`;
}

function normalizeWebsite(url) {
  if (!url) return "";
  return url.startsWith("http") ? url : `https://${url}`;
}

function roleLabel(role) {
  const map = {
    SinhVien: "🎓 Sinh viên",
    NhaTuyenDung: "💼 Nhà tuyển dụng",
    DoanhNghiep: "🏢 Doanh nghiệp",
    Admin: "⚙️ Admin",
    SuperAdmin: "👑 Super Admin",
  };
  return map[role] || "Người dùng";
}

function formatDate(date) {
  if (!date) return "—";
  return new Date(date).toLocaleDateString("vi-VN", {
    year: "numeric",
    month: "2-digit",
    day: "2-digit",
  });
}

import html2canvas from "html2canvas";
import jsPDF from "jspdf";

async function downloadProfile() {
  const element = document.querySelector(".md\\:col-span-7"); // khu vực hồ sơ sinh viên

  const canvas = await html2canvas(element, {
    scale: 2,
    useCORS: true,
    backgroundColor: "#ffffff"
  });

  const imgData = canvas.toDataURL("image/png");

  const pdf = new jsPDF("p", "mm", "a4");
  const pdfWidth = pdf.internal.pageSize.getWidth();
  const pdfHeight = (canvas.height * pdfWidth) / canvas.width;

  pdf.addImage(imgData, "PNG", 0, 0, pdfWidth, pdfHeight);
  pdf.save(`HoSo_${sinhVien.value.hoTen}.pdf`);
}

</script>

<style scoped>
img.h-28:hover {
  transform: scale(1.05);
  transition: all 0.2s ease-in-out;
}
@media (max-width: 768px) {
  .bg-gradient-to-r {
    text-align: center;
  }
}
.card {
  @apply bg-white border border-gray-200 rounded-2xl shadow-sm p-6;
}

.card-title {
  @apply text-lg font-semibold text-gray-800 mb-3 flex items-center gap-2;
}

.label {
  @apply font-medium text-gray-600;
}

.value {
  @apply text-gray-800 leading-relaxed;
}

.skill-pill {
  @apply bg-indigo-50 text-indigo-700 px-3 py-1 rounded-full text-sm border border-indigo-200;
}
.card-2 {
  @apply bg-white border border-gray-200 rounded-2xl p-6 shadow-sm;
}

.card-2-title {
  @apply text-lg font-bold text-gray-900 mb-4 flex items-center gap-2;
}

.value {
  @apply text-gray-800 leading-relaxed text-sm;
}

.empty {
  @apply text-gray-400 text-sm italic;
}

/* ====================== TIMELINE ====================== */
.timeline {
  @apply relative border-l border-gray-300 ml-3 pl-4 space-y-4;
}

.timeline-item {
  @apply relative;
}

.timeline-item .dot {
  @apply w-3 h-3 bg-indigo-600 rounded-full absolute -left-[25px] top-1;
}

/* ====================== SKILL BAR ====================== */
.skill-bar {
  @apply h-2 bg-gray-200 rounded-full overflow-hidden;
}

.skill-level {
  width: calc(60% + (random() * 40%)); /* random visual effect */
  @apply h-full bg-indigo-500 rounded-full;
}

/* ====================== SMALL COMPONENT ====================== */
.label {
  @apply text-gray-600 font-medium;
}

.card-2 {
  @apply bg-white border border-gray-200 rounded-2xl p-6 shadow-sm;
}

.card-2-title {
  @apply text-xl font-bold text-gray-800 mb-4;
}

.empty {
  @apply text-gray-400 italic;
}

.value {
  @apply text-gray-700;
}
/* CARD CHUNG */
.profile-card {
  @apply bg-white border border-gray-200 rounded-2xl p-6 shadow-sm transition hover:shadow-lg;
}

.profile-title {
  @apply text-xl font-bold text-gray-900 mb-4 flex items-center gap-2;
}

/* GRID */
.profile-grid {
  @apply grid grid-cols-1 md:grid-cols-2 gap-5;
}

/* TỪNG FIELD */
.profile-field {
  @apply flex flex-col;
}

.profile-label {
  @apply text-gray-500 text-sm font-medium mb-1;
}

.profile-value {
  @apply text-gray-900 font-semibold text-base;
}

</style>
