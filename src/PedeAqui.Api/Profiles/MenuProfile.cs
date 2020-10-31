using AutoMapper;
using PedeAqui.Api.Models;
using PedeAqui.Core.Stores.Entities;

namespace PedeAqui.Api.Profiles
{
    public class MenuProfile : Profile
    {
        public MenuProfile()
        {
            CreateMap<MenuModel, Menu>()
                .ForAllMembers(opt => opt.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}