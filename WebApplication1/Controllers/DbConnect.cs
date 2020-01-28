using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.Controllers
{
    public class DbConnect
    {
        public SqlConnection getConnection()
        {
            return new SqlConnection(@"Data Source=DESKTOP-401CU18\TUANNDA;Initial Catalog=WEBBANSACH;Integrated Security=True");
        }

        public DataTable getTable(string sql)
        {
            SqlConnection con = getConnection();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public void ExecutedNonQuery(string sql)
        {
            SqlConnection con = getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd.Clone();
            con.Close();
        }
    }
}