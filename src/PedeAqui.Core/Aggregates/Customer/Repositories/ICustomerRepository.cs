using PedeAqui.Core.Aggregates.Store.Repositories;
using PedeAqui.Core.Shared.Repositories;

namespace PedeAqui.Core.Aggregates.Customer.Repositories
{
    public interface ICustomerRepository : IBaseRepository<Customer.Entities.Customer>
    {
         
    }
}