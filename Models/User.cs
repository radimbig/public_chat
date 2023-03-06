using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Text.Json.Serialization;

namespace Online_Chat.Models
{
    [BindRequired]
    public class User
    {
        [BindNever]
        public int Id { get; set; }
        [BindRequired]
        public string Name { get; set; } = null!;
        [BindRequired]
        [JsonIgnore]
        public string Password { get; set; } = null!;

        public User()
        {

        }
        public User(int id, string name, string password)
        {
            Id = id;
            Name = name;
            Password = password;
        }
    }
}
