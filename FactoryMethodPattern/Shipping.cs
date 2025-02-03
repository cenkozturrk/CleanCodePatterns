using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class Shipping
    {
        // Standard shipping class
        public class StandardShipping : IShippingMethod
        {
            public void ShipPackage()
            {
                Console.WriteLine("Shipping package via Standard Shipping. Estimated delivery: 6-8 days.");
            }
        }

        // Expedited shipping class
        public class ExpeditedShipping : IShippingMethod
        {
            public void ShipPackage()
            {
                Console.WriteLine("Shipping package via Expedited Shipping. Estimated delivery: 4-5 days.");
            }
        }

        // International shipping class
        public class InternationalShipping : IShippingMethod
        {
            public void ShipPackage()
            {
                Console.WriteLine("Shipping package via International Shipping. Estimated delivery: 10-15 days.");
            }
        }
    }
}
