using MediatR;
using PedeAqui.Api.Models.Response.Store;
using System;
using System.Text.Json.Serialization;

namespace PedeAqui.Api.Models.Request.Store
{
    public class PatchStoreRequest : StoreModel, IRequest<PatchStoreResponse>
    {
        [JsonIgnore]
        public Guid Id { get; set; }
    }
}