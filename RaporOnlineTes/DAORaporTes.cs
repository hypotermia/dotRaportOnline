using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raport_Online;

namespace RaporOnlineTes
{
    [TestClass]
    public class DAORaporTes
    {
        RaporDAO rap = new RaporDAO();
        [TestMethod]
        public void TestMethodDetail()
        {
            int id = 0;
            RAPOR expectResult = null;
            RAPOR result = rap.detail(id);

            Assert.AreEqual(expectResult, result);
        }

        [TestMethod]
        public void TestMethodDetail2()
        {
            int id = 1;
            RAPOR result = rap.detail(id);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestMethodDetail3()
        {
            int id = 01;
            RAPOR result = rap.detail(id);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestMethodTambah()
        {
            RAPOR rapor = new RAPOR();
            rapor.ID_RAPOR = 1;
            int a = rap.add(rapor);


            Assert.IsNotNull(a);

        }
    }
}
