namespace WebApi.Controllers;

using Domain.Services;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService) => _userService = userService;

    [HttpGet("users")]
    public IActionResult GetUsers()
    {
        return Ok(_userService.GetUsers());
    }

    [HttpGet("{userId:int}")]
    public IActionResult GetUserById(int userId)
    {
        var user = _userService.GetUser(userId);

        if(user == null)
        {
            return NotFound();
        }

        return Ok(value: user);
    }
}
