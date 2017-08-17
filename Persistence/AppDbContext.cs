using Microsoft.EntityFrameworkCore;
using vega.Models;

namespace vega.Persistence
{
  public class AppDbContext : DbContext
  {
    // DbSets
    public DbSet<Make> Makes { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) 
        : base(options) 
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) 
    {

    }
  }
}