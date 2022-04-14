using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BITBackEndApp;
using BITBackEndApp.ViewModels;
using BITBackEndApp.Models;
using System.Collections.ObjectModel;

namespace UnitTestProject1
{
    [TestClass]
    public class BITCoordinatorUnitTest
    {
        [TestMethod]
        public void TestCoordinatorCollection()
        {
            CoordinatorVIewModel coodinatorVM = new CoordinatorVIewModel();
            int count = coodinatorVM.Coordinators.Count;
            Assert.AreEqual(2, count);
        }
        [TestMethod]
        public void TestCoordinatorObject()
        {
            DateTime bday = new DateTime(2002, 11, 16);
            Coordinator coordinator = new Coordinator
            {
                CoordinatorId = 14,
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
            Assert.AreEqual("Abbass", coordinator.FirstName);
            Assert.AreEqual("Al-Asadi", coordinator.LastName);
            Assert.AreEqual("11 Marhaba Street", coordinator.Street);
            Assert.AreEqual("Kingsgrove", coordinator.Suburb);
            Assert.AreEqual("2208", coordinator.PostCode);
            Assert.AreEqual("NSW", coordinator.State);
            Assert.AreEqual("0401876555", coordinator.Phone);
            Assert.AreEqual("Abbass@outlook.com", coordinator.Email);
            Assert.AreEqual(bday, coordinator.DOB);
            Assert.AreEqual("hello", coordinator.Password);
        }
    }
}
