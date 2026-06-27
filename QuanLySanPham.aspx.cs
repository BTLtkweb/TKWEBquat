using System;
using System.Collections.Generic;
using System.Linq;

namespace BTL
{
    public partial class Quanlysanpham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) HienThi();
        }

        private void HienThi()
        {
            gvSanPham.DataSource = (List<SanPham>)Application["DSSanPham"];
            gvSanPham.DataBind();
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            var ds = (List<SanPham>)Application["DSSanPham"];
            int gia;
            int.TryParse(txtGia.Text, out gia); 

            ds.Add(new SanPham
            {
                MaSP = ds.Count + 1,
                TenSP = txtTen.Text,
                Hang = txtHang.Text,
                Loai = txtLoai.Text,
                Gia = gia,
                HinhAnh = fanh.FileName,
            });

            Application["DSSanPham"] = ds;
            HienThi();
        }

        protected void gvSanPham_RowDeleting(object sender, System.Web.UI.WebControls.GridViewDeleteEventArgs e)
        {
            int id = (int)gvSanPham.DataKeys[e.RowIndex].Value;
            var ds = (List<SanPham>)Application["DSSanPham"];
            ds.RemoveAll(x => x.MaSP == id);
            Application["DSSanPham"] = ds;
            HienThi();
        }
    }
}