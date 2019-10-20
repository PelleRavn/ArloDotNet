using System;
using System.Text.Json.Serialization;

namespace Arlo.Models
{
    public class Media
    {
        public Media()
        {

        }

        [JsonPropertyName("ownerId")]
        public string OwnerId { get; set; }

        [JsonPropertyName("uniqueId")]
        public string UniqueId { get; set; }

        [JsonPropertyName("deviceId")]
        public string DeviceId { get; set; }

        [JsonPropertyName("createdDate")]
        public long CreatedDate { get; set; }

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
        public Uri PresignedContentUrl { get; set; }

        [JsonPropertyName("presignedThumbnailUrl")]
        public Uri PresignedThumbnailUrl { get; set; }

        [JsonPropertyName("utcCreatedDate")]
        public long UtcCreatedDate { get; set; }

        [JsonPropertyName("timeZone")]
        public string TimeZone { get; set; }

        [JsonPropertyName("mediaDuration")]
        public DateTimeOffset MediaDuration { get; set; }

        [JsonPropertyName("mediaDurationSecond")]
        public long MediaDurationSecond { get; set; }

        [JsonPropertyName("objCategory")]
        public string ObjCategory { get; set; }

        [JsonPropertyName("objRegion")]
        public string ObjRegion { get; set; }

        [JsonPropertyName("donated")]
        public bool Donated { get; set; }
    }
}
