using Client.Interface;
using Microsoft.Extensions.Logging;

namespace Client
{
    public class ShopifyOrderClientFactory(ILogger<ShopifyOrderClient> logger) : IShopifyOrderClientFactory
    {
        public IShopifyOrderClient CreateClient(string shop, string token)
        {
            return new ShopifyOrderClient(shop, token, logger);
        }
    }
}
