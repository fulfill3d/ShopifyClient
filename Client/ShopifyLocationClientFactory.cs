using Client.Interface;
using Microsoft.Extensions.Logging;

namespace Client
{
    public class ShopifyLocationClientFactory(ILogger<ShopifyLocationClient> logger) : IShopifyLocationClientFactory
    {
        public IShopifyLocationClient CreateClient(string shop, string token)
        {
            return new ShopifyLocationClient(shop, token, logger);
        }
    }
}
