using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raport_Online
{
    public class AspekDAO
    {
        private Logger logger = NLog.LogManager.GetCurrentClassLogger();
        private OnlineRaporEntities context = new OnlineRaporEntities();
        public AspekDAO() { }
        //acess modifier , type data keluaran(typeoutput), nama method ,(parameter(typedata , objek)) 
        public int Add(ASPEK aspek)
        {
            var result = 0;
            try
            {
                context.ASPEK.Add(aspek);
                return context.SaveChanges();
               // result = context.SaveChanges();

            }
            catch
            {
                result = -1;
                //logger.Error(ex.GetType());
                //logger.Error(ex.Message);
                //logger.Error(ex.InnerException);
                //throw ex;
            }
            //logger.Debug(result);

            return result;
        }
        public int Edit(int id, ASPEK aspek)
        {
            var result = 0;
            try
            {
                var exsitingaspek = context.ASPEK.Find(id);
                exsitingaspek.SUB_ASPEK = aspek.SUB_ASPEK;
                exsitingaspek.NAMA_ASPEK = aspek.NAMA_ASPEK;
                exsitingaspek.DIBUAT_OLEH = aspek.DIBUAT_OLEH;
                exsitingaspek.DIBUAT_PADA = aspek.DIBUAT_PADA;
                //context.ASPEK.Add(exsitingaspek);
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


        public ASPEK Detail(int id)
        {
            return context.ASPEK.Find(id);
        }

        public int Delete(int id, bool isPermanent)
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
            catch(Exception ex)
            {
                result = -1;
                logger.Error(ex.Message);
                logger.Error(ex.InnerException);
            }
            logger.Debug(result);
            return result;
        }

        public List<ASPEK> GetAll()
        {
            var q = from x in context.ASPEK
                    where x.STATUS_AKTIF.Equals(true)
                    select x;
            foreach (var item in q)
            {
                Console.WriteLine(item.ID_ASPEK + " " + item.NAMA_ASPEK);
            }
            return context.ASPEK.ToList();
        }
        public List<ASPEK> TampilByNamaAspek()
        {
            var q = from x in context.ASPEK
                    where x.NAMA_ASPEK.Contains("a")
                    select x;
            foreach (var item in q)
            {
                Console.WriteLine(item.NAMA_ASPEK);
            }
            return context.ASPEK.ToList();
        }

        public List<ASPEK> TampilByNamaAspek(string v)
        {
            throw new NotImplementedException();
        }
    }
}