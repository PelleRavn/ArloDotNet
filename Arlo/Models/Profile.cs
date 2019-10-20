using System;
using System.Text.Json.Serialization;

namespace Arlo.Models
{
    public class Profile
    {
        [JsonPropertyName("_type")]
        public string Type { get; set; }

        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        [JsonPropertyName("language")]
        public string Language { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("acceptedPolicy")]
        public int AcceptedPolicy { get; set; }

        [JsonPropertyName("currentPolicy")]
        public int CurrentPolicy { get; set; }

        [JsonPropertyName("validEmail")]
        public bool ValidEmail { get; set; }
    }
}
