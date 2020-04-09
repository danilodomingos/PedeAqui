using System.Collections.Generic;
using PedeAqui.Core.Entities;

namespace PedeAqui.Core.SeedWork
{
    public class PageResult<TEntity> where TEntity : BaseEntity
    {
        public PageResult(List<TEntity> data, int pageNumber, int pageSize, long count, bool hasNextPage)
        {
            Data = data;
            PageNumber = pageNumber;
            PageSize = pageSize;
            Count = count;
            HasNextPage = hasNextPage;
        }

        public List<TEntity> Data { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public long Count { get; set; }
        public bool HasNextPage { get; set; }
    }
}