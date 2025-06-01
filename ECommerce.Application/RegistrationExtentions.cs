using ECommerce.Application.Services;
using ECommerce.Application.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.Application;

public static class RegistrationsExtensions
{
    public static IServiceCollection AddApplicationModule(this IServiceCollection services)
    {
        services = AddServices(services);
        
        return services;
    }

    private static IServiceCollection AddServices(this IServiceCollection services)
    {
        return services.AddScoped<ICategoriesService, CategoriesService>();
    }
}