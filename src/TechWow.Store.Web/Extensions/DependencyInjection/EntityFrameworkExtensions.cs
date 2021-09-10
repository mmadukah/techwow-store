using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TechWow.Store.Repositories.EntityFramework.Configuration;
using TechWow.Store.Repositories.EntityFramework.Configuration.Abstractions;

namespace TechWow.Store.Web.Extensions.DependencyInjection
{
    public static class EntityFrameworkExtensions
    {
        public static void AddEntityFramework(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<StoreContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IStoreContext>(provider => provider.GetService<StoreContext>());
        }
    }
}
