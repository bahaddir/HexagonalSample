using AutoMapper;
using HexagonalSample.Application.Mediatr.Queries.ProductQueries;
using HexagonalSample.Application.Mediatr.Results.ProductResults;
using HexagonalSample.Domain.SecondaryPorts;
using MediatR;

namespace HexagonalSample.Application.Mediatr.Handlers.Read
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductByIdQueryResult>
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public GetProductByIdQueryHandler(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetProductByIdQueryResult> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await _repository.GetByIdAsync(request.Id);

            return _mapper.Map<GetProductByIdQueryResult>(product);
        }
    }
}
