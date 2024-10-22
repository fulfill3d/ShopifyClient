using Client.Interface;
using Client.Model;
using Microsoft.Extensions.Logging;

namespace Client
{
    public class ShopifyFulfillmentServiceClient(string shop, string token, ILogger logger) : ShopifyBasicClient<FulfillmentService>(shop, token, "fulfillment_services", logger), IShopifyFulfillmentServiceClient
    {
    }
}
