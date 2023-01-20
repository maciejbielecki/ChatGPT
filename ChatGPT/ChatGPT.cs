using ChatGPT.Models;
using ChatGPT.Models.Requests;
using ChatGPT.Models.Responses;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;

namespace ChatGPT
{
    public class ChatGPT
    {
        private readonly HttpClient _client;
        private const string _openApiOrganization = "org-Oy5TPHeuYK5Fm1yentxadKft";

        public List<List<ChatAnswer>> Conversations { get; set; } = new();

        public ChatGPT(string apiKey)
        {
            _client = HttpClientFactory.Create();
            _client.BaseAddress = new Uri("https://api.openai.com/v1/");
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
            _client.DefaultRequestHeaders.Add("Accept", "application/json");
            _client.DefaultRequestHeaders.Add("OpenAI-Organization", _openApiOrganization);

            if (!Conversations.Any())
            {
                Conversations.Add(new List<ChatAnswer>());
            }
        }

        public async Task<GtpModelsResponse> GetGtpModels()
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "models");

            var response = await _client.SendAsync(request);

            return await response.Content.ReadFromJsonAsync<GtpModelsResponse>();
        }

        public async Task<GptModel> GetGtpModel(string model)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"models/{model}");
            request.Headers.Add("OpenAI-Organization", _openApiOrganization);

            var response = await _client.SendAsync(request);

            return await response.Content.ReadFromJsonAsync<GptModel>();
        }

        public async Task<GptCompletionsResponse> Completions(GptCompletionsRequest obj, string lastRequestId = null)
        {
            var json = JsonConvert.SerializeObject(obj);
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "completions");
            request.Content = new StringContent(json, Encoding.UTF8, "application/json");

            if (!string.IsNullOrEmpty(lastRequestId))
            {
                request.Headers.Add("x-request-id", lastRequestId);
            }

            var response = await _client.SendAsync(request);

            //Console.WriteLine(await response.Content.ReadAsStringAsync());

            return await response.Content.ReadFromJsonAsync<GptCompletionsResponse>();
        }

        public async Task<GptCompletionsResponse> Edits(GptEditRequest obj)
        {
            var json = JsonConvert.SerializeObject(obj);
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "edits");
            request.Content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _client.SendAsync(request);

            return await response.Content.ReadFromJsonAsync<GptCompletionsResponse>();
        }

        public async Task<GptImageGenerationResponse> ImageGeneration(GptImageGenerationRequest obj)
        {
            var json = JsonConvert.SerializeObject(obj);
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "images/generations");
            request.Content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _client.SendAsync(request);

            return await response.Content.ReadFromJsonAsync<GptImageGenerationResponse>();
        }

        public async Task<GptImageGenerationResponse> ImageEdits(GptImageEditRequest obj)
        {
            var json = JsonConvert.SerializeObject(obj);
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "images/edit");

            request.Content = obj.FormData;

            var response = await _client.SendAsync(request);

            Console.WriteLine(await response.Content.ReadAsStringAsync());

            return await response.Content.ReadFromJsonAsync<GptImageGenerationResponse>();
        }
    }
}
