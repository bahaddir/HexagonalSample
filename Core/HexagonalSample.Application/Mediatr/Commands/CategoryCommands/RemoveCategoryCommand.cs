using MediatR;

namespace HexagonalSample.Application.Mediatr.Commands.CategoryCommands
{
    public class  RemoveCategoryCommand:IRequest<string>
    {
        public int Id { get; set; }

        public RemoveCategoryCommand(int id)
        {
            Id = id;
        }

    }
}
