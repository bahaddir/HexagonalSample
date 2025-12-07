using HexagonalSample.Application.Mediatr.Results.CategoryResults;
using MediatR;

namespace HexagonalSample.Application.Mediatr.Queries.CategoryQueries
{
    public class GetCategoryByIdQuery : IRequest<GetCategoryByIdQueryResult>
    {
        public int Id { get; set; }

        public GetCategoryByIdQuery(int id)
        {
            Id = id;
        }


    }
}
