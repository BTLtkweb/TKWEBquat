using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace banquat
{
    public partial class TrangChu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ThanhVien"] == null)
            {
                Response.Redirect("DangNhap.aspx");
            }
            else
            {
                ThanhVien tv = (ThanhVien)Session["ThanhVien"];
                lblXinChao.InnerHtml = "Xin chào: <b>" + tv.Ten + "</b>";
            }
        }
    }
}