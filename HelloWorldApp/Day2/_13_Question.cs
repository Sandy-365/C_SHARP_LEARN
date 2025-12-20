/*
==============================
Design a Finance Control System

The system should perform the following tasks:
1. Loan Eligibility Check
2. Income Tax Calculation
3. Transaction Entry System
4. Exit Program

The system should run continuously until the user chooses to exit.
==============================
Finance Rules Used
Loan Eligibility Rules

Age must be 21 years or above
Monthly income must be ₹30,000 or more


-------------------------------------------
Income Tax Rules
Annual Income and Tax Rate
≤ ₹2,50,000 = 0%
₹2,50,001 – ₹5,00,000 = 5%
₹5,00,001 – ₹10,00,000 = 20%
Above ₹10,00,000 = 30%

lets Income = ₹6,00,000
Tax Calculation
Up to ₹2,50,000
Tax = 0%
Tax Amount = ₹0

₹2,50,001 – ₹5,00,000 (₹2,50,000)
Tax = 5%
Tax Amount = ₹12,500

₹5,00,001 – ₹6,00,000 (₹1,00,000)
Tax = 20%
Tax Amount = ₹20,000

Total Tax Payable -- ₹12,500 + ₹20,000 = ₹32,500
Final Answer -- You will pay ₹32,500 as income tax


--------------------------------------------
Transaction Rules
User can enter 5 transactions
Negative amount is invalid
Invalid transactions should be skipped



==============================
Program Flow
Program starts
Menu is displayed
User selects an option
Selected operation executes
Menu repeats until the user exits
*/


using System.Collections;
using System.Diagnostics;
using System.Transactions;

class BankApp
{
    public void checkLoanEligibility()
    {

        int Age;
        float Salary;
        Console.Write("\t\tEnter your Customer Age ::>> ");
        Age = Convert.ToInt32(Console.ReadLine());
        Console.Write("\t\tEnter yourCustomer  Salary ::>> ");
        Salary = Convert.ToSingle(Console.ReadLine());

        if (Age >= 21 && Salary >= 30000)
        {
            Console.WriteLine("\t\tEligible for LOAN");
        }
        else
        {
            Console.WriteLine("\t\tNot Eligible for LOAN");
        }

    }

    public void calculateTax()
    {
        float AnnualIncome;
        Console.Write("\t\tEnter yourCustomer  Salary ::>> ");
        AnnualIncome = Convert.ToSingle(Console.ReadLine());
        float tax = 0.0f;


        if (AnnualIncome <= 250000)
        {
            tax = 0;
            Console.WriteLine("\t\t0% Tax Rate on this amount " + AnnualIncome+" and tax is "+tax);
        }
        else if (AnnualIncome > 250000 && AnnualIncome <= 500000)
        {
            tax = (AnnualIncome - 250000.0f) * 0.05f;
            Console.WriteLine("\t\t0% 5% Tax Rate on this amount " + AnnualIncome+" and total tax is "+tax);
        }
        else if (AnnualIncome > 500000 && AnnualIncome <= 1000000)
        {
            tax = (250000 * 0.05f)+((AnnualIncome-500000)*0.2f);
            Console.WriteLine("\t\t0% 5% 20% Tax Rate on this amount " + AnnualIncome+" and total tax is "+tax);
        }
        else
        {
            tax = (250000 * 0.05f)+(500000*0.2f)+((AnnualIncome-100000)*0.3f);
            Console.WriteLine("\t\t0% 5% 20% 30% Tax Rate on this amount " + AnnualIncome+" and total tax is "+tax);
        }

    }

    public void TransactionRules()
    {
        float currentBalance = 0;
        Console.Write("\t\tEnter your Customer  Salary ::>> ");
        currentBalance = Convert.ToSingle(Console.ReadLine());

        for (int i = 0; i < 5; i++)
        {
            float inp = Convert.ToSingle(Console.ReadLine());

            if (currentBalance + inp < 0)
            {
                Console.WriteLine("\t\t\t.~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~.");
                Console.WriteLine("\t\t\t| You Can Not WidthDraw Money      |");
                Console.WriteLine("\t\t\t| First Deposte Some money to take |");
                Console.WriteLine("\t\t\t| Skipping this transaction        |");
                Console.WriteLine("\t\t\t`~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~`");
            }
            else
            {
                currentBalance += inp;
                if (inp < 0)
                {
                    Console.WriteLine($"\t\tCurrent Balance after WidthDraw ::>> {currentBalance}");
                }
                else
                {
                    Console.WriteLine($"\t\tCurrent Balance after Deposite ::>> {currentBalance}");
                }

            }
        }
    }
    public void startMenu()
    {
        Console.WriteLine("\t\t==============================");
        Console.WriteLine("\t\t\tMAIN MENU LOOP");
        Console.WriteLine("\t\t==============================");
        Console.WriteLine("\t\t1.Check Load Eligibility");
        Console.WriteLine("\t\t2.Calculate Tax");
        Console.WriteLine("\t\t3.Enter Transactions");
        Console.WriteLine("\t\t4.Exit");
    }

    public void runProgram()
    {
        int ch = 0;

        do
        {
            Console.WriteLine("\n\n");
            startMenu();
            Console.Write("\t\tEnter Your Choice 1-4 ::>> ");
            ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("\n");
                    Console.WriteLine("\t\t\tWELCOME TO ELIGIBILITY CHECK");
                    checkLoanEligibility();
                    break;
                case 2:
                    Console.WriteLine("\n");
                    Console.WriteLine("\t\t\tWELCOME TO INCOME TAX CALCULATION");
                    calculateTax();
                    break;
                case 3:
                    Console.WriteLine("\n");
                    Console.WriteLine("\t\t\tWELCOME TO TRANSACTIONS");
                    TransactionRules();
                    break;

                case 4:
                    Console.WriteLine("\t\t\t--------------------EXITING-----------");
                    break;
                default:
                    Console.WriteLine("\n");
                    Console.WriteLine("\t\t\tPlease Enter your input between 1 to 4 only.");
                    break;
            }
        } while (ch != 4);
    }
}