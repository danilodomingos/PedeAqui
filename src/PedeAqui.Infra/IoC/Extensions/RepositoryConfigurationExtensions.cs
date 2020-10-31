using Microsoft.Extensions.DependencyInjection;
using PedeAqui.Core.Customers.Repositories;
using PedeAqui.Core.Stores.Repositories;
using PedeAqui.Infra.Repositories;

namespace PedeAqui.Infra.IoC.Extensions
{
    public static class RepositoryConfigurationExtensions
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IStoreRepository, StoreRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
        }
    }
}