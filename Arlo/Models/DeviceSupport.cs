using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Arlo.Models
{
    public class DeviceSupport
    {
        [JsonPropertyName("devices")]
        public Dictionary<string, Docs> Devices { get; set; }

        [JsonPropertyName("arlosmart")]
        public Docs Arlosmart { get; set; }
    }

    public class Docs
    {
        [JsonPropertyName("modelIds")]
        public List<string> ModelIds { get; set; }

        [JsonPropertyName("smartHubs")]
        public List<string> SmartHubs { get; set; }

        [JsonPropertyName("connectionTypes")]
        public Dictionary<string, bool> ConnectionTypes { get; set; }

        [JsonPropertyName("kbArticles")]
        public Dictionary<string, Uri> KbArticles { get; set; }

        [JsonPropertyName("videos")]
        public Dictionary<string, Uri> Videos { get; set; }

        [JsonPropertyName("arloVideos")]
        public Dictionary<string, Uri> ArloVideos { get; set; }

        [JsonPropertyName("ultraProductTourkbArticles")]
        public Dictionary<string, Uri> UltraProductTourkbArticles { get; set; }

        [JsonPropertyName("pro3ProductTourKbArticles")]
        public Dictionary<string, Uri> Pro3ProductTourKbArticles { get; set; }
    }
}
