namespace Client.Interface
{
    public interface IShopifyProductClientFactory
    {
        public IShopifyProductClient CreateClient(string shop, string token);
    }
}
