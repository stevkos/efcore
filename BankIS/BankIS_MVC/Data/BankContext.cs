using BankIS.MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace BankIS.MVC.Data
{
    public class BankContext : DbContext
    {
        public BankContext(DbContextOptions<BankContext> options) : base(options)
        {

        }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Client>()
                .HasIndex(c => c.LastName);
        }


    }
}