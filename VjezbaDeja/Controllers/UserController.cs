using Microsoft.AspNetCore.Mvc;

namespace VjezbaDeja.Controllers
{
    [Controller]
    [Route("[controller]")]

    public class UserController : ControllerBase
    {
        private static List<User> Users = new List<User> {
            new User {Username="Dejana", Email="dejana@test.com"},
            new User {Username="Ognjen", Email="ogi@test.com"}
        };
    

    [HttpGet]

        public async Task<ActionResult<List<User>>> GetUsers()
        {
            var users = Users.ToList();
            return Ok(users);
        }
        [HttpPost]
        public async Task<ActionResult<User>> AddUser([FromBody]User user)
        {
            user.UserId = Users.Count() + 1;
            
            Users.Add(user);

            return Ok(Users);
        }
    }
}

