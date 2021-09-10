using TechWow.Store.Core.Models;
using TechWow.Store.Repositories.EntityFramework.Abstractions;
using TechWow.Store.Repositories.EntityFramework.Configuration.Abstractions;
using TechWow.Store.Repositories.EntityFramework.Mappings.Abstractions;
using TechWow.Store.Repositories.EntityFramework.Models;

namespace TechWow.Store.Repositories.EntityFramework
{
    public class CustomerRepository : Repository<Customer, CustomerEntity>, ICustomerRepository
    {
        public CustomerRepository(IStoreContext context, IEntityMapper<Customer, CustomerEntity> mapper)
            : base(context, mapper)
        {
        }
    }
}
