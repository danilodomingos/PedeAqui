using AutoMapper;
using PedeAqui.Api.Models;

namespace PedeAqui.Api.Profiles
{
    public class MenuProfile : Profile
    {
        public MenuProfile()
        {
            CreateMap<Menu, PedeAqui.Core.ValueObjects.Menu>();
        }
    }
}