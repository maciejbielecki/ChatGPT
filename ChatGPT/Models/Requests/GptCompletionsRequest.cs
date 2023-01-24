using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ChatGPT.Models.Requests
{
    public class GptCompletionsRequest
    {
        public GptCompletionsRequest()
        {

        }

        public GptCompletionsRequest(string prompt, string model)
        {
            Prompt = prompt;
            Model = model;
        }

        public GptCompletionsRequest(string prompt)
        {
            Prompt = prompt;
        }

        public GptCompletionsRequest(string model, string prompt, int temperature, int maxTokens)
        {
            Model = model;
            Prompt = prompt;
            Temperature = temperature;
            MaxTokent = maxTokens;
        }

        [JsonProperty("model")]
        [JsonPropertyName("model")]
        public string Model { get; set; } = "text-davinci-003";
        [JsonProperty("prompt")]
        [JsonPropertyName("prompt")]
        public string Prompt { get; set; }
        [JsonProperty("temperature")]
        [JsonPropertyName("temperature")]

        public int Temperature { get; set; } = 0;
        [JsonProperty("max_tokens")]
        [JsonPropertyName("max_tokens")]
        public int MaxTokent { get; set; } = 2000;

        [JsonProperty("top_p")]
        public int TopP { get; set; } = 1;

        [JsonProperty("n")]
        public int N { get; set; } = 1;

        [JsonProperty("stream")]
        public bool Stream { get; set; } = false;

        [JsonProperty("logprobs")]
        public int? Logprobs { get; set; } = null;

        [JsonProperty("stop")]
        public string Stop { get; set; } = null;

        [JsonProperty("best_of")]
        public int BestOf { get; set; } = 1;

        [JsonProperty("echo")]
        public bool Echo { get; set; } = true;
    }
}
