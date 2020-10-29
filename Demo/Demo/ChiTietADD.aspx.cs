using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo
{
    public partial class ChiTietADD : System.Web.UI.Page
    {
        DemoDataContext dt = new DemoDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                drBantin.DataTextField = "noiDung";
                drBantin.DataValueField = "IDBanTin";
                drBantin.DataSource = dt.BanTin_Seclectall();
                drBantin.DataBind();


            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            dt.ChiTiet_Insert(txtTieuDe.Text, txtNoiDung.Text, DateTime.Now, Convert.ToInt32(drBantin.SelectedValue));
            Response.Redirect("index.aspx");
        }
    }
}