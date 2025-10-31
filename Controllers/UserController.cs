using Microsoft.AspNetCore.Mvc;
using spendlock_backend.Dtos.User;
using spendlock_backend.Services;

namespace spendlock_backend.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class UserController : ControllerBase
{
    
    private readonly UserService _userService;

    public UserController(UserService userService)
    {
        _userService = userService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser([FromBody] CreateUserRequestDto userDto)
    {
        var newUser = await _userService.RegisterUserAsync(userDto);

        if (newUser == null)
            return BadRequest(new { message = "Email already exists." });

        return Ok(CreateUserResponseDto.FromUser(newUser));
    }
    
}