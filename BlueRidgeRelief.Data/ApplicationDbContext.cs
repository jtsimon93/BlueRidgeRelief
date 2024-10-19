using BlueRidgeRelief.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlueRidgeRelief.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    
    public DbSet<CustomUserDetails> CustomUserDetails { get; set; }
    public DbSet<Need> Needs { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Handle foreign key relationship to identity user
        builder.Entity<CustomUserDetails>()
            .HasOne<IdentityUser>()
            .WithOne()
            .HasForeignKey<CustomUserDetails>(c => c.IdentityUserId)
            .IsRequired();
        builder.Entity<Need>()
            .HasOne<IdentityUser>()
            .WithMany()
            .HasForeignKey(n => n.IdentityUserId)
            .IsRequired();

    }
}