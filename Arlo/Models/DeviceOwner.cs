using System.Text.Json.Serialization;

namespace Arlo.Models
{
    public class DeviceOwner
    {
        public DeviceOwner()
        {

        }

        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        [JsonPropertyName("ownerId")]
        public string OwnerId { get; set; }
    }
}
