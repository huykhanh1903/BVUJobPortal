<template>
  <div class="max-w-5xl mx-auto mt-10 bg-white rounded-2xl shadow-xl overflow-hidden">
    <!-- Header -->
    <div class="bg-gradient-to-r from-orange-500 via-red-500 to-pink-500 p-8 text-white text-center">
      <h2 class="text-3xl font-bold">{{ headerTitle }}</h2>
      <p class="text-orange-100 mt-2">{{ headerSubtitle }}</p>
    </div>

    <div class="p-8">
      <div class="flex flex-col items-center mb-8">

        <!-- Avatar + Logo -->
        <div
          class="flex items-start justify-center gap-32 flex-wrap"
          :class="{ 'flex-col gap-10': auth.user?.vaiTro !== 'DoanhNghiep' }"
        >

          <!-- Avatar cá nhân -->
          <div class="flex flex-col items-center text-center">
            <img
              v-if="avatarPreviewUrl || auth.user?.avatarUrl"
              :src="avatarPreviewUrl || getAvatarUrl(auth.user?.avatarUrl)"
              class="h-28 w-28 rounded-full object-cover border-4 border-orange-300 shadow-md hover:scale-105 transition"
            />
            <div
              v-else
              class="h-28 w-28 rounded-full bg-gradient-to-br from-orange-400 to-red-500 flex items-center justify-center text-white text-3xl font-bold shadow"
            >
              {{ form.hoTen?.charAt(0) || 'A' }}
            </div>

            <p class="text-xs text-gray-500 mt-2">Cá nhân</p>

            <!-- Upload avatar cá nhân -->
            <div class="mt-3 flex flex-col items-center">
              <label class="text-sm text-gray-600 font-medium mb-1">🧑‍💼 Ảnh đại diện cá nhân</label>
              <input type="file" accept="image/*" @change="onAvatarFileChange" class="text-sm mb-1" />
              <button
                v-if="avatarFile"
                @click="uploadAvatar"
                class="px-4 py-1.5 bg-orange-600 text-white rounded-lg shadow hover:bg-orange-700 text-sm"
              >
                📤 Upload
              </button>
            </div>
          </div>

          <!-- Logo Công Ty -->
          <div v-if="auth.user?.vaiTro === 'DoanhNghiep'" class="flex flex-col items-center text-center">

            <img
              v-if="logoPreviewUrl || auth.user?.thongTinCongTy?.logoUrl"
              :src="logoPreviewUrl || getAvatarUrl(auth.user?.thongTinCongTy?.logoUrl)"
              class="h-28 w-28 rounded-xl object-cover border-orange-200 shadow-md hover:scale-105 transition"
            />

            <div v-else class="h-28 w-28 rounded-xl bg-gray-200 flex items-center justify-center text-2xl text-gray-600 shadow">
              🏢
            </div>

            <p class="text-xs text-gray-500 mt-2">Công ty</p>

            <!-- Upload logo -->
            <div class="mt-3 flex flex-col items-center">
              <label class="text-sm text-gray-600 font-medium mb-1">🏢 Logo công ty</label>
              <input type="file" accept="image/*" @change="onLogoFileChange" class="text-sm mb-1" />
              <button
                v-if="logoFile"
                @click="uploadLogo"
                class="px-4 py-1.5 bg-orange-600 text-white rounded-lg shadow hover:bg-orange-700 text-sm"
              >
                📤 Upload logo
              </button>
            </div>
          </div>

        </div>
      </div>

      <!-- Form -->
      <form @submit.prevent="updateProfile" class="space-y-10">

        <section v-if="auth.user?.vaiTro === 'SinhVien'">
          <!-- 👤 Thông tin cá nhân -->
        <section>
          <h3 class="section-title">👤 Thông tin cá nhân</h3>

          <div class="grid sm:grid-cols-3 gap-6">
            <div class="sm:col-span-3">
              <label class="label">Họ và tên</label>
              <input v-model="form.hoTen" class="input" />
            </div>

            <div>
              <label class="label">Giới tính</label>
              <select v-model="form.gioiTinh" class="input">
                <option value="Nam">Nam</option>
                <option value="Nữ">Nữ</option>
              </select>
            </div>

            <div>
              <label class="label">Ngày sinh</label>
              <input type="date" v-model="form.ngaySinh" class="input" />
            </div>

            <div>
              <label class="label">Số điện thoại</label>
              <input v-model="form.dienThoai" class="input" />
            </div>

            <div>
              <label class="label">Email liên hệ</label>
              <input type="email" v-model="form.emailLienHe" class="input" />
            </div>

            <div>
              <label class="label">Địa chỉ</label>
              <input v-model="form.diaChi" class="input" />
            </div>

            <div>
              <label class="label">Tỉnh / Thành phố</label>
              <select v-model="form.tinhThanhId" class="input">
                <option disabled value="">-- Chọn tỉnh/thành --</option>
                <option v-for="t in tinhThanhList" :key="t.id" :value="t.id">
                  {{ t.tenTinh }}
                </option>
              </select>
            </div>

            <div>
              <label class="label">Lớp học</label>
              <input v-model="form.lopHoc" class="input" />
            </div>

            <div>
              <label class="label">Khóa học</label>
              <input v-model="form.khoaHoc" class="input" />
            </div>
          </div>
        </section>
        
        <!-- Mục tiêu & mong muốn nghề nghiệp -->
        <section>
          <h3 class="section-title">🎯 Mục tiêu & mong muốn nghề nghiệp</h3>

          <div>
            <label class="label">Mục tiêu nghề nghiệp</label>
            <textarea v-model="form.mucTieuNgheNghiep" class="textarea"></textarea>
          </div>

          <div class="grid sm:grid-cols-2 gap-6 mt-4">
            <div>
              <label class="label">Cấp bậc mong muốn</label>
              <input v-model="form.capBacMongMuon" class="input" />
            </div>

            <div>
              <label class="label">Ngành nghề mong muốn</label>
              <input v-model="form.nganhNgheMongMuon" class="input" />
            </div>

            <div>
              <label class="label">Nơi làm việc mong muốn</label>
              <input v-model="form.noiLamViecMongMuon" class="input" />
            </div>

            <div>
              <label class="label">Phúc lợi mong muốn</label>
              <input v-model="form.phucLoiMongMuon" class="input" />
            </div>
          </div>
        </section>

        <!-- Mức lương mong muốn -->
        <section>
          <h3 class="section-title">💵 Mức lương mong muốn</h3>

          <div class="grid sm:grid-cols-3 gap-6">
            <div>
              <label class="label">Lương từ</label>
              <input v-model="form.mucLuongTu" type="number" class="input" />
            </div>

            <div>
              <label class="label">Lương đến</label>
              <input v-model="form.mucLuongDen" type="number" class="input" />
            </div>

            <div>
              <label class="label">Đơn vị tiền tệ</label>
              <select v-model="form.donViTienTe" class="input">
                <option value="VND">VND</option>
                <option value="USD">USD</option>
              </select>
            </div>

            <div>
              <label class="label">Hình thức làm việc</label>
              <input v-model="form.hinhThucLamViec" class="input" />
            </div>
          </div>
        </section>

        <!-- Kinh nghiệm làm việc -->
        <section>
          <h3 class="section-title">💼 Kinh nghiệm làm việc</h3>

          <div
            v-for="(item, i) in form.kinhNghiems"
            :key="'exp'+i"
            class="grid grid-cols-1 sm:grid-cols-2 gap-4 mb-6 p-4 border rounded-lg bg-gray-50"
          >
            <div>
              <label class="label">Vị trí / chức danh</label>
              <input v-model="item.viTriChucDanh" class="input" />
            </div>

            <div>
              <label class="label">Tên công ty</label>
              <input v-model="item.tenCongTy" class="input" />
            </div>

            <div>
              <label class="label">Phương thức làm việc</label>
              <input v-model="item.phuongThucCongViec" class="input" />
            </div>

            <div>
              <label class="label">Ngày bắt đầu</label>
              <input type="date" v-model="item.ngayBatDau" class="input" />
            </div>

            <div>
              <label class="label">Ngày kết thúc</label>
              <input type="date" v-model="item.ngayKetThuc" class="input" />
            </div>

            <div class="flex items-center gap-2">
              <input type="checkbox" v-model="item.dangLamHienTai" />
              <label>Đang làm hiện tại</label>
            </div>

            <div class="sm:col-span-2">
              <label class="label">Mô tả công việc</label>
              <textarea v-model="item.moTaCongViec" class="textarea"></textarea>
            </div>

            <div class="flex justify-end sm:col-span-2">
              <button class="btn-danger" @click.prevent="form.kinhNghiems.splice(i, 1)">Xóa</button>
            </div>
          </div>

          <button
            class="btn-add"
            @click.prevent="form.kinhNghiems.push({
              id: 0, viTriChucDanh: '', tenCongTy: '', phuongThucCongViec: '',
              ngayBatDau: '', ngayKetThuc: '', dangLamHienTai: false,
              moTaCongViec: '', thuTu: form.kinhNghiems.length + 1
            })"
          >
            ➕ Thêm kinh nghiệm
          </button>
        </section>

        <!-- Học vấn -->
        <section>
          <h3 class="section-title">🎓 Học vấn</h3>

          <div
            v-for="(item, i) in form.hocVans"
            :key="'edu'+i"
            class="grid grid-cols-1 sm:grid-cols-2 gap-4 mb-6 p-4 border rounded-lg bg-gray-50"
          >
            <div>
              <label class="label">Trường / Khóa học</label>
              <input v-model="item.truongHoacKhoaHoc" class="input" />
            </div>

            <div>
              <label class="label">Bằng cấp</label>
              <input v-model="item.bangCap" class="input" />
            </div>

            <div>
              <label class="label">Tháng năm tốt nghiệp</label>
              <input v-model="item.thangNamTotNghiep" class="input" />
            </div>

            <div>
              <label class="label">Ngày tốt nghiệp</label>
              <input type="date" v-model="item.ngayTotNghiep" class="input" />
            </div>

            <div class="sm:col-span-2">
              <label class="label">Mô tả chi tiết</label>
              <textarea v-model="item.moTaChiTiet" class="textarea"></textarea>
            </div>

            <div class="flex justify-end sm:col-span-2">
              <button class="btn-danger" @click.prevent="form.hocVans.splice(i, 1)">Xóa</button>
            </div>
          </div>

          <button
            class="btn-add"
            @click.prevent="form.hocVans.push({
              id:0, truongHoacKhoaHoc:'', bangCap:'', thangNamTotNghiep:'',
              ngayTotNghiep:'', moTaChiTiet:'', thuTu: form.hocVans.length + 1
            })"
          >
            ➕ Thêm học vấn
          </button>
        </section>

        <!-- Chứng chỉ – Ngoại ngữ – Kỹ năng -->
        <section>
          <h3 class="section-title">📜 Chứng chỉ</h3>

          <div
            v-for="(item, i) in form.chungChis"
            :key="'cert'+i"
            class="grid grid-cols-1 sm:grid-cols-2 gap-4 mb-6 p-4 border rounded-lg bg-gray-50"
          >
            <div>
              <label class="label">Tên chứng chỉ</label>
              <input v-model="item.tenChungChi" class="input" />
            </div>

            <div>
              <label class="label">Cấp bởi</label>
              <input v-model="item.capBoi" class="input" />
            </div>

            <div>
              <label class="label">Ngày cấp</label>
              <input type="date" v-model="item.ngayCap" class="input" />
            </div>

            <div>
              <label class="label">Ngày hết hạn</label>
              <input type="date" v-model="item.ngayHetHan" class="input" />
            </div>

            <div class="flex items-center gap-2">
              <input type="checkbox" v-model="item.khongHetHan" />
              <label>Không hết hạn</label>
            </div>

            <div class="flex justify-end sm:col-span-2">
              <button class="btn-danger" @click.prevent="form.chungChis.splice(i, 1)">Xóa</button>
            </div>
          </div>

          <button
            class="btn-add"
            @click.prevent="form.chungChis.push({
              id: 0, tenChungChi:'', capBoi:'', ngayCap:'',
              ngayHetHan:'', khongHetHan:false, thuTu: form.chungChis.length + 1
            })"
          >
            ➕ Thêm chứng chỉ
          </button>
        </section>

        <section>
            <h3 class="section-title">🌐 Ngoại ngữ</h3>

            <div
              v-for="(item, i) in form.ngoaiNgus"
              :key="'lang'+i"
              class="grid grid-cols-1 sm:grid-cols-2 gap-4 mb-6 p-4 border rounded-lg bg-gray-50"
            >
              <div>
                <label class="label">Tên ngoại ngữ</label>
                <input v-model="item.tenNgoaiNgu" class="input" />
              </div>

              <div>
                <label class="label">Trình độ</label>
                <input v-model="item.trinhDo" class="input" />
              </div>

              <div class="sm:col-span-2">
                <label class="label">Chứng chỉ</label>
                <input v-model="item.chungChiNgoaiNgu" class="input" />
              </div>

              <div class="flex justify-end sm:col-span-2">
                <button class="btn-danger" @click.prevent="form.ngoaiNgus.splice(i, 1)">Xóa</button>
              </div>
            </div>

            <button
              class="btn-add"
              @click.prevent="form.ngoaiNgus.push({
                id:0, tenNgoaiNgu:'', trinhDo:'', chungChiNgoaiNgu:'', thuTu: form.ngoaiNgus.length + 1
              })"
            >
              ➕ Thêm ngoại ngữ
            </button>
          </section>

          <section>
            <h3 class="section-title">🛠 Kỹ năng chuyên môn</h3>

            <div
              v-for="(item, i) in form.kyNangs"
              :key="'skill'+i"
              class="grid grid-cols-1 sm:grid-cols-2 gap-4 mb-6 p-4 border rounded-lg bg-gray-50"
            >
              <div>
                <label class="label">Tên kỹ năng</label>
                <input v-model="item.tenKyNang" class="input" />
              </div>

              <div>
                <label class="label">Mức độ (1-5)</label>
                <input type="number" min="1" max="5" v-model="item.mucDo" class="input" />
              </div>

              <div class="sm:col-span-2">
                <label class="label">Mô tả kỹ năng</label>
                <textarea v-model="item.moTaKyNang" class="textarea"></textarea>
              </div>

              <div class="flex justify-end sm:col-span-2">
                <button class="btn-danger" @click.prevent="form.kyNangs.splice(i, 1)">Xóa</button>
              </div>
            </div>

            <button
              class="btn-add"
              @click.prevent="form.kyNangs.push({
                id:0, tenKyNang:'', moTaKyNang:'', mucDo:1, thuTu: form.kyNangs.length + 1
              })"
            >
              ➕ Thêm kỹ năng
            </button>
          </section>

        <!-- Hoạt động – Người tham chiếu -->
        <section>
          <h3 class="section-title">🎉 Hoạt động</h3>

          <div
            v-for="(item, i) in form.hoatDongs"
            :key="'act'+i"
            class="grid grid-cols-1 sm:grid-cols-2 gap-4 mb-6 p-4 border rounded-lg bg-gray-50"
          >
            <div>
              <label class="label">Tổ chức</label>
              <input v-model="item.toChuc" class="input" />
            </div>

            <div>
              <label class="label">Vai trò</label>
              <input v-model="item.vaiTro" class="input" />
            </div>

            <div>
              <label class="label">Ngày bắt đầu</label>
              <input type="date" v-model="item.ngayBatDau" class="input" />
            </div>

            <div>
              <label class="label">Ngày kết thúc</label>
              <input type="date" v-model="item.ngayKetThuc" class="input" />
            </div>

            <div class="flex items-center gap-2">
              <input type="checkbox" v-model="item.dangHoatDong" />
              <label>Đang hoạt động</label>
            </div>

            <div class="sm:col-span-2">
              <label class="label">Mô tả</label>
              <textarea v-model="item.moTaHoatDong" class="textarea"></textarea>
            </div>

            <div class="flex justify-end sm:col-span-2">
              <button class="btn-danger" @click.prevent="form.hoatDongs.splice(i, 1)">Xóa</button>
            </div>
          </div>

          <button
            class="btn-add"
            @click.prevent="form.hoatDongs.push({
              id:0, toChuc:'', vaiTro:'', ngayBatDau:'', ngayKetThuc:'',
              dangHoatDong:false, moTaHoatDong:'', thuTu: form.hoatDongs.length + 1
            })"
          >
            ➕ Thêm hoạt động
          </button>
        </section>

        <section>
          <h3 class="section-title">👥 Người tham chiếu</h3>

          <div
            v-for="(item, i) in form.nguoiThamChieus"
            :key="'ref'+i"
            class="grid grid-cols-1 sm:grid-cols-2 gap-4 mb-6 p-4 border rounded-lg bg-gray-50"
          >
            <div>
              <label class="label">Họ và tên</label>
              <input v-model="item.hoVaTen" class="input" />
            </div>

            <div>
              <label class="label">Chức vụ</label>
              <input v-model="item.chucVu" class="input" />
            </div>

            <div>
              <label class="label">Công ty</label>
              <input v-model="item.congTy" class="input" />
            </div>

            <div>
              <label class="label">Điện thoại</label>
              <input v-model="item.dienThoai" class="input" />
            </div>

            <div>
              <label class="label">Email</label>
              <input v-model="item.email" class="input" />
            </div>

            <div class="flex justify-end sm:col-span-2">
              <button class="btn-danger" @click.prevent="form.nguoiThamChieus.splice(i, 1)">Xóa</button>
            </div>
          </div>

          <button
            class="btn-add"
            @click.prevent="form.nguoiThamChieus.push({
              id:0, hoVaTen:'', chucVu:'', congTy:'', dienThoai:'', email:'', thuTu: form.nguoiThamChieus.length + 1
            })"
          >
            ➕ Thêm người tham chiếu
          </button>
        </section>
        </section>
        <!-- ================= NHÀ TUYỂN DỤNG ================= -->
        <section v-if="auth.user?.vaiTro === 'NhaTuyenDung'">
          <h3 class="section-title">👤 Thông tin cá nhân</h3>

          <div class="grid sm:grid-cols-2 gap-6">
            <div>
              <label class="label">Họ và tên</label>
              <input v-model="form.hoTen" class="input" />
            </div>

            <div>
              <label class="label">Email</label>
              <input type="email" v-model="form.email" class="input" />
            </div>

            <div>
              <label class="label">Số điện thoại</label>
              <input v-model="form.sdt" class="input" />
            </div>
          </div>
        </section>
        <!-- 🏢 Thông tin doanh nghiệp -->
        <section v-if="auth.user?.vaiTro === 'DoanhNghiep'">

          <h3 class="text-xl font-semibold text-gray-800 mb-4 border-b pb-2">🏢 Thông tin doanh nghiệp</h3>
          <!-- Doanh nghiệp chỉnh sửa -->
          <div
            v-if="auth.user?.vaiTro === 'DoanhNghiep'"
            class="space-y-8"
          >

            <!-- Thông tin công ty -->
            <div class="grid sm:grid-cols-2 gap-6">

              <div>
                <label class="text-sm text-gray-500">🏢 Tên công ty</label>
                <input
                  v-model="form.tenCongTy"
                  placeholder="Nhập tên công ty"
                  class="w-full px-3 py-2 border rounded-lg focus:ring focus:ring-orange-200"
                />
              </div>

              <!-- Tỉnh thành -->
              <div class="relative">
                <label class="text-sm text-gray-500">🏙️ Tỉnh/Thành phố</label>
                <input
                  v-model="form.tinhThanhPho"
                  @focus="showSuggestions = true"
                  @input="filterTinhThanh"
                  @blur="hideSuggestions"
                  placeholder="Nhập tỉnh/thành phố..."
                  class="w-full px-3 py-2 border rounded-lg focus:ring focus:ring-orange-200"
                />

                <ul
                  v-if="showSuggestions"
                  class="absolute z-10 bg-white border w-full mt-1 max-h-48 overflow-y-auto rounded-lg shadow"
                >
                  <li
                    v-for="(item, index) in filteredTinhThanh"
                    :key="index"
                    @mousedown.prevent="selectTinhThanh(item)"
                    class="px-3 py-2 hover:bg-orange-100 cursor-pointer text-sm"
                  >
                    {{ item }}
                  </li>
                </ul>
              </div>

              <div class="sm:col-span-2">
                <label class="text-sm text-gray-500">📍 Địa chỉ làm việc</label>
                <input
                  v-model="form.diaChiLamViec"
                  placeholder="Nhập địa chỉ làm việc"
                  class="w-full px-3 py-2 border rounded-lg focus:ring focus:ring-orange-200"
                />
              </div>
            </div>

            <!-- Thông tin liên hệ -->
            <div class="grid sm:grid-cols-2 gap-6">
              <div>
                <label class="text-sm text-gray-500">💼 Chức vụ</label>
                <input
                  v-model="form.chucVuNguoiLienHe"
                  placeholder="VD: Trưởng phòng nhân sự"
                  class="w-full px-3 py-2 border rounded-lg focus:ring focus:ring-orange-200"
                />
              </div>

              <div>
                <label class="text-sm text-gray-500">✉️ Email liên hệ</label>
                <input
                  v-model="form.emailLienHe"
                  placeholder="VD: info@company.com"
                  class="w-full px-3 py-2 border rounded-lg focus:ring focus:ring-orange-200"
                />
              </div>

              <div>
                <label class="text-sm text-gray-500">📞 SĐT liên hệ</label>
                <input
                  v-model="form.soDienThoaiLienHe"
                  placeholder="VD: 0901234567"
                  class="w-full px-3 py-2 border rounded-lg focus:ring focus:ring-orange-200"
                />
              </div>

              <!-- 🌐 Website — nằm cùng hàng với SĐT -->
              <div>
                <label class="text-sm text-gray-500">🌐 Website</label>
                <input
                  v-model="form.website"
                  placeholder="VD: https://company.com"
                  class="w-full px-3 py-2 border rounded-lg focus:ring focus:ring-orange-200"
                />
              </div>
            </div>
            <!-- Giới thiệu -->
            <div>
              <label class="text-sm text-gray-500">💬 Giới thiệu công ty</label>
              <textarea
                v-model="form.gioiThieu"
                rows="3"
                placeholder="Giới thiệu ngắn gọn về công ty..."
                class="w-full px-3 py-2 border rounded-lg focus:ring focus:ring-orange-200"
              ></textarea>
            </div>

          </div>
        </section>

        <!-- 🔐 Bảo mật -->
        <section>
          <h3 class="text-xl font-semibold text-gray-800 mb-4 border-b pb-2">🔐 Bảo mật tài khoản</h3>
          <div class="grid sm:grid-cols-2 gap-6">
            <div>
              <label class="text-sm text-gray-500">Mật khẩu cũ</label>
              <input type="password" v-model="form.matKhauCu" class="w-full px-3 py-2 border rounded-lg" />
            </div>
            <div>
              <label class="text-sm text-gray-500">Mật khẩu mới</label>
              <input type="password" v-model="form.matKhauMoi" class="w-full px-3 py-2 border rounded-lg" />
            </div>
          </div>
        </section>

        <!-- Buttons -->
        <div class="flex justify-end gap-3 pt-6 border-t">
          <router-link
            to="/hoso"
            class="px-5 py-2 bg-gray-200 text-gray-800 rounded-lg font-semibold shadow hover:bg-gray-300 transition"
          >
            ❌ Hủy
          </router-link>

          <button
            type="submit"
            class="px-5 py-2 bg-orange-600 text-white rounded-lg font-semibold shadow hover:bg-orange-700 transition"
          >
            💾 Lưu thay đổi
          </button>
        </div>
      </form>

    </div>
  </div>
