using System;

class Program
{
    static void Main()
    {
        _27_Authentication authObj = new _27_Authentication();
        authObj.Password = "Sandeep123";
        bool notlogin = true;
        
        while (notlogin)
        {
            Console.Write("Enter password ::>> ");
            string pass = Console.ReadLine()!;
            if (authObj.authenticate(pass))
            {
                notlogin = false;
            }
        }

        _27_LifeInsurance life = new _27_LifeInsurance
        {
            PolicyNumber = 12345,
            PolicyHolderName = "AMIT",
            Premium = 5000
        };
        
        _27_HealthInsurance health = new _27_HealthInsurance
        {
            Premium = 8000
        };


        _27_InsurancePolicy p1 = life;
        _27_InsurancePolicy p2 = health;

        Console.WriteLine("Name ::>> "+p1.PolicyHolderName);
        Console.WriteLine("Number ::>> "+p1.PolicyNumber);
        Console.WriteLine("Life Premium: " + p1.CalculatePremium());
        Console.WriteLine("Health Premium: " + p2.CalculatePremium());

        life.ShowPolicy();
        p1.ShowPolicy();
    }
}
