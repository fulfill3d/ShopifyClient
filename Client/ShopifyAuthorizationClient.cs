using Client.Interface;
using Client.Model;
using Microsoft.Extensions.Logging;
using RestSharp;

namespace Client
{
    public class ShopifyAuthorizationClient(string shop, ILogger<ShopifyAuthorizationClient> logger) : ShopifyAuthorizationBaseClient(shop, logger), IShopifyAuthorizationClient
    {
        public async Task<RestResponse<string>> GetAccessToken(ShopifyAccessToken shopifyAccessToken)
        {
            // Use CreateRequest to prepare the request with the appropriate JSON body
            var request = CreateRequest(string.Empty, Method.Post, shopifyAccessToken);

            return await ExecuteWithPolicyAsync<string>(request);
        }
    }
}