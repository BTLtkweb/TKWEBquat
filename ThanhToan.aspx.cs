using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace banquat
{
    public partial class ThanhToan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                XuLyThanhToan();
            }
            else
            {
                HienThiDonHang();
            }
        }
        void HienThiDonHang()
        {
            List<int> gioHang = (List<int>)Session["GioHang"];
            List<SanPham> dsSP = (List<SanPham>)Application["DSSanPham"];

            string html = "";
            int tongTien = 0;
            int stt = 1;
            html += "<table border='1' cellpadding='10'>";
            html += "<tr>";
            html += "<th>STT</th>";
            html += "<th>Hình ảnh</th>";
            html += "<th>Tên sản phẩm</th>";
            html += "<th>Giá</th>";
            html += "</tr>";

            foreach (int maSP in gioHang)
            {
                SanPham spTimThay = null;

                foreach (SanPham sp in dsSP)
                {
                    if (sp.MaSP == maSP)
                    {
                        spTimThay = sp;
                        break;
                    }
                }

                if (spTimThay != null)
                {
                    html += "<tr>";
                    html += "<td>" + stt + "</td>";
                    html += "<td><img src='" + spTimThay.HinhAnh + "' width='100' /></td>";
                    html += "<td>" + spTimThay.TenSP + "</td>";
                    html += "<td>" + spTimThay.Gia + " đ</td>";
                    html += "</tr>";

                    tongTien += spTimThay.Gia;
                    stt++;
                }
            }

            html += "</table>";
            html += "<h3>Tổng tiền: " + tongTien + " đ</h3>";

            noiDungDonHang.InnerHtml = html;
        }
        void XuLyThanhToan()
        {
            string tenKhachHang = Request.Form["tenKhachHang"];
            string soDienThoai = Request.Form["soDienThoai"];
            string diaChi = Request.Form["diaChi"];

            if (tenKhachHang == "" || soDienThoai == "" || diaChi == "")
            {
                lblThongBao.InnerText = "Vui lòng nhập đầy đủ thông tin nhận hàng.";
                HienThiDonHang();
                return;
            }

            List<int> gioHang = (List<int>)Session["GioHang"];
            List<SanPham> dsSP = (List<SanPham>)Application["DSSanPham"];

            int tongTien = 0;

            foreach (int maSP in gioHang)
            {
                foreach (SanPham sp in dsSP)
                {
                    if (sp.MaSP == maSP)
                    {
                        tongTien += sp.Gia;
                        break;
                    }
                }
            }

            if (Application["DSDonHang"] == null)
            {
                Application["DSDonHang"] = new List<DonHang>();
            }

            List<DonHang> dsDonHang = (List<DonHang>)Application["DSDonHang"];

            DonHang dh = new DonHang();

            dh.MaDonHang = dsDonHang.Count + 1;
            dh.TenKhachHang = tenKhachHang;
            dh.SoDienThoai = soDienThoai;
            dh.DiaChi = diaChi;
            dh.NgayDat = DateTime.Now;
            dh.TongTien = tongTien;
            dh.DanhSachMaSP = gioHang;

            dsDonHang.Add(dh);

            Application["DSDonHang"] = dsDonHang;

            Session.Remove("GioHang");

            Response.Write("<script>alert('Đặt hàng thành công.'); window.location='TrangChu.aspx';</script>");
        }
    }
}