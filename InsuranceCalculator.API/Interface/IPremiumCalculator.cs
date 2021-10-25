
namespace InsuranceCalculator.API.Interface
{
    public interface IPremiumCalculator
    {
        decimal Calculate(BusinessInfo businessInfo);
    }
}