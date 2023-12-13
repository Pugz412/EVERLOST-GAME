using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;



namespace UserApi.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {

             
        // localhost:xxx/api/users
        [HttpGet("admin")]
        public IActionResult GetUsers()
        {
            var db = new UserDB();
            return Ok(db.GetAllUsers()); // wrapping http response headers/metadata
        }
    }
}
