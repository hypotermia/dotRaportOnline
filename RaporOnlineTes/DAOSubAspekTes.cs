using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raport_Online;

namespace RaporOnlineTes
{
    [TestClass]
    public class DAOSubAspekTes
    {
        SubAspekDAO subaspek = new SubAspekDAO();
        [TestMethod]
        public void TestMethodDetail()
        {
            int id = 0;
            SUB_ASPEK expectResult = null;
            SUB_ASPEK result = subaspek.detail(id);

            Assert.AreEqual(expectResult, result);
        }

        [TestMethod]
        public void TestMethodDetail2()
        {
            int id = 1;
            SUB_ASPEK result = subaspek.detail(id);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestMethodDetail3()
        {
            int id = 01;
            SUB_ASPEK result = subaspek.detail(id);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestMethodTambah()
        {
            SUB_ASPEK subAs = new SUB_ASPEK();
            subAs.ID_SUB = 1;
            int a = subaspek.add(subAs);


            Assert.IsNotNull(a);

        }
    }
}
