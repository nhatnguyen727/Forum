using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo
{
    public partial class register : System.Web.UI.Page
    {
        DemoDataContext dt = new DemoDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string mahoa(string pass)
        {
            return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(pass.Trim(), "SHA1");
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string s = @"Data Source=NHAT\SQLEXPRESS;Initial Catalog=Blog;Integrated Security=True";

            SqlConnection con = new SqlConnection(s);
            SqlCommand cmd = new SqlCommand("insert into DangNhap(userName,passWord) values('" + txtUserName.Text + "','" + mahoa(txtPassword.Text) + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script>alert('Đăng ký thành công!')</script>");
            Response.Redirect("login.aspx");

        }
    }
}