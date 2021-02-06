using ProxmoxVEAPI.Client.Contracts.Request;
using System.Threading.Tasks;

namespace ProxmoxVEAPI.Client
{
    public class UserClient : BaseClient
    {
        private const string GetTicketUri = "api2/json/access/ticket";

        public Task<bool> AuthenticateUser(AuthenticateContractRequest request)
        {
            return PostAsSuccessAsync(GetTicketUri, request);
        }
    }
}
