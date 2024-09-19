using DomainModels;
using DTOs.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using Services.Interfaces;

namespace LiquorStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        [AllowAnonymous]
        public IActionResult Register([FromBody] RegisterUserDto registerUser)
         {
            try
            {
                var result = _userService.RegisterUser(registerUser);
                if (result == null)
                {
                    return BadRequest("Error!");
                }

                return StatusCode(StatusCodes.Status201Created, "User created successfully!");
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
         }

        [HttpPost("login")]
        [AllowAnonymous]
        public IActionResult LoginUser([FromBody] LoginDto loginDto)
        {
            try
            {
                var result = _userService.LoginUser(loginDto);
                if (result != null)
                {
                    return Ok(result);
                }
                return BadRequest("Something went wrong!");
            }
            catch (Exception ex)
            {
                Log.Error(ex, $"Error while login user.");
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
