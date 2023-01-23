namespace ChatGPT.Models
{
    public class ChatAnswer
    {
        public ChatType Type { get; set; }
        public string Text { get; set; }
        public DateTime Created { get; set; }
        public bool IsHuman => Type == ChatType.Human;
        public bool IsAI => Type == ChatType.AI;
    }

    public enum ChatType
    {
        Human,
        AI
    }
}
