using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raport_Online;

namespace RaporOnlineTes
{
    [TestClass]
    public class DAODetailAspekTes
    {
        
        DetailAspekDAO detail = new DetailAspekDAO();
        [TestMethod]
        public void TestMethodDetail()
        {
            int id = 0;
            DETAIL_ASPEK expectResult = null;
            DETAIL_ASPEK result = detail.detail(id);

            Assert.AreEqual(expectResult, result);
        }

        [TestMethod]
        public void TestMethodDetail2()
        {
            int id = 1;
            DETAIL_ASPEK result = detail.detail(id);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestMethodDetail3()
        {
            int id = 01;
            DETAIL_ASPEK result = detail.detail(id);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestMethodTambah()
        {

            DETAIL_ASPEK DetAs = new DETAIL_ASPEK();
            DetAs.ID_DETAIL= 1;
            int a = detail.add(DetAs);

            Assert.IsNotNull(a);
        }
    }
}