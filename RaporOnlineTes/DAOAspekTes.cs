﻿using System;
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
        public void TestMethodBenarDetail2()
        {
            int id = 1;
            ASPEK result = aDAO.detail(id);

            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestMethodDetail3()
        {
            int id = 01;
            ASPEK result = aDAO.detail(id);

            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestMethodTambahAspek()
        {
            ASPEK Asp = new ASPEK();
            Asp.ID_ASPEK = 1;
            int a = aDAO.add(Asp);
           
            Assert.IsNotNull(a);
            
        }


    }
}
