using Core.Shared.Interfaces;
using Core.Shared.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Shared
{
    public static class dependencyInjection
    {
        public static IServiceCollection  AddCoreServices(this IServiceCollection services)
        {
            services.AddTransient<IJwtService, JwtService>();
            return services;
        }
    }
}
