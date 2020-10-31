using System.Collections.Generic;

namespace PedeAqui.Api.Models.Request.Store
{
    public class PostStoreRequest : StoreModel
    {
        public List<MenuModel> Menus { get; set; }
    }
}