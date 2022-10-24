using System.Text;

namespace SlackMiddlewareAPI.Extensions
{
    public static class SlackMessageExtensions
    {
        /// <summary>
        /// https://api.slack.com/reference/surfaces/formatting
        /// </summary>
        /// <param name="text"></param>
        public static string EscapingText(this string text)
        {
            return text?
               .Replace("&", string.Empty)
               .Replace("<", string.Empty)
               .Replace(">", string.Empty)
               .Replace("`", string.Empty); 
        }
         
    }
} 