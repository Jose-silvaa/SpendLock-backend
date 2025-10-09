using spendlock_backend.Dtos.Category;
using spendlock_backend.Dtos.User;
using spendlock_backend.Models;
using spendlock_backend.SeedWork;

namespace spendlock_backend.Services;

public class CategoryService : BaseService
{
    public CategoryService(SupabaseService supabaseService) : base(supabaseService.GetClient()) {}

    // public async Task<Category> CreateCategoryAsync(CreateCategoryRequestDto categoryRequestDto)
    // {
    //     
    // }
}