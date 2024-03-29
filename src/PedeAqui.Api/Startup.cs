using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PedeAqui.Api.Profiles;
using PedeAqui.Api.Settings;
using PedeAqui.Infra.IoC.Extensions;
using System.Text.Json.Serialization;

namespace PedeAqui.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers()
                .AddJsonOptions(opts =>
                {
                    opts.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                });

            services.AddAutoMapper(config =>
            {
                config.AllowNullCollections = true;
                config.AddProfile<StoreProfile>();

            }, typeof(Startup));

            services.AddDatabase(Configuration.GetDatabaseSettings());
            services.AddRabbitMq(Configuration.GetRabbitMqSettings());
            services.AddRepositories();
            services.AddPublishers();

            services.AddMediatR(typeof(Startup));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints => endpoints.MapControllers());
        }
    }
}
