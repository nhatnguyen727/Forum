using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo
{
    public partial class chitiet : System.Web.UI.Page
    {
        DemoDataContext dt = new DemoDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            //lấy số lần xem
            int? so = null;
            int id = Convert.ToInt32(Request["ID"]);
            int idbantin = Convert.ToInt32(Request["idbantin"]);
            //lấy dl trong sql server
            dt.ChiTiet_LanXem(id,ref so);
            
            if(so == null)
            {
                so = 0;
            }
            int gt = Convert.ToInt32(so) + 1;

            //Tần số lượt xem
            dt.ChiTiet_SLX(gt, id);
            rpBanTin.DataSource = dt.BanTin_SeclectID(idbantin);
            rpBanTin.DataBind();
            rpChiTiet.DataSource = dt.ChiTiet_SELECT(id);
            rpChiTiet.DataBind();
            rpRanDom.DataSource = dt.ChiTiet_SelectRanDom(idbantin);
            rpRanDom.DataBind();
           

        }
   
    }
}