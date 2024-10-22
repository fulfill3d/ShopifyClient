using Client.Interface;
using Microsoft.Extensions.Logging;

namespace Client
{
    public class ShopifyExchangeTokenClientFactory(ILogger<ShopifyExchangeTokenClient> logger) : IShopifyExchangeTokenClientFactory
    {
        public IShopifyExchangeTokenClient CreateClient(string shop)
        {
            return new ShopifyExchangeTokenClient(shop, logger);
        }
    }
}