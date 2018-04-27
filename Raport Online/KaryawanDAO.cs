using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raport_Online
{
    class KaryawanDAO
    {
        private fixraporEntities context = new fixraporEntities();

        public KaryawanDAO()
        {

        }

        public int add(KARYAWAN karyawan)
        {
            var result = 0;
            try
            {
                context.KARYAWAN.Add(karyawan);
                context.SaveChanges();
            }
            catch
            {
                result = -1;
            }
            return result;
        }

        public int edit(int id, KARYAWAN karyawan)
        {
            var result = 0;
            try
            {
                var exsitingKaryawan = context.KARYAWAN.Find(id);
                exsitingKaryawan.NAMA_LENGKAP = karyawan.NAMA_LENGKAP;
                exsitingKaryawan.KEWARGANEGARAAN = karyawan.KEWARGANEGARAAN;

                result = context.SaveChanges();
            }
            catch
            {
                result = -1;
            }

            return result;
        }


        public KARYAWAN detail(int id)
        {
            return context.KARYAWAN.Find(id);
        }

        public int delete(int id, bool isPermanent)
        {
            int result = 0;

            try
            {
                var exsitingKaryawan = context.KARYAWAN.Find(id);
                if (!isPermanent)
                {
                    exsitingKaryawan.DIUBAH_PADA = DateTime.Now;
                    exsitingKaryawan.STATUS_AKTIF = false;
                }

                else
                {
                    context.KARYAWAN.Remove(exsitingKaryawan);
                }

                result = context.SaveChanges();
            }
            catch
            {
                result = -1;
            }
            return result;
        }

        public List<KARYAWAN> getAll()
        {
            return context.KARYAWAN.ToList();
        }
        
    }
}
