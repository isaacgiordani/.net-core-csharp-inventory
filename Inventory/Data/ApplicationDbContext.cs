using Inventory.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Company> Company { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Equipment> Equipment { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>()
                .HasOne(b => b.Company)
                .WithMany(a => a.Employees)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Equipment>()
                .HasOne(b => b.Employee)
                .WithMany(a => a.Equipments)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
