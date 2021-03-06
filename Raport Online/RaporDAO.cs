﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Raport_Online
{
    public class RaporDAO
    {
        private Logger logger = NLog.LogManager.GetCurrentClassLogger();
        private OnlineRaporEntities context = new OnlineRaporEntities();
        public RaporDAO() { }
        public int Add(RAPOR rapor)
        {
            var result = 0;
            try
            {
                context.RAPOR.Add(rapor);
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

        public int Edit(int id, RAPOR rapor)
        {
            var result = 0;
            try
            {
                var exsitingrapor = context.RAPOR.Find(id);
                exsitingrapor.BERLAKU = rapor.BERLAKU;
                exsitingrapor.RATA2 = rapor.RATA2;

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


        public RAPOR Detail(int id)
        {
            return context.RAPOR.Find(id);
        }

        public int Delete(int id, bool isPermanent)
        {
            int result = 0;

            try
            {
                var exsitingrapor = context.RAPOR.Find(id);
                if (!isPermanent)
                {
                    exsitingrapor.DIBUAT_PADA = DateTime.Now;
                    exsitingrapor.STATUS_AKTIF = false;
                }

                else
                {
                    context.RAPOR.Remove(exsitingrapor);
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

        public List<RAPOR> GetAll()
        {
            var q = from x in context.KARYAWAN
                    where x.STATUS_AKTIF.Equals(true)
                    select x;
            foreach (var item in q)
            {
                Console.WriteLine(item.ID_KARYAWAN + " " + item.STATUS_AKTIF);
            }
               
            return context.RAPOR.ToList();
        }

        public List<KARYAWAN> CariBynamaKaryawan(string a)
        {
            var q = from x in context.RAPOR
                    where x.KARYAWAN.NAMA_LENGKAP.Contains(a)
                    select x;
            foreach (var item in q)
            {
                Console.WriteLine(item.ID_RAPOR + " " + item.RATA2);
            }
            return context.KARYAWAN.ToList();
        }
        //mentok
        public List<KARYAWAN> CariBynamaPenilai(string penilai)
        {
            var q = from x in context.RAPOR
                    where x.KARYAWAN1.NAMA_LENGKAP.Contains(penilai)
                    select x;
            foreach (var item in q)
            {
                Console.WriteLine(item.ID_RAPOR+ " " + item.RATA2);
            }
            return context.KARYAWAN.ToList();
        }

        //mentok lagi dibantu oleh mba novi
        public List<RAPOR> CariRataTertinggi()
        {
            var maxValue = context.RAPOR.Max(x => x.RATA2);
            //var q = context.RAPOR.First(x => x.RATA2 == maxValue);
            var q = from x in context.RAPOR
                    where x.RATA2 == maxValue
                    select x;
            //Console.WriteLine(q.KARYAWAN.NAMA_LENGKAP+" "+q.RATA2);
            foreach (var item in q)
            {
                Console.WriteLine(item.KARYAWAN.NAMA_LENGKAP + " " + item.ID_RAPOR + " " + item.RATA2);
            }
            return context.RAPOR.ToList();

        }

        ////Mentok lagi di bantu oleh mba novi
        //public void Caridariperiod(int tahun)
        //{
        //    var q = from x in context.RAPOR
        //            where x.PERIODE.Year==tahun
        //            select x;
        //    foreach (var item in q)
        //    {
        //        Console.WriteLine(item.KARYAWAN.NAMA_LENGKAP+" "+item.RATA2+" "+item.PERIODE);
        //    }
        //}

        //public void print()
        //{
        //    var q = from x in context.RAPOR
        //            where x.DETAIL_ASPEK.ToList()
        //            select x;
        //    try
        //    {
        //        Stream FilePath = null;
        //        StreamReader streamToPrint = new StreamReader(FilePath);
        //    }   
        //}



    }
}
