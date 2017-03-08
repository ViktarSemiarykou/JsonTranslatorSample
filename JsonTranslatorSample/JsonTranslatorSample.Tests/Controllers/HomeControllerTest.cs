using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JsonTranslatorSample;
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
            HomeController controller = new HomeController(new DummyJsonDataService(new DummyJsonDataRepository(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Content\Data.json"))));

            // Act
            ViewResult result = controller.Index().Result as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
