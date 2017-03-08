using System.Collections.Generic;
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
