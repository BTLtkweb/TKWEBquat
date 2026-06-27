using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL
{
    public partial class ThanhVien1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ThanhVien"] == null)
            {
                Response.Redirect("Dangnhap.aspx?ReturnUrl=ThanhVien.aspx");
            }
        }

        protected void btnDangKy_Click(object sender, EventArgs e)
        {
            ThanhVien currentUser = (ThanhVien)Session["ThanhVien"];

            // 1. Kiểm tra session đăng nhập
            if (currentUser == null)
            {
                Response.Redirect("Dangnhap.aspx?ReturnUrl=ThanhVien.aspx");
                return;
            }

            // 2. Kiểm tra an toàn cho Application
            if (Application["DSThanhVien"] == null)
            {
                lblThongBao.Text = "Lỗi hệ thống: Không tìm thấy dữ liệu thành viên.";
                return;
            }

            List<ThanhVien> ds = (List<ThanhVien>)Application["DSThanhVien"];

            var tv = ds.FirstOrDefault(u => u.TenDangNhap == currentUser.TenDangNhap);

            if (tv != null)
            {
                tv.LoaiThanhVien = ddlGoi.SelectedValue;
                Application["DSThanhVien"] = ds;
                Session["ThanhVien"] = tv;

                lblThongBao.Text = "Chúc mừng! Bạn đã đăng ký thành công gói: " + tv.LoaiThanhVien;
            }
        }

    }
}
