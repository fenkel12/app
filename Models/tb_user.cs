using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class tb_user
    {
        public int id { get; set; }
        public string  Name { get; set; }

        public string  Gender { get; set; }
        public string  Telephone { get; set; }
        public DateTime Regdate { get; set; }
        public int userType { get; set; }
    }
}
