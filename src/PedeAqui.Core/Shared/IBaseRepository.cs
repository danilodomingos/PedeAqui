using PedeAqui.Core.Shared.SeedWork;
using PedeAqui.Core.Shared.SeedWork.Enums;
using System;
using System.Linq.Expressions;

namespace PedeAqui.Core.Shared
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