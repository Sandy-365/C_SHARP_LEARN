class _15_BankAccount
{
    public int AccNum;
    public double Balance;

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