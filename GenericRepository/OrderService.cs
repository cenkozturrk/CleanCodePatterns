using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository
{
    public class OrderService
    {
        private readonly IRepository<Order> _orderRepository;

        public OrderService(IRepository<Order> orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public async Task<IEnumerable<Order>> GetOrdersAsync() => await _orderRepository.GetAllAsync();
        public async Task<Order?> GetOrderByIdAsync(int id) => await _orderRepository.GetByIdAsync(id);
        public async Task AddOrderAsync(Order order)
        {
            await _orderRepository.AddAsync(order);
            await _orderRepository.SaveChangesAsync(order);
        }
        public async Task UpdateOrderAsync(Order order)
        {
            _orderRepository.Update(order);
            await _orderRepository.SaveChangesAsync(order);
        }
        public async Task DeleteOrderAsync(int id)
        {
            var order = await _orderRepository.GetByIdAsync(id);
            if (order is not null)
            {
                _orderRepository.Delete(order);
                await _orderRepository.SaveChangesAsync(order);
            }
        }
    }
}
