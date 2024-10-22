using Client.Interface;
using Client.Model;
using Microsoft.Extensions.Logging;
using RestSharp;

namespace Client
{
    public class ShopifyExchangeTokenClient(string shop, ILogger<ShopifyExchangeTokenClient> logger) : ShopifyAuthorizationBaseClient(shop, logger), IShopifyExchangeTokenClient
    {
        public async Task<RestResponse<string>> GetAccessToken(ExchangeToken exchangeToken)
        {
            // Use CreateRequest to prepare the request with the appropriate JSON body
            var request = CreateRequest(string.Empty, Method.Post, exchangeToken);

            return await ExecuteWithPolicyAsync<string>(request);
        }
    }
}