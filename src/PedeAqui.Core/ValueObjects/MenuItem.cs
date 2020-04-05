using PedeAqui.Core.SeedWork.Enums;

namespace PedeAqui.Core.ValueObjects
{
    public class MenuItem
    {
        public string Name { get; set; }
        public string PhotoUrl { get; set; }
        public double Price { get; set; }
        public ItemTypeEnum Type { get; set; }
        public bool IsUnavailable { get; set; }
    }
}