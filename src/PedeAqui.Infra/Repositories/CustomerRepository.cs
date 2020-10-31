using Mongo.CRUD;
using PedeAqui.Core.Customers.Entities;
using PedeAqui.Core.Customers.Repositories;

namespace PedeAqui.Infra.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(IMongoCRUD<Customer> dbContext) : base(dbContext)
        {
        }
    }
}