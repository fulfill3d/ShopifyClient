namespace Client.Interface
{
    public interface IShopifyFulfillmentRequestClientFactory
    {
        IShopifyFulfillmentRequestClient CreateClient(string shop, string token);
    }
}
