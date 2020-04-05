using System;
using PedeAqui.Core.Entities;
using PedeAqui.Core.Repositories.Interfaces;
using PedeAqui.Core.SeedWork.Interfaces;

namespace PedeAqui.Core.Services
{
    public class BaseService<TEntity> : ICrudOperations<TEntity> where TEntity : BaseEntity
    {
        private readonly IBaseRepository<TEntity> _repository;

        public BaseService(IBaseRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public void Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public System.Collections.Generic.List<TEntity> GetAll(Func<TEntity, bool> spec)
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