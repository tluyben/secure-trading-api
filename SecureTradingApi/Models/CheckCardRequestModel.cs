using System;
using Newtonsoft.Json;
using SecureTradingApi.Enums;
using SecureTradingApi.Models.Abstract;

namespace SecureTradingApi.Models
{
    public class CheckCardRequestModel : BaseInnerRequest
    {

        public CheckCardRequestModel() : base(RequestTypeDescriptionEnum.ACCOUNTCHECK)
        {
        }


            [JsonProperty("sitereference")]
            public string SiteReference { get; set; }

            [JsonProperty("currencyiso3a")]
            public string  currencyiso3a {get;set;}

            [JsonProperty("baseamount")]
            public string baseamount {get;set;} = "0";

            [JsonProperty("orderreference")]
            public string orderreference {get;set;}

            [JsonProperty("accounttypedescription")]
            public string accounttypedescription {get;set;}

            [JsonProperty("pan")]
            public string pan {get;set;}

            [JsonProperty("expirydate")]
            public string expirydate {get;set;}

            [JsonProperty("securitycode")]
            public string securitycode {get;set;}

            [JsonProperty("billingpremise")]
            public string billingpremise {get;set;}            

            [JsonProperty("billingpostcode")]
            public string billingpostcode {get;set;}     



    }
}