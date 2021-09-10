using TechWow.Store.Core.Models;
using TechWow.Store.Repositories.EntityFramework.Abstractions;
using TechWow.Store.Repositories.EntityFramework.Configuration.Abstractions;
using TechWow.Store.Repositories.EntityFramework.Mappings.Abstractions;
using TechWow.Store.Repositories.EntityFramework.Models;

namespace TechWow.Store.Repositories.EntityFramework
{
    public class OrderRepository : Repository<Order, OrderEntity>, IOrderRepository
    {
        public OrderRepository(IStoreContext context, IEntityMapper<Order, OrderEntity> mapper) 
            : base(context, mapper)
        {
        }
    }
}
