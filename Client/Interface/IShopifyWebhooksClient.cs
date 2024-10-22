using Client.Model;
using RestSharp;

namespace Client.Interface
{
    public interface IShopifyWebhooksClient
    {
        Task<RestResponse<Webhook>> Create(Webhook webhook);
    }
}