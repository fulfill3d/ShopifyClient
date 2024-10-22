using Client.Model.Order;
using RestSharp;

namespace Client.Interface
{
    public interface IShopifyOrderClient
    {
        Task<RestResponse<Order>> Get(long shopifyOrderId);
    }
}
