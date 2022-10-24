using Microsoft.AspNetCore.Http;
using SlackMiddlewareAPI.Services;
using System;
using System.Net;
using System.Threading.Tasks;

namespace SlackMiddlewareAPI
{
    public class SlackMiddleware
    {
        private readonly RequestDelegate next;
        private readonly ISlackService _slackService;

        public SlackMiddleware(RequestDelegate next, ISlackService slackService)
        {
            this.next = next;
            this._slackService = slackService;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            { 
                var applicationName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
                await _slackService.NotifyException(applicationName, ex?.ToString());

                context.Response.ContentType = "application/json";
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                await context.Response.WriteAsync(new  
                {
                    StatusCode = context.Response.StatusCode,
                    Message = "Internal Server Error -> Reporting to Slack"
 
                }.ToString());
            }
        }

     
        
    }
}
