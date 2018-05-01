using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raport_Online
{
    public class SubAspekDAO
    {
        private OnlineRaporEntities context = new OnlineRaporEntities();

        public SubAspekDAO()
        {

        }

        public int Add(SUB_ASPEK subaspek)
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

        public int Edit(int id, SUB_ASPEK subaspek)
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


        public SUB_ASPEK Detail(int id)
        {
            return context.SUB_ASPEK.Find(id);
        }

        public int Delete(int id, bool isPermanent)
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

        public List<SUB_ASPEK> GetAll()
        {
            return context.SUB_ASPEK.ToList();
        }

    }
}
