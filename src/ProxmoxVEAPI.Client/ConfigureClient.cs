namespace ProxmoxVEAPI.Client
{
    public class ConfigureClient
    {
        internal static string AccessToken { get; set; }
        internal static string BaseUri { get; set; }

        public static void Initialise(string baseUri, string token)
        {
            BaseUri = baseUri;
            AccessToken = token;
        }
    }
}
