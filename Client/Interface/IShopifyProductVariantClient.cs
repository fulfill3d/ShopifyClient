using Client.Model.Product;
using RestSharp;

namespace Client.Interface
{
    public interface IShopifyProductVariantClient
    {
        Task<RestResponse<ProductVariant>> Update(long variantId, ProductVariant updateObject);
        Task<RestResponse<ProductVariant>> Get(long variantId);
    }
}
