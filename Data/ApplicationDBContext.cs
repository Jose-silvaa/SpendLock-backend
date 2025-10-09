using spendlock_backend.models;
using spendlock_backend.Models;

namespace spendlock_backend.Data;
using Microsoft.EntityFrameworkCore;

public class ApplicationDBContext : DbContext
{
    public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
    {
        
    }
    
    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Bills> Budgets { get; set; }
    public DbSet<Transactions> Expenses { get; set; }
    public DbSet<Notification> Notifications { get; set; }
    
}