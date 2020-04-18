using Mongo.CRUD;
using PedeAqui.Core.Aggregates.Customer.Entities;
using PedeAqui.Core.Aggregates.Customer.Repositories;

namespace PedeAqui.Infra.Repositories
{
    public class CustomerRepository :  BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(IMongoCRUD<Customer> dbContext) : base(dbContext)
        {   
        }
    }
}