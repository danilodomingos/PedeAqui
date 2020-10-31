using AutoMapper;
using PedeAqui.Api.Models;
using PedeAqui.Core.Stores.Entities;

namespace PedeAqui.Api.Profiles
{
    public class MenuItemProfile : Profile
    {
        public MenuItemProfile()
        {
            CreateMap<MenuItemModel, MenuItem>()
                .ForAllMembers(opt => opt.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}