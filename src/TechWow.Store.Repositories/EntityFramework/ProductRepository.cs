using TechWow.Store.Core.Models;
using TechWow.Store.Repositories.EntityFramework.Abstractions;
using TechWow.Store.Repositories.EntityFramework.Configuration.Abstractions;
using TechWow.Store.Repositories.EntityFramework.Mappings.Abstractions;
using TechWow.Store.Repositories.EntityFramework.Models;

namespace TechWow.Store.Repositories.EntityFramework
{
    public class ProductRepository: Repository<Product, ProductEntity>, IProductRepository
    {
        public ProductRepository(IStoreContext context, IEntityMapper<Product, ProductEntity> mapper) 
            : base(context, mapper)
        {
        }
    }
}
