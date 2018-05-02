using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raport_Online;

namespace RaporOnlineTes
{
    [TestClass]
    public class DAODetailAspekTes
    {

        private DetailAspekDAO aDAO = new DetailAspekDAO();
        [TestMethod]
        public void TestMethodDetail()
        {
            int id = 0;
            DETAIL_ASPEK expectResult = null;
            DETAIL_ASPEK result = aDAO.Detail(id);

            Assert.AreEqual(expectResult, result);
        }

        [TestMethod]
        public void TestMethodDetail2()
        {
            int id = 1;
            DETAIL_ASPEK result = aDAO.Detail(id);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestMethodDetail3()
        {
            int id = 01;
            DETAIL_ASPEK result = aDAO.Detail(id);
            Assert.IsNotNull(result);
        }
        [TestMethod]//okpass
        public void TestMethodDetailBenar()
        {
            int id = 1;
            var det = aDAO.Detail(id);
            Assert.AreEqual(70, det.NILAI_K_A);
        }
        [TestMethod]//okpass
        public void TestGetall()
        {
            Assert.IsNotNull(aDAO.getAll());
        }
        [TestMethod]//oktes+db
        public void TesTambahDetailbenar()
        {
            DETAIL_ASPEK det = new DETAIL_ASPEK();
            det.NILAI_K_A = 80;
            int a = aDAO.Add(det);

            Assert.IsNotNull(a);

        }
        [TestMethod]//okpass+db
        public void TesTambahDetailGagal()
        {
            DETAIL_ASPEK det = new DETAIL_ASPEK();
            det.NILAI_K_A = 80;
            int a = aDAO.Add(det);

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



    }
}