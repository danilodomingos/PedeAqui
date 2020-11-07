using MediatR;
using PedeAqui.Api.Models.Response.Store;
using PedeAqui.Core.Shared.SeedWork;

namespace PedeAqui.Api.Models.Request.Store
{
    public class GetStoreByFilterRequest : IRequest<PageResult<GetStoreResponse>>
    {
        public string Name { get; set; }
        public int PageSize { get; set; } = 10;
        public int PageNumber { get; set; } = 1;
    }
}
