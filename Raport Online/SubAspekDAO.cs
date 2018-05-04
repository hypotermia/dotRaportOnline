using NLog;
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
        private Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public SubAspekDAO() { }
        public int Add(SUB_ASPEK subaspek)
        {
            var result = 0;
            try
            {
                context.SUB_ASPEK.Add(subaspek);
                return context.SaveChanges();
            }
            catch(Exception ex)
            {
                //log class
                //log message
                //log inner
                throw ex;
                //logger.Error(ex.GetType());
                //logger.Error(ex.Message);
                //logger.Error(ex.InnerException);
            }
            
            
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
            catch(Exception ex)
            {
                result = -1;
                logger.Error(ex.Message);
                logger.Error(ex.InnerException);
            }
            logger.Debug(result);
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
            catch(Exception ex)
            {
                result = -1;
                logger.Error(ex.Message);
                logger.Error(ex.InnerException);
            }
            logger.Debug(result);
            return result;
        }
        public List<SUB_ASPEK> GetAll()
        {
            return context.SUB_ASPEK.ToList();
        }
        public List<SUB_ASPEK> TampilByNamaSubaspek()
        {
            var q = from x in context.SUB_ASPEK
                    where x.NAMA_SUBASPEK.Contains("a")
                    select x;
            foreach (var item in q)
            {
                Console.WriteLine(item.NAMA_SUBASPEK);
            }
            return context.SUB_ASPEK.ToList();
        }
       
        public List<SUB_ASPEK> TampilByNamaAspek()
        {
            var q = from x in context.SUB_ASPEK
                    where x.ASPEK.NAMA_ASPEK.Contains("a")
                    select x;
            foreach (var item in q)
            {
                Console.WriteLine(item.ID_ASPEK+" "+item.ID_SUB+ " "+item.NAMA_SUBASPEK);
            }
            return context.SUB_ASPEK.ToList();
        }



    }
}
