//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Raport_Online;

//namespace RaporOnlineTes
//{
//    [TestClass]
//    public class DAOAlamatTes
//    {
//        [TestMethod]
//        public void TestMethod1()
//        {
//        }
//        AlamatDAO alDAO = new AlamatDAO();
//        [TestMethod]
//        public void TestMethodDetail()
//        {
//            int id = 0;
//            ALAMAT expectResult = null;
//            ALAMAT result = alDAO.detail(id);

//            Assert.AreEqual(expectResult, result);
//        }

//        [TestMethod]
//        public void TestMethodDetail2()
//        {
//            int id = 1;
//            ALAMAT result = alDAO.detail(id);
//            Assert.IsNotNull(result);
//        }
//        [TestMethod]
//        public void TestMethodDetail3()
//        {
//            int id = 01;
//            ALAMAT result = alDAO.detail(id);
//            Assert.IsNotNull(result);
//        }
//        public void TestMethodTambahAlamat()
//        {
//            ALAMAT Asp = new ALAMAT();
//            Asp.ID_ALAMAT = 1;
//            int a = alDAO.add(Asp);

            
//            Assert.IsNotNull(a);
            
//        }

//    }
//}