using Microsoft.Extensions.DependencyInjection;
using PedeAqui.Core.Aggregates.Customer.Repositories;
using PedeAqui.Core.Aggregates.Store.Repositories;
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