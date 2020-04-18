using AutoMapper;
using PedeAqui.Api.Models.Request;
using PedeAqui.Api.Utils;
using PedeAqui.Core.Entities;

namespace PedeAqui.Api.Profiles
{
    public class StoreProfile : Profile
    {
        public StoreProfile()
        {
            CreateMap<StorePostRequest, Store>();
            CreateMap<StorePatchRequest, Store>()
                .ForAllMembers(opt => opt.Condition((src, dest, srcMember, destMember) => srcMember.IsNotNull()));
        }

    }
}