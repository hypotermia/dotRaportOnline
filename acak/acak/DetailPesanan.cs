using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acak
{
   public class DetailPesanan:Pasiencs
    {
        public int id_detail { get; set; }
        public int id_pasien { get; set; }
        public int id_kacamata { get; set; }
        public int id_outlet { get; set; }
        public DetailPesanan()
        {
        }
        
    }
    
    
}
