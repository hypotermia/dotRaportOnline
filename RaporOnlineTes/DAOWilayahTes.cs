using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raport_Online;

namespace RaporOnlineTes
{
    [TestClass]
    public class DAOWilayahTes
    {
        private WilayahDAO aDAO = new WilayahDAO();
        public void TestMethodDetail()
        {
            int id = 0;
            WILAYAH expectResult = null;
            WILAYAH result = aDAO.Detail(id);

            Assert.AreEqual(expectResult, result);
        }

        [TestMethod]
        public void TestMethodDetail2()
        {
            int id = 1;
            WILAYAH result = aDAO.Detail(id);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestMethodDetail3()
        {
            int id = 01;
            WILAYAH result = aDAO.Detail(id);
            Assert.IsNotNull(result);
        }
        [TestMethod]//okpass
        public void TestMethodJabatanBenar()
        {
            int id = 1;
            var det = aDAO.Detail(id);
            Assert.AreEqual("wilayah", det.NAMA_WIL);
        }
        [TestMethod]//okpass
        public void TestGetall()
        {
            Assert.IsNotNull(aDAO.GetAll());
        }
        [TestMethod]//oktes+db
        public void TesTambahbenar()
        {
            WILAYAH det = new WILAYAH();
            det.NAMA_WIL = "wilayah";
            int a = aDAO.Add(det);


            Assert.IsNotNull(a);

        }
        [TestMethod]//okpass+db
        public void TesTambahGagal()
        {
            WILAYAH det = new WILAYAH();
            det.NAMA_WIL = "wila";
            int a = aDAO.Add(det);
           

            Assert.IsNotNull(a);
        }
        [TestMethod]//oktess+db
        public void TesEditbenar()
        {
            WILAYAH det = aDAO.Detail(2);
            Assert.IsNotNull(det);
            det.NAMA_WIL = "wil";
            var a = aDAO.Edit(2, det);

            Assert.AreEqual(1, a);
        }
        [TestMethod]//oktess+db
        public void TesEditSalah()
        {
            WILAYAH det = aDAO.Detail(0);
            Assert.IsNotNull(det);
            det.NAMA_WIL = "wil";
            var a = aDAO.Edit(0, det);

            Assert.AreEqual(0, a);
        }
        [TestMethod]//oktes+db
        public void TesDeletebenar()
        {
            WILAYAH det = aDAO.Detail(17);
            Assert.IsNotNull(det);
            bool isPermanent = false;

            var a = aDAO.delete(17, false);
        }
    }
}
