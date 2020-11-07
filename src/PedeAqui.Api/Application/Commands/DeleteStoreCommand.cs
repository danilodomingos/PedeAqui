using MediatR;
using PedeAqui.Core.Stores.Repositories;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace PedeAqui.Api.Application.Commands
{
    public class DeleteStoreCommand : IRequest<bool>
    {
        public Guid Id { get; set; }

        public DeleteStoreCommand(Guid id) => Id = id;
    }

    public class DeleteStoreCommandHandler : IRequestHandler<DeleteStoreCommand, bool>
    {
        private readonly IStoreRepository _repository;

        public DeleteStoreCommandHandler(IStoreRepository repository)
        {
            _repository = repository;
        }

        public Task<bool> Handle(DeleteStoreCommand request, CancellationToken cancellationToken)
        {
            _repository.Delete(request.Id);
            return Task.FromResult(true);
        }
    }
}
