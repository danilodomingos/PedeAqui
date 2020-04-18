using AutoMapper;
using PedeAqui.Api.Models.Request;
using PedeAqui.Api.Utils;
using PedeAqui.Core.Aggregates.Store.Entities;

namespace PedeAqui.Api.Profiles
{
    public class StoreProfile : Profile
    {
        public StoreProfile()
        {
            CreateMap<PostStoreRequest, Store>();
            CreateMap<PatchStoreRequest, Store>()
                .ForAllMembers(opt => opt.Condition((src, dest, srcMember, destMember) => srcMember.IsNotNull()));
        }

    }
}