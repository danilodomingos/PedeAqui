using Mongo.CRUD;
using PedeAqui.Core.Aggregates.Store.Entities;
using PedeAqui.Core.Aggregates.Store.Repositories;

namespace PedeAqui.Infra.Repositories
{
    public class StoreRepository : BaseRepository<Store>, IStoreRepository
    {
        public StoreRepository(IMongoCRUD<Store> dbContext) : base(dbContext)
        {   
        }
    }
}