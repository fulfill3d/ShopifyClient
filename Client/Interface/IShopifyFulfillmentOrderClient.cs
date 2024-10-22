using Client.Model;
using RestSharp;

namespace Client.Interface
{
    public interface IShopifyFulfillmentOrderClient
    {
        Task<RestResponse<IEnumerable<FulfillmentOrder>>> GetFulfillmentOrdersOfOrderAsync(long orderId);
    }
}
