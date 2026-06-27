using System;
using System.Collections.Generic;
using System.Linq;

namespace BTL
{
    public partial class BaoCaoThongKe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var dsSP = (List<SanPham>)Application["DSSanPham"];
                var dsDH = (List<DonHang>)Application["DanhSachDonHang"];

                if (dsDH != null && dsDH.Count > 0)
                {
                    // Tổng số đơn hàng
                    lblTongDon.Text = dsDH.Count.ToString();

                    // Tìm sản phẩm bán chạy nhất bằng cách đếm tần suất xuất hiện mã SP trong đơn hàng
                    var banChayNhat = dsDH
                        .SelectMany(dh => dh.DanhSachMaSP)
                        .GroupBy(ma => ma)
                        .OrderByDescending(g => g.Count())
                        .FirstOrDefault();

                    if (banChayNhat != null)
                    {
                        int maSP = banChayNhat.Key;
                        int soLuong = banChayNhat.Count();
                        var sp = dsSP.FirstOrDefault(s => s.MaSP == maSP);

                        lblBanChayNhat.Text = sp != null ?
                            $"{sp.TenSP} (Đã bán: {soLuong} đơn)" : "Sản phẩm không xác định";
                    }
                    else
                    {
                        lblBanChayNhat.Text = "Chưa có dữ liệu bán hàng.";
                    }
                }
                else
                {
                    lblTongDon.Text = "0";
                    lblBanChayNhat.Text = "Chưa có đơn hàng nào.";
                }
            }
        }
    }
}