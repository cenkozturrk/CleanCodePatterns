using FactoryMethodPattern;

Console.WriteLine("Welcome to our E-Commerce Platform!");


Console.WriteLine("Please choose a shipping method: (standard, expedited, international)");
string userChoice = Console.ReadLine();

if (Enum.TryParse(userChoice, true, out ShippingType shippingType))
{
    IShippingMethod shippingMethod = ShippingFactory.GetShippingMethod(shippingType);
    
    shippingMethod.ShipPackage();
}
else
    Console.WriteLine("Invalid shipping method. Please choose from Standard, Expedited, or International.");
