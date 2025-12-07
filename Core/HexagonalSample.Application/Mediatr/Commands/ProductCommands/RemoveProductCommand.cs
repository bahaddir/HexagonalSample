using MediatR;

namespace HexagonalSample.Application.Mediatr.Commands.ProductCommands
{
    public class RemoveProductCommand : IRequest<string>
    {
        public int Id { get; set; }

        public RemoveProductCommand(int id)
        {
            Id = id;
        }

    }
}
