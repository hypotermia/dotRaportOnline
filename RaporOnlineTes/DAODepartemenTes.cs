using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raport_Online;

namespace RaporOnlineTes
{
    [TestClass]
    public class DAODepartemenTes
    {
        DepartemenDAO aDAO = new DepartemenDAO();
        [TestMethod]
        public void TestTampilDetailSalah()
        {
            int id = 0;
            DEPARTEMEN expectResult = null;
            DEPARTEMEN result = aDAO.Detail(id);

            Assert.AreEqual(expectResult, result);
        }

        [TestMethod]//oktes+db
        public void TestTampilDetailbenar()
        {
            int id = 1;
            DEPARTEMEN result = aDAO.Detail(id);

            Assert.IsNotNull(result);
        }
        [TestMethod]//okpass
        public void TestMethodDetailBenar()
        {
            int id = 1;
            DEPARTEMEN dep = aDAO.Detail(id);
            Assert.AreEqual("ubah lagi ya", dep.NAMA_DEPARTEMEN);
        }
        [TestMethod]//okpass
        public void TestGetall()
        {
            Assert.IsNotNull(aDAO.GetAll());
        }

        [TestMethod]//oktes+db
        public void TestTambahDepartemenbenar()
        {
            DEPARTEMEN dep = new DEPARTEMEN();
            dep.NAMA_DEPARTEMEN = "HR";
            int a = aDAO.Add(dep);

            Assert.IsNotNull(a);

        }
        [TestMethod]//okpass+db
        public void TambahDepartemenGagal()
        {
            DEPARTEMEN dep = new DEPARTEMEN();
            dep.ID_DEPARTEMEN = 1;
            dep.NAMA_DEPARTEMEN = "HR";
            int a = aDAO.Add(dep);

            Assert.IsNotNull(a);
        }
        [TestMethod]//oktess+db
        public void TesEditDepartbenar()
        {
            DEPARTEMEN depart = aDAO.Detail(2);
            Assert.IsNotNull(depart);
            depart.ID_DEPARTEMEN = 1;
            depart.NAMA_DEPARTEMEN = "hr";
            depart.DIUBAH_OLEH = "saya";
            depart.DIUBAH_PADA = DateTime.Now;
            var a = aDAO.Edit(2, depart);

            Assert.AreEqual(1, a);
        }
        //[TestMethod]//oktess+db
        public void TesEditDepartSalah()
        {
            DEPARTEMEN depart = aDAO.Detail(0);
            Assert.IsNotNull(depart);
            depart.ID_DEPARTEMEN = 1;
            depart.NAMA_DEPARTEMEN = "hr";
            depart.DIUBAH_OLEH = "saya";
            depart.DIUBAH_PADA = DateTime.Now;
            var a = aDAO.Edit(0, depart);

            Assert.AreEqual(0, a);
        }
        //[TestMethod]//oktess+db
        //public void TesEditAspectSalah2()
        //{
        //    ASPEK aspek = aDAO.Detail(2);
        //    Assert.IsNotNull(aspek);
        //    aspek.NAMA_ASPEK = "Komplit pake banget";
        //    aspek.DIUBAH_OLEH = "suci";
        //    aspek.DIUBAH_PADA = DateTime.Now;
        //    aspek.STATUS_AKTIF = true;
        //    var a = aDAO.Edit(2, aspek);

        //    Assert.AreEqual(2, a);
        //}
        [TestMethod]//oktes+db
        public void TesDeleteDepartbenar()
        {
            DEPARTEMEN depart = aDAO.Detail(17);
            Assert.IsNotNull(depart);
            bool isPermanent = false;

            var a = aDAO.Delete(17, false);
        }
        //[TestMethod]//oktes+db
        //public void TesDeleteAspeksalah()
        //{
        //    ASPEK aspek = aDAO.Detail(4);
        //    Assert.IsNull(aspek);
        //    bool isPermanent = false;

        //    var a = aDAO.Delete(4, false);
        //}


    }
}