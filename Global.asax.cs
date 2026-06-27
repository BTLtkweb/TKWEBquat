using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace BTL
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            List<ThanhVien> ds = new List<ThanhVien>();

            ThanhVien admin = new ThanhVien();
            admin.TenDangNhap = "admin";
            admin.MatKhau = "123";
            admin.Ten = "Quản trị viên";
            admin.SoDienThoai = "0123456789";
            admin.NgaySinh = new DateTime(2006, 1, 1);
            admin.GioiTinh = "Nam";
            admin.Email = "admin@gmail.com";

            ds.Add(admin);

            Application["DSThanhVien"] = ds;

            List<SanPham> dsSP = new List<SanPham>();

            SanPham sp1 = new SanPham();
            sp1.MaSP = 1;
            sp1.TenSP = "Quạt đứng Fugio";
            sp1.Hang = "Fugio";
            sp1.Loai = "Quạt đứng";
            sp1.Gia = 450000;
            sp1.MoTa = "Quạt đứng 3 tốc độ, chạy êm, phù hợp gia đình.";
            sp1.HinhAnh = "./images/quat1.jpg";

            dsSP.Add(sp1);

            SanPham sp2 = new SanPham();
            sp2.MaSP = 2;
            sp2.TenSP = "Quạt hơi nước Kangaroo";
            sp2.Hang = "Kangaroo";
            sp2.Loai = "Quạt hơi nước";
            sp2.Gia = 2390000;
            sp2.MoTa = "Quạt hơi nước làm mát nhanh, có điều khiển từ xa.";
            sp2.HinhAnh = "./images/quat2.png";

            dsSP.Add(sp2);

            Application["DSSanPham"] = dsSP;
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}