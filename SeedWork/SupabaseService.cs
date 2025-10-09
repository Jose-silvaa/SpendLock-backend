using DotNetEnv;
using Supabase;

namespace spendlock_backend.SeedWork;

public class SupabaseService
{
    private readonly Client _client;

    public SupabaseService()
    {
        var url = Environment.GetEnvironmentVariable("SUPABASE__URL");
        var key = Environment.GetEnvironmentVariable("SUPABASE__KEY");
        
        if (string.IsNullOrEmpty(url) || string.IsNullOrEmpty(key))
            throw new Exception("Supabase URL or Key not found.");

        
        _client = new Client(url, key, new SupabaseOptions
        {
            AutoRefreshToken = true,
            AutoConnectRealtime = true
        });
    }
    
    public Client GetClient()
    {
        return _client;
    }
}