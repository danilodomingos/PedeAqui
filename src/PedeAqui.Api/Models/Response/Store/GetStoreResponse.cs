using System;

namespace PedeAqui.Api.Models.Response.Store
{
    public class GetStoreResponse : StoreModel
    {
        public Guid Id { get; }
        public DateTime Created { get; }
        public DateTime Updated { get; }
    }
}
