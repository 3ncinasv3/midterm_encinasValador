using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using midterm_encinasValador.Models;

namespace midterm_encinasValador.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Product> products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        
        modelBuilder.Entity<IdentityUserLogin<string>>()
            .HasKey(x => x.UserId); 

        
        modelBuilder.Entity<Product>()
            .Property(p => p.Category)
            .HasDefaultValue("Uncategorized");
    }
}
