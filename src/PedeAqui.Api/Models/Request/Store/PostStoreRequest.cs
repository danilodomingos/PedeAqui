using System.Collections.Generic;

namespace PedeAqui.Api.Models.Request.Store
{
    public class PostStoreRequest : Models.Store
    {
        public List<Menu> Menus { get; set; }
    }
}