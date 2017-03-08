using System;
using Newtonsoft.Json;

namespace JsonTranslatorSample.Data.Dto
{
    public class MessageDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("channelId")]
        public int ChannelId { get; set; }
    }
}
