using Microsoft.Extensions.Configuration;
using PedeAqui.Infra.IoC.Settings;

namespace PedeAqui.Api.Settings
{
    public static class AppSettingsBinderExtensions
    {
        public static DatabaseSettings GetDatabaseSettings(this IConfiguration config)
        {
            var databaseSettings = new DatabaseSettings();
            config.GetSection("DatabaseSettings").Bind(databaseSettings);

            return databaseSettings;
        }

        public static RabbitMqSettings GetRabbitMqSettings(this IConfiguration config)
        {
            var rabbitMqSettings = new RabbitMqSettings();
            config.GetSection("RabbitMQSettings").Bind(rabbitMqSettings);

            return rabbitMqSettings;
        }
    }
}