using System;
using System.Text.Json.Serialization;

namespace Arlo.Models.Requests
{
    public class MediaLibraryRequest
    {
        public MediaLibraryRequest()
        {

        }

        public MediaLibraryRequest(DateTime dateFrom, DateTime dateTo)
        {
            DateFrom = dateFrom.ToString("yyyyMMdd");
            DateTo = dateTo.ToString("yyyyMMdd");
        }

        [JsonPropertyName("dateFrom")]
        public string DateFrom { get; set; }

        [JsonPropertyName("dateTo")]
        public string DateTo { get; set; }
    }
}
