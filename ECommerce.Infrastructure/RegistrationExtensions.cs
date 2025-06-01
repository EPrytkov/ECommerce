using ECommerce.Infrastructure.Repositories;
using ECommerce.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.Infrastructure;

public static class RegistrationExtensions
{
    public static IServiceCollection AddInfrastructureModule(this IServiceCollection services, IConfiguration configuration)
    {
        services = AddRepositories(services);
        services = AddDbContext(services, configuration);
        
        return services;
    }
    
    private static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        return services.AddScoped<ICategoriesRepository, CategoriesRepository>();
    }

    private static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        return services.AddDbContext<ECommerceDbContext>(c => 
            c.UseNpgsql(configuration.GetConnectionString("ECommerce")));
    }
}