using AutoMapper;
using MediatR;
using PedeAqui.Api.Models.Request.Store;
using PedeAqui.Api.Models.Response.Store;
using PedeAqui.Core.Stores.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace PedeAqui.Api.Application.Commands
{
    public class UpdateStoreCommandHandler : IRequestHandler<PatchStoreRequest, PatchStoreResponse>
    {
        private readonly IMapper _mapper;
        private readonly IStoreRepository _repository;

        public UpdateStoreCommandHandler(IMapper mapper, IStoreRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public Task<PatchStoreResponse> Handle(PatchStoreRequest request, CancellationToken cancellationToken)
        {
            var actual = _repository.GetById(request.Id);

            if (actual == null)
                return null;

            _mapper.Map(request, actual);
            _repository.Update(actual);

            return Task.FromResult(_mapper.Map<PatchStoreResponse>(actual));
        }
    }
}
