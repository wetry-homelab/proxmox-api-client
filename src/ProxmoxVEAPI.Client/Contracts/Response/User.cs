using System.Text.Json.Serialization;

namespace ProxmoxVEAPI.Client.Contracts.Response
{
    public class User
    {
        [JsonPropertyName("userid")]
        public string UserId { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("firstname")]
        public string Firstname { get; set; }

        [JsonPropertyName("lastname")]
        public string Lastname { get; set; }

        [JsonPropertyName("enable")]
        public bool Enable { get; set; }
    }
}
