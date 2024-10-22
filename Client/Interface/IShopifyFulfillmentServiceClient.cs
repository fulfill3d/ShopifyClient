using Client.Model;
using RestSharp;

namespace Client.Interface
{
    public interface IShopifyFulfillmentServiceClient
    {
        Task<RestResponse<IEnumerable<FulfillmentService>>> GetAll();
        Task<RestResponse<FulfillmentService>> Create(FulfillmentService item);

    }
}
