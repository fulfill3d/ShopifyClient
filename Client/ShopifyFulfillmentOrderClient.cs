using Client.Interface;
using Client.Model;
using Microsoft.Extensions.Logging;
using RestSharp;

namespace Client
{
    public class ShopifyFulfillmentOrderClient(string shop, string accessToken, ILogger logger) : ShopifyBaseClient(shop, accessToken, logger), IShopifyFulfillmentOrderClient
    {

        public async Task<RestResponse<IEnumerable<FulfillmentOrder>>> GetFulfillmentOrdersOfOrderAsync(long orderId)
        {
            var url = $"orders/{orderId}/fulfillment_orders.json";

            var request = CreateRequest(url, Method.Get);
            return await ExecuteWithPolicyAsync<IEnumerable<FulfillmentOrder>>(request);
        }
    }
}