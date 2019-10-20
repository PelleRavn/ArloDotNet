using System;
using System.Text.Json.Serialization;

namespace Arlo.Models
{
    public class Session
    {
        [JsonPropertyName("userId")]
        public string UserId { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("token")]
        public string Token { get; set; }

        [JsonPropertyName("accountStatus")]
        public string AccountStatus { get; set; }

        [JsonPropertyName("countryCode")]
        public string CountryCode { get; set; }

        [JsonPropertyName("tocUpdate")]
        public bool TocUpdate { get; set; }

        [JsonPropertyName("policyUpdate")]
        public bool PolicyUpdate { get; set; }

        [JsonPropertyName("validEmail")]
        public bool ValidEmail { get; set; }

        [JsonPropertyName("arlo")]
        public bool Arlo { get; set; }

        [JsonPropertyName("dateCreated")]
        public long DateCreated { get; set; }

        [JsonPropertyName("mailProgramChecked")]
        public bool MailProgramChecked { get; set; }
    }
}
