using System.Collections.Generic;

namespace PedeAqui.Api.Models.Request
{
    public class StorePostRequest : Store
    {
        public List<Menu> Menus { get; set; }
    }
}