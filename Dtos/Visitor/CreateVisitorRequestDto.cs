using System.ComponentModel.DataAnnotations;

namespace spendlock_backend.Dtos.Visitor;

public class CreateVisitorRequestDto
{
    [Required]
    public string Name { get; set; }

    [Required]
    public string Email { get; set; }
}