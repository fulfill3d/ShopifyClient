using Client.Model.Product;
using RestSharp;

namespace Client.Interface
{
    public interface IShopifyProductClient
    {
        Task<RestResponse<Product>> CreateOrUpdate(Product product);

        Task<RestResponse<Product>> Get(long id);
    }
}
