using BITBackEndApp.ViewModels;
using BITBackEndApp.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BITBackEndApp;

namespace UnitTestProject1
{
    [TestClass]
    public class BITContractorUnitTest
    {
        [TestMethod]
        public void TestContractorCollection()
        {
            ContractorViewModel contractorVM = new ContractorViewModel();
            int count = contractorVM.Contractors.Count;
            Assert.AreEqual(4, count);
        }
        [TestMethod]
        public void TestContractorObject()
        {
            DateTime bday = new DateTime(2002, 11, 16);
            Contractor contractor = new Contractor
            {
                ContractorId = 14,
                FirstName = "Abbass",
                LastName = "Al-Asadi",
                Street = "11 Marhaba Street",
                Suburb = "Kingsgrove",
                PostCode = "2208",
                State = "NSW",
                Phone = "0401876555",
                Email = "Abbass@outlook.com",
                DOB = bday,
                Password = "hello",
                Status = "Active"
            };
            Assert.AreEqual("Abbass", contractor.FirstName);
            Assert.AreEqual("Al-Asadi", contractor.LastName);
            Assert.AreEqual("11 Marhaba Street", contractor.Street);
            Assert.AreEqual("Kingsgrove", contractor.Suburb);
            Assert.AreEqual("2208", contractor.PostCode);
            Assert.AreEqual("NSW", contractor.State);
            Assert.AreEqual("0401876555", contractor.Phone);
            Assert.AreEqual("Abbass@outlook.com", contractor.Email);
            Assert.AreEqual(bday, contractor.DOB);
            Assert.AreEqual("hello", contractor.Password);
        }
    }
}
