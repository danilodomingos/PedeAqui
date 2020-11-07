using AutoMapper;
using PedeAqui.Api.Models.Request.Store;
using PedeAqui.Api.Models.Response.Store;
using PedeAqui.Api.Utils;
using PedeAqui.Core.Shared.SeedWork;
using PedeAqui.Core.Stores.Entities;

namespace PedeAqui.Api.Profiles
{
    public class StoreProfile : Profile
    {
        public StoreProfile()
        {
            CreateMap<PostStoreRequest, Store>();
            CreateMap<PageResult<Store>, PageResult<GetStoreResponse>>();

            CreateMap<PatchStoreRequest, Store>()
                .ForAllMembers(opt => opt.Condition((src, dest, srcMember, destMember) => srcMember.IsNotNull()));

            CreateMap<Store, PostStoreResponse>();
            CreateMap<Store, GetStoreResponse>();
        }

    }
}