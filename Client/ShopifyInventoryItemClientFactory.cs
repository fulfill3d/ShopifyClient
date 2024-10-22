using Client.Interface;
using Microsoft.Extensions.Logging;

namespace Client
{
    public class ShopifyInventoryItemClientFactory(ILogger<ShopifyInventoryItemClient> logger) : IShopifyInventoryItemClientFactory
    {
        public IShopifyInventoryItemClient CreateClient(string shop, string token)
        {
            return new ShopifyInventoryItemClient(shop, token, logger);
        }
    }
}
