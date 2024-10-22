namespace Client.Interface
{
    public interface IShopifyAuthorizationClientFactory
    {
        public IShopifyAuthorizationClient CreateClient(string shop);
    }
}
