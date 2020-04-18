using System;
using Microsoft.Extensions.DependencyInjection;
using Mongo.CRUD;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Driver;
using PedeAqui.Core.Aggregates.Store.Entities;
using PedeAqui.Core.Shared.Entities;
using PedeAqui.Infra.IoC.Settings;

namespace PedeAqui.Infra.IoC
{
    public static class DatabaseConfigurationExtensions
    {
        public static void AddDatabase(this IServiceCollection services, DatabaseSettings settings)
        {
            AddConventions();
            AddMappings();

            services.AddSingleton<IMongoClient, MongoClient>(p => {
                return new MongoClient(settings.Connection);
            });

            services.AddScoped(p => {
                var client = p.GetService<IMongoClient>();
                return client.GetDatabase(settings.Name);
            });

            services.AddScoped<IMongoCRUD<Store>>(p => 
            {
                var mongoClient = p.GetService<IMongoClient>();
                var database = p.GetService<IMongoDatabase>();
                return new MongoCRUD<Store>(mongoClient, database);
            });    

        }

        private static void AddMappings()
        {
            BsonClassMap.RegisterClassMap<BaseEntity>(cm =>
            {
                cm.AutoMap();
                cm.MapIdField(p => p.Id);
            });
        }

        private static void AddConventions()
        {
            var conventionPack = new ConventionPack 
            {
                new CamelCaseElementNameConvention(), 
                new EnumRepresentationConvention(BsonType.String)
            };

            ConventionRegistry.Register("default", conventionPack, t => true);
            BsonSerializer.RegisterIdGenerator(typeof(Guid), CombGuidGenerator.Instance);
        }
    }
}