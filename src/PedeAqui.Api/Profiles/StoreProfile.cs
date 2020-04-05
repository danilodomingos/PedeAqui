using AutoMapper;
using PedeAqui.Api.Models.Request;
using PedeAqui.Core.Entities;

namespace PedeAqui.Api.Profiles
{
    public class StoreProfile : Profile
    {
        public StoreProfile()
        {
            CreateMap<StorePostRequest, Store>();
        }
    }
}