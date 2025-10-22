using spendlock_backend.SeedWork;
using Supabase.Gotrue;
using User = Supabase.Gotrue.User;

namespace spendlock_backend.Services;

public class AuthUsersService : BaseService
{
    public AuthUsersService(SupabaseService supabaseService) : base(supabaseService.GetClient()) { }
    
    public async Task<UserList<User>?> GetAuthenticatedUsersAsync()
    {
        var serviceRole = Environment.GetEnvironmentVariable("SERVICE__ROLE");

        if (serviceRole != null)
        {
            var usersAuthenticated = await SupabaseClient.AdminAuth(serviceRole).ListUsers();

            return usersAuthenticated;
        }
        
        return null;
    }
}