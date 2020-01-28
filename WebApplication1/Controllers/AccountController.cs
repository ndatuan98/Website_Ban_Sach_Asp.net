using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.Controllers
{
    public class AccountController
    {
        DbConnect connectDB = new DbConnect();
        public bool CheckRegister(string email)
        {
            string cmd = "SELECT * FROM dbo.ACCOUNTS where EMAIL = '" + email + "'";
            DataTable dt = connectDB.getTable(cmd);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public void Register(string user, string pass, string name)
        {
            SqlConnection conn = connectDB.getConnection();
            string sqlInsert = "INSERT INTO dbo.ACCOUNTS  ( USERNAME , PASSWORD, FULLNAME)" +
                            " VALUES  ( @Username,@Password,@FullName)";
            SqlCommand cmd = new SqlCommand(sqlInsert, conn);
            cmd.Parameters.AddWithValue("@Username", user);
            cmd.Parameters.AddWithValue("@Password", pass);
            cmd.Parameters.AddWithValue("@FullName", name);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void DeleteAccount(int userId)
        {
            SqlConnection conn = connectDB.getConnection();
            string sqlDelete = "DELETE  FROM dbo.ACCOUNTS WHERE ID=@id";
            SqlCommand cmd = new SqlCommand(sqlDelete, conn);
            cmd.Parameters.AddWithValue("@id", userId);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}