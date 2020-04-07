using Mongo.CRUD;
using PedeAqui.Core.Entities;
using PedeAqui.Core.Repositories.Interfaces;

namespace PedeAqui.Infra.Repositories
{
    public class StoreRepository : BaseRepository<Store>, IStoreRepository
    {
        public StoreRepository(IMongoCRUD<Store> dbContext) : base(dbContext)
        {   
        }
    }
}