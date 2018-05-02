using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raport_Online;

namespace RaporOnlineTes
{
    [TestClass]
    public class DAOAlamatTes
    {
        AlamatDAO aDAO = new AlamatDAO();
        [TestMethod]
        public void TestTampilDetailSalah()
        {
            int id = 0;
            ALAMAT expectResult = null;
            ALAMAT result = aDAO.Detail(id);

            Assert.AreEqual(expectResult, result);
        }
        [TestMethod]//oktes+db
        public void TesTampilDetailbenar()
        {
            int id = 1;
            ALAMAT result = aDAO.Detail(id);

            Assert.IsNotNull(result);
        }
        [TestMethod]//okpass
        public void TestGetall()
        {
            Assert.IsNotNull(aDAO.getAll());
        }
        [TestMethod]//oktes+db
        public void TesTambahAlamatbenar()
        {
            ALAMAT alamat = new ALAMAT();
            alamat.ID_KARYAWAN = 1;
            alamat.ID_WILAYAH = 1;
            int a = aDAO.Add(alamat);

            Assert.IsNotNull(a);

        }
        [TestMethod]//okpass+db
        public void TesTambahAlamatGagal()
        {
            ALAMAT alamat = new ALAMAT();
            alamat.ID_KARYAWAN = 1;
            alamat.ID_WILAYAH = 1;
            int a = aDAO.Add(alamat);

            Assert.IsNotNull(a);
        }
        [TestMethod]//oktess+db
        public void TesEditAlamatbenar()
        {
            ALAMAT alamat = aDAO.Detail(2);
            Assert.IsNotNull(alamat);
            alamat.ID_KARYAWAN = 1;
            alamat.ID_WILAYAH = 1;
            var a = aDAO.Edit(2, alamat);

            Assert.AreEqual(1, a);
        }
        [TestMethod]//oktess+db
        public void TesEditAlamatSalah()
        {
            ALAMAT alamat = aDAO.Detail(0);
            Assert.IsNotNull(alamat);
            alamat.ID_KARYAWAN = 1;
            alamat.ID_WILAYAH = 1;
            var a = aDAO.Edit(0, alamat);

            Assert.AreEqual(0, a);
        }
        [TestMethod]//oktes+db
        public void TesDeleteAlamatbenar()
        {
            ALAMAT alamat = aDAO.Detail(17);
            Assert.IsNotNull(alamat);
            bool isPermanent = false;

            var a = aDAO.Delete(17, false);
        }

    }
}