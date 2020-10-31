using PedeAqui.Core.Shared;
using System.Collections.Generic;

namespace PedeAqui.Core.Stores.Entities
{
    public class Menu : BaseEntity
    {
        public List<MenuItem> Items { get; }
    }
}