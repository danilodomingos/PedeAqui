using PedeAqui.Core.Shared;
using PedeAqui.Core.Shared.ValueObjects;
using System.Collections.Generic;

namespace PedeAqui.Core.Stores.Entities
{
    public class Store : BaseEntity
    {
        public string Name { get; private set; }
        public string LegalName { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public string Document { get; private set; }
        public Address Address { get; private set; }
        public List<Menu> Menus { get; private set; }
    }
}