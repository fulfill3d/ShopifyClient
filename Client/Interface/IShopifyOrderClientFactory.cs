namespace Client.Interface
{
    public interface IShopifyOrderClientFactory
    {
        IShopifyOrderClient CreateClient(string shop, string token);
    }
}
