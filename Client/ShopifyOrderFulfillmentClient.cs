using Microsoft.Extensions.Logging;
using RestSharp;
using System.Dynamic;
using Client.Interface;
using Client.Model;
using Client.Model.Order;

namespace Client
{
    public class ShopifyOrderFulfillmentClient(
        string token,
        string store,
        ILogger<ShopifyOrderFulfillmentClient> logger) : ShopifyBasicClient<FulfillmentShipping>(token, store, "fulfillments", logger), IShopifyOrderFulfillmentClient
    {
        public new async Task<RestResponse<Fulfillment>> Create(FulfillmentShipping shipping)
        {
            var url = "fulfillments.json";

            // Create a dynamic object to wrap the fulfillment data
            dynamic obj = new ExpandoObject();
            obj.fulfillment = shipping;

            // Use CreateRequest to prepare the request
            var request = CreateRequest(url, Method.Post, obj);

            return await ExecuteWithPolicyAsync<Fulfillment>(request);
        }
    }
}