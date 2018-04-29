using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raport_Online
{
   public class DetailAspekDAO
    {
        private fixraporEntities context = new fixraporEntities();

        public DetailAspekDAO()
        {

        }

        public int add(DETAIL_ASPEK detailaspek)
        {
            var result = 0;
            try
            {
                context.DETAIL_ASPEK.Add(detailaspek);
                result=context.SaveChanges();
            }
            catch
            {
                result = -1;
            }
            return result;
        }

        public int edit(int id, DETAIL_ASPEK detailaspek)
        {
            var result = 0;
            try
            {
                var exsitingdetailaspek = context.DETAIL_ASPEK.Find(id);
                exsitingdetailaspek.NILAI_K_A = detailaspek.NILAI_K_A;
                exsitingdetailaspek.NILAI_K_B = detailaspek.NILAI_K_B;

                result = context.SaveChanges();
            }
            catch
            {
                result = -1;
            }

            return result;
        }


        public DETAIL_ASPEK detail(int id)
        {
            return context.DETAIL_ASPEK.Find(id);
        }

        public int delete(int id, bool isPermanent)
        {
            int result = 0;

            try
            {
                var exsitingdetailaspek = context.DETAIL_ASPEK.Find(id);
                if (!isPermanent)
                {
                    exsitingdetailaspek.ID_DETAIL = exsitingdetailaspek.ID_DETAIL;
                    //exsitingdetailaspek.isActive = false;
                }

                else
                {
                    context.DETAIL_ASPEK.Remove(exsitingdetailaspek);
                }

                result = context.SaveChanges();
            }
            catch
            {
                result = -1;
            }
            return result;
        }

        public List<DETAIL_ASPEK> getAll()
        {
            return context.DETAIL_ASPEK.ToList();
        }

    }
}
