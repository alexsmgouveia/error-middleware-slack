using Newtonsoft.Json;

namespace SlackMiddlewareAPI.Models
{
    public class TextBlock
    {
        public TextBlock()
        {

        }

        public TextBlock(string type, string text)
        {
            Type = type;
            Text = text;
        }


        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
