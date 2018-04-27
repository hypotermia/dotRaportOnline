using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raport_Online
{
    class WilayahDAO
    {
        private fixraporEntities context = new fixraporEntities();

        public WilayahDAO()
        {

        }

        public int add(WILAYAH wilayah)
        {
            var result = 0;
            try
            {
                context.WILAYAH.Add(wilayah);
                context.SaveChanges();
            }
            catch
            {
                result = -1;
            }
            return result;
        }

        public int edit(int id, WILAYAH wilayah)
        {
            var result = 0;
            try
            {
                var exsitingwilayah = context.WILAYAH.Find(id);
                exsitingwilayah.WILAYAH1 = wilayah.WILAYAH1;
                exsitingwilayah.WILAYAH2 = wilayah.WILAYAH2;

                result = context.SaveChanges();
            }
            catch
            {
                result = -1;
            }

            return result;
        }


        public WILAYAH detail(int id)
        {
            return context.WILAYAH.Find(id);
        }

        public int delete(int id, bool isPermanent)
        {
            int result = 0;

            try
            {
                var exsitingwilayah = context.WILAYAH.Find(id);
                if (!isPermanent)
                {
                    exsitingwilayah.DIUBAH_PADA = DateTime.Now;
                    exsitingwilayah.STATUS_AKTIF = false;
                }

                else
                {
                    context.WILAYAH.Remove(exsitingwilayah);
                }

                result = context.SaveChanges();
            }
            catch
            {
                result = -1;
            }
            return result;
        }

        public List<WILAYAH> getAll()
        {
            return context.WILAYAH.ToList();
        }

    }
}
