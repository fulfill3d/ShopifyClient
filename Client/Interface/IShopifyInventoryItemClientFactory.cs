
namespace Client.Interface
{
    public interface IShopifyInventoryItemClientFactory
    {
        IShopifyInventoryItemClient CreateClient(string shop, string token);
    }
}
