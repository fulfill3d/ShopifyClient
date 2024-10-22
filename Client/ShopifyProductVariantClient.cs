using Client.Interface;
using Client.Model.Product;
using Microsoft.Extensions.Logging;

namespace Client
{
    public class ShopifyProductVariantClient(
        string store,
        string accessToken,
        ILogger<ShopifyProductVariantClient> logger) : ShopifyBasicClient<ProductVariant>(store, accessToken, "variants", logger), IShopifyProductVariantClient
    {
        
    }
}
