using System.ComponentModel.DataAnnotations.Schema;
using spendlock_backend.Interfaces;
using Supabase.Postgrest.Models;

namespace spendlock_backend.Models.Payments;

[Table("payments")]
public class Payments : BaseModel, IHasTimestamps
{
    
    [Column("user_id")]
    public string Name { get; set; } //Mudar isso aqui 
    
    [Column("created_at")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    [Column("updated_at")] 
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

}