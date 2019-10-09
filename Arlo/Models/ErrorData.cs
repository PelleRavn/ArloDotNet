using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Arlo.Models
{
    public class ErrorData
    {
        public ErrorData()
        {

        }

        [JsonPropertyName("error")]
        public string Error { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        [JsonPropertyName("errors")]
        public List<string> Errors { get; set; }
    }
}
