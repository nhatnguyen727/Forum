using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Demo
{
    public class QL
    {
        public int ID { get; set; }
        public string tieuDe { get; set; }
        public string noiDung { get; set; }
        public int IDBanTin { get; set; }
        DB db = new DB();
        public void Update(QL bv)
        {
            string s = @"Data Source=NHAT\SQLEXPRESS;Initial Catalog=Blog;Integrated Security=True" ;
            SqlConnection cnn = new SqlConnection(s);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("ChiTiet_Update", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = bv.ID;
            cmd.Parameters.Add("@IDBanTin", SqlDbType.Int).Value = bv.ID;
            cmd.Parameters.Add("@tieuDe", SqlDbType.VarChar).Value = bv.tieuDe;
            cmd.Parameters.Add("@noiDung", SqlDbType.VarChar).Value = bv.noiDung;
            
            
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cnn.Close();

        }
        public void Delete(QL bv)
        {
            string s = @"Data Source=NHAT\SQLEXPRESS;Initial Catalog=Blog;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(s);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("ChiTiet_Delete", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = bv.ID;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cnn.Close();
        }
      


    }
}