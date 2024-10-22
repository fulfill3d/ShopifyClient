namespace Client.Interface
{
    public interface IShopifyFulfillmentServiceClientFactory
    {
        IShopifyFulfillmentServiceClient CreateClient(string shop, string token);
    }
}
