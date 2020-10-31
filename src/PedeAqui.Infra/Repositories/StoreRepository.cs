using Mongo.CRUD;
using PedeAqui.Core.Stores.Entities;
using PedeAqui.Core.Stores.Repositories;

namespace PedeAqui.Infra.Repositories
{
    public class StoreRepository : BaseRepository<Store>, IStoreRepository
    {
        public StoreRepository(IMongoCRUD<Store> dbContext) : base(dbContext)
        {
        }
    }
}