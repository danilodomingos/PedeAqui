using Microsoft.Extensions.DependencyInjection;
using PedeAqui.Infra.Publishers;
using PedeAqui.Infra.Publishers.Interfaces;

namespace PedeAqui.Infra.IoC.Extensions
{
    public static class PublishersConfigurationExtensions
    {
        public static void AddPublishers(this IServiceCollection services)
        {
            services.AddScoped<IOrderPublisher, OrderPublisher>();
        }
    }
}