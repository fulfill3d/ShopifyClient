using Client.Interface;
using Client.Model;
using Microsoft.Extensions.Logging;

namespace Client
{
    public class ShopifyWebhooksClient(string token, string store, ILogger<ShopifyWebhooksClient> logger) : ShopifyBasicClient<Webhook>(token, store, "webhooks", logger), IShopifyWebhooksClient
    {
    }
}
