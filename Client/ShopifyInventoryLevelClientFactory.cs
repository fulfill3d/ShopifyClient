using Client.Interface;
using Microsoft.Extensions.Logging;

namespace Client
{
    public class ShopifyInventoryLevelClientFactory(ILogger<ShopifyInventoryLevelClient> logger) : IShopifyInventoryLevelClientFactory
    {
        public IShopifyInventoryLevelClient CreateClient(string shop, string token)
        {
            return new ShopifyInventoryLevelClient(shop, token, logger);
        }
    }
}
