class _15_BankAccount
{
    public int AccNum;
    public double Balance;

    public void Deposit(double amount)
    {
        Balance += amount;
    }

}

class _15_Employee
{
    public string? Name;
    public double Salary;

    public void DisplayDetails()
    {
        Console.WriteLine($"{Name} earns {Salary}");
    }
}