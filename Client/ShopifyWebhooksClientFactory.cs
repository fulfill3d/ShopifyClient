using Client.Interface;
using Microsoft.Extensions.Logging;

namespace Client
{
    public class ShopifyWebhooksClientFactory(ILogger<ShopifyWebhooksClient> logger) : IShopifyWebhooksClientFactory
    {
        public IShopifyWebhooksClient CreateClient(string shop, string token)
        {
            return new ShopifyWebhooksClient(shop, token, logger);
        }
    }
}
