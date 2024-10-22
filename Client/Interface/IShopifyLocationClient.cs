using Client.Model;
using RestSharp;

namespace Client.Interface
{
    public interface IShopifyLocationClient
    {
        Task<RestResponse<IEnumerable<Location>>> GetAll();
    }
}
