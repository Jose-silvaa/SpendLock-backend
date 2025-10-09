namespace spendlock_backend.SeedWork;

public class BaseService
{
    protected readonly Supabase.Client SupabaseClient;

    protected BaseService(Supabase.Client client)
    {
        SupabaseClient = client;
    }

}