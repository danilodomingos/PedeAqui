using System;
using System.Linq.Expressions;
using Mongo.CRUD;
using MongoDB.Driver;
using PedeAqui.Core.Entities;
using PedeAqui.Core.Repositories.Interfaces;
using PedeAqui.Core.SeedWork;
using PedeAqui.Core.SeedWork.Enums;
using PedeAqui.Infra.Helper;

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

        public PageResult<TEntity> GetAll(Expression<Func<TEntity, bool>> spec, int pageSize = 20, int pageNumber = 1, 
            string sortField = null, SortModeEnum sort = SortModeEnum.Asc)
        {
            if(spec == null)
            {
                spec = p => p.Id != null;
            }

            var options = PaginationHelper.BuildOptions(pageSize, pageNumber, sortField, sort);
            var search =_dbContext.Search(spec, options);
            var hasNextPage = PaginationHelper.HasNextPage(pageSize, pageNumber, search.Count);

            return new PageResult<TEntity>(search.Documents, pageNumber, pageSize, search.Count, hasNextPage);
        }

        public TEntity GetById(Guid id)
        {
            Expression<Func<TEntity, bool>> exp = p => p.Id == id;
            return _dbContext.Collection.Find(exp)?.FirstOrDefault();
        }

        public void Update(TEntity entity)
        {
            Expression<Func<TEntity, bool>> exp = p => p.Id == entity.Id;
            _dbContext.UpdateByQuery(exp, entity);
        }
    }
}