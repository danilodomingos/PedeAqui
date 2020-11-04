using PedeAqui.Core.Shared;
using PedeAqui.Core.Shared.SeedWork.Enums;

namespace PedeAqui.Core.Stores.Entities
{
    public class MenuItem : BaseEntity
    {
        public string Name { get; private set; }
        public string PhotoUrl { get; private set; }
        public double Price { get; private set; }
        public ItemTypeEnum Type { get; private set; }
        public bool IsUnavailable { get; private set; }
    }
}