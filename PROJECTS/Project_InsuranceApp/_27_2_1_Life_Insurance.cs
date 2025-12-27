using System;

class _27_LifeInsurance : _27_InsurancePolicy
{
    public override double CalculatePremium()
    {
        return Premium + 500;
    }

    public new void ShowPolicy()
    {
        Console.WriteLine("Life Insurance Policy");
        
    }
}
