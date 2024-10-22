using Client.Interface;
using Client.Model.Product;
using Microsoft.Extensions.Logging;
using RestSharp;

namespace Client
{
    public class ShopifyProductClient(
        string store,
        string accessToken,
        ILogger<ShopifyProductClient> logger) : ShopifyBasicClient<Product>(store, accessToken, "products", logger), IShopifyProductClient
    {
        public async Task<RestResponse<Product>> CreateOrUpdate(Product product)
        {
            if (product.Id.HasValue)
            {
                return await Update(product.Id.Value, product);
            }

            return await Create(product);
        }
    }
}
