using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Online_Chat.Models
{
    [BindRequired]
    public class User
    {
        
        public int Id;
        public string Name = string.Empty;
        public string Password = string.Empty;

        public User() { }
        public User(int id, string name, string password)
        {
            Id = id;
            Name = name;
            Password = password;
        }
    }
}
