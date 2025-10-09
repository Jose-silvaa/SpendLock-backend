using spendlock_backend.Dtos.Category;
using spendlock_backend.Models;
using Supabase;

namespace spendlock_backend.Helpers;

public static class CategoryHelpers
{
    public static async Task<Category?> CreateCategoryAsync(this Client client, CreateCategoryRequestDto categoryRequestDto)
    {
        return null;
    }
}