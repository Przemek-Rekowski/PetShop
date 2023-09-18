using Microsoft.AspNetCore.Mvc;
using PetShopAPI.Models;
using PetShopAPI.Services;

namespace PetShopAPI.Controllers
{
    [ApiController]
    [Route("api/account")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost]
        public ActionResult RegisterUser([FromBody]RegisterUserDto dto)
        {
            _userService.Register(dto);
            return Ok();
        }

        [HttpPost("login")]
        public ActionResult Login([FromBody]LogInDto dto)
        {
            string token = _userService.GenerateToken(dto);
            return Ok(token);
        }
    }
}
