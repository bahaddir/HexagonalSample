using HexagonalSample.Application.Mediatr.Commands.CategoryCommands;
using HexagonalSample.Domain.SecondaryPorts;
using MediatR;

namespace HexagonalSample.Application.Mediatr.Handlers.Modify.CategoryCommandHandlers
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, string>
    {
        private readonly ICategoryRepository _repository;

        public UpdateCategoryCommandHandler(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<string> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = await _repository.GetByIdAsync(request.Id);
            if (category == null) return " bulunamadı";

            category.CategoryName = request.CategoryName;
            category.Description = request.Description;
            category.UpdatedDate = DateTime.Now;

             _repository.Update(category);

            return "güncellendi";
        }
    }
}
