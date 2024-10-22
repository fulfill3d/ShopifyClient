using Client.Interface;
using Microsoft.Extensions.Logging;

namespace Client
{
    public class ShopifyShopClientFactory(ILogger<ShopifyShopClient> logger) : IShopifyShopClientFactory
    {
        public IShopifyShopClient CreateClient(string shop, string token)
        {
            return new ShopifyShopClient(shop, token, logger);
        }
    }
}
