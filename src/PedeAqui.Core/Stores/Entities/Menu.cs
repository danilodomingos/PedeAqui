using PedeAqui.Core.Shared;
using PedeAqui.Core.Shared.SeedWork.Enums;
using System.Collections.Generic;

namespace PedeAqui.Core.Stores.Entities
{
    public class Menu : BaseEntity
    {
        public List<MenuItem> Items { get; private set; }
        public List<AvailabilityEnum> Availability { get; private set; }
    }
}