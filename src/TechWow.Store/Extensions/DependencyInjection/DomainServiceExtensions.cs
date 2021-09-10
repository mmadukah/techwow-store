using Microsoft.Extensions.DependencyInjection;
using TechWow.Store.Services;
using TechWow.Store.Services.Abstractions;

namespace TechWow.Store.Web.Extensions.DependencyInjection
{
    public static class DomainServiceExtensions
    {
        public static void AddDomainServices(this IServiceCollection services)
        {
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<ICustomerService, CustomerService>();
        }
    }
}
