using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Online_Chat.Models
{
    
    public class MessageReq
    {
        [BindRequired]
        public string Name { get; set; } = null!;
        [BindRequired]
        public string Password { get; set; } = null!;
        [BindRequired]
        public string Text  { get; set; } = null!;

        public MessageReq() { }

}
}
