using System.Collections.Generic;
using PedeAqui.Core.Shared.Entities;
using PedeAqui.Core.Shared.ValueObjects;

namespace PedeAqui.Core.Aggregates.Store.Entities
{
    public class Store : BaseEntity
    {
        public string Name { get; set; }
        public string LegalName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Document { get; set; }
        public Address Address { get; set; }
        public List<Menu> Menus { get; set; }
    }
}