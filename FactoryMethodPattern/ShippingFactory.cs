using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FactoryMethodPattern.Shipping;

namespace FactoryMethodPattern
{
    public static class ShippingFactory
    {
        public static IShippingMethod GetShippingMethod(ShippingType shippingType)
        {
            switch (shippingType)
            {
                case ShippingType.Standard:
                    return new StandardShipping();
                case ShippingType.Expedited:
                    return new ExpeditedShipping();
                case ShippingType.International:
                    return new InternationalShipping();
                default:
                    throw new ArgumentException(ShippingType.Invalidshippingmethod.ToString());
            }
        }
    }
}
