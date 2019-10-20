using System;
using System.Text.Json.Serialization;

namespace Arlo.Models
{
    public class PaymentOffer
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("planId")]
        public string PlanId { get; set; }

        [JsonPropertyName("planName")]
        public string PlanName { get; set; }

        [JsonPropertyName("planType")]
        public string PlanType { get; set; }

        [JsonPropertyName("numBaseStationsSupported")]
        public int NumBaseStationsSupported { get; set; }

        [JsonPropertyName("numCamerasSupported")]
        public int NumCamerasSupported { get; set; }

        [JsonPropertyName("numPushNotify")]
        public int NumPushNotify { get; set; }

        [JsonPropertyName("numSmartHomeModes")]
        public int NumSmartHomeModes { get; set; }

        [JsonPropertyName("numAccounts")]
        public int NumAccounts { get; set; }

        [JsonPropertyName("maxStorage")]
        public int MaxStorage { get; set; }

        [JsonPropertyName("groupNumber")]
        public int GroupNumber { get; set; }

        [JsonPropertyName("groupName")]
        public string GroupName { get; set; }

        [JsonPropertyName("createdDate")]
        public object CreatedDate { get; set; }

        [JsonPropertyName("lastModified")]
        public object LastModified { get; set; }

        [JsonPropertyName("autoManageStorageExpiry")]
        public int AutoManageStorageExpiry { get; set; }

        [JsonPropertyName("libraryAccessExpiry")]
        public int LibraryAccessExpiry { get; set; }

        [JsonPropertyName("cvrAccessExpiry")]
        public int CvrAccessExpiry { get; set; }

        [JsonPropertyName("sharingExpiry")]
        public int SharingExpiry { get; set; }

        [JsonPropertyName("storageAutoDelete")]
        public int StorageAutoDelete { get; set; }

        [JsonPropertyName("alertStorage")]
        public int AlertStorage { get; set; }

        [JsonPropertyName("alertLowBattery")]
        public int AlertLowBattery { get; set; }

        [JsonPropertyName("scheduleExpiry")]
        public int ScheduleExpiry { get; set; }

        [JsonPropertyName("countryCode")]
        public string CountryCode { get; set; }

        [JsonPropertyName("planMinutes")]
        public int PlanMinutes { get; set; }

        [JsonPropertyName("maxE911Locations")]
        public int MaxE911Locations { get; set; }

        [JsonPropertyName("term")]
        public string Term { get; set; }

        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        [JsonPropertyName("amountRaw")]
        public int AmountRaw { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("planDescription")]
        public string PlanDescription { get; set; }

        [JsonPropertyName("tieredAmount")]
        public string TieredAmount { get; set; }
    }
}
