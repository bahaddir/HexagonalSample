using MediatR;

namespace HexagonalSample.Application.Mediatr.Commands.CategoryCommands
{
    public class UpdateCategoryCommand: IRequest<string>
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
