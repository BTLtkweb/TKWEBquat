using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL
{
    public partial class GioHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                XoaSanPhamKhoiGio();
                ThemSanPhamVaoGio();
                HienThiGioHang();
            }
            void ThemSanPhamVaoGio()
            {
                string id = Request.QueryString["id"];

                if (id != null)
                {
                    int idReal = int.Parse(id);
                    List<int> gioHang;

                    if (Session["GioHang"] == null)
                    {
                        gioHang = new List<int>();
                    }
                    else
                    {
                        gioHang = (List<int>)Session["GioHang"];
                    }
                    gioHang.Add(idReal);
                    Session["GioHang"] = gioHang;
                }
            }

            void HienThiGioHang()
            {
                if (Session["GioHang"] == null)
                {
                    noiDungGioHang.InnerHtml = "<p>Giỏ hàng đang trống.</p>";
                    return;
                }

                List<int> gioHang = (List<int>)Session["GioHang"];
                List<SanPham> dsSP = (List<SanPham>)Application["DSSanPham"];

                string html = "";
                int tongTien = 0;

                html += "<table border='1' cellpadding='10'>";
                html += "<tr>";
                html += "<th>STT</th>";
                html += "<th>Hình ảnh</th>";
                html += "<th>Tên sản phẩm</th>";
                html += "<th>Hãng</th>";
                html += "<th>Giá</th>";
                html += "<th>Thao tác</th>";
                html += "</tr>";

                int stt = 1;

                for (int i = 0; i < gioHang.Count; i++)
                {
                    int maSP = gioHang[i];
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
                        html += "<td>" + spTimThay.Hang + "</td>";
                        html += "<td>" + spTimThay.Gia + " đ</td>";
                        html += "<td><a href='GioHang.aspx?xoa=" + i + "'>Xóa</a></td>";
                        html += "</tr>";
                        tongTien += spTimThay.Gia;
                        stt++;
                    }
                }

                html += "</table>";

                html += "<h3>Tổng tiền: " + tongTien + " đ</h3>";

                html += "<a href='ThanhToan.aspx'>Tiến hành thanh toán</a>";

                noiDungGioHang.InnerHtml = html;
            }
            void XoaSanPhamKhoiGio()
            {
                string xoaText = Request.QueryString["xoa"];

                if (xoaText != null && Session["GioHang"] != null)
                {
                    int viTri = int.Parse(xoaText);

                    List<int> gioHang = (List<int>)Session["GioHang"];

                    if (viTri >= 0 && viTri < gioHang.Count)
                    {
                        gioHang.RemoveAt(viTri);
                        Session["GioHang"] = gioHang;
                    }
                    if (gioHang.Count == 0)
                    {
                        Session.Remove("GioHang");
                    }
                    else
                    {
                        Session["GioHang"] = gioHang;
                    }
                    Response.Redirect("GioHang.aspx");
                }
            }
        }
    }
}