using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raport_Online
{
   public class DetailAspekDAO
    {
        private OnlineRaporEntities context = new OnlineRaporEntities();
        private Logger logger = NLog.LogManager.GetCurrentClassLogger(); 
        public DetailAspekDAO()
        {

        }

        public int Add(DETAIL_ASPEK detailaspek)
        {
            var result = 0;
            try
            {
                context.DETAIL_ASPEK.Add(detailaspek);
                result=context.SaveChanges();
            }
            catch(Exception ex)
            {
                result = -1;
                logger.Error(ex.Message);
                logger.Error(ex.InnerException);
            }
            logger.Debug(result);
            return result;
        }

        public int Edit(int id, DETAIL_ASPEK detailaspek)
        {
            var result = 0;
            try
            {
                var exsitingdetailaspek = context.DETAIL_ASPEK.Find(id);
                exsitingdetailaspek.NILAI_K_A = detailaspek.NILAI_K_A;
                exsitingdetailaspek.NILAI_K_B = detailaspek.NILAI_K_B;

                result = context.SaveChanges();
            }
            catch(Exception ex)
            {
                result = -1;
                logger.Error(ex.Message);
                logger.Error(ex.InnerException);
            }
            logger.Debug(result);
            return result;
        }


        public DETAIL_ASPEK Detail(int id)
        {
            return context.DETAIL_ASPEK.Find(id);
        }

        public int Delete(int id, bool isPermanent)
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
            catch(Exception ex)
            {
                result = -1;
                logger.Error(ex.Message);
                logger.Error(ex.InnerException);
            }
            logger.Debug(result);
            return result;
        }

        public List<DETAIL_ASPEK> getAll()
        {
            return context.DETAIL_ASPEK.ToList();
        }

        public List<DETAIL_ASPEK> TampilByIDRapor(int v)
        {
            throw new NotImplementedException();
        }

        public List<DETAIL_ASPEK> TampilByIDRapor()
        {
            var q = from x in context.DETAIL_ASPEK
                    where x.ID_RAPOR.Equals(1)
                    select x;
            foreach (var item in q)
            {
                Console.Write(item.ID_RAPOR);
            }
            return context.DETAIL_ASPEK.ToList();
        }

        public List<DETAIL_ASPEK> TampilByIDSubaspek(int v)
        {
            throw new NotImplementedException();
        }

        public List<DETAIL_ASPEK> TampilByIDSubaspek()
        {
            var q = from x in context.DETAIL_ASPEK
                    where x.ID_SUB.Equals(1)
                    select x;
            foreach (var item in q)
            {
                Console.Write(item.ID_SUB);
            }
            return context.DETAIL_ASPEK.ToList();
        }
    }
}
