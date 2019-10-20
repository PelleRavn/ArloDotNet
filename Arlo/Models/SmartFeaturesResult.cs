using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Arlo.Models
{
    public class SmartFeaturesResult
    {
        [JsonPropertyName("lastUpdatedTime")]
        public long LastUpdatedTime { get; set; }

        [JsonPropertyName("engagementsPending")]
        public EngagementsPending EngagementsPending { get; set; }

        //[JsonPropertyName("featureAvailabilityOnMaxCameras")]
        //public FeatureAvailabilityOnMaxCameras FeatureAvailabilityOnMaxCameras { get; set; }

        [JsonPropertyName("resolutions")]
        public List<Resolution> Resolutions { get; set; }

        [JsonPropertyName("resolutionReductionPath")]
        public Dictionary<string, List<string>> ResolutionReductionPath { get; set; }

        [JsonPropertyName("audioFeatures")]
        public List<string> AudioFeatures { get; set; }

        [JsonPropertyName("videoFeatures")]
        public List<string> VideoFeatures { get; set; }

        [JsonPropertyName("features")]
        public Dictionary<string, Feature> Features { get; set; }
    }

    public class EngagementsPending
    {
        [JsonPropertyName("arloSmartPromotionGen5Popup")]
        public bool ArloSmartPromotionGen5Popup { get; set; }
    }

    //public class FeatureAvailabilityOnMaxCameras
    //{
    //}

    public class Feature
    {
        [JsonPropertyName("arloSmartEnabled")]
        public bool ArloSmartEnabled { get; set; }

        [JsonPropertyName("smartFeatures")]
        public SmartFeatures SmartFeatures { get; set; }

        [JsonPropertyName("planFeatures")]
        public PlanFeatures PlanFeatures { get; set; }
    }

    public class PlanFeatures
    {
        [JsonPropertyName("cvrEnabled")]
        public bool CvrEnabled { get; set; }

        [JsonPropertyName("mvnoDeviceEnabled")]
        public bool MvnoDeviceEnabled { get; set; }

        [JsonPropertyName("alertLowBattery")]
        public bool AlertLowBattery { get; set; }

        [JsonPropertyName("alertStorage")]
        public bool AlertStorage { get; set; }

        [JsonPropertyName("cloudLiveStreaming")]
        public bool CloudLiveStreaming { get; set; }

        [JsonPropertyName("cloudVideoRecording")]
        public bool CloudVideoRecording { get; set; }

        [JsonPropertyName("dailySummary")]
        public bool DailySummary { get; set; }

        [JsonPropertyName("eventReporting")]
        public bool EventReporting { get; set; }

        [JsonPropertyName("lastImageUpload")]
        public bool LastImageUpload { get; set; }

        [JsonPropertyName("localLiveStreaming")]
        public bool LocalLiveStreaming { get; set; }

        [JsonPropertyName("eventRecording")]
        public bool EventRecording { get; set; }

        [JsonPropertyName("partnerAccess")]
        public bool PartnerAccess { get; set; }

        [JsonPropertyName("localRecording")]
        public bool LocalRecording { get; set; }

        [JsonPropertyName("shareCamera")]
        public bool ShareCamera { get; set; }

        [JsonPropertyName("sirenPlayback")]
        public bool SirenPlayback { get; set; }

        [JsonPropertyName("storageAutoDelete")]
        public bool StorageAutoDelete { get; set; }

        [JsonPropertyName("twoWayAudio")]
        public bool TwoWayAudio { get; set; }

        [JsonPropertyName("cvrAccessDays")]
        public long CvrAccessDays { get; set; }

        [JsonPropertyName("mvnoplanCapacityMB")]
        public long MvnoplanCapacityMb { get; set; }

        [JsonPropertyName("mvnoPlanMinutes")]
        public long MvnoPlanMinutes { get; set; }

        [JsonPropertyName("emailNotificationAddressCount")]
        public long EmailNotificationAddressCount { get; set; }

        [JsonPropertyName("libraryAccessDays")]
        public long LibraryAccessDays { get; set; }

        [JsonPropertyName("pushNotificationClientCount")]
        public long PushNotificationClientCount { get; set; }

        [JsonPropertyName("voicemail")]
        public bool Voicemail { get; set; }

        [JsonPropertyName("maxLiveStreamSecs")]
        public long MaxLiveStreamSecs { get; set; }

        [JsonPropertyName("maxManualRecordingSecs")]
        public long MaxManualRecordingSecs { get; set; }

        [JsonPropertyName("cvrRecordingResolution")]
        public object CvrRecordingResolution { get; set; }

        [JsonPropertyName("cloudLiveStreamingResolution")]
        public string CloudLiveStreamingResolution { get; set; }

        [JsonPropertyName("localLiveStreamingResolution")]
        public string LocalLiveStreamingResolution { get; set; }

        [JsonPropertyName("eventRecordingResolution")]
        public string EventRecordingResolution { get; set; }

        [JsonPropertyName("localRecordingResolution")]
        public string LocalRecordingResolution { get; set; }
    }

    public class SmartFeatures
    {
        [JsonPropertyName("videoFeatures")]
        public VideoFeatures VideoFeatures { get; set; }

        [JsonPropertyName("audioFeatures")]
        public AudioFeatures AudioFeatures { get; set; }
    }

    public class AudioFeatures
    {
        [JsonPropertyName("otherAudio")]
        public bool OtherAudio { get; set; }

        [JsonPropertyName("smokeCOAlarm")]
        public bool SmokeCoAlarm { get; set; }
    }

    public class VideoFeatures
    {
        [JsonPropertyName("otherVideo")]
        public bool OtherVideo { get; set; }

        [JsonPropertyName("animalDetection")]
        public bool AnimalDetection { get; set; }

        [JsonPropertyName("personDetection")]
        public bool PersonDetection { get; set; }

        [JsonPropertyName("packageDetection")]
        public bool PackageDetection { get; set; }

        [JsonPropertyName("vehicleDetection")]
        public bool VehicleDetection { get; set; }
    }

    public class Resolution
    {
        [JsonPropertyName("resolution")]
        public string ResolutionString { get; set; }

        [JsonPropertyName("config")]
        public Dictionary<string, Quality> Config { get; set; }
    }

    public class Quality
    {
        [JsonPropertyName("minQP")]
        public long MinQp { get; set; }

        [JsonPropertyName("vbr")]
        public bool Vbr { get; set; }

        [JsonPropertyName("targetbps")]
        public long Targetbps { get; set; }

        [JsonPropertyName("minbps")]
        public long Minbps { get; set; }

        [JsonPropertyName("cbrbps")]
        public long Cbrbps { get; set; }

        [JsonPropertyName("maxbps")]
        public long Maxbps { get; set; }

        [JsonPropertyName("maxQP")]
        public long MaxQp { get; set; }
    }
}
