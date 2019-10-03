using System.Text.Json.Serialization;

namespace Arlo.Models
{
    public class DeviceProperties
    {
        public DeviceProperties()
        {

        }

        [JsonPropertyName("modelId")]
        public string ModelId { get; set; }

        [JsonPropertyName("olsonTimeZone")]
        public string OlsonTimeZone { get; set; }

        [JsonPropertyName("hwVersion")]
        public string HwVersion { get; set; }
    }
}
