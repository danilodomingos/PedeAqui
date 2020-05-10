using System;

namespace PedeAqui.Infra.Publishers.Request
{
    //TO-DO: Essa classe deveria pertencer a um SDK.

    public class PostOrderRequest
    {
        public Guid ClientId { get; set; }
        public Guid StoreId { get; set; }
        public Guid ItemMenuId { get; set; }
        public string ItemMenuName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string StorePhotoUrl { get; set; }
        public string ItemMenuPhotoUrl { get; set; }
    }
}