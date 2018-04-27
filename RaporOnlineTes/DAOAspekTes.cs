using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raport_Online;

namespace RaporOnlineTes
{
    [TestClass]
    public class DAOAspekTes
    {
        [TestMethod]
        public void TestMethod1()
        {
            int id = 0;
            AspekDAO aDAO = new AspekDAO();
            ASPEK expectResult = null;
            ASPEK result = aDAO.detail(id);

            Assert.AreEqual(expectResult, result);
        }
        
        [TestMethod]
        public void TestMethod2()
        {
            int id = 1;
            AspekDAO aDAO = new AspekDAO();
            //ASPEK expectResult = null;
            ASPEK result = aDAO.detail(id);
            
            Assert.IsNotNull(result);
        }

        public void TestTambah()
        {
            int id = 1;

        }
    }
}
