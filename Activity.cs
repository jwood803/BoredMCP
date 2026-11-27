using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace BoredMCP
{
    public class Activity
    {
        [JsonPropertyName("activity")]
        public required string ActivityDescription { get; set; }
        public float Availability { get; set; }
        public required string Type { get; set; }
        public int Participants { get; set; }
        public float Price { get; set; }
        public string? Accessibility { get; set; }
        public string? Duration { get; set; }
        public bool IsKidFriendly { get; set; }
        public string? Link { get; set; }
        public int Key { get; set; }
    }

}
