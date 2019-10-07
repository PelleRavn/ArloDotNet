using System;
using System.Text.Encodings.Web;
using System.Text.Json.Serialization;

namespace Arlo.Models
{
    public class Device
    {
        public Device()
        {

        }

        [JsonPropertyName("userId")]
        public string UserId { get; set; }

        [JsonPropertyName("deviceId")]
        public string DeviceId { get; set; }

        [JsonPropertyName("parentId")]
        public string ParentId { get; set; }

        [JsonPropertyName("uniqueId")]
        public string UniqueId { get; set; }

        [JsonPropertyName("deviceType")]
        public string DeviceType { get; set; }

        [JsonPropertyName("deviceName")]
        public string DeviceName { get; set; }

        [JsonPropertyName("lastModified")]
        public long LastModified { get; set; }

        [JsonPropertyName("xCloudId")]
        public string XCloudId { get; set; }

        [JsonPropertyName("userRole")]
        public string UserRole { get; set; }

        [JsonPropertyName("displayOrder")]
        public int DisplayOrder { get; set; }

        [JsonPropertyName("mediaObjectCount")]
        public int MediaObjectCount { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("modelId")]
        public string ModelId { get; set; }

        [JsonPropertyName("cvrEnabled")]
        public bool CvrEnabled { get; set; }

        [JsonPropertyName("dateCreated")]
        public long DateCreated { get; set; }

        [JsonPropertyName("owner")]
        public DeviceOwner Owner { get; set; }

        [JsonPropertyName("firmwareVersion")]
        public string FirmwareVersion { get; set; }

        [JsonPropertyName("lastImageUploaded")]
        public string LastImageUploaded { get; set; }

        [JsonPropertyName("presignedLastImageUrl")]
        public string PresignedLastImageUrl { get; set; }

        [JsonPropertyName("presignedSnapshotUrl")]
        public string PresignedSnapshotUrl { get; set; }

        [JsonPropertyName("presignedFullFrameSnapshotUrl")]
        public string PresignedFullFrameSnapshotUrl { get; set; }

        [JsonPropertyName("arloMobilePlan")]
        public bool? ArloMobilePlan { get; set; }

        [JsonPropertyName("interfaceVersion")]
        public string InterfaceVersion { get; set; }

        [JsonPropertyName("interfaceSchemaVer")]
        public string InterfaceSchemaVer { get; set; }

        [JsonPropertyName("properties")]
        public DeviceProperties Properties { get; set; }
    }
}
