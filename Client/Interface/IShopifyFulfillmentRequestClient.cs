using Client.Model;
using RestSharp;

namespace Client.Interface
{
    public interface IShopifyFulfillmentRequestClient
    {
        Task<RestResponse<FulfillmentOrder>> CreateAsync(
            long fulfillmentOrderId, 
            FulfillmentRequest fulfillmentRequest);

        Task<RestResponse<FulfillmentOrder>> AcceptAsync(long fulfillmentOrderId);
    }
}
