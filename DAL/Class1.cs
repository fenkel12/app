using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DAL
{
    public class Class1
    {
        public static DataTable cx() {
            string sql = "select * from tb_user";
            return DBHelper.Quer(sql);
        }
        public static DataTable mh(string name) {
            string sql =string.Format( "select * from tb_user where Name like '%{0}%' ",name);
            return DBHelper.Quer(sql);
        }
        public static DataTable cxid(int id) {
            string sql = "select * from tb_user where id=" + id;
            return DBHelper.Quer(sql);
        }
        public static bool Setvip(int id, int type)
        {
            string sql = "update tb_user set userType=" + type + " where id=" + id;
            return DBHelper.ZSG(sql);
        }
    }
}
