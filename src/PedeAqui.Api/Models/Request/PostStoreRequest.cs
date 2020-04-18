using System.Collections.Generic;

namespace PedeAqui.Api.Models.Request
{
    public class PostStoreRequest : Store
    {
        public List<Menu> Menus { get; set; }
    }
}