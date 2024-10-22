using Client.Interface;
using Client.Model;
using Microsoft.Extensions.Logging;
using RestSharp;

namespace Client
{
    internal class ShopifyFulfillmentRequestClient(string shop, string accessToken, ILogger logger)  : ShopifyBaseClient(shop, accessToken, logger), IShopifyFulfillmentRequestClient
    {
        public async Task<RestResponse<FulfillmentOrder>> AcceptAsync(long fulfillmentOrderId)
        {
            var url = $"fulfillment_orders/{fulfillmentOrderId}/fulfillment_request/accept.json";

            var request = CreateRequest(url, Method.Post);
            return await ExecuteWithPolicyAsync<FulfillmentOrder>(request);
        }

        public async Task<RestResponse<FulfillmentOrder>> CreateAsync(long fulfillmentOrderId, FulfillmentRequest fulfillmentRequest)
        {
            var url = $"fulfillment_orders/{fulfillmentOrderId}/fulfillment_request.json";

            var request = CreateRequest(url, Method.Post, fulfillmentRequest);
            return await ExecuteWithPolicyAsync<FulfillmentOrder>(request);
        }
    }
}