using Microsoft.Extensions.DependencyInjection;
using PedeAqui.Infra.IoC.Settings;
using RabbitMQ.Client;

namespace PedeAqui.Infra.IoC
{
    public static class RabbitMQExtensions
    {
        public static void AddRabbitMQ(this IServiceCollection services, RabbitMQSettings settings)
        {
            services.AddSingleton<RabbitMQ.Client.IConnection>(provider =>
            {
                var factory = new ConnectionFactory()
                {
                    UserName = settings.UserName,
                    Password = settings.Password,
                    VirtualHost = settings.VirtualHost,
                    HostName = settings.HostName
                };
                
                return factory.CreateConnection();
            });

            services.AddScoped<IModel>(provider => {
                var connection = provider.GetService<RabbitMQ.Client.IConnection>();
                return connection.CreateModel();
            });
        }
    }
}