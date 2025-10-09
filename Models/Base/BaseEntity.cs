using Supabase.Postgrest.Attributes;

namespace spendlock_backend.Models.Base;

public abstract class BaseEntity
{
    [PrimaryKey("id", false)] 
    public int Id { get; set; }
    
    [Column("created_at")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    [Column("updated_at")]
    public DateTime? UpdatedAt { get; set; }

}