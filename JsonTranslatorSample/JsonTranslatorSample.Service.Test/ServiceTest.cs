using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JsonTranslatorSample.Data;
using JsonTranslatorSample.Data.Dto;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using InstanceNotFoundException = System.Management.Instrumentation.InstanceNotFoundException;

namespace JsonTranslatorSample.Service.Test
{
    [TestClass]
    public class ServiceTest
    {

        private DataObject _validData = new DataObject
        {
            Messages = new List<MessageDto>
            {
                new MessageDto
                {
                    Id = 1,
                    Date = DateTime.Now,
                    Subject = "1",
                    ChannelId = 1
                },
                new MessageDto
                {
                    Id = 2,
                    Date = DateTime.Now,
                    Subject = "2",
                    ChannelId = 1
                }
            },
            Channels = new List<ChannelDto>
            {
                new ChannelDto
                {
                    Id = 1,
                    Name = "Channel1"
                }
            }
        };

        private DataObject _invalidData = new DataObject
        {
            Messages = new List<MessageDto>
            {
                new MessageDto
                {
                    Id = 1,
                    Date = DateTime.Now,
                    Subject = "1",
                    ChannelId = 1
                },
                new MessageDto
                {
                    Id = 2,
                    Date = DateTime.Now,
                    Subject = "2",
                    ChannelId = 1
                }
            },
            Channels = new List<ChannelDto>
            {
                new ChannelDto
                {
                    Id = 2,
                    Name = "Channel1"
                }
            }
        };

        [TestMethod]
        public async void CheckChannelMerging()
        {
            var rep = Substitute.For<IDataRepository>();
            rep.GetAsync().Returns<Task<DataObject>>(Task.FromResult(_validData));
            var service = new DummyJsonDataService(rep);
            var messages = await service.GetMessagesAsync();
            Assert.IsNotNull(messages);
            Assert.IsFalse(messages.Any(m => m.Channel == null));
        }

        [TestMethod]
        public async void CheckChannelMergingOfInvalidData()
        {
            try
            {
                var rep = Substitute.For<IDataRepository>();
                rep.GetAsync().Returns<Task<DataObject>>(Task.FromResult(_invalidData));
                var service = new DummyJsonDataService(rep);
                var messages = await service.GetMessagesAsync();
            }
            catch (InstanceNotFoundException)
            {
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
    }
}
