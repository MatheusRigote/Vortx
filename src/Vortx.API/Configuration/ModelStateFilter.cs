using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System.Net;
using System.Threading.Tasks;
using Vortx.Domain.Core.Notification;

namespace Vortx.API.Configuration
{
    public class ModelStateFilter : IAsyncResultFilter
    {
        private readonly Notification _notification;

        public ModelStateFilter(Notification notification)
        {
            _notification = notification;
        }

        public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            if (_notification.HasNotifications)
            {
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;                                
                await context.HttpContext.Response.WriteAsync(JsonConvert.SerializeObject(_notification.Notifications));
                return;
            }

            await next();
        }
    }
}
