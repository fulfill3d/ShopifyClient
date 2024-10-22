using Client.Model;
using RestSharp;

namespace Client.Interface
{
    public interface IShopifyAuthorizationClient
    {
        Task<RestResponse<string>> GetAccessToken(ShopifyAccessToken shopifyAccessToken);
    }
}
