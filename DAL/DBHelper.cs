using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DBHelper
    {
        public static string connrt = "Data Source=.;Initial Catalog=ChangeDB;Integrated Security=True";
        public static DataTable Quer(string sql) {
            SqlConnection conn = new SqlConnection(connrt);
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            return ds.Tables[0];
        }
        public static bool ZSG(string sql) {
            SqlConnection conn = null;
            bool f = false;
            conn =new SqlConnection(connrt);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (cmd.ExecuteNonQuery()>0)
            {
                f = true;
            }
            conn.Close();
            return f;
        }
    }
}
