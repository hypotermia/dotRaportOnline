using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raport_Online;

namespace RaporOnlineTes
{
    [TestClass]
    public class DAOSubAspekTes
    {
        private SubAspekDAO aDAO = new SubAspekDAO();
        public void TestTampilDetailSubasSalah()
        {
            int id = 0;
            SUB_ASPEK expectResult = null;
            SUB_ASPEK result = aDAO.Detail(id);

            Assert.AreEqual(expectResult, result);
        }
        [TestMethod]
        public void TestTampilDetailSubasBenar()
        {
            int id = 1;
            SUB_ASPEK result = aDAO.Detail(id);
            Assert.IsNotNull(result);
        }
        [TestMethod]//okpass
        public void TestTampilSubasByNamaBenar()
        {
            int id = 1;
            var det = aDAO.Detail(id);
            Assert.AreEqual("subaspek", det.NAMA_SUBASPEK);
        }
        [TestMethod]//okpass
        public void TestSubaspekGetall()
        {
            Assert.IsNotNull(aDAO.GetAll());
        }
        [TestMethod]//oktes+db
        public void TesTambahSubaspekbenar()
        {
            SUB_ASPEK det = new SUB_ASPEK();
            det.NAMA_SUBASPEK = "SubaspekA";
            det.DIBUAT_OLEH = "saya";
            det.DIBUAT_PADA = DateTime.Now;
            det.STATUS_AKTIF = true;
            int a = aDAO.Add(det);
            Trace.WriteLine(det.ID_ASPEK);
            Assert.AreEqual(1,a);
        }
        [TestMethod]//kondisi properties tidak diisi dengan lengkap
        [ExpectedException(typeof(DbEntityValidationException))]
        public void TesTambahSubaspekGagal()
        {
            SUB_ASPEK det = new SUB_ASPEK();
            det.NAMA_SUBASPEK = "Sub";
            det.DIBUAT_OLEH = "saya";
            det.DIBUAT_PADA = DateTime.Now;
            int a = aDAO.Add(det);
            Trace.WriteLine(det.ID_ASPEK);
            
        }
        [TestMethod]//oktess+db
        public void TesEditSubaspekbenar()
        {
            SUB_ASPEK det = aDAO.Detail(2);
            Assert.IsNotNull(det);
            det.NAMA_SUBASPEK = "SUBB";
            var a = aDAO.Edit(2, det);

            Assert.AreEqual(1, a);
        }
        [TestMethod]//oktess+db
        public void TesEditSubaspekSalah()
        {
            SUB_ASPEK det = aDAO.Detail(0);
            Assert.IsNotNull(det);
            det.NAMA_SUBASPEK = "SUBBB";
            var a = aDAO.Edit(0, det);

            Assert.AreEqual(0, a);
        }
        [TestMethod]//oktes+db
        public void TesDeleteSubaspekbenar()
        {
            SUB_ASPEK det = aDAO.Detail(17);
            Assert.IsNotNull(det);
            bool isPermanent = false;

            var a = aDAO.Delete(17, false);
        }
    }
}
