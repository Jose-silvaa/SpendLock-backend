
using spendlock_backend.Interfaces;
using spendlock_backend.Models.Base;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace spendlock_backend.Models;

[Table("categories")]
public class Category :  BaseModel, IHasTimestamps
{
    [PrimaryKey("id", false)]
    public Guid Id { get; set; }
    
    [Column("user_id")]
    public User UserId { get; set; }
    
    [Column("name")]
    public string Name { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
    
    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }
}