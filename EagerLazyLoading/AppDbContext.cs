using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EagerLazyLoading
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products
        {
            get; set;
        }
        public DbSet<Category> Categories
        {
            get; set;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies(); // Enable Lazy Loading. Be careful when using!!!!!
            optionsBuilder.UseSqlServer("YourConnectionStringHere"); // When you decide to try the topic that you need to connect with DB!!.
        }
    }

}
