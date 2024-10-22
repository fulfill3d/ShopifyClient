using Client.Interface;
using Microsoft.Extensions.Logging;

namespace Client
{
    public class ShopifyAuthorizationClientFactory(ILogger<ShopifyAuthorizationClient> logger) : IShopifyAuthorizationClientFactory
    {
        public IShopifyAuthorizationClient CreateClient(string shop)
        {
            return new ShopifyAuthorizationClient(shop, logger);
        }
    }
}
