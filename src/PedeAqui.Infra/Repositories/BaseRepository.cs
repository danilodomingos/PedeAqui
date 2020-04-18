using System;
using System.Linq.Expressions;
using Mongo.CRUD;
using MongoDB.Driver;
using PedeAqui.Core.Aggregates.Store.Repositories;
using PedeAqui.Core.Shared.Entities;
using PedeAqui.Core.Shared.Repositories;
using PedeAqui.Core.Shared.SeedWork;
using PedeAqui.Core.Shared.SeedWork.Enums;
using PedeAqui.Infra.Helper;

namespace PedeAqui.Infra.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity, new()
    {
        protected readonly IMongoCRUD<TEntity> DbContext;

        public BaseRepository(IMongoCRUD<TEntity> dbContext)
        {
            DbContext = dbContext;
        }
        public void Add(TEntity entity)
        {
            DbContext.Collection.InsertOne(entity);
        }

        public void Delete(Guid id)
        {
            DbContext.Delete(id);
        }

        public PageResult<TEntity> GetAll(Expression<Func<TEntity, bool>> spec, int pageSize = 20, int pageNumber = 1, 
            string sortField = null, SortModeEnum sort = SortModeEnum.Asc)
        {
            if(spec == null)
            {
                spec = p => p.Id != null;
            }

            var options = PaginationHelper.BuildOptions(pageSize, pageNumber, sortField, sort);
            var search =DbContext.Search(spec, options);
            var hasNextPage = PaginationHelper.HasNextPage(pageSize, pageNumber, search.Count);

            return new PageResult<TEntity>(search.Documents, pageNumber, pageSize, search.Count, hasNextPage);
        }

        public TEntity GetById(Guid id)
        {
            Expression<Func<TEntity, bool>> exp = p => p.Id == id;
            return DbContext.Collection.Find(exp)?.FirstOrDefault();
        }

        public void Update(TEntity entity)
        {
            Expression<Func<TEntity, bool>> exp = p => p.Id == entity.Id;
            DbContext.UpdateByQuery(exp, entity);
        }
    }
}