using AuthService.Application.DTOs;
using AuthService.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AuthService.API.Controllers
{

    [Route("api/[Controller]/[action]")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly IUserAppService _userAppService;
        public AuthController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }


        [HttpPost]
        public IActionResult Login([FromBody] LoginDTO loginDTO)
        {
            var user = _userAppService.LoginUser(loginDTO);
            if (user != null)
            {
                return Ok(user);
            }
            return Unauthorized("Invalid email or password.");
        }

        [HttpPost]
        public IActionResult SignUp([FromBody] SignUpDTO signUpDTO, string Role)
        {
            var isRegistered = _userAppService.SignUpUser(signUpDTO, Role);
            if (isRegistered)
            {
                return Ok("User registered successfully.");
            }
            return BadRequest("User registration failed. User may already exist.");
        }
    }
}
