using AutoMapper;
using HexagonalSample.Application.Mediatr.Commands.CategoryCommands;
using HexagonalSample.Domain.Entities;
using HexagonalSample.Domain.SecondaryPorts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexagonalSample.Application.Mediatr.Handlers.Modify.CategoryCommandHandlers
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, string>
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;

        public CreateCategoryCommandHandler(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<string> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {

            var category = new Category
            {
                CategoryName = request.CategoryName,
                Description = request.Description,
                CreatedDate = DateTime.Now
            };

            await _repository.CreateAsync(category);
            return "eklendi";
        }
    }
}
