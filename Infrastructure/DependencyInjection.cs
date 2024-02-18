﻿using Application.shared.Interfaces;
using Infrastructure.Logging;
using Infrastructure.Mediators;
using Infrastructure.Repository;
using Infrastructure.RestCommunication;
using Microsoft.Extensions.DependencyInjection;
namespace Infrastructure
{
    public static class DependencyInjection
    {
      
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddHttpClient();
            services.AddTransient<IShophubRepository, ShophubRepository>();
            services.AddTransient<ICommandDispatcher, CommandDispatcher>();
            services.AddTransient<IQueryDispatcher, QueryDispatcher>();
            services.AddTransient<IRestCommunicationService, RestCommunicationService>();
            services.AddSingleton(typeof(IPlatformLogger<>), typeof(PlatformLoggerService<>));
            return services;
        }

       
    }

   
}