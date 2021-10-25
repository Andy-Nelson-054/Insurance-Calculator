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

        //public decimal CalculatePremium()
        //{

        //}
    }
}
