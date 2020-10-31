using AutoMapper;
using PedeAqui.Api.Models.Request.Store;
using PedeAqui.Api.Utils;
using PedeAqui.Core.Stores.Entities;

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