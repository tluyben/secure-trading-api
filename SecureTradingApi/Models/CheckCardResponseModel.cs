using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SecureTradingApi.Enums;
using SecureTradingApi.Models.Abstract;

namespace SecureTradingApi.Models
{
    public class CheckCardResponseModel : BaseInnerResponse
    {

        
        [JsonProperty("tid")]
        public string TransactionId { get; set; }

        [JsonProperty("livestatus")]
        public LiveStatus LiveStatus { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("dccenabled")]
        public string DccEnabled { get; set; }

        [JsonProperty("settleduedate")]
        public DateTime SettleDueDate { get; set; }

        [JsonProperty("baseamount")]
        public string Amount { get; set; }

        [JsonProperty("transactionreference")]
        public string TransactionReference { get; set; }

        [JsonProperty("merchantname")]
        public string MerchantName { get; set; }

        [JsonProperty("paymenttypedescription")]
        public string PaymentTypeDescription { get; set; }

        [JsonProperty("orderreference")]
        public string OrderReference { get; set; }

        [JsonProperty("accounttypedescription")]
        [JsonConverter(typeof(StringEnumConverter))]
        public AccountTypeDescription AccountTypeDescription { get; set; }

        [JsonProperty("splitfinalnumber")]
        public string SplitFinalNumber { get; set; }

        [JsonProperty("acquirerresponsecode")]
        public string AcquireResponseCode { get; set; }

        [JsonProperty("currencyiso3a")]
        public string CurrencyIso3a { get; set; }

        [JsonProperty("authcode")]
        public string AuthCode { get; set; }

        [JsonProperty("merchantnumber")]
        public string MerchantNumber { get; set; }

        [JsonProperty("merchantcountryiso2a")]
        public string MerchantCountryIso2a { get; set; }

        [JsonProperty("maskedpan")]
        public string MaskedCardNumber { get; set; }

        [JsonProperty("issuercountryiso2a")]
        public string IssuerCountryIso2a { get; set; }

        [JsonProperty("operatorname")]
        public string OperatorName { get; set; }

        [JsonProperty("SettleStatus")]
        public SettleStatus SettleStatus { get; set; }

        [JsonProperty("securityresponsesecuritycode")]
        public string securityresponsesecuritycode {get;set;}

        [JsonProperty("securityresponsepostcode")]
        public string securityresponsepostcode {get;set;}

        [JsonProperty("securityresponseaddress")]
        public string securityresponseaddress {get;set;}

    }

}