using AutoMapper;
using HexagonalSample.Application.Mediatr.Queries.CategoryQueries;
using HexagonalSample.Application.Mediatr.Results.CategoryResults;
using HexagonalSample.Domain.SecondaryPorts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexagonalSample.Application.Mediatr.Handlers.Read
{
    public class GetCategoryQueryHandler : IRequestHandler<GetCategoryQuery, List<GetCategoryQueryResult>>
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;

        public GetCategoryQueryHandler(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetCategoryQueryResult>> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
        {
            var category = await _repository.GetAllAsync();
            return _mapper.Map<List<GetCategoryQueryResult>>(category);
        }
    }
}
