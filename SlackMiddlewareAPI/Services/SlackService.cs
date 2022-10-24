using Microsoft.Extensions.Configuration;
using SlackMiddlewareAPI.Extensions;
using SlackMiddlewareAPI.Models;
using SlackMiddlewareAPI.Resources;
using SlackMiddlewareAPI.Util;
using System;
using System.Threading.Tasks;

namespace SlackMiddlewareAPI.Services
{
    public class SlackService : ISlackService
    {
        public readonly Uri _webHookUri; 
        public SlackService(IConfiguration configuration)
        {
            _webHookUri = new Uri(configuration.GetValue<string>("WEBHOOK"));
        }
        
        public async Task NotifyException(string applicationName, string text)
        {
            var title = string.Format(SlackResource.TITLE, applicationName);
            var body = $"```{text.EscapingText()}```";

            var blocksItems = new BlocksItems(new Block(title), new Block(body));
            WebClientMessage.SendObject(_webHookUri, blocksItems);

            await Task.CompletedTask;
        }


       
    }
}
