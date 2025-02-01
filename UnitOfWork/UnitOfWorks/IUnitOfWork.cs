using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Entity;
using UnitOfWork.Repositories;

namespace UnitOfWork.UnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Order> Orders
        {
            get;
        }
        Task<int> CommitAsync();
    }
}
