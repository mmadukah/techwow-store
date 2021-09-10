using Microsoft.Extensions.DependencyInjection;
using TechWow.Store.Repositories.EntityFramework;
using TechWow.Store.Repositories.EntityFramework.Abstractions;

namespace TechWow.Store.Web.Extensions.DependencyInjection
{
    public static class RepositoryExtensions
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
        }
    }
}
