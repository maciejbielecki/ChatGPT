using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ChatGPT.Models.Responses
{
    public class CompletionsResponse
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonProperty("object")]
        [JsonPropertyName("object")]
        public string Object { get; set; }
        [JsonProperty("created")]
        [JsonPropertyName("created")]
        public int Created { get; set; }
        [JsonProperty("model")]
        [JsonPropertyName("model")]
        public string Model { get; set; }
        [JsonProperty("choices")]
        [JsonPropertyName("choices")]
        public List<GptChoice> Choices { get; set; }
        [JsonProperty("usage")]
        [JsonPropertyName("usage")]
        public GptUsage Usage { get; set; }
    }
}
