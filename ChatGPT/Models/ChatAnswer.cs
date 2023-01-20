namespace ChatGPT.Models
{
    public class ChatAnswer
    {
        public ChatType Type { get; set; }
        public string Text { get; set; }
        public DateTime Created { get; set; }
    }

    public enum ChatType
    {
        Human,
        AI
    }
}