</template>

<script setup>
import { ref, onMounted } from "vue";
import api from "@/api/axios";
import { useAuthStore } from "@/store/auth";
import { useRouter } from "vue-router";

const auth = useAuthStore();
const router = useRouter();
const baseUrl = "https://localhost:7248";

const showOldPassword = ref(false);
const showNewPassword = ref(false);

const form = ref({
  hoTen: "",
  email: "",
  sdt: "",
  matKhauCu: "",
  matKhauMoi: "",
  tenCongTy: "",
  gioiThieu: "",
  logoUrl: "",
  diaChiLamViec: "",
  tinhThanhId: null,
  website: "",
  emailLienHe: "",
  soDienThoaiLienHe: "",
  nguoiLienHe: "",
  chucVuNguoiLienHe: "",
  daDuocAdminXacMinh: true
});

// Avatar
const avatarFile = ref(null);
const avatarPreviewUrl = ref(null);
function onAvatarFileChange(e) {
  const file = e.target.files[0];
  if (file) {
    avatarFile.value = file;
    avatarPreviewUrl.value = URL.createObjectURL(file);
  }
}
async function uploadAvatar() {
  if (!avatarFile.value) return;
  const formData = new FormData();
  formData.append("File", avatarFile.value);
  try {
    const res = await api.post("/TaiKhoan/upload-avatar", formData, {
      headers: {
        Authorization: `Bearer ${auth.token}`,
        "Content-Type": "multipart/form-data",
      },
    });
    alert("✅ Ảnh đại diện đã được cập nhật!");
    auth.user.avatarUrl = res.data.avatarUrl;
    avatarFile.value = null;
    avatarPreviewUrl.value = null;
  } catch (err) {
    console.error(err);
    alert("❌ Upload avatar thất bại!");
  }
}

