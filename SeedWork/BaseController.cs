using Microsoft.AspNetCore.Mvc;
using Supabase;

namespace spendlock_backend.SeedWork;

public abstract class BaseController : ControllerBase
{
    protected readonly Client SupabaseClient;
    
    protected BaseController(SupabaseService supabaseService)
    {
        SupabaseClient = supabaseService.GetClient();
    }
}