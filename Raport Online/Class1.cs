using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raport_Online
{
    public class Class1
    {
        public static void Main(String[] args)
        {
            AspekDAO aDAO = new AspekDAO();
            ASPEK aspek = aDAO.Detail(2);
           

            aspek.NAMA_ASPEK = "Try it ";
            aspek.DIUBAH_OLEH = "Zakki";
            aspek.DIUBAH_PADA = DateTime.Now;
            //aDAO.Edit(1, aspek);

            aDAO.Edit(2, aspek);
        }
    }
}
