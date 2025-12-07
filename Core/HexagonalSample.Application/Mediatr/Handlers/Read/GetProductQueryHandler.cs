using AutoMapper;
using HexagonalSample.Application.Mediatr.Queries.ProductQueries;
using HexagonalSample.Application.Mediatr.Results.ProductResults;
using HexagonalSample.Domain.SecondaryPorts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexagonalSample.Application.Mediatr.Handlers.Read
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, List<GetProductQueryResult>>
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public GetProductQueryHandler(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetProductQueryResult>> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            var product = await _repository.GetAllAsync();
            return _mapper.Map<List<GetProductQueryResult>>(product);
        }
    }
}
