using PedeAqui.Core.Entities;
using PedeAqui.Core.SeedWork.Interfaces;

namespace PedeAqui.Core.Repositories.Interfaces
{
    public interface IBaseRepository<TEntity> : ICrudOperations<TEntity> where TEntity : BaseEntity
    {
         
    }
}