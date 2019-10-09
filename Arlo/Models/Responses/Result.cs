using System.Collections.Generic;
using System.Net;
using System.Text.Json.Serialization;

namespace Arlo.Models
{
    public sealed class Result<T>
    {
        public HttpStatusCode StatusCode { get; set; }

        [JsonPropertyName("success")]
        public bool Success { get; set; }

        [JsonPropertyName("data")]
        public T Data { get; set; }

        // Error messages
        public ErrorData ErrorData { get; set; }
    }
}
