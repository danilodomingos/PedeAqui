using Microsoft.Extensions.DependencyInjection;
using PedeAqui.Infra.IoC.Settings;
using RabbitMQ.Client;

namespace PedeAqui.Infra.IoC.Extensions
{
    public static class RabbitMqExtensions
    {
        public static void AddRabbitMq(this IServiceCollection services, RabbitMqSettings settings)
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

            services.AddScoped<IModel>(provider =>
            {

                var connection = provider.GetService<RabbitMQ.Client.IConnection>();
                var channel = connection.CreateModel();
                channel.ConfirmSelect();

                return channel;
            });
        }
    }
}