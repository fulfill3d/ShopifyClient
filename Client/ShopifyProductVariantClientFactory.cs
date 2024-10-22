using Client.Interface;
using Microsoft.Extensions.Logging;

namespace Client
{
    public class ShopifyProductVariantClientFactory(ILogger<ShopifyProductVariantClient> logger) : IShopifyProductVariantClientFactory
    {
        public IShopifyProductVariantClient CreateClient(string shop, string token)
        {
            return new ShopifyProductVariantClient(shop, token, logger);
        }
    }
}
