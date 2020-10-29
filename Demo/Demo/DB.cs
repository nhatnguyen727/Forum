using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Demo
{
    public class DB
    {
        public SqlConnection cnn { get; set; }
        public DB()
        {
            string s = @"Data Source=NHAT\SQLEXPRESS;Initial Catalog=Blog;Integrated Security=True";
            this.cnn = new SqlConnection(s);
        }
        public void ExcuteDB(string query)
        {
            
            SqlCommand cmd = new SqlCommand(query, this.cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            cmd.Dispose();
        }
        public DataTable GetTable(string query)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, this.cnn);
            cnn.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        internal void ExcuteDB()
        {
            throw new NotImplementedException();
        }
        public string ExecuteScalar(string query)
        {
            SqlCommand cmd = new SqlCommand(query, this.cnn);
            cnn.Open();
            string kq = cmd.ExecuteScalar().ToString();
            cnn.Close();
            cmd.Dispose();
            return kq;
        }
        public SqlDataReader ExecuteReader(string query)
        {
            SqlCommand cmd = new SqlCommand(query, this.cnn);
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        internal void ExcuteDB(object p)
        {
            throw new NotImplementedException();
        }
    }
}