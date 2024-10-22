namespace Client.Interface
{
    public interface IShopifyInventoryLevelClientFactory
    {
        IShopifyInventoryLevelClient CreateClient(string shop, string token);

    }
}
