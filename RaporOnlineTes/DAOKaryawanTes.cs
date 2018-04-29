using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raport_Online;

namespace RaporOnlineTes
{
    [TestClass]
    public class DAOKaryawanTes
    {
        KaryawanDAO karyawan = new KaryawanDAO();
        [TestMethod]
        public void TestMethodDetail()
        {
            int id = 0;
            KARYAWAN expectResult = null;
            KARYAWAN result = karyawan.detail(id);

            Assert.AreEqual(expectResult, result);
        }

        [TestMethod]
        public void TestMethodDetail2()
        {
            int id = 1;
            KARYAWAN result = karyawan.detail(id);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestMethodDetail3()
        {
            int id = 01;
            KARYAWAN result = karyawan.detail(id);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestMethodTambah()
        {
            KARYAWAN dept = new KARYAWAN();
            dept.ID_DEPARTEMEN = 1;
            int a = karyawan.add(dept);


            Assert.IsNotNull(a);

        }
    }
}
