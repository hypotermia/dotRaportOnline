using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raport_Online
{
   public class JabatanDAO
    {
        private OnlineRaporEntities context = new OnlineRaporEntities();

        public JabatanDAO()
        {

        }

        public int add(JABATAN jabatan)
        {
            var result = 0;
            try
            {
                context.JABATAN.Add(jabatan);
                result=context.SaveChanges();
            }
            catch
            {
                result = -1;
            }
            return result;
        }

        public int edit(int id, JABATAN jabatan)
        {
            var result = 0;
            try
            {
                var exsitingjabatan = context.JABATAN.Find(id);
                exsitingjabatan.NAMA_JABATAN = jabatan.NAMA_JABATAN;
                //exsitingwilayah.WILAYAH2 = wilayah.WILAYAH2;

                result = context.SaveChanges();
            }
            catch
            {
                result = -1;
            }

            return result;
        }


        public JABATAN detail(int id)
        {
            return context.JABATAN.Find(id);
        }

        public int delete(int id, bool isPermanent)
        {
            int result = 0;

            try
            {
                var exsitingjabatan = context.JABATAN.Find(id);
                if (!isPermanent)
                {
                    exsitingjabatan.DIUBAH_PADA = DateTime.Now;
                    exsitingjabatan.STATUS_AKTIF = false;
                }

                else
                {
                    context.JABATAN.Remove(exsitingjabatan);
                }

                result = context.SaveChanges();
            }
            catch
            {
                result = -1;
            }
            return result;
        }

        public List<JABATAN> getAll()
        {
            return context.JABATAN.ToList();
        }

    }
}
