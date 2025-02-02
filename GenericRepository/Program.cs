using GenericRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

var serviceProvider = new ServiceCollection()
    .AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("TestDb"))
    .AddScoped(typeof(IRepository<>), typeof(Repository<>))
    .AddScoped<OrderService>()
    .BuildServiceProvider();

var orderService = serviceProvider.GetRequiredService<OrderService>();

await Run(orderService);
async Task Run(OrderService orderService)
{
    while (true)
    {
        Console.WriteLine("\nChoose an action:");
        Console.WriteLine("1 - Add Order");
        Console.WriteLine("2 - View Orders");
        Console.WriteLine("3 - Exit");

        Console.Write("Enter your choice: ");
        var choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                await AddOrder(orderService);
                break;
            case "2":
                await ViewOrders(orderService);
                break;
            case "3":
                Console.WriteLine("Exiting application...");
                return;
            default:
                Console.WriteLine("Invalid choice. Try again.");
                break;
        }
    }
}
async Task AddOrder(OrderService orderService)
{
    Console.Write("\nEnter Product Name: ");
    string productName = Console.ReadLine() ?? string.Empty;

    Console.Write("Enter Quantity: ");
    if (!int.TryParse(Console.ReadLine(), out int quantity))
    {
        Console.WriteLine("Invalid quantity. Please enter a number.");
        return;
    }

    var order = new Order { ProductName = productName, Quantity = quantity };
    await orderService.AddOrderAsync(order);

    Console.WriteLine("Order added successfully!");
}
async Task ViewOrders(OrderService orderService)
{
    var orders = await orderService.GetOrdersAsync();

    if (!orders.Any())
    {
        Console.WriteLine("\nNo orders found.");
        return;
    }

    Console.WriteLine("\n Orders List:");
    foreach (var o in orders)
    {
        Console.WriteLine($" {o.Id} - {o.ProductName} - {o.Quantity}");
    }
}
