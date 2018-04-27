using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raport_Online
{
    public class AspekDAO
    {
        private fixraporEntities context = new fixraporEntities();

        public AspekDAO()
        {

        }

        public int add(ASPEK aspek)
        {
            var result = 0;
            try
            {
                context.ASPEK.Add(aspek);
                context.SaveChanges();
            }
            catch
            {
                result = -1;
            }
            return result;
        }

        public int edit(int id, ASPEK aspek)
        {
            var result = 0;
            try
            {
                var exsitingaspek = context.ASPEK.Find(id);
                exsitingaspek.SUB_ASPEK = aspek.SUB_ASPEK;
                exsitingaspek.NAMA_ASPEK = aspek.NAMA_ASPEK;

                result = context.SaveChanges();
            }
            catch
            {
                result = -1;
            }

            return result;
        }


        public ASPEK detail(int id)
        {
            return context.ASPEK.Find(id);
        }

        public int delete(int id, bool isPermanent)
        {
            int result = 0;

            try
            {
                var exsitingaspek = context.ASPEK.Find(id);
                if (!isPermanent)
                {
                    exsitingaspek.DIBUAT_PADA = DateTime.Now;
                    exsitingaspek.STATUS_AKTIF = false;
                }

                else
                {
                    context.ASPEK.Remove(exsitingaspek);
                }

                result = context.SaveChanges();
            }
            catch
            {
                result = -1;
            }
            return result;
        }

        public List<ASPEK> getAll()
        {
            return context.ASPEK.ToList();
        }

    }
}
