using System.Text.Json.Serialization;

namespace ProxmoxVEAPI.Client.Contracts.Request
{
    public class AuthenticateContractRequest
    {
        [JsonPropertyName("username")]
        public string Username { get; set; }
        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}
