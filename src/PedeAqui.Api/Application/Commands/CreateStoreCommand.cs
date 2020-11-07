using AutoMapper;
using MediatR;
using PedeAqui.Api.Models.Request.Store;
using PedeAqui.Api.Models.Response.Store;
using PedeAqui.Core.Stores.Entities;
using PedeAqui.Core.Stores.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace PedeAqui.Api.Commands
{
    public class CreateStoreCommand : IRequestHandler<PostStoreRequest, PostStoreResponse>
    {
        private readonly IMapper _mapper;
        private readonly IStoreRepository _repository;

        public CreateStoreCommand(IMapper mapper, IStoreRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public Task<PostStoreResponse> Handle(PostStoreRequest request, CancellationToken cancellationToken)
        {
            var model = _mapper.Map<Store>(request);
            _repository.Add(model);

            return Task.FromResult(_mapper.Map<PostStoreResponse>(model));
        }
    }
}
