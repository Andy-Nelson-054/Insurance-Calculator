using Newtonsoft.Json.Linq;

namespace InsuranceCalculator.API
{
    public interface IBusinessInfo
    {
        decimal Revenue { get; set; }
        string State { get; set; }
        string Business { get; set; }
        void DeserializePayload(JObject payload);
    }
}
