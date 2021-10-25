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
        
        public InsuranceController(IPremiumCalculator premiumCalculator)
        {
            _premiumCalculator = premiumCalculator;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello World!");
        }

        [HttpPost]
        public IActionResult Post(JObject payload)
        {
            //move this stuff to a business logic class
            string businessJson = payload.ToString(Newtonsoft.Json.Formatting.None);
            BusinessInfo businessInfo = JsonConvert.DeserializeObject<BusinessInfo>(businessJson);

            decimal premium =  _premiumCalculator.Calculate(businessInfo.Revenue, businessInfo.State, businessInfo.Business);

            //Would want to validate payload in production for security
            return Ok(premium);
        }
    }
}
