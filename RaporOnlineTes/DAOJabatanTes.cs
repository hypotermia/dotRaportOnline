using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raport_Online;

namespace RaporOnlineTes
{
    [TestClass]
    public class DAOJabatanTes
    {
        JabatanDAO jabatan = new JabatanDAO();
        [TestMethod]
        public void TestMethodDetail()
        {
            int id = 0;
            JABATAN expectResult = null;
            JABATAN result = jabatan.detail(id);

            Assert.AreEqual(expectResult, result);
        }

        [TestMethod]
        public void TestMethodDetail2()
        {
            int id = 1;
            JABATAN result = jabatan.detail(id);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestMethodDetail3()
        {
            int id = 01;
            JABATAN result = jabatan.detail(id);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestMethodTambah()
        {
            JABATAN dept = new JABATAN();
            dept.ID_JABATAN = 1;
            int a = jabatan.add(dept);


            Assert.IsNotNull(a);

        }
    }
}
