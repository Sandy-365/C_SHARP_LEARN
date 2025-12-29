using System;
using System.IO;


class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string msg) : base(msg)
    {

    }
}

class BankAccount
{
    public decimal Balance { get; private set; } = 5000;
    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be greaer than zero");
        }
        if (amount > Balance)
        {
            throw new InsufficientBalanceException("Insufficient balance for withdrawal");
        }
        Balance -= amount;
    }
}

class TryExcept
{
    public void Main()
    {
        try
        {
            Console.Write("Enter the amount ::>> ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            int divisionCheck = 10 / 2;

            string data = File.ReadAllText("account.txt");

            BankAccount account = new BankAccount();
            account.Withdraw(amount);
            Console.WriteLine("Withdrawal successful.");
        }

        catch (FormatException ex)
        {
            LogException(ex);
            Console.WriteLine("Invalid input format.");
        }
        catch (DivideByZeroException ex)
        {
            LogException(ex);
            Console.WriteLine("Arithmetic error occurred.");
        }
        catch (FileNotFoundException ex)
        {
            LogException(ex);
            Console.WriteLine("File not found.");
        }

    }
    public static void LogException(Exception ex)
    {
        File.AppendAllText("log.txt",DateTime.Now+" | "+ex.GetType().Name+"  |  "+ex.Message+" "+Environment.NewLine);
    }
}
