using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace banquat
{
    public class ThanhVien
    {
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string Ten { get; set; }
        public string SoDienThoai { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string Email { get; set; }
        public string VaiTro { get; set; }
    }
    public class SanPham
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public string Hang { get; set; }
        public string Loai { get; set; }
        public int Gia { get; set; }
        public string MoTa { get; set; }
        public string HinhAnh { get; set; }
    }
    public class DonHang
    {
        public int MaDonHang { get; set; }
        public string TenKhachHang { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgayDat { get; set; }
        public int TongTien { get; set; }
        public List<int> DanhSachMaSP { get; set; }
    }
}