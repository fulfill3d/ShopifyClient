namespace Client.Interface
{
    public interface IShopifyProductVariantClientFactory
    {
        IShopifyProductVariantClient CreateClient(string shop, string token);
    }
}
