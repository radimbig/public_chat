namespace Online_Chat.Models
{
    public class Message
    {
        public int id;
        public int from;
        public string message = null!;

        public Message(int id, int from, string message)
        {
            this.id = id;
            this.from = from;
            this.message = message;
        }

        public Message() { }
    }
}
