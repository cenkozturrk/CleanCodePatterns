using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EagerLazyLoading
{
    public class ProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        // Eager loading
        public List<Product> GetProductsWithCategoriesEager()
        {
            return _context.Products.Include(p => p.Category).ToList();

            // With AsNoTracking()
            //return _context.Products.Include(p => p.Category)
            //.AsNoTracking()
            //.ToList(); //Tracking is disabled, so EF Core does not keep changes in memory.

        }


        // Lazy Loading
        public List<Product> GetProductsLazy()
        {
            return _context.Products.ToList(); // Category will be loaded when accessed // Do NOT use AsNoTracking() if you need Lazy Loading.
        }
    }
}
