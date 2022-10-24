using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SlackMiddlewareAPI.Models
{
    public class BlocksItems
    { 
        public BlocksItems(params Block[] blocks)
        {

            Blocks = new List<Block>();

            if (!(blocks is null))
            {
                Blocks.AddRange(blocks);
            }
        }

        [JsonProperty("blocks")]
        public List<Block> Blocks { get; set; }
    }
}
