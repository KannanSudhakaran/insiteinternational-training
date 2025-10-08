using EnittyFramworkConsoleApp.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnittyFramworkConsoleApp.Data
{
    internal class InsiteDbContext : DbContext
    {

        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = (localdb)\mssqllocaldb;
Initial Catalog = insitedb;Integrated Security = True; TrustServerCertificate = True; MultipleActiveResultSets = true");
        }


    }
}
