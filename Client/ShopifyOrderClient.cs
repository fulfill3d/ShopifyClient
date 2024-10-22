using Client.Interface;
using Client.Model.Order;
using Microsoft.Extensions.Logging;

namespace Client
{
    public class ShopifyOrderClient(
        string store,
        string accessToken,
        ILogger<ShopifyOrderClient> logger) : ShopifyBasicClient<Order>(store, accessToken, "orders", logger), IShopifyOrderClient
    {
    }
}
