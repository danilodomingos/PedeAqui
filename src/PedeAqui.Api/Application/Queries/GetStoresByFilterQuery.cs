using AutoMapper;
using MediatR;
using PedeAqui.Api.Models.Request.Store;
using PedeAqui.Api.Models.Response.Store;
using PedeAqui.Core.Shared.SeedWork;
using PedeAqui.Core.Stores.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace PedeAqui.Api.Application.Queries
{
    public class GetStoresByFilterQuery : IRequestHandler<GetStoreByFilterRequest, PageResult<GetStoreResponse>>
    {
        private readonly IMapper _mapper;
        private readonly IStoreRepository _repository;

        public GetStoresByFilterQuery(IMapper mapper, IStoreRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public Task<PageResult<GetStoreResponse>> Handle(GetStoreByFilterRequest request, CancellationToken cancellationToken)
        {
            var stores = _repository.GetAll(pageSize: request.PageSize, pageNumber: request.PageNumber);
            return Task.FromResult(_mapper.Map<PageResult<GetStoreResponse>>(stores));
        }
    }
}
