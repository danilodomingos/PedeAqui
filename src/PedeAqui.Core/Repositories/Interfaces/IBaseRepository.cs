using System;
using System.Linq.Expressions;
using PedeAqui.Core.Entities;
using PedeAqui.Core.SeedWork;
using PedeAqui.Core.SeedWork.Enums;

namespace PedeAqui.Core.Repositories.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(Guid id);
        TEntity GetById(Guid id);
        PageResult<TEntity> GetAll(Expression<Func<TEntity, bool>> spec = null, int pageSize = 20, int pageNumber = 1, 
            string sortField = null, SortModeEnum sort = SortModeEnum.Asc);
    }
}