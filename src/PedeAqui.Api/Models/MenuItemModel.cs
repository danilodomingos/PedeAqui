using PedeAqui.Core.Shared.SeedWork.Enums;

namespace PedeAqui.Api.Models
{
    public class MenuItemModel
    {
        public string Name { get; set; }
        public string PhotoUrl { get; set; }
        public double Price { get; set; }
        public ItemTypeEnum Type { get; set; }
        public bool IsUnavailable { get; set; }
    }
}