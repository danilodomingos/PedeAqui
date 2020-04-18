using System.Collections.Generic;

namespace PedeAqui.Core.Entities
{
    public class Menu : BaseEntity
    {
        public List<MenuItem> Items { get; private set; }
    }
}