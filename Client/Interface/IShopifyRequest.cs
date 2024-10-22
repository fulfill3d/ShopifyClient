using System.Collections.Specialized;

namespace Client.Interface
{
    public interface IShopifyRequest
    {
        bool IsAuthenticRequest(NameValueCollection queryString,string shopifySecretKey);
        bool IsAuthenticWebhook(string hmacHeaderValue, string requestBody, string shopifySecretKey);
    }
}
