using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raport_Online;

namespace RaporOnlineTes
{
    [TestClass]
    public class DAODetailAspekTes
    {
        private DetailAspekDAO aDAO = new DetailAspekDAO();
        [TestMethod]
        public void TestDetailAspekBenar()
        {
            int id = 0;
            DETAIL_ASPEK expectResult = null;
            DETAIL_ASPEK result = aDAO.Detail(id);
            Assert.AreEqual(expectResult, result);
        }
        [TestMethod]
        public void TestDetailAspBenar()
        {
            int id = 1;
            DETAIL_ASPEK result = aDAO.Detail(id);
            Assert.IsNotNull(result);
        }
        [TestMethod]//okpass
        public void TestTampilByNilaiBenar()
        {
            int id = 1;
            var det = aDAO.Detail(id);
            Assert.AreEqual(70, det.NILAI_K_A);
        }
        [TestMethod]//okpass
        public void TestGetallDetailAsp()
        {
            Assert.IsNotNull(aDAO.getAll());
        }
        [TestMethod]//oktes+db
        public void TesTambahDetailAspekbenar()
        {
            DETAIL_ASPEK det = new DETAIL_ASPEK();
            det.NILAI_K_A = 80;
            int a = aDAO.Add(det);
            Trace.WriteLine(det.ID_RAPOR);
            Assert.IsNotNull(a);
        }
        [TestMethod]//okpass+db
        public void TesTambahDetailAspekGagal()
        {
            DETAIL_ASPEK det = new DETAIL_ASPEK();
            det.NILAI_K_A = 80;
            int a = aDAO.Add(det);
            Trace.WriteLine(det.ID_RAPOR);
            Assert.IsNotNull(a);
        }
        [TestMethod]//oktess+db
        public void TesEditDetailbenar()
        {
            DETAIL_ASPEK det = aDAO.Detail(2);
            Assert.IsNotNull(det);
            det.NILAI_K_A = 80;
            var a = aDAO.Edit(2, det);

            Assert.AreEqual(1, a);
        }
        [TestMethod]//oktess+db
        public void TesEditDetailSalah()
        {
            DETAIL_ASPEK det = aDAO.Detail(0);
            Assert.IsNotNull(det);
            det.NILAI_K_A = 80;
            var a = aDAO.Edit(0, det);
            Assert.AreEqual(0, a);
        }
        [TestMethod]//oktes+db
        public void TesDeleteAlamatbenar()
        {
            DETAIL_ASPEK det = aDAO.Detail(17);
            Assert.IsNotNull(det);
            bool isPermanent = false;
            var a = aDAO.Delete(17, false);
        }
        [TestMethod]
        public void TampilByIdRapor()
        {
            List<DETAIL_ASPEK> det = aDAO.TampilByIDRapor(1);
            Assert.Equals(5, det.Count);
        }
        [TestMethod]
        public void TampilByIdSubAspek()
        {
            List<DETAIL_ASPEK> det = aDAO.TampilByIDSubaspek(1);
            Assert.Equals(5, det.Count);
        }

    }
}