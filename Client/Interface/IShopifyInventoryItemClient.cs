using Client.Model;
using RestSharp;

namespace Client.Interface
{
    public interface IShopifyInventoryItemClient
    {
        Task<RestResponse<InventoryItem>> Update(long id, InventoryItem item);
    }
}
