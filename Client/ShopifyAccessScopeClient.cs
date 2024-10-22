using Client.Interface;
using Client.Model;
using Microsoft.Extensions.Logging;
using RestSharp;

namespace Client
{
    public class ShopifyAccessScopeClient(string shop, string token, ILogger logger) : ShopifyBaseClient(shop, token, logger), IShopifyAccessScopeClient
    {
        protected override bool SupportsApiVersioning => false;

        public async Task<RestResponse<IEnumerable<AccessScope>>> GetAll()
        {
            var url = "oauth/access_scopes";
            var request = CreateRequest(url, Method.Get);

            return await base.ExecuteWithPolicyAsync<IEnumerable<AccessScope>>(request);
        }
    }
}