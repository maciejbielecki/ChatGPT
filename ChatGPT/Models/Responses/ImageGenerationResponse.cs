using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ChatGPT.Models.Responses
{
    public class ImageGenerationResponse
    {
        [JsonProperty("created")]
        [JsonPropertyName("created")]
        public int Created { get; set; }
        [JsonProperty("data")]
        [JsonPropertyName("data")]
        public List<ImageGenerationUrl> Data { get; set; }
    }

    public class ImageGenerationUrl
    {
        [JsonProperty("url")]
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
