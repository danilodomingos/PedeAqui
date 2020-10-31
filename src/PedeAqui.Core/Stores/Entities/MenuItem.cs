using PedeAqui.Core.Shared;
using PedeAqui.Core.Shared.SeedWork.Enums;

namespace PedeAqui.Core.Stores.Entities
{
    public class MenuItem : BaseEntity
    {
        public string Name { get; }
        public string PhotoUrl { get; }
        public double Price { get; }
        public ItemTypeEnum Type { get; }
        public bool IsUnavailable { get; }
    }
}