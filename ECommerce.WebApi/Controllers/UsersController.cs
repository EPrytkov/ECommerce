using ECommerce.Application.Dto.Users.Requests;
using ECommerce.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    [HttpPost("register")]
    public IActionResult Register([FromBody] UserRegisterRequest userRegisterRequest)
    {
        return Ok();
    }
    
    [HttpGet("login")]
    public Task<IActionResult> LoginAsync([FromBody] UserLoginRequest userLoginRequest)
    {
        return Task.FromResult<IActionResult>(Ok());
    }
}