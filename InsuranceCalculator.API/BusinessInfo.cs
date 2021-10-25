using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace InsuranceCalculator.API
{
    public class BusinessInfo : IBusinessInfo
    {
        public decimal Revenue { get; set; }
        public string State { get; set; }
        public string Business { get; set; }

        public void DeserializePayload(JObject payload)
        {
            string payloadString = payload.ToString(Newtonsoft.Json.Formatting.None);
            var businessJson = Newtonsoft.Json.JsonConvert.DeserializeObject<BusinessInfo>(payloadString);

            Revenue = businessJson.Revenue;
            State = businessJson.State;
            Business = businessJson.Business;
        }
    }
}
