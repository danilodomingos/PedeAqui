using AutoMapper;
using PedeAqui.Api.Models;
using PedeAqui.Core.Shared.ValueObjects;

namespace PedeAqui.Api.Profiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<AddressModel, Address>()
                .ReverseMap()
                .ForAllMembers(opt => opt.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}