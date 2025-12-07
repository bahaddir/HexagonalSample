using HexagonalSample.Application.PrimaryPorts.CategoryPorts;
using HexagonalSample.Application.PrimaryPorts.ProductPorts;
using HexagonalSample.Application.UseCases.CategoryUseCases;
using HexagonalSample.Application.UseCases.ProductUseCases;
using HexagonalSample.Persistence.DependencyResolvers;
using HexagonalSample.Persistence.EFData;
using HexagonalSample.WebApi.Controllers;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

//Bu proje bizim Composition root, run => gercek uygulama...

//HexagonalSample.WebApi => Sadece bir Controller kütüphanesidir...Yani gizli ama gerçek API katmanı...Artık gerçek entry point sizin Host'unuz oldugu icin normal API katmanı projeniz cok daha serbestlik kazanır...

// Add services to the container.

//Todo: => UseCase Resolving Refactoring
//Todo: Mediator paterni refactoring
builder.Services.AddRepositoryService();
builder.Services.AddScoped<ICreateCategoryUseCase, CreateCategoryUseCase>();
builder.Services.AddScoped<ICreateProductUseCase, CreateProductUseCase>();
builder.Services.AddDbContext<MyContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("MyConnection")));



builder.Services.AddControllers().AddApplicationPart(typeof(CategoryController).Assembly); //burası cok önemli.Cünkü Controller'larin bulundugu assembly'i tanıtıyoruz ki API cagrılarında Controller'lar nerede bulunabilsin...Burada Asp .Net Core'a sunu demiş oluyoruz : "HexagonalSample.WebApi icindeki Controllerları da kullan"
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
