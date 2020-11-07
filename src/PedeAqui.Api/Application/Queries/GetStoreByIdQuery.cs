using AutoMapper;
using MediatR;
using PedeAqui.Api.Models.Response.Store;
using PedeAqui.Core.Stores.Repositories;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace PedeAqui.Api.Queries
{
    public class GetStoreByIdQuery : IRequest<GetStoreResponse>
    {
        public Guid Id { get; private set; }

        public GetStoreByIdQuery(Guid id)
        {
            Id = id;
        }
    }

    public class GetStoreByIdQueryHandler : IRequestHandler<GetStoreByIdQuery, GetStoreResponse>
    {
        private readonly IMapper _mapper;
        private readonly IStoreRepository _repository;

        public GetStoreByIdQueryHandler(IMapper mapper, IStoreRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public Task<GetStoreResponse> Handle(GetStoreByIdQuery request, CancellationToken cancellationToken)
        {
            var model = _repository.GetById(request.Id);
            return Task.FromResult(_mapper.Map<GetStoreResponse>(model));
        }
    }
}
