using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EagerLazyLoading
{
    public class ProductService
    {
        private readonly ProductRepository _repository;

        public ProductService(ProductRepository repository)
        {
            _repository = repository;
        }

        public void DisplayProducts(bool useEagerLoading)
        {
            var products = useEagerLoading
                ? _repository.GetProductsWithCategoriesEager() 
                : _repository.GetProductsLazy();

            foreach (var product in products)
            {
                Console.WriteLine($"Product: {product.Name} - Category: {product.Category.Name}");
            }
        }
    }
}
