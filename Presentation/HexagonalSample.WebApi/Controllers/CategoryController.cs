using HexagonalSample.Application.DtoClasses.Categories;
using HexagonalSample.Application.PrimaryPorts.CategoryPorts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexagonalSample.WebApi.Controllers
{
    //Dikkat ettiyseniz artık Composition Root normal şartlardaki gibi bu katmanda degildir...BUrası sadece bir Controller kütüphanesidir...Geliştirme bu alanda yapılacaktır...Middleware girişlerinden burasının haberi yoktur...Bu size Persistence'tan tamamen izole olmayı saglar..Ve geliştirirken kullanmamanız gereken , Encapsulation'i bozacak tiplerden uzak bir alan saglar...

    [ApiController]
    [Route("api/[controller]")]
    
    public class CategoryController : ControllerBase
    {
        private readonly ICreateCategoryUseCase _createCategoryUseCase;

        public CategoryController(ICreateCategoryUseCase createCategoryUseCase)
        {
            _createCategoryUseCase = createCategoryUseCase;
        }

        public record CreateCategoryRequest(string Name,string Description);

        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody] CreateCategoryRequest request)
        {
            CreateCategoryCommand command = new()
            {
                Name = request.Name,
                Description = request.Description
            };

            await _createCategoryUseCase.ExecuteAsync(command);
            return Ok("Category created");
        }
    }
}
