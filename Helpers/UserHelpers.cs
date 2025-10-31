using spendlock_backend.Dtos.User;
using spendlock_backend.Dtos.Visitor;
using spendlock_backend.Models;
using spendlock_backend.Models.Email;
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

    public static async Task<Visitor?> CreateVistorAsync(this Client client, CreateVisitorRequestDto createVisitorDto)
    {
        var response = await client.From<Visitor>().Insert(new Visitor
        {
            Name = createVisitorDto.Name,
            Email = createVisitorDto.Email,
        });
        
        return response.Models.FirstOrDefault();
    }
}   