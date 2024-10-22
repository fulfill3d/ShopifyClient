using Newtonsoft.Json;

namespace Client.Model
{
    public class OutgoingFulfillmentRequestOptions
    {
        [JsonProperty("notify_customer")] public bool? NotifyCustomer { get; set; }
    }
}
