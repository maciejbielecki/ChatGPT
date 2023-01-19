using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ChatGPT.Models
{
    public class GptModel
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
        [JsonProperty("owned_by")]
        [JsonPropertyName("owned_by")]
        public string OwnedBy { get; set; }
        [JsonProperty("permission")]
        [JsonPropertyName("permission")]
        public List<GptPermission> Permission { get; set; }
        [JsonProperty("root")]
        [JsonPropertyName("root")]
        public string Root { get; set; }
        [JsonProperty("parent")]
        [JsonPropertyName("parent")]
        public object Parent { get; set; }

    }
}
