using Client.Interface;
using Microsoft.Extensions.Logging;

namespace Client
{
    public class ShopifyOrderFulfillmentClientFactory(ILogger<ShopifyOrderFulfillmentClient> logger) : IShopifyOrderFulfillmentClientFactory
    {
        public IShopifyOrderFulfillmentClient CreateClient(string shop, string token)
        {
            return new ShopifyOrderFulfillmentClient(shop, token, logger);
        }
    }
}
