using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ChatGPT.Models.Requests
{
    public class GptEditRequest
    {
        public GptEditRequest()
        {

        }

        public GptEditRequest(string model, string input, string instruction, int temperature = 0)
        {
            Model = model;
            Input = input;
            Instruction = instruction;
            Temperature = temperature;
        }

        [JsonProperty("model")]
        [JsonPropertyName("model")]
        public string Model { get; set; }

        [JsonProperty("input")]
        [JsonPropertyName("input")]
        public string Input { get; set; }

        [JsonProperty("instruction")]
        [JsonPropertyName("instruction")]
        public string Instruction { get; set; }
        [JsonProperty("temperature")]
        [JsonPropertyName("temperature")]

        public int Temperature { get; set; } = 0;
    }
}
