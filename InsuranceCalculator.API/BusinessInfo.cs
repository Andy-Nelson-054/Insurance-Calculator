using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace InsuranceCalculator.BLL
{
    public class BusinessInfo : IBusinessInfo
    {
        public decimal Revenue { get; set; }
        public string State { get; set; }
        public string Business { get; set; }

        public void DeserializePayload(JObject payload)
        {
            string businessJson = payload.ToString(Newtonsoft.Json.Formatting.None);
            var payloadString = Newtonsoft.Json.JsonConvert.DeserializeObject<BusinessInfo>(businessJson);

            Revenue = payloadString.Revenue;
            State = payloadString.State;
            Business = payloadString.Business;
        }
    }
}
