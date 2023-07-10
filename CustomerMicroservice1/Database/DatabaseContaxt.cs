using CustomerMicroservice1.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace CustomerMicroservice1.Database
{
    public class DatabaseContaxt: DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=DESKTOP-L9SOPPH\MSSQLSERVER1;initial catalog=CustomerMicroservice;persist security info=True;user id=sa;password=123;TrustServerCertificate=True");
        }
    }
}
