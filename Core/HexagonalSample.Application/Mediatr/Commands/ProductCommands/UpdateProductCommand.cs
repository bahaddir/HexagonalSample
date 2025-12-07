using MediatR;

namespace HexagonalSample.Application.Mediatr.Commands.ProductCommands
{
    public class UpdateProductCommand : IRequest<string>
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int? CategoryId { get; set; }

    }
}
