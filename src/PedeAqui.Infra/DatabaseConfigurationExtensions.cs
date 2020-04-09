using System;
using Microsoft.Extensions.DependencyInjection;
using Mongo.CRUD;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Driver;
using PedeAqui.Core.Entities;
using PedeAqui.Core.SeedWork.Enums;
using PedeAqui.Core.ValueObjects;

namespace PedeAqui.Infra
{
    public static class DatabaseConfigurationExtensions
    {
        public static void AddDatabaseConfiguration(this IServiceCollection services, DatabaseSettings settings)
        {
            AddConventions();
            AddMappings();

            services.AddSingleton<IMongoClient, MongoClient>(p => {
                return new MongoClient(settings.Connection);
            });

            services.AddScoped<IMongoDatabase>(p => {
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

            BsonClassMap.RegisterClassMap<Store>(cm => {
                cm.AutoMap();
            });

            BsonClassMap.RegisterClassMap<MenuItem>(cm => {
                cm.AutoMap();
                cm.MapMember(c => c.Type).SetSerializer(new EnumSerializer<ItemTypeEnum>(BsonType.String));
            });
        }

        private static void AddConventions()
        {
            var conventionPack = new ConventionPack {new CamelCaseElementNameConvention()}; 
            ConventionRegistry.Register("camelCase", conventionPack, t => true);
            BsonSerializer.RegisterIdGenerator(typeof(Guid), CombGuidGenerator.Instance);
        }
    }
}