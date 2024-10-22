﻿using Client.Interface;
using Client.Model;
using Microsoft.Extensions.Logging;
using RestSharp;

namespace Client
{
    public class ShopifyShopClient(
        string store,
        string accessToken,
        ILogger<ShopifyShopClient> logger) : ShopifyBasicClient<ShopifySeller>(store, accessToken, string.Empty, logger), IShopifyShopClient
    {
        private const string Url = "/shop.json";
        
        public async Task<RestResponse<ShopifySeller>> GetShop()
        {
            // Use CreateRequest to prepare the request
            var request = CreateRequest(Url, Method.Get);

            return await ExecuteWithPolicyAsync<ShopifySeller>(request);
        }
    }
}