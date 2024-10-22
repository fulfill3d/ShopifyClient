namespace Client.Interface
{
    public interface IShopifyOrderFulfillmentClientFactory
    {
        IShopifyOrderFulfillmentClient CreateClient(string shop, string token);
    }
}
