using System.Collections.Generic;
using System.Threading.Tasks;
using JsonTranslatorSample.Service.Models;

namespace JsonTranslatorSample.Service
{
    public interface IDataService
    {
        Task<List<Message>> GetMessagesAsync();
    }
}
