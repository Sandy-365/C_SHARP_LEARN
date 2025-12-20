class _16_Wallet
{
    private double Money;
    public _16_Wallet(double amount)
    {
        Money = amount;
    }

    public void AddMoney(double amount)
    {
        Money += amount;
        Console.WriteLine($"{amount} is added to your wallet");
    }

    public double GetMoney()
    {
        return Money;
    }
}