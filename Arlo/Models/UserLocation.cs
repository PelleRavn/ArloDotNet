using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Arlo.Models
{
    public class UserLocation
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("ownerId")]
        public string OwnerId { get; set; }

        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }

        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("homeMode")]
        public string HomeMode { get; set; }

        [JsonPropertyName("awayMode")]
        public string AwayMode { get; set; }

        [JsonPropertyName("geoEnabled")]
        public bool GeoEnabled { get; set; }

        [JsonPropertyName("geoRadius")]
        public int GeoRadius { get; set; }

        [JsonPropertyName("uniqueIds")]
        public List<string> UniqueIds { get; set; }

        [JsonPropertyName("smartDevices")]
        public List<string> SmartDevices { get; set; }

        [JsonPropertyName("pushNotifyDevices")]
        public List<string> PushNotifyDevices { get; set; }
    }
}
