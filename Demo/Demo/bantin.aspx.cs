using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo
{
    public partial class bantin : System.Web.UI.Page
    {
        DemoDataContext dt = new DemoDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            rpIDBanTin.DataSource = dt.BanTin_SeclectID(Convert.ToInt32(Request["idbantin"]));
            rpIDBanTin.DataBind();
            rpChiTiet.DataSource = dt.ChiTiet_SeclectID(Convert.ToInt32(Request["idbantin"]));
            rpChiTiet.DataBind();
        }
    }
}