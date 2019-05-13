using System;
using NUnit.Framework;
using Moq;
using reportingapiexercise.Interfaces;
using reporting_api_exercise.Controllers;

namespace ReportingControllerTests
{
    [TestFixture]
    public class ReportingControllerTests
    {
        private Mock<IJsonManager> _moqJsonManager;
        private Mock<IReportingManager> _moqReportingManager;
        private ReportingController _controller;

        [SetUp]
        public void BeforeEachTest()
        {
            _moqJsonManager = new Mock<IJsonManager>(MockBehavior.Strict);
            _moqReportingManager = new Mock<IReportingManager>(MockBehavior.Strict);
            _controller = new ReportingController(_moqJsonManager.Object, _moqReportingManager.Object);
        }

        public void ReportingControllerReturnsAnInteger()
        {
            //var integer = _controller.GetOrderedPrices(business_id);
            //Assert.IsTrue;
        }
    }

}
