using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JsonTranslatorSample.Data.Dto
{
    public class DataObject
    {
        [JsonProperty("messages")]
        public List<MessageDto> Messages { get; set; }

        [JsonProperty("channels")]
        public List<ChannelDto> Channels { get; set; }
    }
}
