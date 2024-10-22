using Client.Interface;
using Microsoft.Extensions.Logging;

namespace Client
{
    public class ShopifyProductClientFactory(ILogger<ShopifyProductClient> logger) : IShopifyProductClientFactory
    {
        public IShopifyProductClient CreateClient(string shop, string token)
        {
            return new ShopifyProductClient(shop, token, logger);
        }
    }
}
