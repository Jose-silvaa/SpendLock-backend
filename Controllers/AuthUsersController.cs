using Microsoft.AspNetCore.Mvc;
using spendlock_backend.Services;

namespace spendlock_backend.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class AuthUsersController : ControllerBase
{
    private readonly AuthUsersService _authUsersService;

    public AuthUsersController(AuthUsersService authUsersService)
    {
        _authUsersService = authUsersService;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAllUsers()
    {
        var allAuthenticatedUsers = await _authUsersService.GetAuthenticatedUsersAsync();

        if (allAuthenticatedUsers == null)
            return BadRequest(new { message = "It doesn't exists any users" });

        return Ok(allAuthenticatedUsers);
    }
}