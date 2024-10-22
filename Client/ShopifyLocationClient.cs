using Client.Interface;
using Client.Model;
using Microsoft.Extensions.Logging;

namespace Client
{
    public class ShopifyLocationClient(
        string store,
        string accessToken,
        ILogger<ShopifyLocationClient> logger) : ShopifyBasicClient<Location>(store, accessToken, "locations", logger), IShopifyLocationClient
    {
    }
}
