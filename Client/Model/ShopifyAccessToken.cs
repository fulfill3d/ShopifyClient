﻿using Newtonsoft.Json;

namespace Client.Model
{
    public class ShopifyAccessToken
    {
        [JsonProperty("client_id")] public string ClientId { get; set; }

        [JsonProperty("client_secret")] public string ClientSecret { get; set; }

        [JsonProperty("code")] public string Code { get; set; }
    }
}
