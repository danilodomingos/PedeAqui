using System;
using System.Collections.Generic;
using PedeAqui.Core.Entities;
using PedeAqui.Core.Repositories.Interfaces;

namespace PedeAqui.Infra.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        public void Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
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