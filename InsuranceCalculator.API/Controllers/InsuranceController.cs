using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using InsuranceCalculator.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InsuranceCalculator.API.Interface;

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
            //string businessJson = payload.ToString(Newtonsoft.Json.Formatting.None);
            //BusinessInfo businessInfo = JsonConvert.DeserializeObject<BusinessInfo>(businessJson);
            BusinessInfo businessInfo = new BusinessInfo();
            businessInfo.DeserializePayload(payload);
            decimal premium =  _premiumCalculator.Calculate(businessInfo);

            //Would want to validate payload in production for security
            return Ok(premium);
        }
    }
}
