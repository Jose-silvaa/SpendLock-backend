namespace spendlock_backend.Dtos.Visitor;

public record CreateVistorResponseDto(Guid Id, string Name, string Email, DateTime CreatedAt)
{
    public static CreateVistorResponseDto FromVisitor(Models.Email.Visitor visitor) =>
        new(visitor.Id, visitor.Name, visitor.Email, visitor.CreatedAt);
}