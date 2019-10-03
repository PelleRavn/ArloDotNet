using System.Text.Json.Serialization;

namespace Arlo.Models
{
    public class Result<T>
    {
        public Result()
        {

        }

        [JsonPropertyName("data")]
        public T Data { get; set; }

        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
