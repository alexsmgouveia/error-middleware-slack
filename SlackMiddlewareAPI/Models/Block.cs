using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SlackMiddlewareAPI.Models
{
    public class Block
    { 
        public Block(string text, string typeBlock = "section", string typeText = "mrkdwn")
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new System.ArgumentException($"'{nameof(text)}' cannot be null or empty.", nameof(text));
            }

            if (string.IsNullOrEmpty(typeBlock))
            {
                throw new System.ArgumentException($"'{nameof(typeBlock)}' cannot be null or empty.", nameof(typeBlock));
            }

            if (string.IsNullOrEmpty(typeText))
            {
                throw new System.ArgumentException($"'{nameof(typeText)}' cannot be null or empty.", nameof(typeText));
            }

            Type = typeBlock;
            Text = new TextBlock(typeText, text);
        }

         

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public TextBlock Text { get; set; }

    }
}