// Logo
const logoFile = ref(null);
const logoPreviewUrl = ref(null);
function onLogoFileChange(e) {
  const file = e.target.files[0];
  if (file) {
    logoFile.value = file;
    logoPreviewUrl.value = URL.createObjectURL(file);
  }
}
async function uploadLogo() {
  if (!logoFile.value) return;
  const formData = new FormData();
  formData.append("File", logoFile.value);
  try {
    const res = await api.post("/TaiKhoan/upload-logo", formData, {
      headers: {
        Authorization: `Bearer ${auth.token}`,
        "Content-Type": "multipart/form-data",
      },
    });
    alert("✅ Logo công ty đã được cập nhật!");
    auth.user.thongTinCongTy.logoUrl = res.data.logoUrl;
    logoFile.value = null;
    logoPreviewUrl.value = null;
  } catch (err) {
    console.error(err);
    alert("❌ Upload logo thất bại!");
  }
}

onMounted(async () => {
  try {
    const res = await api.get("/TaiKhoan/thong-tin", {
      headers: { Authorization: `Bearer ${auth.token}` },
    });
    auth.user = res.data;
    localStorage.setItem("user", JSON.stringify(res.data));

    const user = res.data;
    const dn = user.thongTinCongTy;
    
    await loadTinhThanh();

    if (user.vaiTro === "DoanhNghiep" && dn) {
      form.value = {
        id: sv.id,
        gioiTinh: sv.gioiTinh,
        ngaySinh: sv.ngaySinh,
        tinhThanhId: sv.tinhThanhId,
        diaChi: sv.diaChi,

        hoTen: sv.hoTen,
        dienThoai: sv.dienThoai,
        emailLienHe: sv.emailLienHe,
        avatarUrl: sv.avatarUrl,
        lopHoc: sv.lopHoc,
        khoaHoc: sv.khoaHoc,

        mucTieuNgheNghiep: sv.mucTieuNgheNghiep,

        capBacMongMuon: sv.capBacMongMuon,
        luongThoaThuan: sv.luongThoaThuan,
        mucLuongTu: sv.mucLuongTu,
        mucLuongDen: sv.mucLuongDen,
        donViTienTe: sv.donViTienTe,

        hinhThucLamViec: sv.hinhThucLamViec,
        nganhNgheMongMuon: sv.nganhNgheMongMuon,
        noiLamViecMongMuon: sv.noiLamViecMongMuon,

        phucLoiMongMuon: Array.isArray(sv.phucLoiMongMuon) ? sv.phucLoiMongMuon : [],

        thanhTichNoiBat: sv.thanhTichNoiBat,

        kinhNghiems: sv.kinhNghiems || [],
        hocVans: sv.hocVans || [],
        chungChis: sv.chungChis || [],
        ngoaiNgus: sv.ngoaiNgus || [],
        kyNangs: sv.kyNangs || [],
        hoatDongs: sv.hoatDongs || [],
        nguoiThamChieus: sv.nguoiThamChieus || [],

        matKhauCu: "",
        matKhauMoi: ""
      };
    }

    else if (user.vaiTro === "NhaTuyenDung") {
      form.value = {
        hoTen: user.hoTen || "",
        email: user.email || "",
        sdt: user.sdt || "",
        tenCongTy: user.thongTinCongTy?.tenCongTy || "",
        diaChiLamViec: user.thongTinCongTy?.diaChiLamViec || "",
        emailLienHe: user.thongTinCongTy?.emailLienHe || "",
        soDienThoaiLienHe: user.thongTinCongTy?.soDienThoaiLienHe || "",
        matKhauCu: "",
        matKhauMoi: ""
      };
    }

    else if (user.vaiTro === "SinhVien") {

      // Gọi API lấy hồ sơ sinh viên
      const resSV = await api.get("/sinhvien/profile", {
        headers: { Authorization: `Bearer ${auth.token}` }
      });

      const sv = resSV.data;
      form.value = {
        id: sv.id,
        gioiTinh: sv.gioiTinh,
        ngaySinh: sv.ngaySinh,
        tinhThanhId: sv.tinhThanhId,
        diaChi: sv.diaChi,
        hoTen: sv.hoTen,
        dienThoai: sv.dienThoai,
        emailLienHe: sv.emailLienHe,
        avatarUrl: sv.avatarUrl,
        lopHoc: sv.lopHoc,
        khoaHoc: sv.khoaHoc,

        mucTieuNgheNghiep: sv.mucTieuNgheNghiep,
        capBacMongMuon: sv.capBacMongMuon,
        luongThoaThuan: sv.luongThoaThuan,
        mucLuongTu: sv.mucLuongTu,
        mucLuongDen: sv.mucLuongDen,
        donViTienTe: sv.donViTienTe,

        hinhThucLamViec: sv.hinhThucLamViec,
        nganhNgheMongMuon: sv.nganhNgheMongMuon,
        noiLamViecMongMuon: sv.noiLamViecMongMuon,

        phucLoiMongMuon: sv.phucLoiMongMuon || [],
        thanhTichNoiBat: sv.thanhTichNoiBat || "",

        kinhNghiems: sv.kinhNghiems || [],
        hocVans: sv.hocVans || [],
        chungChis: sv.chungChis || [],
        ngoaiNgus: sv.ngoaiNgus || [],
        kyNangs: sv.kyNangs || [],
        hoatDongs: sv.hoatDongs || [],
        nguoiThamChieus: sv.nguoiThamChieus || [],

        matKhauCu: "",
        matKhauMoi: ""
      };
    }
  } catch (err) {
    console.error("❌ Lỗi tải thông tin người dùng:", err);
  }
});

