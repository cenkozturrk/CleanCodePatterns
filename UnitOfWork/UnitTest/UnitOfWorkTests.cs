using Microsoft.EntityFrameworkCore;
using UnitOfWork.Entity;
using Xunit;

namespace UnitOfWork.UnitTest
{
    public class UnitOfWorkTests
    {
        [Fact]
        public async Task AddOrder_ShouldAddOrderToDatabase()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;

            using (var context = new AppDbContext(options))
            using (var unitOfWork = new UnitOfWorks.UnitOfWork(context))
            {
                var order = new Order
                {
                    ProductName = "Test Product",
                    Price = 100
                };

                unitOfWork.Orders.Add(order);
                await unitOfWork.CommitAsync();

                var fetchedOrder = await unitOfWork.Orders.GetByIdAsync(order.Id);

                Assert.NotNull(fetchedOrder);
                Assert.Equal(order.ProductName, fetchedOrder.ProductName);
                Assert.Equal(order.Price, fetchedOrder.Price);
            }
        }
    }
}
