using HexagonalSample.Application.Mediatr.Commands.ProductCommands;
using HexagonalSample.Domain.SecondaryPorts;
using MediatR;

namespace HexagonalSample.Application.Mediatr.Handlers.Modify.ProductCommandHandlers
{
    public class RemoveProductCommandHandler : IRequestHandler<RemoveProductCommand, string>
    {
        private readonly IProductRepository _repository;

        public RemoveProductCommandHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<string> Handle(RemoveProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _repository.GetByIdAsync(request.Id);
            if (product == null) return "bulunamadı";

            _repository.Delete(product);
            return "silindi";
        }
    }
}
