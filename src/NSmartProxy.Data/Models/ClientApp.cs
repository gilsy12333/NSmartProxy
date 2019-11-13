﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NSmartProxy.Data
{
    public enum Protocol : byte
    {
        TCP = 0x00,
        HTTP = 0x01,
        HTTPS = 0x02,
        UDP = 0x04
    }

    public class ClientApp
    {
        [JsonIgnore]
        public int AppId { get; set; }
        public string IP { get; set; }
        public int TargetServicePort { get; set; }
        public int ConsumerPort { get; set; }
        public bool IsCompress { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public Protocol Protocol { get; set; }
        public string Host { get; set; }
        public string Description { get; set; }
    }
}
