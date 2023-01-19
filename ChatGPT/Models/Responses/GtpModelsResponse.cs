namespace ChatGPT.Models.Responses
{
    public class GtpModelsResponse
    {
        public string Object { get; set; }
        public List<GptModel> Data { get; set; }
    }
}
