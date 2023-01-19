using System.Net.Http.Formatting;

namespace ChatGPT.Models.Requests
{
    public class ImageEditRequest
    {
        public ImageEditRequest()
        {

        }

        public ImageEditRequest(string prompt, byte[] image, byte[] mask, int n = 1, string size = "1024x1024")
        {
            Prompt = prompt;
            N = n;
            Size = size;
            Mask = mask;
            Image = image;
        }

        public byte[] Image { get; set; } = new byte[] { };
        public byte[] Mask { get; set; } = new byte[] { };
        public string Prompt { get; set; }
        public int N { get; set; } = 1; //1-10

        public string Size { get; set; } = "1024x1024"; //Must be one of 256x256, 512x512, or 1024x1024



        public MultipartFormDataContent FormData
        {
            get
            {
                var formContent = new MultipartFormDataContent();
                formContent.Add(new StreamContent(new MemoryStream(Image)), "image");
                formContent.Add(new StreamContent(new MemoryStream(Mask)), "mask");
                formContent.Add(new StringContent(Prompt), "prompt");
                //formContent.Add(new ObjectContent<int>(N, new JsonMediaTypeFormatter()), "n");
                formContent.Add(new StringContent(Size), "size");
                return formContent;
            }
        }
    }
}
