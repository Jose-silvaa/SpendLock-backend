using spendlock_backend.Dtos.User;
using spendlock_backend.Helpers;
using spendlock_backend.Models;
using spendlock_backend.SeedWork;

namespace spendlock_backend.Services;

public class UserService : BaseService
{
    public UserService(SupabaseService supabaseService) : base(supabaseService.GetClient()) { }

    public async Task<User?> RegisterUserAsync(CreateUserRequestDto userRequestDto)
    {
        var emailExists = await SupabaseClient.From<User>()
            .Where(user => user.Email == userRequestDto.Email)
            .Single();

        if (emailExists != null)
            return null;
        
        userRequestDto.Password = PasswordHelper.HashPassword(userRequestDto.Password);

        var newUser = await SupabaseClient.CreateUserAsync(userRequestDto);
        
        if (newUser == null)
            throw new Exception("Failed to create user.");
        
        return newUser;
    }

}