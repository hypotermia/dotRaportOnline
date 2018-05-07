using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acak
{
    public class User:Karyawan
    {
        int id_user { get; set; }
        string username { get; set; }
        string password { get; set; }

        public User()
        {
        }
    }
}
