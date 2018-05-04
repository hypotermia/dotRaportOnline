using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raport_Online;

namespace RaporOnlineTes
{
    [TestClass]
    public class DAORaporTes
    {
       
        private RaporDAO aDAO = new RaporDAO();
        [TestMethod]
        public void TestTampilDetailRaporSalah()
        {
            int id = 0;
            RAPOR expectResult = null;
            RAPOR result = aDAO.Detail(id);

            Assert.AreEqual(expectResult, result);
        }
        [TestMethod]
        public void TestTampilDetailRaporBenar()
        {
            int id = 1;
            RAPOR result = aDAO.Detail(id);
            Assert.IsNotNull(result);
        }
        [TestMethod]//okpass
        public void TestTampilRaporByJumlahBenar()
        {
            int id = 1;
            var det = aDAO.Detail(id);
            Assert.AreEqual(80, det.JUMLAH);
        }
        [TestMethod]//okpass
        public void TestGetallRapor()
        {
            Assert.IsNotNull(aDAO.GetAll());
        }
        [TestMethod]//oktes+db
        public void TesTambahRaporbenar()
        {
            RAPOR det = new RAPOR();
            det.JUMLAH = 80;
            int a = aDAO.Add(det);
            Assert.IsNotNull(a);

        }
        [TestMethod]//okpass+db
        public void TesTambahRaporGagal()
        {
            RAPOR det = new RAPOR();
            det.JUMLAH = 80;
            int a = aDAO.Add(det);
            Trace.WriteLine(det.ID_KARYAWAN);
            Trace.WriteLine(det.ID_PENILAI);
            Assert.IsNotNull(a);
        }
        [TestMethod]//oktess+db
        public void TesEditRaporbenar()
        {
            RAPOR det = aDAO.Detail(2);
            Assert.IsNotNull(det);
            det.JUMLAH = 80;
            var a = aDAO.Edit(2, det);
            Assert.AreEqual(1, a);
        }
        [TestMethod]//oktess+db
        public void TesEditRaporSalah()
        {
            RAPOR det = aDAO.Detail(0);
            Assert.IsNotNull(det);
            det.JUMLAH = 80;
            var a = aDAO.Edit(0, det);

            Assert.AreEqual(0, a);
        }
        [TestMethod]//oktess+db
        public void TesEditRaporSalah2()
        {
            RAPOR det = aDAO.Detail(0);
            Assert.IsNotNull(det);
            det.ID_KARYAWAN = 1;
            
            var a = aDAO.Edit(0, det);

            Assert.AreEqual(-1, a);
        }
        [TestMethod]//oktes+db
        public void TesDeleteRaporbenar()
        {
            RAPOR det = aDAO.Detail(17);
            Assert.IsNotNull(det);
            bool isPermanent = false;
            var a = aDAO.Delete(17, false);
        }
        [TestMethod]
        public void TesRaporRata2()
        {
            string x = "a";
            List<KARYAWAN> det =aDAO.CariBynamaKaryawan(x);
            //Assert.Equals(5, det.Count);
            Assert.IsTrue(det.Exists(p=>p.NAMA_LENGKAP=="zaki"));
        }
        [TestMethod]
        public void TestRaporBynamaPenilai()
        {
            List<KARYAWAN> det = aDAO.CariBynamaPenilai("a");
            Assert.Equals(5, det.Count);
        }
        [TestMethod]
        public void TesRaporCariRataTertinggi()
        {
            List<RAPOR> det = aDAO.CariRataTertinggi();
           
        }

    }
}
