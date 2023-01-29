namespace ChatGPT.Models.Requests
{
    public class GptImageEditRequest
    {
        public GptImageEditRequest()
        {

        }

        public GptImageEditRequest(string prompt, byte[] image, byte[] mask, int n = 1, string size = "1024x1024")
        {
            Prompt = prompt;
            N = n;
            Size = size;
            Mask = mask;
            Image = image;
        }

        public GptImageEditRequest(byte[] image, int n = 1)
        {
            N = n;
            Image = image;
        }

        public byte[] Image { get; set; } = new byte[] { };
        public byte[]? Mask { get; set; } = null;
        public string? Prompt { get; set; } = null;
        public int N { get; set; } = 1; //1-10

        public string Size { get; set; } = "1024x1024"; //Must be one of 256x256, 512x512, or 1024x1024

        public string ResponseFormat { get; set; }// = "b64_json";

        public MultipartFormDataContent FormData
        {
            get
            {
                var multipartContent = new MultipartFormDataContent();
                if (ResponseFormat != null)
                    multipartContent.Add(new StringContent(ResponseFormat), "response_format");
                if (Size != null)
                    multipartContent.Add(new StringContent(Size), "size");
                if (N != null)
                    multipartContent.Add(new StringContent(N.ToString()), "n");
                if (Mask != null)
                    multipartContent.Add(new ByteArrayContent(Mask), "mask", "mask.png");
                multipartContent.Add(new ByteArrayContent(Image), "image", "original.png");

                if (Prompt != null)
                    multipartContent.Add(new StringContent(Prompt), "prompt");

                return multipartContent;
            }
        }

    }
}
