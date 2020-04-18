using AutoMapper;
using PedeAqui.Api.Models;

namespace PedeAqui.Api.Profiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<Address, PedeAqui.Core.ValueObjects.Address>()
                .ForAllMembers(opt => opt.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}