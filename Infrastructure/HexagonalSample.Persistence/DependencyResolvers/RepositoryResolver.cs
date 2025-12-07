using HexagonalSample.Domain.SecondaryPorts;
using HexagonalSample.Persistence.EFData;
using HexagonalSample.Persistence.EFRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexagonalSample.Persistence.DependencyResolvers
{
    public static class PersistenceServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MyContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("MyConnection")));

            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
