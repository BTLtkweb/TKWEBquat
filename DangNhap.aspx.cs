using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace banquat
{
    public partial class DangNhap : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string tenDangNhap = Request.Form["tenDangNhap"];
                string matKhau = Request.Form["matKhau"];

                if (tenDangNhap == "" || matKhau == "")
                {
                    lblThongBao.InnerText = "Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.";
                    return;
                }

                List<ThanhVien> ds = (List<ThanhVien>)Application["DSThanhVien"];

                ThanhVien tv = null;

                foreach (ThanhVien x in ds)
                {
                    if (x.TenDangNhap == tenDangNhap && x.MatKhau == matKhau)
                    {
                        tv = x;
                        break;
                    }
                }

                if (tv != null)
                {
                    Session["ThanhVien"] = tv;
                    Session["TenDangNhap"] = tv.TenDangNhap;

                    Response.Redirect("TrangChu.aspx");
                }
                else
                {
                    lblThongBao.InnerText = "Tên đăng nhập hoặc mật khẩu không đúng.";
                }
            }
        }
    }
}