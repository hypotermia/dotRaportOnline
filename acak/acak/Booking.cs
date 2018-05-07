using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acak
{
    public class Booking:Pasiencs
    {
        public int myNewID;
        public Pasiencs pasien;           
        public DateTime waktu_book { get; set; }
        public string nama_kary { get; set; }
        public bool status { get; set; }
        public Booking()
        {
        }
        public int ID
        {
            get
            {
                return myNewID;
            }
            set
            {
                if (value > 0) this.myNewID = value;
            }
        }
        public void tambahBooking(Pasiencs pas)
        {

        }
    }  
}