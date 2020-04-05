using AutoMapper;
using PedeAqui.Api.Models;

namespace PedeAqui.Api.Profiles
{
    public class MenuItemProfile : Profile
    {
        public MenuItemProfile()
        {
            CreateMap<MenuItem, PedeAqui.Core.ValueObjects.MenuItem>();
        }
    }
}