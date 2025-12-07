using HexagonalSample.Application.Mediatr.Commands.CategoryCommands;
using HexagonalSample.Domain.SecondaryPorts;
using MediatR;

namespace HexagonalSample.Application.Mediatr.Handlers.Modify.CategoryCommandHandlers
{
    public class RemoveCategoryCommandHandler : IRequestHandler<RemoveCategoryCommand, string>
    {
        private readonly ICategoryRepository _repository;

        public RemoveCategoryCommandHandler(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<string> Handle(RemoveCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = await _repository.GetByIdAsync(request.Id);
            if (category == null) return "bulunamadı";

            _repository.Delete(category);
            return "silindi";
        }
    }
}
