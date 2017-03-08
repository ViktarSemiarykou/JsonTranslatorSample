using System;
using System.IO;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JsonTranslatorSample.Controllers;
using JsonTranslatorSample.Data;
using JsonTranslatorSample.Service;

namespace JsonTranslatorSample.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            var controller = new HomeController(new DummyJsonDataService(new DummyJsonDataRepository(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Content\Data.json"))));

            // Act
            var result = controller.Index().Result as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
