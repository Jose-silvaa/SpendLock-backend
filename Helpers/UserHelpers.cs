using spendlock_backend.Dtos.User;
using spendlock_backend.Models;
using Supabase;

public static class UserHelpers
{
    public static async Task<User?> CreateUserAsync(this Client client, CreateUserRequestDto userDto)
    {
        var response = await client.From<User>().Insert(new User
        {
            Name = userDto.Name,
            Email = userDto.Email,
            Password = userDto.Password
        });
        
        return response.Models.FirstOrDefault();
    }
}   