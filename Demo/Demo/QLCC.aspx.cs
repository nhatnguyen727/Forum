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
    public partial class QLCC : System.Web.UI.Page
    {
        DemoDataContext dt = new DemoDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                

            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                QL bv = new QL()
                {
                    ID = int.Parse(ViewState["ID"].ToString()),
                    IDBanTin = int.Parse(drBantin.SelectedValue),
                    tieuDe = txtTieuDe.Text,
                    noiDung = txtNoiDung.Text
                  
                };
                bv.Update(bv);
                Response.Redirect("~/QLCC.aspx");
            }
            catch
            {

            }
        }
      

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = int.Parse(e.CommandArgument.ToString());
            if (e.CommandName == "Select") //load dl lên con control
            {
                var db = new DB();
                SqlDataReader reader = db.ExecuteReader(@"Select IDBanTin,tieuDe,noiDung from ChiTiet 
                                        where ID =" + int.Parse(GridView1.Rows[index].Cells[0].Text + ""));
                while (reader.Read())
                {
                    drBantin.SelectedValue = reader[0].ToString();
                    txtTieuDe.Text = reader[1].ToString();
                    txtNoiDung.Text = reader[2].ToString();
                }
                reader.Close();
                ViewState["ID"] = int.Parse(GridView1.Rows[index].Cells[0].Text);
            }
            else if (e.CommandName == "del")
            {
                QL bv = new QL();
                bv.ID = +int.Parse(GridView1.Rows[index].Cells[0].Text);
                bv.Delete(bv);
                Response.Redirect("~/QLCC.aspx");
            }
        }

    }
    
}