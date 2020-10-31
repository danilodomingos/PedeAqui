using PedeAqui.Core.Shared;
using PedeAqui.Core.Shared.ValueObjects;
using System.Collections.Generic;

namespace PedeAqui.Core.Stores.Entities
{
    public class Store : BaseEntity
    {
        public string Name { get; }
        public string LegalName { get; }
        public string Email { get; }
        public string Phone { get; }
        public string Document { get; }
        public Address Address { get; }
        public List<Menu> Menus { get; }
    }
}