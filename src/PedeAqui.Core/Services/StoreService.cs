using PedeAqui.Core.Entities;
using PedeAqui.Core.Repositories.Interfaces;

namespace PedeAqui.Core.Services.Interfaces
{
    public class StoreService : BaseService<Store>, IStoreService
    {
        private readonly IStoreRepository _repository;

        public StoreService(IStoreRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}