using AutoMapper;
using PedeAqui.Api.Models;

namespace PedeAqui.Api.Profiles
{
    public class MenuItemProfile : Profile
    {
        public MenuItemProfile()
        {
            CreateMap<MenuItem, PedeAqui.Core.Entities.MenuItem>()
                .ForAllMembers(opt => opt.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}