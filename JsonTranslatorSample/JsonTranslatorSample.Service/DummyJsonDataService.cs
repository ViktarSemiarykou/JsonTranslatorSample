using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Threading.Tasks;
using JsonTranslatorSample.Data;
using JsonTranslatorSample.Service.Models;

namespace JsonTranslatorSample.Service
{
    public class DummyJsonDataService : IDataService
    {
        private IDataRepository _repository;

        public DummyJsonDataService(IDataRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Message>> GetMessagesAsync()
        {
            var data = await _repository.GetAsync();

            var result = new List<Message>();

            foreach (var messageDto in data.Messages)
            {
                var channelDto = data.Channels.FirstOrDefault(c => c.Id.Equals(messageDto.ChannelId));

                if (channelDto == null)
                {
                    throw new InstanceNotFoundException($"Channel with {messageDto.ChannelId} not found.");
                }

                var message = new Message
                {
                    Id = messageDto.Id,
                    Subject = messageDto.Subject,
                    Date = messageDto.Date,
                    Channel = new Channel { Id = channelDto.Id, Name = channelDto.Name }
                };

                result.Add(message);
            }

            return result;
        }
    }
}
