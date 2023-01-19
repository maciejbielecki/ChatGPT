using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ChatGPT.Models
{
    public class GptChoice
    {
        [JsonProperty("text")]
        [JsonPropertyName("text")]
        public string Text { get; set; }
        [JsonProperty("index")]
        [JsonPropertyName("index")]
        public int Index { get; set; }
        [JsonProperty("logprobs")]
        [JsonPropertyName("logprobs")]
        public object Logprobs { get; set; }
        [JsonProperty("finish_reason")]
        [JsonPropertyName("finish_reason")]
        public string FinishReason { get; set; }
    }
}
