using System;
using System.Diagnostics;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raport_Online;

namespace RaporOnlineTes
{
    [TestClass]
    public class DAOAspekTes
    {
        AspekDAO aDAO = new AspekDAO();
        [Timeout(1000)]
        [TestMethod]
        public void TestTampilDetailSalah()
        {
            int id = 0;
            ASPEK expectResult = null;
            ASPEK result = aDAO.Detail(id);

            Assert.AreEqual(expectResult, result);
            Thread.Sleep(2000);
        }

        [TestMethod]//oktes+db
        public void TestTampilDetailbenar()
        {
            int id = 1;
            ASPEK result = aDAO.Detail(id);

            Assert.IsNotNull(result);
        }
        [TestMethod]//okpass
        public void TestMethodDetailBenar()
        {
            int id = 1;
            ASPEK asp = aDAO.Detail(id);
            Assert.AreEqual("ubah lagi ya", asp.NAMA_ASPEK);
        }
        [TestMethod]//okpass
        public void TestGetall()
        {
            Assert.IsNotNull(aDAO.GetAll());
        }
        [TestMethod]//oktes+db
        public void TestTambahAspekbenar()
        {
            ASPEK Asp = new ASPEK();
            /*Asp.ID_ASPEK = 1;*/
            Asp.NAMA_ASPEK = "aspek";
            Asp.DIBUAT_OLEH = "Zakki";
            Asp.DIBUAT_PADA = DateTime.Now;
            Asp.STATUS_AKTIF = true;
            int a = aDAO.Add(Asp);
           
            Assert.IsNotNull(a);

        }
        [TestMethod]//okpass+db
        public void TambahAspekGagal()
        {
            ASPEK Asp = new ASPEK();
            Asp.ID_ASPEK = 17;
            Asp.NAMA_ASPEK = "aspek";
            Asp.DIBUAT_OLEH = "Zakki";
            Asp.DIBUAT_PADA = DateTime.Now;
            Asp.STATUS_AKTIF = true;
            int a = aDAO.Add(Asp);

            Assert.IsNotNull(a);
        }
        [TestMethod]//oktess+db
        public void TesEditAspectbenar()
        {
            ASPEK aspek = aDAO.Detail(2);
            Assert.IsNotNull(aspek);
            aspek.NAMA_ASPEK = "ubah lagi ya";
            aspek.DIUBAH_OLEH = "suci f";
            aspek.DIUBAH_PADA = DateTime.Now;
            aspek.STATUS_AKTIF = true;
            var a = aDAO.Edit(2, aspek);

            Assert.AreEqual(1, a);
        }
        [TestMethod]//oktess+db
        public void TesEditAspectSalah()
        {
            ASPEK aspek = aDAO.Detail(0);
            Assert.IsNotNull(aspek);
            aspek.NAMA_ASPEK = "Komplit pake banget";
            aspek.DIUBAH_OLEH = "suci";
            aspek.DIUBAH_PADA = DateTime.Now;
            aspek.STATUS_AKTIF = true;
            var a = aDAO.Edit(0, aspek);

            Assert.AreEqual(0, a);
        }
        [TestMethod]//oktess+db
        public void TesEditAspectSalah2()
        {
            ASPEK aspek = aDAO.Detail(2);
            Assert.IsNotNull(aspek);
            aspek.NAMA_ASPEK = "Komplit pake banget";
            aspek.DIUBAH_OLEH = "suci";
            aspek.DIUBAH_PADA = DateTime.Now;
            aspek.STATUS_AKTIF = true;
            var a = aDAO.Edit(2, aspek);

            Assert.AreEqual(2, a);
        }
        [TestMethod]//oktes+db
        public void TesDeleteAspekbenar()
        {
            ASPEK aspek = aDAO.Detail(17);
            Assert.IsNotNull(aspek);
            bool isPermanent = false;
           
            var a = aDAO.Delete(17, false);
        }
       
    }
}