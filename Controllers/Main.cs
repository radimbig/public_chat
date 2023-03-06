using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Online_Chat.Models;
using System.Text.Json;

namespace Online_Chat.Controllers
{

    [Route("api/")]
    [ApiController]

    public class Main : ControllerBase
    {
        public Database _database;
        IConfiguration _config;


        public Main( IConfiguration configuration, Database database)
        {
            _config = configuration;

            _database = database;
            Console.WriteLine("controller was created");
        }
        [Route("register")]
        [HttpPost]
        public IActionResult Register([FromBody] UserRegister user)
        {
            
            if(_database.Users.Any(x=>x.Name == user.Name))
            {
                return new BadRequestObjectResult(new {error = $"User with name:'{user.Name}' already exists"});
            }
            _database.Users.Add(new User(_database.Users.Count(), user.Name, user.Password));
            Console.WriteLine(JsonSerializer.Serialize(_database.Users));
            
            return new JsonResult(_database.Users.Last());
        }

        [Route("send")]
        [HttpPost]
        public IActionResult Send([FromBody] MessageReq message)
        {
            return Ok();
        }

        [Route("users")]
        [HttpGet]
        public string GetAllUsers()
        {
            string response = JsonSerializer.Serialize(_database.Users);
            return response;
            
        }
    }
}
