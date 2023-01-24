namespace ChatGPT.Models
{
    public enum TextInputType
    {
        Text,
        Image
    }

    public class Conversation
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public TextInputType Type { get; set; }
        public List<ChatAnswer> Answers { get; set; } = new List<ChatAnswer>();

        public Conversation(TextInputType type)
        {
            Type = type;
        }
    }
}
