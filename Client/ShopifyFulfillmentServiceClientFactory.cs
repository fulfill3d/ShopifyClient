using Client.Interface;
using Microsoft.Extensions.Logging;

namespace Client
{
    public class ShopifyFulfillmentServiceClientFactory(ILogger<ShopifyFulfillmentServiceClient> logger) : IShopifyFulfillmentServiceClientFactory
    {
        public IShopifyFulfillmentServiceClient CreateClient(string shop, string token)
        {
            return new ShopifyFulfillmentServiceClient(shop, token, logger);
        }
    }
}
