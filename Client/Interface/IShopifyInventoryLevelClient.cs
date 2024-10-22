using Client.Model;
using RestSharp;

namespace Client.Interface
{
    public interface IShopifyInventoryLevelClient
    {
        Task<RestResponse<InventoryLevel>> Connect(InventoryLevel item);
        Task<RestResponse<InventoryLevel>> Set(InventoryLevel item);
    }
}
