using AutoMapper;
using HexagonalSample.Application.Mediatr.Commands.ProductCommands;
using HexagonalSample.Domain.Entities;
using HexagonalSample.Domain.SecondaryPorts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexagonalSample.Application.Mediatr.Handlers.Modify.ProductCommandHandlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, string>
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public CreateProductCommandHandler(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<string> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {

            var product = new Product
            {
                ProductName = request.ProductName,
                UnitPrice = request.UnitPrice,
                CategoryId =request.CategoryId,
                CreatedDate = DateTime.Now
            };

            await _repository.CreateAsync(product);
            return "eklendi";
        }
    }
}
