using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using Vortx.Application.AutoMapper.Config;

namespace Vortx.API.Configuration
{
    public static class AutoMapperSetup
    {
        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper();
            
            Automapper.BootStrapper();
        }
    }
}
