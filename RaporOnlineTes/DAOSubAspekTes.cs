using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raport_Online;

namespace RaporOnlineTes
{
    [TestClass]
    public class DAOSubAspekTes
    {
        private SubAspekDAO aDAO = new SubAspekDAO();
        public void TestMethodDetail()
        {
            int id = 0;
            SUB_ASPEK expectResult = null;
            SUB_ASPEK result = aDAO.Detail(id);

            Assert.AreEqual(expectResult, result);
        }

        [TestMethod]
        public void TestMethodDetail2()
        {
            int id = 1;
            SUB_ASPEK result = aDAO.Detail(id);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestMethodDetail3()
        {
            int id = 01;
            SUB_ASPEK result = aDAO.Detail(id);
            Assert.IsNotNull(result);
        }
        [TestMethod]//okpass
        public void TestMethodBenar()
        {
            int id = 1;
            var det = aDAO.Detail(id);
            Assert.AreEqual("subaspek", det.NAMA_SUBASPEK);
        }
        [TestMethod]//okpass
        public void TestGetall()
        {
            Assert.IsNotNull(aDAO.GetAll());
        }
        [TestMethod]//oktes+db
        public void TesTambahbenar()
        {
            SUB_ASPEK det = new SUB_ASPEK();
            det.NAMA_SUBASPEK = "SubaspekA";
            int a = aDAO.Add(det);


            Assert.IsNotNull(a);

        }
        [TestMethod]//okpass+db
        public void TesTambahGagal()
        {
            SUB_ASPEK det = new SUB_ASPEK();
            det.NAMA_SUBASPEK = "Sub";
            
            int a = aDAO.Add(det);
            Trace.WriteLine(det.ID_ASPEK);
          

            Assert.IsNotNull(a);
        }
        [TestMethod]//oktess+db
        public void TesEditbenar()
        {
            SUB_ASPEK det = aDAO.Detail(2);
            Assert.IsNotNull(det);
            det.NAMA_SUBASPEK = "SUBB";
            var a = aDAO.Edit(2, det);

            Assert.AreEqual(1, a);
        }
        [TestMethod]//oktess+db
        public void TesEditSalah()
        {
            SUB_ASPEK det = aDAO.Detail(0);
            Assert.IsNotNull(det);
            det.NAMA_SUBASPEK = "SUBBB";
            var a = aDAO.Edit(0, det);

            Assert.AreEqual(0, a);
        }
        [TestMethod]//oktes+db
        public void TesDeletebenar()
        {
            SUB_ASPEK det = aDAO.Detail(17);
            Assert.IsNotNull(det);
            bool isPermanent = false;

            var a = aDAO.Delete(17, false);
        }
    }
}
