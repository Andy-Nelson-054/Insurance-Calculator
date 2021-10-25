using InsuranceCalculator.API.Interface;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace InsuranceCalculator.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsuranceController : ControllerBase
    {
        private readonly IPremiumCalculator _premiumCalculator;
        private readonly IBusinessInfo _businessInfo;
        
        public InsuranceController(IPremiumCalculator premiumCalculator, IBusinessInfo businessInfo)
        {
            _premiumCalculator = premiumCalculator;
            _businessInfo = businessInfo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello World!");
        }

        [HttpPost]
        public IActionResult Post(JObject payload)
        {
            BusinessInfo businessInfo = new BusinessInfo();
            businessInfo.DeserializePayload(payload);
            decimal premium =  _premiumCalculator.Calculate(businessInfo);

            //Would want to validate payload in production for security
            return Ok(premium);
        }
    }
}
