using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankIS.ConsoleApp
{
    public class BankContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        public DbSet<Address> Adressess { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Initial Catalog=bankdb01");
        }
    }
}