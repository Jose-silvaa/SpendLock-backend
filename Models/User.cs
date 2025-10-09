using spendlock_backend.Interfaces;
using spendlock_backend.Models.Base;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace spendlock_backend.Models;


[Table("users")]
public class User : BaseModel, IHasTimestamps
{
    [PrimaryKey("id", false)]
    public Guid Id { get; set; }
        
    [Column("name")]
    public string Name { get; set; }
    
    [Column("email")]
    public string Email { get; set; }
    
    [Column("password")]
    public string Password { get; set; }
    
    [Column("last_access")]
    public DateTime? LastAccess { get; set; }
    
    [Column("created_at")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    [Column("updated_at")] 
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    
    public void UpdateLastAccess()
    {
        LastAccess = DateTime.UtcNow;
    }

    
}