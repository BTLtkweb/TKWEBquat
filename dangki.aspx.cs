using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL
{
    public partial class dangki : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack)
            {
                string tenDangNhap = Request.Form["tenDangNhap"];
                string matKhau = Request.Form["matKhau"];
                string nhapLaiMatKhau = Request.Form["nhapLaiMatKhau"];

                string ten = Request.Form["ten"];
                string soDienThoai = Request.Form["soDienThoai"];
                string ngaySinhText = Request.Form["ngaySinh"];
                string gioiTinh = Request.Form["gioiTinh"];
                string email = Request.Form["email"];

                if (tenDangNhap == "" || matKhau == "" || nhapLaiMatKhau == "" || ten == "" || soDienThoai == "" || ngaySinhText == "" || gioiTinh == "" || email == "")
                {
                    lblThongBao.InnerText = "Vui lòng nhập đầy đủ thông tin.";
                    return;
                }
                if (matKhau != nhapLaiMatKhau)
                {
                    lblThongBao.InnerText = "Mật khẩu nhập lại không khớp.";
                    return;
                }
                DateTime ngaySinh = DateTime.Parse(ngaySinhText);
                List<ThanhVien> ds = (List<ThanhVien>)Application["DSThanhVien"];

                foreach (ThanhVien x in ds)
                {
                    if (x.TenDangNhap == tenDangNhap)
                    {
                        lblThongBao.InnerText = "Tên đăng nhập đã tồn tại.";
                        return;
                    }
                }
                ThanhVien tv = new ThanhVien();

                tv.TenDangNhap = tenDangNhap;
                tv.MatKhau = matKhau;
                tv.Ten = ten;
                tv.SoDienThoai = soDienThoai;
                tv.NgaySinh = ngaySinh;
                tv.GioiTinh = gioiTinh;
                tv.Email = email;

                ds.Add(tv);

                Application["DSThanhVien"] = ds;

                lblThongBao.Style["color"] = "green";
                Response.Write("<script>alert('Đăng ký thành công. Vui lòng đăng nhập.'); window.location='DangNhap.aspx';</script>");
            }
        } 
    }
}