
namespace InsuranceCalculator.API.Interface
{
    public interface IPremiumCalculator
    {
        decimal Calculate(IBusinessInfo businessInfo);
    }
}