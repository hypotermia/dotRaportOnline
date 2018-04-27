using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raport_Online
{
     public class DepartemenDAO
    {
        private fixraporEntities context = new fixraporEntities();

        public DepartemenDAO()
        {

        }

        public int add(DEPARTEMEN departemen)
        {
            var result = 0;
            try
            {
                context.DEPARTEMEN.Add(departemen);
                result=context.SaveChanges();
            }
            catch
            {
                result = -1;
            }
            return result;
        }

        public int edit(int id, DEPARTEMEN departemen)
        {
            var result = 0;
            try
            {
                var exsitingdepartemen = context.DEPARTEMEN.Find(id);
                exsitingdepartemen.KARYAWAN = departemen.KARYAWAN;
                exsitingdepartemen.KARYAWAN1 = departemen.KARYAWAN1;

                result = context.SaveChanges();
            }
            catch
            {
                result = -1;
            }

            return result;
        }


        public DEPARTEMEN detail(int id)
        {
            return context.DEPARTEMEN.Find(id);
        }

        public int delete(int id, bool isPermanent)
        {
            int result = 0;

            try
            {
                var exsitingdepartemen = context.DEPARTEMEN.Find(id);
                if (!isPermanent)
                {
                    exsitingdepartemen.DIUBAH_PADA = DateTime.Now;
                    exsitingdepartemen.STATUS_AKTIF = false;
                }

                else
                {
                    context.DEPARTEMEN.Remove(exsitingdepartemen);
                }

                result = context.SaveChanges();
            }
            catch
            {
                result = -1;
            }
            return result;
        }

        public List<DEPARTEMEN> getAll()
        {
            return context.DEPARTEMEN.ToList();
        }

    }
}
