using InsuranceCalculator.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceCalculator.API.Interface
{
    public interface IPremiumCalculator
    {
        decimal Calculate(BusinessInfo businessInfo);
    }
}
