using Client.Model;
using RestSharp;

namespace Client.Interface
{
    public interface IShopifyExchangeTokenClient
    {
        Task<RestResponse<string>> GetAccessToken(ExchangeToken exchangeToken);
    }
}