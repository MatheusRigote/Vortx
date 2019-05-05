using Microsoft.Extensions.DependencyInjection;
using Vortx.Application.Contract;
using Vortx.Application.Services;
using Vortx.Domain.Contract;
using Vortx.Domain.Core.Notification;
using Vortx.Domain.Service;

namespace Vortx.CrossCutting.Ioc.Container
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<Notification>();
            services.AddScoped<IPlan, PlanService>();
            services.AddScoped<IPlanApplication, PlanServiceApplication>();
        }
    }
}
