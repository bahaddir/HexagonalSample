using AutoMapper;
using HexagonalSample.Application.Mediatr.Commands.CategoryCommands;
using HexagonalSample.Application.Mediatr.Commands.ProductCommands;
using HexagonalSample.Application.Mediatr.Results.CategoryResults;
using HexagonalSample.Application.Mediatr.Results.ProductResults;
using HexagonalSample.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexagonalSample.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<Product, GetProductQueryResult>();
            CreateMap<Product, GetProductByIdQueryResult>();
            CreateMap<CreateProductCommand, Product>();
            CreateMap<UpdateProductCommand, Product>();


            CreateMap<Category, GetCategoryQueryResult>();
            CreateMap<Category, GetCategoryByIdQueryResult>();
            CreateMap<CreateCategoryCommand, Category>();
            CreateMap<UpdateCategoryCommand, Category>();

        }
    }
}
