using System;
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
        public void TestMethodDetail()
        {
            int id = 0;
            RAPOR expectResult = null;
            RAPOR result = aDAO.Detail(id);

            Assert.AreEqual(expectResult, result);
        }

        [TestMethod]
        public void TestMethodDetail2()
        {
            int id = 1;
            RAPOR result = aDAO.Detail(id);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestMethodDetail3()
        {
            int id = 01;
            RAPOR result = aDAO.Detail(id);
            Assert.IsNotNull(result);
        }
        [TestMethod]//okpass
        public void TestMethodJabatanBenar()
        {
            int id = 1;
            var det = aDAO.Detail(id);
            Assert.AreEqual(80, det.JUMLAH);
        }
        [TestMethod]//okpass
        public void TestGetall()
        {
            Assert.IsNotNull(aDAO.GetAll());
        }
        [TestMethod]//oktes+db
        public void TesTambahbenar()
        {
            RAPOR det = new RAPOR();
            det.JUMLAH = 80;
            int a = aDAO.Add(det);
            

            Assert.IsNotNull(a);

        }
        [TestMethod]//okpass+db
        public void TesTambahGagal()
        {
            RAPOR det = new RAPOR();
            det.JUMLAH = 80;
            int a = aDAO.Add(det);
            Trace.WriteLine(det.ID_KARYAWAN);
            Trace.WriteLine(det.ID_PENILAI);
            
            Assert.IsNotNull(a);
        }
        [TestMethod]//oktess+db
        public void TesEditbenar()
        {
            RAPOR det = aDAO.Detail(2);
            Assert.IsNotNull(det);
            det.JUMLAH = 80;
            var a = aDAO.Edit(2, det);

            Assert.AreEqual(1, a);
        }
        [TestMethod]//oktess+db
        public void TesEditSalah()
        {
            RAPOR det = aDAO.Detail(0);
            Assert.IsNotNull(det);
            det.JUMLAH = 80;
            var a = aDAO.Edit(0, det);

            Assert.AreEqual(0, a);
        }
        [TestMethod]//oktes+db
        public void TesDeleteKarybenar()
        {
            RAPOR det = aDAO.Detail(17);
            Assert.IsNotNull(det);
            bool isPermanent = false;

            var a = aDAO.Delete(17, false);
        }
    }
}
