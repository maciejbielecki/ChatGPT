using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ChatGPT.Models.Requests
{
    public class ImageGenerationRequest
    {
        public ImageGenerationRequest()
        {

        }

        public ImageGenerationRequest(string prompt, int n = 1, string size = "1024x1024")
        {
            Prompt = prompt;
            N = n;
            Size = size;
        }

        [JsonProperty("prompt")]
        [JsonPropertyName("prompt")]
        public string Prompt { get; set; }

        [JsonProperty("n")]
        [JsonPropertyName("n")]
        public int N { get; set; } = 1; //1-10

        [JsonProperty("size")]
        [JsonPropertyName("size")]
        public string Size { get; set; } = "1024x1024"; //Must be one of 256x256, 512x512, or 1024x1024
    }
}
