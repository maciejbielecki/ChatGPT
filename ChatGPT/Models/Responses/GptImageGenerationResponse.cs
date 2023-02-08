using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ChatGPT.Models.Responses
{
    public class GptImageGenerationResponse
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

        [JsonProperty("b64_json")]
        [JsonPropertyName("b64_json")]
        public string Base64 { get; set; }
    }
}
