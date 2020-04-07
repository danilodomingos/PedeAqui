using System;
using System.Collections.Generic;
using Mongo.CRUD;
using PedeAqui.Core.Entities;
using PedeAqui.Core.Repositories.Interfaces;

namespace PedeAqui.Infra.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity, new()
    {
        protected readonly IMongoCRUD<TEntity> _dbContext;

        public BaseRepository(IMongoCRUD<TEntity> dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(TEntity entity)
        {
            _dbContext.Collection.InsertOne(entity);
        }

        public void Delete(Guid id)
        {
            _dbContext.Delete(id);
        }

        public List<TEntity> GetAll(Func<TEntity, bool> spec)
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}