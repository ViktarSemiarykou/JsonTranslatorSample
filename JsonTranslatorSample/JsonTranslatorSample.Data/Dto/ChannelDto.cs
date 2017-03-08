using Newtonsoft.Json;

namespace JsonTranslatorSample.Data.Dto
{
    public class ChannelDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
