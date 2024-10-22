using Client.Interface;
using Microsoft.Extensions.Logging;

namespace Client
{
    public class ShopifyAccessScopeClientFactory(ILogger<ShopifyAccessScopeClient> logger) : IShopifyAccessScopeClientFactory
    {
        public IShopifyAccessScopeClient CreateClient(string shop, string token)
        {
            return new ShopifyAccessScopeClient(shop, token, logger);
        }
    }
}
