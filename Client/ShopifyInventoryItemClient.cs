using Client.Interface;
using Client.Model;
using Microsoft.Extensions.Logging;

namespace Client
{
    public class ShopifyInventoryItemClient(string token, string store, ILogger logger) : ShopifyBasicClient<InventoryItem>(token, store, "inventory_items", logger), IShopifyInventoryItemClient
    {
    }
}
