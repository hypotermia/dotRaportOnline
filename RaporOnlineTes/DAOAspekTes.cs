using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raport_Online;

namespace RaporOnlineTes
{
    [TestClass]
    public class DAOAspekTes
    {
        AspekDAO aDAO = new AspekDAO();
        //        [TestMethod]
        //        public void TestMethodDetail()
        //        {
        //            int id = 0;
        //            ASPEK expectResult = null;
        //            ASPEK result = aDAO.Detail(id);

        //            Assert.AreEqual(expectResult, result);
        //        }

        //        [TestMethod]
        //        public void TestMethodBenarDetail2()
        //        {
        //            int id = 1;
        //            ASPEK result = aDAO.Detail(id);

        //            Assert.IsNotNull(result);
        //        }
        //        [TestMethod]
        //        public void TestMethodDetail3()
        //        {
        //            int id = 01;
        //            ASPEK result = aDAO.Detail(id);

        //            Assert.IsNotNull(result);
        //        }
        [TestMethod]
        public void TestMethodTambahAspek()
        {
            ASPEK Asp = new ASPEK();
            Asp.ID_ASPEK = 1;
            Asp.DIBUAT_OLEH = "Zakki";
            Asp.DIBUAT_PADA = DateTime.Now;
            Asp.STATUS_AKTIF = true;
            //aDAO.Add(Asp);

            Assert.IsNotNull(aDAO.Add(Asp));

        }
        //        [TestMethod]
        //        public void TambahAspekGagal()
        //        {
        //            ASPEK aspek = new ASPEK();
        //            aspek.DIBUAT_OLEH = null;
        //            int a = aDAO.Add(aspek);

        //            Assert.IsNull(a);
        //        }

        //        [TestMethod]
        //        public void TambahAspekGagal2()
        //        {
        //            ASPEK aspek = new ASPEK();
        //            aspek.NAMA_ASPEK = null;
        //            int a = aDAO.Add(aspek);

        //            Assert.IsNull(a);
        //        }

        //        [TestMethod]
        //        public void EditAspect(int id, ASPEK aspek)
        //        {
        //            if (aspek == null)
        //            {
        //                throw new ArgumentNullException(nameof(aspek));
        //            }
        //            aspek.NAMA_ASPEK = null;
        //            int a = aDAO.Edit(1, aspek);

        //            Assert.IsNotNull(a);
        //        }


        //[TestMethod]
//public void EditAspect1(int id, ASPEK aspek)
//{
//    if (aspek == null)
//    {
//        throw new ArgumentNullException(nameof(aspek));
//    }
//    aspek.NAMA_ASPEK = "Anjaaaaaaay";
//    int a = aDAO.Edit(1, aspek);

//    Assert.IsNotNull(a);
//}

        //        [TestMethod]
        //        public void Delete()
        //        {
        //            int id = 1;
        //            bool isPermanent = false;
        //            ASPEK aspek = new ASPEK();
        //            var anu = aDAO.Delete(1, false);

        //        }
    }
}
