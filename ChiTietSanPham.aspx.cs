using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace banquat
{
    public partial class ChiTietSanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            if (id == null)
            {
                noiDungChiTiet.InnerHtml = "Không có mã sản phẩm.";
                return;
            }
            int idreal = int.Parse(id);

            List<SanPham> dsSP = (List<SanPham>)Application["DSSanPham"];

            SanPham sptimthay = null;

            foreach (SanPham sp in dsSP)
            {
                if (sp.MaSP == idreal)
                {
                    sptimthay = sp;
                    break;
                }
            }

            if (sptimthay == null)
            {
                noiDungChiTiet.InnerHtml = "Không tìm thấy sản phẩm.";
            }
            else
            {
                noiDungChiTiet.InnerHtml =
                    "<h2>" + sptimthay.TenSP + "</h2>" +
                    "<img src='" + sptimthay.HinhAnh + "' width='250' />" +
                    "<p>Hãng: " + sptimthay.Hang + "</p>" +
                    "<p>Loại: " + sptimthay.Loai + "</p>" +
                    "<p>Giá: " + sptimthay.Gia + " đ</p>" +
                    "<p>Mô tả: " + sptimthay.MoTa + "</p>" +
                    "<a href='GioHang.aspx?id=" + sptimthay.MaSP + "'>Thêm vào giỏ hàng</a>";
            }
        }
    }
}