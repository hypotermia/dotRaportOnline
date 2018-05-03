using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raport_Online;

namespace RaporOnlineTes
{
    [TestClass]
    public class DAOKaryawanTes
    {
        private KaryawanDAO aDAO = new KaryawanDAO();
        
        [TestMethod]
        public void TestTampilDetailByIDBenar()
        {
            int id = 1;
            KARYAWAN result = aDAO.Detail(id);
            Assert.IsNotNull(result);
        }
        [TestMethod]//okpass
        public void TestTampilByNamaBenar()
        {
            int id = 1;
            var det = aDAO.Detail(id);
            Assert.AreEqual("Ayu", det.NAMA_LENGKAP);
        }
        [TestMethod]//okpass
        public void TestGetall()
        {
            Assert.IsNotNull(aDAO.getAll());
        }
        [TestMethod]//oktes+db
        public void TesTambahKarybenar()
        {
            KARYAWAN det = new KARYAWAN();
            det.NAMA_LENGKAP = "Saya";
            det.JENIS_KELAMIN = "apa";
            det.AGAMA = "Islam";
            det.STATUS_PERKAWINAN = "Belum";
            det.PENDIDIKAN = "S1 Manajemen";
            int a = aDAO.Add(det);
            Trace.WriteLine(det.ID_JABATAN);
            Trace.WriteLine(det.ID_DEPARTEMEN);
            
            Assert.IsNotNull(a);
        }
        [TestMethod]//okpass+db
        public void TesTambahKaryGagal()
        {
            KARYAWAN det = new KARYAWAN();
            det.NAMA_LENGKAP = "Programmer";
            int a = aDAO.Add(det);
            Trace.WriteLine(det.ID_JABATAN);
            Trace.WriteLine(det.ID_DEPARTEMEN);
            Assert.IsNotNull(a);
        }
        [TestMethod]//oktess+db
        public void TesEditKarybenar()
        {
            KARYAWAN det = aDAO.Detail(2);
            Assert.IsNotNull(det);
            det.NAMA_LENGKAP = "wak";
            var a = aDAO.Edit(2, det);
            Assert.AreEqual(1, a);
        }
        [TestMethod]//oktess+db
        public void TesEditKarySalah()
        {
            KARYAWAN det = aDAO.Detail(0);
            Assert.IsNotNull(det);
            det.NAMA_LENGKAP = "wakawk";
            var a = aDAO.Edit(0, det);

            Assert.AreEqual(0, a);
        }
        [TestMethod]//oktes+db
        public void TesDeleteKarybenar()
        {
            KARYAWAN det = aDAO.Detail(17);
            Assert.IsNotNull(det);
            bool isPermanent = false;

            var a = aDAO.Delete(17, false);
        }
    }
}
