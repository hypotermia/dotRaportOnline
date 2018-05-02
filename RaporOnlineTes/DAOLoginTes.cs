using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raport_Online;

namespace RaporOnlineTes
{
    [TestClass]
    public class DAOLoginTes
    {
        private LoginDAO aDAO = new LoginDAO();
        [TestMethod]
        public void TestMethodDetail()
        {
            int id = 0;
            LOGIN expectResult = null;
            LOGIN result = aDAO.detail(id);

            Assert.AreEqual(expectResult, result);
        }

        [TestMethod]
        public void TestMethodDetail2()
        {
            int id = 1;
            LOGIN result = aDAO.detail(id);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestMethodDetail3()
        {
            int id = 01;
            LOGIN result = aDAO.detail(id);
            Assert.IsNotNull(result);
        }
        [TestMethod]//okpass
        public void TestMethodBenar()
        {
            int id = 1;
            var det = aDAO.detail(id);
            Assert.AreEqual("Merdeka", det.USERNAME);
        }
        [TestMethod]//okpass
        public void TestGetall()
        {
            Assert.IsNotNull(aDAO.getAll());
        }
        [TestMethod]//oktes+db
        public void TesTambahbenar()
        {
            LOGIN det = new LOGIN();
            det.USERNAME = "Saya";
            
            int a = aDAO.add(det);
          

            Assert.IsNotNull(a);

        }
        [TestMethod]//okpass+db
        public void TesTambahKaryGagal()
        {
            LOGIN det = new LOGIN();
            det.USERNAME = "Programmer";
            int a = aDAO.add(det);
            
            Assert.IsNotNull(a);
        }
        [TestMethod]//oktess+db
        public void TesEditKarybenar()
        {
            LOGIN det = aDAO.detail(2);
            Assert.IsNotNull(det);
            det.USERNAME = "wak";
            var a = aDAO.edit(2, det);

            Assert.AreEqual(1, a);
        }
        [TestMethod]//oktess+db
        public void TesEditSalah()
        {
            LOGIN det = aDAO.detail(0);
            Assert.IsNotNull(det);
            det.USERNAME = "wakawk";
            var a = aDAO.edit(0, det);

            Assert.AreEqual(0, a);
        }
        [TestMethod]//oktes+db
        public void TesDeleteKarybenar()
        {
            LOGIN det = aDAO.detail(17);
            Assert.IsNotNull(det);
            bool isPermanent = false;

            var a = aDAO.delete(17, false);
        }
    }
}
