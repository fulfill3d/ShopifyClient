using Client.Interface;
using Microsoft.Extensions.Logging;

namespace Client
{
    internal class ShopifyFulfillmentRequestClientFactory(ILogger<ShopifyFulfillmentRequestClient> logger) : IShopifyFulfillmentRequestClientFactory
    {
        public IShopifyFulfillmentRequestClient CreateClient(string shop, string token)
        {
            return new ShopifyFulfillmentRequestClient(shop, token, logger);
        }
    }
}
