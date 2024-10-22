namespace Client.Interface
{
    public interface IShopifyLocationClientFactory
    {
        IShopifyLocationClient CreateClient(string shop, string token);
    }
}
