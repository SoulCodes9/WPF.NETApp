using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BITBackEndApp;
using BITBackEndApp.ViewModels;
using BITBackEndApp.Models;

namespace UnitTestProject1
{
    [TestClass]
    public class BITClientUnitTest
    {
        //Unit Test Case ID: 001
        //This test case will test the ObservableCollection for Client
        [TestMethod]
        public void TestClientCollection()
        {
            ClientViewModel clientVM = new ClientViewModel();
            int count = clientVM.Clients.Count;
            Assert.AreEqual(6, count);
        }

        [TestMethod]
        public void TestClientObject()
        {
            DateTime bday = new DateTime(2002, 11, 16);
            Client client = new Client
            {
                ClientId = 14,
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
            Assert.AreEqual("Abbass", client.FirstName);
            Assert.AreEqual("Al-Asadi", client.LastName);
            Assert.AreEqual("11 Marhaba Street", client.Street);
            Assert.AreEqual("Kingsgrove", client.Suburb);
            Assert.AreEqual("2208", client.PostCode);
            Assert.AreEqual("NSW", client.State);
            Assert.AreEqual("0401876555", client.Phone);
            Assert.AreEqual("Abbass@outlook.com", client.Email);
            Assert.AreEqual(bday, client.DOB);
            Assert.AreEqual("hello", client.Password);
        }
    }
}
