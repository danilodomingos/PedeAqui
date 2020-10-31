using AutoMapper;
using PedeAqui.Api.Models;
using PedeAqui.Core.Customers.Entities;

namespace PedeAqui.Api.Profiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CustomerModel, Customer>();
        }
    }
}