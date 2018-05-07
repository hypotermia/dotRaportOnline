using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acak
{
   public class Pemeriksaan:Booking
    {
        int id_pemeriksaan { get; set; }
        int id_book { get; set; }
        string resep { get; set; }
        DateTime jadwal { get; set; }
        string jadwal_selanjutnya { get; set; }
        double biaya { get; set; }
        string histori { get; set; }

        public Pemeriksaan()
        {
        }
    }
}
