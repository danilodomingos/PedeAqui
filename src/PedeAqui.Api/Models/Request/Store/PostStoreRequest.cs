using MediatR;
using PedeAqui.Api.Models.Response.Store;

namespace PedeAqui.Api.Models.Request.Store
{
    public class PostStoreRequest : StoreModel, IRequest<PostStoreResponse>
    {
    }
}