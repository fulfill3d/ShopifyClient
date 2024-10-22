using Client.Model;
using RestSharp;

namespace Client.Interface
{
    public interface IShopifyAccessScopeClient
    {
        Task<RestResponse<IEnumerable<AccessScope>>> GetAll();
    }
}
