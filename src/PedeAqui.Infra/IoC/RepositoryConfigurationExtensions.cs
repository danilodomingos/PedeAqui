using Microsoft.Extensions.DependencyInjection;
using PedeAqui.Core.Repositories.Interfaces;
using PedeAqui.Infra.Repositories;

namespace PedeAqui.Infra.IoC
{
    public static class RepositoryConfigurationExtensions
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IStoreRepository, StoreRepository>();
        }
    }
}