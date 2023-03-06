using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Online_Chat.Models
{
    public class UserRegister
    {
        [BindRequired]
        public string Password { get; set; } = null!;
        [BindRequired]
        public string Name { get; set; } = null!;
    }
}
