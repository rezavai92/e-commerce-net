using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            var assembly = typeof(DependencyInjection).Assembly;
            services.AddSingleton(assembly);    
            return services;
        }
    }
}