using spendlock_backend.Dtos.Visitor;
using spendlock_backend.Models.Email;
using spendlock_backend.SeedWork;

namespace spendlock_backend.Services;

public class VisitorService : BaseService
{
    public VisitorService(SupabaseService supabaseService) : base(supabaseService.GetClient()) { }

    public async Task<Visitor?> RegisterVisitor(CreateVisitorRequestDto createVisitorDto)
    {
        var newVistor = await SupabaseClient.CreateVistorAsync(createVisitorDto);
        
        if (newVistor == null)
            throw new Exception("Failed to create user.");
        
        return newVistor;
    }
}