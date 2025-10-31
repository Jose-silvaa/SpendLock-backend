using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;
using spendlock_backend.Dtos.Visitor;
using spendlock_backend.Services;

namespace spendlock_backend.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class VisitorController : ControllerBase
{
    private readonly VisitorService _visitorService;

    public VisitorController(VisitorService visitorService)
    {
        _visitorService = visitorService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateVisitor([FromBody] CreateVisitorRequestDto createVisitorDto)
    {
        var newVistor = await _visitorService.RegisterVisitor(createVisitorDto);
        
        if (newVistor == null)
            return BadRequest(new { message = "There is no visitor." });

        return Ok(CreateVistorResponseDto.FromVisitor(newVistor));
    }
}