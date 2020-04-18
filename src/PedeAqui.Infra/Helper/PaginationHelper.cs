using System;
using Mongo.CRUD.Enums;
using Mongo.CRUD.Models;
using PedeAqui.Core.Shared.SeedWork.Enums;

namespace PedeAqui.Infra.Helper
{
    public class PaginationHelper
    {
        public static SearchOptions BuildOptions(int pageSize, int pageNumber, string sortField, SortModeEnum sort)
        {
            return new SearchOptions() { 
                PageSize = pageSize, 
                PageNumber = pageNumber,
                SortField = sortField,
                SortMode = (SortMode) Enum.Parse(typeof(SortMode), sort.ToString(), true)
            };
        }

        public static bool HasNextPage(int pageSize, int pageNumber, long count)
        {
            var hasData = (count > 0);
            var hasNextPage = false;

            if(hasData) {
                hasNextPage  = (pageSize * pageNumber) < count;
            }

            return hasNextPage;
        }
    }
}