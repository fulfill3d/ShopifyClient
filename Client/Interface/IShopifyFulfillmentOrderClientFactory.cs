namespace Client.Interface
{
    public interface IShopifyFulfillmentOrderClientFactory
    {
        public IShopifyFulfillmentOrderClient CreateClient(string shop, string token);
    }
}
