using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace InsuranceCalculator.BLL
{
    public interface IBusinessInfo
    {
        decimal Revenue { get; set; }
        string State { get; set; }
        string Business { get; set; }
        void DeserializePayload(JObject payload);
    }
}
