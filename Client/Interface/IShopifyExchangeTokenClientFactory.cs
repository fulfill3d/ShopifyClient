namespace Client.Interface
{
    public interface IShopifyExchangeTokenClientFactory
    {
        IShopifyExchangeTokenClient CreateClient(string shop);
    }
}