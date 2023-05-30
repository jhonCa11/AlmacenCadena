using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using AlmacenCadena.Models;

namespace AlmacenCadena
/*
 *  dotnet ef migrations add InitialMigration --context ApplicationDbContext
 *  dotnet ef database update --context ApplicationDbContext
 */
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleItem> SaleItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración adicional de las entidades, relaciones, etc.
        }
    }
}
