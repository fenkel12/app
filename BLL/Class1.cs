using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace BLL
{
    public class Class1
    {
        public static DataTable cxbll() {
            return DAL.Class1.cx();
        }
        public static DataTable mh(string name) {
            return DAL.Class1.mh(name);
        }
        public static DataTable GetByidBLL(int id)
        {
            return DAL.Class1.cxid(id);
        }
        public static bool SetVipBll(int id, int type)
        {
            return DAL.Class1.Setvip(id, type);
        }
    }
}
