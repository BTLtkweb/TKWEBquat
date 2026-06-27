using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL
{
    public partial class ChiTietSanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            int idreal;

            if (string.IsNullOrEmpty(id) || !int.TryParse(id, out idreal))
            {
                noiDungChiTiet.InnerHtml = "Mã sản phẩm không hợp lệ.";
                return;
            }

            List<SanPham> dsSP = (List<SanPham>)Application["DSSanPham"];
            if (dsSP == null)
            {
                noiDungChiTiet.InnerHtml = "Lỗi hệ thống dữ liệu.";
                return;
            }

            SanPham sptimthay = dsSP.FirstOrDefault(x => x.MaSP == idreal);

            if (sptimthay == null)
            {
                noiDungChiTiet.InnerHtml = "Không tìm thấy sản phẩm này.";
            }
            else
            {
                noiDungChiTiet.InnerHtml = string.Format(
                    "<h2>{0}</h2>" +
                    "<img src='{1}' width='250' />" +
                    "<p>Hãng: {2}</p>" +
                    "<p>Loại: {3}</p>" +
                    "<p>Giá: {4:N0} đ</p>" +
                    "<p>Mô tả: {5}</p>" +
                    "<a href='GioHang.aspx?id={6}'>Thêm vào giỏ hàng</a>",
                    sptimthay.TenSP, sptimthay.HinhAnh, sptimthay.Hang, sptimthay.Loai, sptimthay.Gia, sptimthay.MoTa, sptimthay.MaSP
                );
            }
        }
    }
}