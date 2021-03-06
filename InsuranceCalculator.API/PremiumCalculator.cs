using InsuranceCalculator.API.Interface;
using System;

namespace InsuranceCalculator.API
{
    public class PremiumCalculator : IPremiumCalculator
    {

        public decimal Calculate(IBusinessInfo businessInfo)
        {
            decimal revenue = businessInfo.Revenue;
            string state = businessInfo.State;
            string business = businessInfo.Business;
            
            decimal OHFactor = 1;
            decimal FLFactor = 1.2M;
            decimal TXFactor = 0.943M;

            decimal architect = 1;
            decimal plumber = 0.5M;
            decimal programmer = 1.25M;

            decimal hazardFactor = 4;

            decimal stateFactor;
            decimal businessFactor;
            
            decimal premium = 0M;

            decimal basePremium = Math.Ceiling(revenue / 1000);

            if (state == "OH")
            {
                stateFactor = OHFactor;
            } 
            else if (state == "FL")
            {
                stateFactor = FLFactor;
            }
            else if (state == "TX")
            {
                stateFactor = TXFactor;
            }
            else
            {
                throw new ArgumentException($"Insurance not available for {state}");
            }

            if(business == "Architect")
            {
                businessFactor = architect;
            }
            else if(business == "Plumber")
            {
                businessFactor = plumber;
            }
            else if (business == "Programmer")
            {
                businessFactor = programmer;
            }
            else
            {
                throw new ArgumentException($"Insurance not available for {business}");
            }

            premium = decimal.Round( stateFactor * businessFactor * hazardFactor * basePremium, 2 );

            return premium;
        }


    }
}
