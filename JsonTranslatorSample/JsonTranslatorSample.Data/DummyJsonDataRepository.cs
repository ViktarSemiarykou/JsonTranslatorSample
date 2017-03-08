using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonTranslatorSample.Data.Dto;
using Newtonsoft.Json;

namespace JsonTranslatorSample.Data
{
    public class DummyJsonDataRepository : IDataRepository
    {
        private string _dataFilePath;

        public DummyJsonDataRepository(string dataFilePath)
        {
            _dataFilePath = dataFilePath;
        }

        public async Task<DataObject> GetAsync()
        {
            using (var reader = File.OpenText(_dataFilePath))
            {
                var json = await reader.ReadToEndAsync();
                return JsonConvert.DeserializeObject<DataObject>(json);
            }
        }
    }
}
