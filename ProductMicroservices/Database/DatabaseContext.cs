using Microsoft.EntityFrameworkCore;
using ProductMicroservices.Database.Entities;
using System.Collections.Generic;

namespace ProductMicroservices.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=DESKTOP-L9SOPPH\MSSQLSERVER1;initial catalog=ProductMicroserviceDatabase;persist security info=True;user id=sa;password=123;TrustServerCertificate=True");
        }
    }
}
