using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EagerLazyLoading
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set;}

        // Navigation property for related products
        public virtual List<Product> Products { get; set; }
    }
}
