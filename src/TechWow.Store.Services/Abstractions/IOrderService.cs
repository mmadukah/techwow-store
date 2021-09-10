using System.Collections.Generic;
using TechWow.Store.Core.Models;

namespace TechWow.Store.Services.Abstractions
{
    public interface IOrderService
    {
        void Add(Order model);
        void Add(IEnumerable<Order> models);
        void Delete(int id);
        Order Get(int id);
        IEnumerable<Order> GetAll();
        void Update(Order model);
        void Update(IEnumerable<Order> models);
    }
}
