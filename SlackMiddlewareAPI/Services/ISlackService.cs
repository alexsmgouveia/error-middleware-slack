using System.Threading.Tasks;

namespace SlackMiddlewareAPI.Services
{
    public interface ISlackService
    {
        Task NotifyException(string applicationName, string text);
    }
}