using CatalogService.Application.Interfaces;
using CatalogService.Application.Mapings;
using CatalogService.Application.Services;
using CatalogService.Domain.Interfaces;
using CatalogService.Infrastructure.Persistance;
using CatalogService.Infrastructure.Persistance.Repositories;
using Mapster;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CatalogService.Infrastructure
{
    public class ServiceRegistration
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            // Implementation for service registration
            string connectionString = configuration.GetConnectionString("DBConnection");

            services.AddDbContext<CatalogServiceContext>(options =>
            {
                // Configure your DbContext here, e.g., using SQL Server or another provider
                options.UseSqlServer(connectionString);
            });

            //Repository registartion
            services.AddScoped<IProductRepository, ProductRepository>();

            //Service registration
            services.AddScoped<IProductAppService, ProductAppService>();

            //mapster registration
            var config = TypeAdapterConfig.GlobalSettings;
            config.Scan(typeof(CatalogRegister).Assembly);
            services.AddSingleton(config);
            services.AddScoped<IMapper, Mapper>();
        }
    }
}
