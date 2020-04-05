using System.Collections.Generic;

namespace PedeAqui.Api.Models
{
    public class Menu
    {
        public string StoreId { get; set; }
        public List<MenuItem> MenuItems { get; set; }
    }
}