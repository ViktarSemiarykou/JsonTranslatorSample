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
        public async Task<DataObject> GetAsync()
        {
            using (var reader = File.OpenText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Content\Data.json")))
            {
                var json = await reader.ReadToEndAsync();
                return JsonConvert.DeserializeObject<DataObject>(json);
            }
        }
    }
}
