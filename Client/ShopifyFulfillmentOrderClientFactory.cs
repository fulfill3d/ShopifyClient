using Client.Interface;
using Microsoft.Extensions.Logging;

namespace Client
{
    public class ShopifyFulfillmentOrderClientFactory(ILogger<ShopifyFulfillmentOrderClient> logger) : IShopifyFulfillmentOrderClientFactory
    {
        public IShopifyFulfillmentOrderClient CreateClient(string shop, string token)
        {
            return new ShopifyFulfillmentOrderClient(shop, token, logger);
        }
    }
}
