using System;

namespace PedeAqui.Api.Models.Response.Store
{
    public class GetStoreResponse : StoreModel
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
