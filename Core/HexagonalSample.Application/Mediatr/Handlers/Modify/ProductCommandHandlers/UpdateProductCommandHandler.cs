using HexagonalSample.Application.Mediatr.Commands.ProductCommands;
using HexagonalSample.Domain.SecondaryPorts;
using MediatR;

namespace HexagonalSample.Application.Mediatr.Handlers.Modify.ProductCommandHandlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, string>
    {
        private readonly IProductRepository _repository;

        public UpdateProductCommandHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<string> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _repository.GetByIdAsync(request.Id);
            if (product == null) return " bulunamadı";

            product.ProductName = request.ProductName;
            product.UnitPrice = request.UnitPrice;
            product.CategoryId = request.CategoryId;
            product.UpdatedDate = DateTime.Now;

             _repository.Update(product);

            return "güncellendi";
        }
    }
}
