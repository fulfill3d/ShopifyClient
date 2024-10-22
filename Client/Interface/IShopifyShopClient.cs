using Client.Model;
using RestSharp;

namespace Client.Interface
{
    public interface IShopifyShopClient
    {
        Task<RestResponse<ShopifySeller>> GetShop();
    }
}
