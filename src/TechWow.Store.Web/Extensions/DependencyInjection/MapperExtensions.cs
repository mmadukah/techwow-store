using Microsoft.Extensions.DependencyInjection;
using TechWow.Store.Repositories.EntityFramework.Mappings;
using TechWow.Store.Repositories.EntityFramework.Mappings.Abstractions;
using TechWow.Store.Web.Mappings;
using TechWow.Store.Web.Mappings.Abstractions;

namespace TechWow.Store.Web.Extensions.DependencyInjection
{
    public static class MapperExtensions
    {
        public static void AddMappers(this IServiceCollection services)
        {
            services.AddScoped(typeof(IEntityMapper<,>), typeof(EntityMapperBase<,>));
            services.AddScoped(typeof(IModelMapper<,>), typeof(ModelMapperBase<,>));
        }
    }
}
