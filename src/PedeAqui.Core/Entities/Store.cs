using System.Collections.Generic;
using PedeAqui.Core.ValueObjects;

namespace PedeAqui.Core.Entities
{
    public class Store : BaseEntity
    {
        public string Name { get; set; }
        public string LegalName { get; set; }
        public string Document { get; set; }
        public Address Address { get; set; }
        public List<Menu> Menus { get; set; }
    }
}