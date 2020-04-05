using System.Collections.Generic;

namespace PedeAqui.Api.Models
{
    public class Store
    {
        public string Name { get; set; }
        public string LegalName { get; set; }
        public string Document { get; set; }
        public Address Address { get; set; }
        public List<Menu> Menus { get; set; }
    }
}