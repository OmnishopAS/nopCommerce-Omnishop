﻿using Newtonsoft.Json;

namespace Vendr.Contrib.PaymentProviders.Api.Models
{
    public class NetsPaymentResult
    {
        [JsonProperty("paymentId")]
        public string PaymentId { get; set; }

        [JsonProperty("hostedPaymentPageUrl")]
        public string HostedPaymentPageUrl { get; set; }
    }
}
