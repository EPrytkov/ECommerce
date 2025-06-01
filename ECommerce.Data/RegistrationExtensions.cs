
using ECommerce.Data.Repositories;
using ECommerce.Data.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.Data;

public static class RegistrationExtensions
{
    public static IServiceCollection AddDataModule(this IServiceCollection services)
    {
        services = AddRepositories(services);
        
        return services;
    }
    
    private static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        return services.AddScoped<ICategoriesRepository, CategoriesRepository>();
    }
}