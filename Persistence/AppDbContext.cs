using Microsoft.EntityFrameworkCore;
using App.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace App.Persistence
{
  public class AppDbContext : IdentityDbContext<ApplicationUser>
  {
    // DbSets

    public AppDbContext(DbContextOptions<AppDbContext> options) 
        : base(options) 
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) 
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<ApplicationUser>().ToTable("Users");
        modelBuilder.Entity<IdentityRole>().ToTable("Roles");
    }
  }
}