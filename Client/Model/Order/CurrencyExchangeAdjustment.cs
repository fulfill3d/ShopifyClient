﻿using Newtonsoft.Json;

namespace Client.Model.Order
{
    public class CurrencyExchangeAdjustment : ShopifyObject
    {
        /// <summary>
        /// The difference between the amounts on the associated transaction and the parent transaction.
        /// </summary>
        [JsonProperty("adjustment")] public decimal? Adjustment { get; set; }

        /// <summary>
        /// The amount of the parent transaction in the shop currency.
        /// </summary>
        [JsonProperty("original_amount")] public decimal? OriginalAmount { get; set; }

        /// <summary>
        /// The amount of the associated transaction in the shop currency.
        /// </summary>
        [JsonProperty("final_amount")] public decimal? FinalAmount { get; set; }

        /// <summary>
        /// The shop currency.
        /// </summary>
        [JsonProperty("currency")] public string Currency { get; set; }
    }
}