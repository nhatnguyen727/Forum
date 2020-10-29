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
    public partial class login : System.Web.UI.Page
    {
        DemoDataContext dt = new DemoDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string mahoa(string pass)
        {
            return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(pass.Trim(), "SHA1");
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string passmahoa = mahoa(txtPassword.Text);
            string s = @"Data Source=NHAT\SQLEXPRESS;Initial Catalog=Blog;Integrated Security=True";
            SqlConnection con = new SqlConnection(s);
            SqlDataAdapter da = new SqlDataAdapter("select * from DangNhap where userName='" + txtUserName.Text + "' and passWord='" + passmahoa + "'", con);  
            DataTable tb = new DataTable();
            da.Fill(tb);
            if (tb.Rows.Count > 0)
            {
                Session["name"] = txtUserName.Text;
                Session["allow"] = true;
                Response.Redirect("Index.aspx");
            }
            else Response.Write("<script>alert('Username/Password chưa đúng')</script>");

        }
    }
}