using Client.Model;
using Client.Model.Order;
using RestSharp;

namespace Client.Interface
{
    public interface IShopifyOrderFulfillmentClient
    {
        Task<RestResponse<Fulfillment>> Create(FulfillmentShipping shipping);
    }
}
