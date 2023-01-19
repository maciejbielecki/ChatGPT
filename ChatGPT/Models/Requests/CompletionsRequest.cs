using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ChatGPT.Models.Requests
{
    public class CompletionsRequest
    {
        public CompletionsRequest()
        {

        }

        public CompletionsRequest(string model, string prompt, int temperature, int maxTokens)
        {
            Model = model;
            Prompt = prompt;
            Temperature = temperature;
            MaxTokent = maxTokens;
        }

        [JsonProperty("model")]
        [JsonPropertyName("model")]
        public string Model { get; set; }
        [JsonProperty("prompt")]
        [JsonPropertyName("prompt")]
        public string Prompt { get; set; }
        [JsonProperty("temperature")]
        [JsonPropertyName("temperature")]

        public int Temperature { get; set; } = 0;
        [JsonProperty("max_tokens")]
        [JsonPropertyName("max_tokens")]
        public int MaxTokent { get; set; }

        //[JsonProperty("top_p")]
        //public int TopP { get; set; } = 1;

        //[JsonProperty("n")]
        //public int N { get; set; } = 1;

        //[JsonProperty("stream")]
        //public bool Stream { get; set; } = false;

        //[JsonProperty("logprobs")]
        //public int? Logprobs { get; set; } = null;

        //[JsonProperty("stop")]
        //public string Stop { get; set; } = "\n";
    }
}
