using Arch.EntityFrameworkCore.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Entity;
using UnitOfWork.Repositories;

namespace UnitOfWork.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private Repositories.IRepository<Order> _orders;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        public Repositories.IRepository<Order> Orders => _orders ??= new Repositories.Repository<Order>(_context);
        public async Task<int> CommitAsync() => await _context.SaveChangesAsync();
        public void Dispose() => _context.Dispose();
    }

}
