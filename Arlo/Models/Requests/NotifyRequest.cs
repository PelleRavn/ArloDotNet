using System;
using System.Text.Json.Serialization;

namespace Arlo.Models.Requests
{
    public enum Mode
    {
        Disarm,
        Arm
    }

    public class NotifyRequest
    {
        public NotifyRequest(Device device, string from, Mode mode)
        {
            To = device.DeviceId;
            From = from;
            Properties = new NotifyProperties(mode);
        }

        public NotifyRequest()
        {

        }

        public class NotifyProperties
        {
            public NotifyProperties(Mode mode)
            {
                switch (mode)
                {
                    case Mode.Disarm:
                        Active = "mode0";
                        break;
                    case Mode.Arm:
                        Active = "mode1";
                        break;
                    default:
                        throw new ArgumentException("Unknown mode!");
                }
            }

            public NotifyProperties(string active)
            {
                Active = active;
            }

            public NotifyProperties()
            {

            }

            [JsonPropertyName("active")]
            public string Active { get; set; }
        }

        [JsonPropertyName("from")]
        public string From { get; set; }

        [JsonPropertyName("to")]
        public string To { get; set; }

        [JsonPropertyName("action")]
        public string Action { get; set; } = "set";

        [JsonPropertyName("resource")]
        public string Resource { get; set; } = "modes";

        [JsonPropertyName("transId")]
        public string TransId { get; set; }

        [JsonPropertyName("publishResponse")]
        public bool PublishResponse { get; set; } = true;

        [JsonPropertyName("properties")]
        public NotifyProperties Properties { get; set; } = new NotifyProperties();
    }
}