const tinhThanhList = ref([]);
const filteredTinhThanh = ref([]);
const showSuggestions = ref(false);

const loadTinhThanh = async () => {
  try {
    const res = await api.get("/DiaChi/tinh-thanh", {
      headers: { Authorization: `Bearer ${auth.token}` }
    });
    tinhThanhList.value = res.data;
    filteredTinhThanh.value = [...tinhThanhList.value];
  } catch (err) {
    console.error("❌ Lỗi tải tỉnh/thành:", err);
  }
};

const filterTinhThanh = () => {
  const keyword = form.value.tinhThanhPho.toLowerCase().trim();
  filteredTinhThanh.value = tinhThanhList.value.filter(t =>
    t.toLowerCase().includes(keyword)
  );
};

const selectTinhThanh = (name) => {
  form.value.tinhThanhPho = name;
  showSuggestions.value = false;
};

const hideSuggestions = () => {
  setTimeout(() => (showSuggestions.value = false), 120);
};

async function updateProfile() {
  try {
    let endpoint = "";

    switch (auth.user?.vaiTro) {
      case "DoanhNghiep":
        endpoint = "/TaiKhoan/cap-nhat-doanh-nghiep";
        break;
      case "NhaTuyenDung":
        endpoint = "/TaiKhoan/cap-nhat-nhatuyendung";
        break;
      case "SinhVien":
        endpoint = "/sinhvien/profile";
        break;
      default:
        alert("❌ Vai trò không hợp lệ!");
        return;
    }

    await api.put(endpoint, form.value, {
      headers: { Authorization: `Bearer ${auth.token}` },
    });

    alert("✅ Cập nhật thông tin thành công!");
    router.push("/hoso");
  } catch (err) {
    console.error("❌ Lỗi cập nhật hồ sơ:", err);
    alert("❌ Cập nhật thất bại!");
  }
}

function getAvatarUrl(path) {
  if (!path) return "/default-avatar.png";
  return path.startsWith("http") ? path : `${baseUrl}${path}`;
}
</script>


<style scoped>
.section-title {
  @apply text-xl font-semibold text-gray-800 mb-4 border-b pb-2;
}
.label {
  @apply text-sm text-gray-600 mb-1 block;
}
.input {
  @apply w-full px-3 py-2 border rounded-lg focus:ring focus:ring-orange-200;
}
.textarea {
  @apply w-full px-3 py-2 border rounded-lg h-28 focus:ring focus:ring-orange-200;
}
.btn-add {
  @apply mt-2 px-4 py-1.5 bg-orange-600 text-white rounded-lg hover:bg-orange-700 text-sm shadow;
}
.btn-danger {
  @apply px-3 py-1 bg-red-500 text-white rounded-lg text-sm hover:bg-red-600;
}
</style>
