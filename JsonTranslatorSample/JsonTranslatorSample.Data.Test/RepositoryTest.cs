using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JsonTranslatorSample.Data.Test
{
    [TestClass]
    public class RepositoryTest
    {
        [TestMethod]
        public async void CheckJsonConverters()
        {
            var rep = new DummyJsonDataRepository(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Content\Data.json"));

            var data = await rep.GetAsync();

            Assert.IsNotNull(data);
            Assert.IsTrue(data.Messages.Count.Equals(3));
            Assert.IsTrue(data.Channels.Count.Equals(2));
        }
    }
}
