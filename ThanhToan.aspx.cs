using System;
using System.Collections.Generic;
using System.Linq;

namespace BTL
{
    public partial class ThanhToan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Kiểm tra giỏ hàng
                List<int> gioHang = Session["GioHang"] as List<int>;
                if (gioHang == null || gioHang.Count == 0)
                {
                    lblThongBao.InnerText = "Giỏ hàng của bạn đang trống!";
                    btnDatHang.Enabled = false;
                }
            }
        }

        protected void btnDatHang_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ Session và Application
            List<int> gioHang = Session["GioHang"] as List<int>;
            var dsSP = (List<SanPham>)Application["DSSanPham"];
            List<DonHang> dsDH = Application["DanhSachDonHang"] as List<DonHang> ?? new List<DonHang>();

            if (gioHang == null || dsSP == null) return;

            // 1. Tính tổng tiền
            int tongTien = 0;
            foreach (int ma in gioHang)
            {
                var sp = dsSP.FirstOrDefault(s => s.MaSP == ma);
                if (sp != null) tongTien += sp.Gia;
            }

            // 2. Giảm giá theo gói thành viên
            ThanhVien user = (ThanhVien)Session["User"];
            if (user != null)
            {
                if (user.LoaiThanhVien == "Vàng") tongTien = (int)(tongTien * 0.9);
                else if (user.LoaiThanhVien == "Bạc") tongTien = (int)(tongTien * 0.95);
            }

            // 3. Tạo đơn hàng
            DonHang dhMoi = new DonHang
            {
                MaDonHang = dsDH.Count + 1,
                TenKhachHang = txtTen.Text,
                SoDienThoai = txtSDT.Text,
                DiaChi = txtDiaChi.Text,
                NgayDat = DateTime.Now,
                TongTien = tongTien,
                DanhSachMaSP = gioHang
            };
            dsDH.Add(dhMoi);
            Application["DanhSachDonHang"] = dsDH;

            // 5. Kết thúc
            Session["GioHang"] = null;
            lblThongBao.InnerText = "Đặt hàng thành công! Tổng tiền sau giảm giá: " + tongTien.ToString("N0") + " VNĐ";
            btnDatHang.Enabled = false;
        }
    }
}