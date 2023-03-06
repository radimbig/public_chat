using System.Text.Json;

namespace Online_Chat.Models
{
    public class Database
    {
        public List<Message> Messages = new List<Message>();
        public List<User> Users = new List<User>();
    }
}
