using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raport_Online
{
    public class SubAspekDAO
    {
        private fixraporEntities context = new fixraporEntities();

        public SubAspekDAO()
        {

        }

        public int add(SUB_ASPEK subaspek)
        {
            var result = 0;
            try
            {
                context.SUB_ASPEK.Add(subaspek);
                result=context.SaveChanges();
            }
            catch
            {
                result = -1;
            }
            return result;
        }

        public int edit(int id, SUB_ASPEK subaspek)
        {
            var result = 0;
            try
            {
                var exsitingsubaspek = context.SUB_ASPEK.Find(id);
                exsitingsubaspek.NAMA_SUBASPEK = subaspek.NAMA_SUBASPEK;
                exsitingsubaspek.ASPEK = subaspek.ASPEK;

                result = context.SaveChanges();
            }
            catch
            {
                result = -1;
            }

            return result;
        }


        public SUB_ASPEK detail(int id)
        {
            return context.SUB_ASPEK.Find(id);
        }

        public int delete(int id, bool isPermanent)
        {
            int result = 0;

            try
            {
                var exsitingsubaspek = context.SUB_ASPEK.Find(id);
                if (!isPermanent)
                {
                    exsitingsubaspek.DIUBAH_PADA = DateTime.Now;
                    exsitingsubaspek.STATUS_AKTIF = false;
                }

                else
                {
                    context.SUB_ASPEK.Remove(exsitingsubaspek);
                }

                result = context.SaveChanges();
            }
            catch
            {
                result = -1;
            }
            return result;
        }

        public List<SUB_ASPEK> getAll()
        {
            return context.SUB_ASPEK.ToList();
        }

    }
}
