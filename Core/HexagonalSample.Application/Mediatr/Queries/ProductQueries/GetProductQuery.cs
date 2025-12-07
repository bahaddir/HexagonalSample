using HexagonalSample.Application.Mediatr.Results.ProductResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexagonalSample.Application.Mediatr.Queries.ProductQueries
{
    public class GetProductQuery : IRequest<List<GetProductQueryResult>>
    {

    }
}
