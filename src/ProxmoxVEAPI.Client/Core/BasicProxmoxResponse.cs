﻿using System.Text.Json.Serialization;

namespace ProxmoxVEAPI.Client.Core
{
    public class BasicProxmoxResponse<T>
    {
        [JsonPropertyName("data")]
        public T[] Data { get; set; }
    }

    public class BasicProxmoxSingleResponse<T>
    {
        [JsonPropertyName("data")]
        public T Data { get; set; }
    }
}
