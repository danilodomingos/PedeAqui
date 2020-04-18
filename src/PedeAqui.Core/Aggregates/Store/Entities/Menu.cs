using System.Collections.Generic;
using PedeAqui.Core.Shared.Entities;

namespace PedeAqui.Core.Aggregates.Store.Entities
{
    public class Menu : BaseEntity
    {
        public List<MenuItem> Items { get; private set; }
    }
}