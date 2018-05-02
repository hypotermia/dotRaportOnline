using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raport_Online;

namespace RaporOnlineTes
{
    [TestClass]
    public class DAOJabatanTes
    {
        private JabatanDAO aDAO = new JabatanDAO();
        [TestMethod]
        public void TestMethodDetail()
        {
            int id = 0;
            JABATAN expectResult = null;
            JABATAN result = aDAO.Detail(id);

            Assert.AreEqual(expectResult, result);
        }

        [TestMethod]
        public void TestMethodDetail2()
        {
            int id = 1;
            JABATAN result = aDAO.Detail(id);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestMethodDetail3()
        {
            int id = 01;
            JABATAN result = aDAO.Detail(id);
            Assert.IsNotNull(result);
        }
        [TestMethod]//okpass
        public void TestMethodJabatanBenar()
        {
            int id = 1;
            var det = aDAO.Detail(id);
            Assert.AreEqual("Staff", det.NAMA_JABATAN);
        }
        [TestMethod]//okpass
        public void TestGetall()
        {
            Assert.IsNotNull(aDAO.getAll());
        }
        [TestMethod]//oktes+db
        public void TesTambahJabatanbenar()
        {
            JABATAN det = new JABATAN();
            det.NAMA_JABATAN = "Staff";
            det.DIBUAT_OLEH = "saya";
            det.DIBUAT_PADA = DateTime.Now;
            int a = aDAO.Add(det);

            Assert.IsNotNull(a);

        }
        [TestMethod]//okpass+db
        public void TesTambahJabatanGagal()
        {
            JABATAN det = new JABATAN();
            det.NAMA_JABATAN = "Programmer";
            int a = aDAO.Add(det);

            Assert.IsNotNull(a);
        }
        [TestMethod]//oktess+db
        public void TesEditJabatanbenar()
        {
            JABATAN det = aDAO.Detail(2);
            Assert.IsNotNull(det);
            det.NAMA_JABATAN = "wak";
            var a = aDAO.Edit(2, det);

            Assert.AreEqual(1, a);
        }
        [TestMethod]//oktess+db
        public void TesEditJabatanSalah()
        {
            JABATAN det = aDAO.Detail(0);
            Assert.IsNotNull(det);
            det.NAMA_JABATAN = "wakawk";
            var a = aDAO.Edit(0, det);

            Assert.AreEqual(0, a);
        }
        [TestMethod]//oktes+db
        public void TesDeleteJabatanbenar()
        {
            JABATAN det = aDAO.Detail(17);
            Assert.IsNotNull(det);
            bool isPermanent = false;

            var a = aDAO.Delete(17, false);
        }
    }
}
