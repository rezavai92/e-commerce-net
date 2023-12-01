using Application.shared.Interfaces;
using Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;
namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IShophubRepository, ShophubRepository>();
            return services;
        }
    }
}