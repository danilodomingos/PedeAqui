using PedeAqui.Core.Entities;
using PedeAqui.Core.SeedWork.Interfaces;

namespace PedeAqui.Core.Services.Interfaces
{
    public interface IBaseService<TEntity> : ICrudOperations<TEntity> where TEntity : BaseEntity 
    {
         
    }
}