﻿namespace Client.Interface
{
    public interface IShopifyShopClientFactory
    {
        IShopifyShopClient CreateClient(string shop, string token);
    }
}
