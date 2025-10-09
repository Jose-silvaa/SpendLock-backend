namespace spendlock_backend.Dtos.User;

public record CreateUserResponseDto(Guid Id, string Name, string Email, DateTime CreatedAt)
{
    public static CreateUserResponseDto FromUser(Models.User user) =>
        new(user.Id, user.Name, user.Email, user.CreatedAt);
}