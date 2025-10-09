namespace spendlock_backend.Dtos.Category;

public class CreateCategoryRequestDto
{
    public Guid UserId { get; set; }
    public string Name { get; set; }
}