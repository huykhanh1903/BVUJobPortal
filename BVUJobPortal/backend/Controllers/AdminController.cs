using BVUJobPortal.Data;
using BVUJobPortal.DTOs;
using BVUJobPortal.DTOs.Admin;
using BVUJobPortal.Models;
using BVUJobPortal.Services.Admin;
using BVUJobPortal.Services.BaoCao;
using BVUJobPortal.Services.System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace BVUJobPortal.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin, SuperAdmin")]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminService;
        private readonly IBaoCaoService _baoCaoService;
        private readonly SystemConfigService _configService;
        private readonly ApplicationDbContext _context;

        public AdminController(IAdminService adminService, IBaoCaoService baoCaoService, SystemConfigService configService, ApplicationDbContext context)
        {
            _adminService = adminService;
            _baoCaoService = baoCaoService;
            _configService = configService;
            _context = context;
        }

        [HttpPost("tao-admin")]
        [Authorize(Roles = "SuperAdmin")] 
        public async Task<IActionResult> TaoAdmin(AdminCapNhatNguoiDungDto dto)
        {
            var user = await _adminService.TaoNguoiDungTheoVaiTroAsync(dto, "Admin");
            if (user == null) return BadRequest(new { ThongBao = "Email đã tồn tại" });
            return Ok(user);
        }

        [HttpPost("tao-superadmin")]
        [Authorize(Roles = "SuperAdmin")] 
        public async Task<IActionResult> TaoSuperAdmin(AdminCapNhatNguoiDungDto dto)
        {
            var user = await _adminService.TaoNguoiDungTheoVaiTroAsync(dto, "SuperAdmin");
            if (user == null) return BadRequest(new { ThongBao = "Email đã tồn tại" });
            return Ok(user);
        }

        [HttpPost("tao-sinhvien")]
        public async Task<IActionResult> TaoSinhVien(AdminCapNhatNguoiDungDto dto)
        {
            var user = await _adminService.TaoNguoiDungTheoVaiTroAsync(dto, "SinhVien");
            if (user == null) return BadRequest(new { ThongBao = "Email đã tồn tại" });
            return Ok(user);
        }

        [HttpPost("tao-nhatuyendung")]
        public async Task<IActionResult> TaoNhaTuyenDung(AdminNhaTuyenDungDto dto)
        {
            var user = await _adminService.TaoNhaTuyenDungAsync(dto);
            if (user == null) return BadRequest(new { ThongBao = "Email đã tồn tại" });
            return Ok(user);
        }

        [HttpPost("tao-congty")]
        public async Task<IActionResult> TaoCongTy([FromBody] AdminCongTyDto dto)
        {
            var congTy = await _adminService.TaoCongTyAsync(dto);
            return Ok(congTy);
        }

        [HttpPost("tao-tai-khoan-cong-ty")]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<IActionResult> TaoTaiKhoanCongTy([FromBody] AdminTaoTaiKhoanCongTyDto dto)
        {
            try
            {
                var result = await _adminService.TaoTaiKhoanCongTyAsync(dto);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new { ThongBao = ex.Message });
            }
        }

        [HttpGet("nguoi-dung")]
        public async Task<IActionResult> DanhSachNguoiDung(
            [FromQuery] int trang = 1,
            [FromQuery] int soLuongMoiTrang = 10,
            [FromQuery] string sapXepTheo = "NgayTao",
            [FromQuery] string thuTu = "desc",
            [FromQuery] string? vaiTro = null,
            [FromQuery] DateTime? tuNgay = null,
            [FromQuery] DateTime? denNgay = null,
            [FromQuery] bool? biKhoa = null)
        {
            var ketQua = await _adminService.DanhSachNguoiDungAsync(trang, soLuongMoiTrang, sapXepTheo, thuTu, vaiTro, tuNgay, denNgay, biKhoa);
            return Ok(ketQua);
        }

        [HttpGet("nguoi-dung/tim-kiem")]
        public async Task<IActionResult> TimKiemNguoiDung(
            [FromQuery] string tuKhoa,
            [FromQuery] int trang = 1,
            [FromQuery] int soLuongMoiTrang = 10)
        {
            var ketQua = await _adminService.TimKiemNguoiDungAsync(tuKhoa, trang, soLuongMoiTrang);
            return Ok(ketQua);
        }

        [HttpGet("nguoi-dung/{id}")]
        public async Task<IActionResult> ChiTietNguoiDung(int id)
        {
            var user = await _adminService
                .LayThongTinNguoiDungTheoIdAsync(id); 

            if (user == null)
                return NotFound(new { ThongBao = "Không tìm thấy người dùng" });

            return Ok(user);
        }


        [HttpPut("nguoi-dung/{id}")]
        public async Task<IActionResult> CapNhatNguoiDung(int id, [FromBody] AdminCapNhatNguoiDungDto dto)
        {
            var user = await _adminService.CapNhatNguoiDungAsync(id, dto);
            if (user == null) return NotFound(new { ThongBao = "Không tìm thấy người dùng" });
            return Ok(user);
        }


        // Khoa tk
        [HttpPut("nguoi-dung/{id}/khoa")]
        public async Task<IActionResult> KhoaNguoiDung(int id, [FromBody] KhoaTaiKhoanDto dto)
        {
            var ok = await _adminService.KhoaNguoiDungAsync(id, dto.LyDo);
            if (!ok) return NotFound(new { ThongBao = "Không tìm thấy người dùng" });

            return Ok(new { ThongBao = "Đã khóa tài khoản", LyDo = dto.LyDo });
        }


        // Mo khoa tk
        [HttpPut("nguoi-dung/{id}/mo-khoa")]
        public async Task<IActionResult> MoKhoaNguoiDung(int id)
        {
            var ok = await _adminService.MoKhoaNguoiDungAsync(id);
            if (!ok) return NotFound(new { ThongBao = "Không tìm thấy người dùng" });

            return Ok(new { ThongBao = "Đã mở khóa tài khoản" });
        }

        [HttpDelete("nguoi-dung/{id}")]
        public async Task<IActionResult> XoaNguoiDung(int id)
        {
            var ok = await _adminService.XoaNguoiDungAsync(id);
            if (!ok)
                return NotFound(new { ThongBao = "Không tìm thấy người dùng" });

            return Ok(new { ThongBao = "Đã xóa tài khoản vĩnh viễn" });
        }

        [AllowAnonymous]
        [HttpGet("cong-ty")]
        public async Task<IActionResult> DanhSachCongTy()
        {
            var ds = await _adminService.DanhSachCongTyAsync();
            return Ok(ds);
        }

        [AllowAnonymous]
        [HttpGet("cong-ty/{id}")]
        public async Task<IActionResult> LayChiTietCongTy(int id)
        {
            var data = await _adminService.LayChiTietCongTyAsync(id);
            if (data == null) return NotFound();
            return Ok(data);
        }


        [HttpPut("cong-ty/{id}")]
        public async Task<IActionResult> CapNhatCongTy(int id, [FromBody] AdminCongTyDto dto)
        {
            var congTy = await _adminService.CapNhatCongTyAsync(id, dto);
            if (congTy == null) return NotFound(new { ThongBao = "Không tìm thấy công ty" });
            return Ok(congTy);
        }

        [HttpDelete("cong-ty/{id}")]
        public async Task<IActionResult> XoaCongTy(int id)
        {
            var ok = await _adminService.XoaCongTyAsync(id);
            if (!ok)
                return NotFound(new { ThongBao = "Không tìm thấy công ty" });

            return Ok(new { ThongBao = "✅ Đã xóa công ty thành công." });
        }

        [AllowAnonymous]
        [HttpGet("cong-viec")]
        public async Task<IActionResult> DanhSachCongViec()
        {
            var ds = await _adminService.DanhSachCongViecAsync();
            return Ok(ds);
        }
        [AllowAnonymous]
        [HttpGet("cong-ty/{congTyId}/cong-viec")]
        public async Task<IActionResult> LayCongViecTheoCongTy(int congTyId)
        {
            var result = await _adminService.LayCongViecTheoCongTyAsync(congTyId);
            return Ok(result);
        }

        [HttpPut("cong-viec/{id}/duyet")]
        public async Task<IActionResult> DuyetCongViec(int id)
        {
            try
            {
                var adminId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
                var ok = await _adminService.DuyetCongViecAsync(id, adminId);
                if (!ok)
                    return NotFound(new { ThongBao = "Không tìm thấy công việc hoặc đã được duyệt" });

                return Ok(new { ThongBao = "Công việc đã được duyệt thành công" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ThongBao = "Lỗi khi duyệt công việc", ChiTiet = ex.Message });
            }
        }

        [HttpPut("cong-viec/{id}/huy-duyet")]
        public async Task<IActionResult> HuyDuyetCongViec(int id)
        {
            try
            {
                var ok = await _adminService.HuyDuyetCongViecAsync(id);
                if (!ok)
                    return NotFound(new { ThongBao = "Không tìm thấy công việc hoặc chưa được duyệt" });

                return Ok(new { ThongBao = "Đã huỷ duyệt công việc — nhà tuyển dụng có thể chỉnh sửa lại" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ThongBao = "Lỗi khi huỷ duyệt công việc", ChiTiet = ex.Message });
            }
        }

        [HttpPut("cong-viec/{id}")]
        public async Task<IActionResult> CapNhatCongViec(int id, [FromBody] AdminCapNhatCongViecDto dto)
        {
            var job = await _adminService.CapNhatCongViecAsync(id, dto);
            if (job == null) return NotFound(new { ThongBao = "Không tìm thấy công việc" });
            return Ok(job);
        }

        [HttpDelete("cong-viec/{id}")]
        public async Task<IActionResult> XoaCongViec(int id)
        {
            var ok = await _adminService.XoaCongViecAsync(id);
            if (!ok) return NotFound(new { ThongBao = "Không tìm thấy công việc" });
            return Ok(new { ThongBao = "Đã xoá công việc" });
        }

        [AllowAnonymous]
        [HttpGet("linh-vuc")]
        public async Task<IActionResult> DanhSachLinhVuc()
        {
            var ds = await _adminService.DanhSachLinhVucAsync();
            return Ok(ds);
        }

        [AllowAnonymous]
        [HttpGet("linh-vuc/{id}/nghe-nghiep")]
        public async Task<IActionResult> LayNgheTheoLinhVuc(int id)
        {
            var data = await _adminService.LayNgheTheoLinhVucAsync(id);
            return Ok(data);
        }

        [HttpPost("linh-vuc")]
        public async Task<IActionResult> TaoLinhVuc([FromBody] AdminLinhVucDto dto)
        {
            var lv = await _adminService.TaoLinhVucAsync(dto);
            return Ok(lv);
        }

        [HttpPut("linh-vuc/{id}")]
        public async Task<IActionResult> CapNhatLinhVuc(int id, [FromBody] AdminLinhVucDto dto)
        {
            var lv = await _adminService.CapNhatLinhVucAsync(id, dto);
            if (lv == null) return NotFound(new { ThongBao = "Không tìm thấy lĩnh vực" });
            return Ok(lv);
        }

        [HttpDelete("linh-vuc/{id}")]
        public async Task<IActionResult> XoaLinhVuc(int id)
        {
            var ok = await _adminService.XoaLinhVucAsync(id);
            if (!ok) return NotFound(new { ThongBao = "Không tìm thấy lĩnh vực" });
            return Ok(new { ThongBao = "Xóa lĩnh vực thành công" });
        }

        [HttpGet("bao-cao")]
        public async Task<IActionResult> DanhSachBaoCao()
        {
            var ds = await _baoCaoService.DanhSachBaoCaoAsync();
            return Ok(ds);
        }

        [HttpPut("bao-cao/{id}/xu-ly")]
        public async Task<IActionResult> XuLyBaoCao(int id, [FromBody] AdminXuLyBaoCaoDto dto)
        {
            var bc = await _baoCaoService.XuLyBaoCaoAsync(id, dto.TrangThai);
            if (bc == null) return NotFound(new { ThongBao = "Không tìm thấy báo cáo" });
            return Ok(bc);
        }

        [HttpPost("thong-bao")]
        public async Task<IActionResult> TaoThongBao([FromBody] AdminGuiThongBaoDto dto)
        {
            var adminId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var tb = await _adminService.TaoThongBaoAsync(dto, adminId);
            return Ok(tb);
        }

        [HttpGet("thong-bao")]
        public async Task<IActionResult> DanhSachThongBao()
        {
            var ds = await _adminService.DanhSachThongBaoAsync();
            return Ok(ds);
        }


        [HttpGet("thong-ke")]
        public async Task<IActionResult> ThongKe()
        {
            var result = await _adminService.ThongKeHeThongAsync();
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet("nghe-nghiep")]
        public async Task<IActionResult> DanhSachNgheNghiep()
        {
            var ds = await _adminService.DanhSachNgheNghiepAsync();
            return Ok(ds);
        }

        [AllowAnonymous]
        [HttpGet("nghe-nghiep/{id}/chuyen-nganh")]
        public async Task<IActionResult> LayChuyenNganhTheoNghe(int id)
        {
            var data = await _adminService.LayChuyenNganhTheoNgheAsync(id);
            return Ok(data);
        }

        [HttpPost("nghe-nghiep")]
        public async Task<IActionResult> TaoNgheNghiep([FromBody] AdminNgheNghiepDto dto)
        {
            var result = await _adminService.TaoNgheNghiepAsync(dto);
            return Ok(result);
        }

        [HttpPut("nghe-nghiep/{id}")]
        public async Task<IActionResult> CapNhatNgheNghiep(int id, [FromBody] AdminNgheNghiepDto dto)
        {
            var result = await _adminService.CapNhatNgheNghiepAsync(id, dto);
            if (result == null)
                return NotFound(new { ThongBao = "Không tìm thấy nghề nghiệp" });

            return Ok(result);
        }

        [HttpDelete("nghe-nghiep/{id}")]
        public async Task<IActionResult> XoaNgheNghiep(int id)
        {
            var ok = await _adminService.XoaNgheNghiepAsync(id);
            if (!ok)
                return NotFound(new { ThongBao = "Không tìm thấy nghề nghiệp" });

            return Ok(new { ThongBao = "Đã xóa nghề nghiệp thành công" });
        }


        [AllowAnonymous]
        [HttpGet("chuyen-nganh")]
        public async Task<IActionResult> DanhSachChuyenNganh()
        {
            var data = await _adminService.DanhSachChuyenNganhAsync();
            return Ok(data);
        }

        [HttpPost("chuyen-nganh")]
        public async Task<IActionResult> TaoChuyenNganh([FromBody] AdminChuyenNganhDto dto)
        {
            var result = await _adminService.TaoChuyenNganhAsync(dto);
            return Ok(result);
        }

        [HttpPut("chuyen-nganh/{id}")]
        public async Task<IActionResult> CapNhatChuyenNganh(int id, [FromBody] AdminChuyenNganhDto dto)
        {
            var result = await _adminService.CapNhatChuyenNganhAsync(id, dto);
            if (result == null)
                return NotFound(new { ThongBao = "Không tìm thấy chuyên ngành" });

            return Ok(result);
        }

        [HttpDelete("chuyen-nganh/{id}")]
        public async Task<IActionResult> XoaChuyenNganh(int id)
        {
            var ok = await _adminService.XoaChuyenNganhAsync(id);
            if (!ok)
                return NotFound(new { ThongBao = "Không tìm thấy chuyên ngành" });

            return Ok(new { ThongBao = "Đã xóa chuyên ngành thành công" });
        }
        [AllowAnonymous]
        [HttpGet("muc-kinh-nghiem")]
        public async Task<IActionResult> DanhSach()
        {
            return Ok(await _adminService.LayDanhSachMucKinhNghiemAsync());
        }

        [HttpPost("muc-kinh-nghiem")]
        public async Task<IActionResult> Tao(AdminMucKinhNghiemDto dto)
        {
            var result = await _adminService.TaoMucKinhNghiemAsync(dto);
            return Ok(new { thongBao = "Thêm thành công", mucKinhNghiem = result });
        }

        [HttpPut("muc-kinh-nghiem/{id}")]
        public async Task<IActionResult> CapNhat(int id, AdminMucKinhNghiemDto dto)
        {
            var result = await _adminService.CapNhatMucKinhNghiemAsync(id, dto);
            return Ok(new { thongBao = "Cập nhật thành công", mucKinhNghiem = result });
        }

        [HttpDelete("muc-kinh-nghiem/{id}")]
        public async Task<IActionResult> Xoa(int id)
        {
            var ok = await _adminService.XoaMucKinhNghiemAsync(id);
            if (!ok) return NotFound();

            return Ok(new { thongBao = "Xóa thành công" });
        }

        [HttpGet("loai-cong-viec")]
        [AllowAnonymous]
        public async Task<IActionResult> GetLoaiCongViec()
        {
            var data = await _adminService.LayDanhSachLoaiCongViecAsync();
            return Ok(data);
        }

        [HttpPost("loai-cong-viec")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> TaoLoaiCongViec(AdminLoaiCongViecDto dto)
        {
            var result = await _adminService.TaoLoaiCongViecAsync(dto);
            return Ok(result);
        }

        [HttpPut("loai-cong-viec/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CapNhatLoaiCongViec(int id, AdminLoaiCongViecDto dto)
        {
            var result = await _adminService.CapNhatLoaiCongViecAsync(id, dto);
            return result == null ? NotFound() : Ok(result);
        }

        [HttpDelete("loai-cong-viec/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> XoaLoaiCongViec(int id)
        {
            var result = await _adminService.XoaLoaiCongViecAsync(id);
            return result ? Ok(new { message = "Đã xóa" }) : NotFound();
        }

        [HttpGet("cap-bac")]
        [AllowAnonymous]
        public async Task<IActionResult> GetCapBac()
        {
            var data = await _adminService.LayDanhSachCapBacAsync();
            return Ok(data);
        }

        [HttpPost("cap-bac")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> TaoCapBac(AdminCapBacDto dto)
        {
            var result = await _adminService.TaoCapBacAsync(dto);
            return Ok(result);
        }

        [HttpPut("cap-bac/{id}")]
        public async Task<IActionResult> CapNhatCapBac(int id, AdminCapBacDto dto)
        {
            var result = await _adminService.CapNhatCapBacAsync(id, dto);
            return result == null ? NotFound() : Ok(result);
        }

        [HttpDelete("cap-bac/{id}")]
        public async Task<IActionResult> XoaCapBac(int id)
        {
            var result = await _adminService.XoaCapBacAsync(id);
            return result ? Ok(new { message = "Đã xóa" }) : NotFound();
        }

        [HttpPut("toggle-ai")]
        public async Task<IActionResult> ToggleAI(bool enable)
        {
            await _configService.SetAiStateAsync(enable);

            return Ok(new
            {
                thanhCong = true,
                trangThai = enable ? "AI đã bật" : "AI đã tắt"
            });
        }

        [HttpGet("messages")]
        public async Task<IActionResult> GetMessages()
        {
            var msgs = await _context.ChatMessages
                .OrderBy(x => x.Timestamp)
                .ToListAsync();

            return Ok(msgs);
        }

        [HttpPost("reply")]
        public async Task<IActionResult> Reply([FromBody] ReplyDto dto)
        {
            var adminId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            _context.ChatMessages.Add(new AppChatMessage
            {
                SenderId = adminId,
                ReceiverId = dto.UserId,
                Message = dto.Message,
                IsFromAI = false,
                Timestamp = DateTime.UtcNow
            });

            await _context.SaveChangesAsync();

            return Ok(new { message = "Đã gửi trả lời cho người dùng." });
        }
    }
}
