using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL
{
    public partial class DanhSachSanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) HienThiDuLieu();
        }

        private void HienThiDuLieu()
        {
            var ds = (List<SanPham>)Application["DSSanPham"];
            if (ds != null)
            {
                rptSanPham.DataSource = ds;
                rptSanPham.DataBind();
            }
        }

        protected void btnTimKiem_Click(object sender, EventArgs e)
        {
            var ds = (List<SanPham>)Application["DSSanPham"];
            if (ds == null) return;

            string key = txtTimKiem.Text.ToLower().Trim();
            string loai = ddlLoai.SelectedValue;
            var ketQua = ds.Where(s => s.TenSP.ToLower().Contains(key));
            if (loai != "Tất cả")
            {
                ketQua = ketQua.Where(s => s.Loai == loai);
            }

            rptSanPham.DataSource = ketQua.ToList();
            rptSanPham.DataBind();
        }
    }
}