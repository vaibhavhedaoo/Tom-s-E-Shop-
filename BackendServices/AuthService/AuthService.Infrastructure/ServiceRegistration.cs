using AuthService.Domain.Interfaces;
using AuthService.Infrastructure.Presistance.Repositories;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AuthService.Infrastructure
{
    public class ServiceRegistration
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            // Implementation for service registration
            services.AddDbContext<Presistance.AuthServiceContext>(options =>
            {
                // Configure your DbContext here, e.g., using SQL Server or another provider
                options.UseSqlServer(configuration.GetConnectionString("DBConnection"));
            });


            //Repository registartion
            services.AddScoped<IUserRepository,UserRepository>();

            //Service registration
            services.AddScoped<Application.Interfaces.IUserAppService,Application.Services.UserAppServices>();

            //mapster registration
            var config = new Mapster.TypeAdapterConfig();
            config.Scan(typeof(Application.Mapings.AuthRegister).Assembly);
            services.AddSingleton(config);
            services.AddScoped<IMapper, Mapper>();
        }
    }
}
