using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raport_Online;

namespace RaporOnlineTes
{
    [TestClass]
    public class DAOLoginTes
    {
        LoginDAO login = new LoginDAO();
        [TestMethod]
        public void TestMethodDetail()
        {
            int id = 0;
            LOGIN expectResult = null;
            LOGIN result = login.detail(id);

            Assert.AreEqual(expectResult, result);
        }

        [TestMethod]
        public void TestMethodDetail2()
        {
            int id = 1;
            LOGIN result = login.detail(id);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestMethodDetail3()
        {
            int id = 01;
            LOGIN result = login.detail(id);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestMethodTambah()
        {
            LOGIN log = new LOGIN();
            log.ID_LOGIN= 1;
            int a = login.add(log);


            Assert.IsNotNull(a);

        }
    }
}
