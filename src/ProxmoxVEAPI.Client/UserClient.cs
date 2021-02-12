using ProxmoxVEAPI.Client.Contracts.Request;
using ProxmoxVEAPI.Client.Contracts.Response;
using System.Threading.Tasks;

namespace ProxmoxVEAPI.Client
{
    public class UserClient : BaseClient
    {
        private const string GetTicketUri = "api2/json/access/ticket";
        private const string GetUserUri = "api2/json/access/users";

        public Task<bool> AuthenticateUser(AuthenticateContractRequest request)
        {
            return PostAsSuccessAsync(GetTicketUri, request);
        }

        public Task<User[]> GetUsers()
        {
            return GetAsync<User>(GetUserUri);
        }
    }
}
