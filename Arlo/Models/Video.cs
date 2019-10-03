using System;
using System.Text.Json.Serialization;

namespace Arlo.Models
{
    public class Video
    {
        public Video()
        {

        }

        [JsonPropertyName("ownerId")]
        public string OwnerId { get; set; }

        [JsonPropertyName("uniqueId")]
        public string UniqueId { get; set; }

        [JsonPropertyName("deviceId")]
        public string DeviceId { get; set; }

        [JsonPropertyName("createdDate")]
        public string CreatedDate { get; set; }

        [JsonPropertyName("currentState")]
        public string CurrentState { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        [JsonPropertyName("createdBy")]
        public string CreatedBy { get; set; }

        [JsonPropertyName("lastModified")]
        public long LastModified { get; set; }

        [JsonPropertyName("localCreatedDate")]
        public long LocalCreatedDate { get; set; }

        [JsonPropertyName("presignedContentUrl")]
        public string PresignedContentUrl { get; set; }

        [JsonPropertyName("presignedThumbnailUrl")]
        public string PresignedThumbnailUrl { get; set; }

        [JsonPropertyName("utcCreatedDate")]
        public long UtcCreatedDate { get; set; }

        [JsonPropertyName("timeZone")]
        public string TimeZone { get; set; }

        [JsonPropertyName("mediaDuration")]
        public DateTime MediaDuration { get; set; }

        [JsonPropertyName("mediaDurationSecond")]
        public long MediaDurationSecond { get; set; }

        [JsonPropertyName("donated")]
        public bool Donated { get; set; }
    }
}
