using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BITBackEndApp;
using BITBackEndApp.ViewModels;
using BITBackEndApp.Models;

namespace UnitTestProject1
{
    [TestClass]
    public class BITRequestUnitTest
    {
        [TestMethod]
        public void TestRequestCollection()
        {
            RequestViewModel reqVM = new RequestViewModel();
            int count = reqVM.Requests.Count;
            Assert.AreEqual(7, count);
        }

        [TestMethod]
        public void TestRequestObject()
        {
            DateTime jobDay = new DateTime(2020, 12, 17);
            Request request = new Request
            {
                RequestId = 1051,
                CoordinatorId = 6,
                LocationId = 2,
                Kilometers = 0,
                ContractorId = 6,
                ClientId = 15,
                Status = "Booked",
                SkillName = "Computer Build",
                DayOfJob = jobDay,
                RequestTime = "13:00",
                ReqEndTime = "14:00",
            };
            Assert.AreEqual("Booked", request.Status);
            Assert.AreEqual(1051, request.RequestId);

        }
    }
}
