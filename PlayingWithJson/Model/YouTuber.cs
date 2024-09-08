using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PlayingWithJson.Model
{
    internal class YouTuber
    {

        [JsonPropertyName("name")]
        public string Name { get; set; }
        public string Channel { get; set; }

        [JsonPropertyName("active")]
        public Boolean Active { get; set; }

        [JsonPropertyName("age")]
        public int Age { get; set; }


        [JsonPropertyName("member")]
        public string[] Members { get; set; }

    }
}
