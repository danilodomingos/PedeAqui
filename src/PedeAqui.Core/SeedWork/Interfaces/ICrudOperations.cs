using System;
using System.Collections.Generic;
using PedeAqui.Core.Entities;

namespace PedeAqui.Core.SeedWork.Interfaces
{
    public interface ICrudOperations<TEntity> where TEntity : BaseEntity
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(Guid id);
        TEntity GetById(Guid id);
        List<TEntity> GetAll(Func<TEntity, bool> spec);
    }
}