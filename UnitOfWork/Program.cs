using Microsoft.EntityFrameworkCore;
using UnitOfWork.Entity;

var options = new DbContextOptionsBuilder<UnitOfWork.AppDbContext>()
    .UseInMemoryDatabase("UnitOfWorkDb")
    .Options;

var context = new UnitOfWork.AppDbContext(options);

// Using Unit of Work
using (UnitOfWork.UnitOfWorks.UnitOfWork unitOfWork = new UnitOfWork.UnitOfWorks.UnitOfWork(context))
{
    // Add a new order
    var newOrder = new Order { ProductName = "Laptop", Price = 1200 };
    unitOfWork.Orders.Add(newOrder);
    await unitOfWork.CommitAsync();

    // Fetch all orders
    var orders = await unitOfWork.Orders.GetAllAsync();
    Console.WriteLine("Orders:");
    foreach (var order in orders)
    {
        Console.WriteLine($"Order Id: {order.Id}, Product: {order.ProductName}, Price: {order.Price}");
    }
}
