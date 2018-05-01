using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raport_Online
{
    public class AlamatDAO
    {
        private OnlineRaporEntities context = new OnlineRaporEntities();

        public AlamatDAO()
        {

        }
        public int add(ALAMAT alamat)
        {
            var result = 0;
            try
            {
                context.ALAMAT.Add(alamat);
                result = context.SaveChanges();
            }
            catch
            {
                result = -1;
            }
            return result;
        }

        public int edit(int id, ALAMAT alamat)
        {
            var result = 0;
            try
            {
                var exsitingalamat = context.ALAMAT.Find(id);
                exsitingalamat.KARYAWAN = alamat.KARYAWAN;
                exsitingalamat.STATUS_AKTIF = alamat.STATUS_AKTIF;

                result = context.SaveChanges();
            }
            catch
            {
                result = -1;
            }

            return result;
        }


        public ALAMAT detail(int id)
        {
            return context.ALAMAT.Find(id);
        }

        public int delete(int id, bool isPermanent)
        {
            int result = 0;

            try
            {
                var exsitingalamat = context.ALAMAT.Find(id);
                if (!isPermanent)
                {
                    exsitingalamat.DIUBAH_PADA = DateTime.Now;
                    exsitingalamat.STATUS_AKTIF = false;
                }

                else
                {
                    context.ALAMAT.Remove(exsitingalamat);
                }

                result = context.SaveChanges();
            }
            catch
            {
                result = -1;
            }
            return result;
        }

        public List<ALAMAT> getAll()
        {
            return context.ALAMAT.ToList();
        }
    }
}
