using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raport_Online;

namespace RaporOnlineTes
{
    [TestClass]
    public class DAODepartemenTes
    {

        DepartemenDAO depart = new DepartemenDAO();
        [TestMethod]
        public void TestMethodDetail()
        {
            int id = 0;
            DEPARTEMEN expectResult = null;
            DEPARTEMEN result = depart.detail(id);

            Assert.AreEqual(expectResult, result);
        }

        [TestMethod]
        public void TestMethodDetail2()
        {
            int id = 1;
            DEPARTEMEN result = depart.detail(id);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestMethodDetail3()
        {
            int id = 01;
            DEPARTEMEN result = depart.detail(id);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestMethodTambah()
        {
            DEPARTEMEN dept = new DEPARTEMEN();
            dept.ID_DEPARTEMEN = 1;
            int a = depart.add(dept);


            Assert.IsNotNull(a);

        }
        //[TestMethod]
        //public void TestMethodEdit()
        //{
        //    DEPARTEMEN dept = new DEPARTEMEN();
        //    dept.ID_DEPARTEMEN = 1;
        //    int a = depart.edit(dept);

        //    Assert.IsNotNull(a);

        //}

    }
}
