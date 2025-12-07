using HexagonalSample.Application.Mediatr.Results.ProductResults;
using MediatR;

namespace HexagonalSample.Application.Mediatr.Queries.ProductQueries
{
    public class GetProductByIdQuery : IRequest<GetProductByIdQueryResult>
    {
        public int Id { get; set; }

        public GetProductByIdQuery(int id)
        {
            Id = id;
        }


    }
}
