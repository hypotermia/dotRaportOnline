using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raport_Online;

namespace RaporOnlineTes
{
    [TestClass]
    public class DAOAspekTes
    {
        AspekDAO aDAO = new AspekDAO();
        [TestMethod]
        public void TestMethodDetail()
        {
            int id = 0;
            ASPEK expectResult = null;
            ASPEK result = aDAO.detail(id);

            Assert.AreEqual(expectResult, result);
        }
        
        [TestMethod]
        public void TestMethodDetail2()
        {
            int id = 1;
            ASPEK result = aDAO.detail(id);
            
            Assert.IsNotNull(result);
        }
<<<<<<< HEAD

        public void TestTambah()
        {
            int id = 1;

        }
||||||| merged common ancestors
=======
        public void TestMethodTambahBerhasil()
        {
            ASPEK Asp = new ASPEK();
            ASPEK expectResult = null;
            var result = aDAO.add(Asp);

            Assert.AreEqual(-1, result);
        }
>>>>>>> 9e1c3cf39c9166cfcd138000dc91de118e3dd145
    }
}
