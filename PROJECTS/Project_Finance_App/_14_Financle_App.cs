/*
NOTE:

This is a **Mini Project: Finance Management System** implemented in C#.
The program is fully menu-driven and demonstrates practical usage of
core programming concepts.

==============================================================
PROJECT OBJECTIVE
==============================================================
To design a finance system that handles:
- Money outflow (Debit)
- Money inflow (Credit)

The program runs continuously until the user chooses Exit.

==============================================================
PROJECT STRUCTURE
==============================================================
Classes Used:
1. FinanceApp   → Main controller and menu handler
2. Debit        → Handles money outflow operations
3. Credit       → Handles money inflow operations

Each Debit and Credit class contains **exactly four functions**,
as per project rules.

==============================================================
MAIN CLASS: FinanceApp
==============================================================
Responsibilities:
- Displays the main menu
- Controls program flow
- Redirects user to Debit or Credit operations

Menu Options:
1. Debit Operations
2. Credit Operations
3. Exit

Concepts Used:
- do-while loop
- switch-case
- Object creation
- Modular design

==============================================================
CLASS: Debit (Money Outflow)
==============================================================
Handles expenses, withdrawals, and balance checks.

--------------------------------------------------------------
1. ATM Withdrawal Limit Validation
--------------------------------------------------------------
Rule:
- Daily limit = ₹40,000

Expected Output:
- "Withdrawal permitted within daily limit."
- "Daily ATM withdrawal limit exceeded."

--------------------------------------------------------------
2. EMI Burden Evaluation
--------------------------------------------------------------
Rule:
- EMI must not exceed 40% of monthly income

Expected Output:
- "EMI is financially manageable."
- "EMI exceeds safe income limit."

--------------------------------------------------------------
3. Transaction-Based Daily Spending Calculator
--------------------------------------------------------------
Expected Output:
- "Total debit amount for the day: ₹XXXX"

--------------------------------------------------------------
4. Minimum Balance Compliance Check
--------------------------------------------------------------
Rule:
- Minimum balance = ₹2,000

Expected Output:
- "Minimum balance not maintained. Penalty applicable."
- "Minimum balance requirement satisfied."

==============================================================
CLASS: Credit (Money Inflow)
==============================================================
Handles income, deposits, and rewards.

--------------------------------------------------------------
1. Net Salary Credit Calculation
--------------------------------------------------------------
Expected Output:
- "Net salary credited: ₹XXXX"

--------------------------------------------------------------
2. Fixed Deposit Maturity Calculation
--------------------------------------------------------------
Expected Output:
- "Fixed Deposit maturity amount: ₹XXXX"

--------------------------------------------------------------
3. Credit Card Reward Points Evaluation
--------------------------------------------------------------
Expected Output:
- "Reward points earned: XXXX"

--------------------------------------------------------------
4. Employee Bonus Eligibility Check
--------------------------------------------------------------
Expected Output:
- "Employee is eligible for bonus."
- "Employee is not eligible for bonus."

==============================================================
PROGRAM FLOW
==============================================================
1. Program starts
2. Main menu displayed
3. User selects option
4. Selected module executes
5. Menu repeats
6. Program exits only when Exit is selected

==============================================================
KEY CONCEPTS DEMONSTRATED
==============================================================
- Classes and objects
- Menu-driven programs
- switch-case
- if–else and logical operators
- for and do-while loops
- User input handling
- Real-world finance logic

==============================================================
KEY LEARNING
==============================================================
This project is a complete example of combining
decision making, loops, and modular programming
to build a real-world console-based application.
*/


class FinanceApp
{
	void MainMenuOptions()
	{
		Console.WriteLine("\n\n");
		Console.WriteLine("\t\t=========================================");
		Console.WriteLine("\t\t||              MAIN MENU              ||");
		Console.WriteLine("\t\t=========================================");

		Console.WriteLine("\t\t1.	Debit Operations");
		Console.WriteLine("\t\t2.	Credit Operations");
		Console.WriteLine("\t\t3.	Exit");
		Console.WriteLine("");
		Console.Write("\t\tEnter your choice ::>> ");

	}
	public void runProgram()
	{
		int choice = 0;
		do
		{
			MainMenuOptions();
			choice = Convert.ToInt32(Console.ReadLine());

			switch (choice)
			{
				case 1:
					Debit debitObj = new Debit();
					debitObj.runDebit();
					break;
				case 2:
					Credit creditObj = new Credit();
					creditObj.runCredit();
					break;
				case 3:
					Console.WriteLine("\n\t\t\t---------------EXITING------------");
					break;
				default:
					Console.WriteLine("\n\t\t\tPlease Enter your choice between 1-3 only");
					break;
			}

		} while (choice != 3);
	}
}

class Debit
{
	void DebitMenu()
	{
		Console.WriteLine("");
		Console.WriteLine("\t\t\t ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
		Console.WriteLine("\t\t\t|         DEBIT MENU            |");
		Console.WriteLine("\t\t\t ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
		Console.WriteLine("\t\t1: ATM Withdrawal Limit Validation");
		Console.WriteLine("\t\t2: EMI Burden Evaluation");
		Console.WriteLine("\t\t3: Transaction-Based Daily Spending Calculator");
		Console.WriteLine("\t\t4: Minimum Balance Compliance Check");
		Console.WriteLine("\t\t5: Main Menu");
		Console.WriteLine("");
		Console.Write("\t\tEnter your choice ::>> ");
	}
	public void runDebit()
	{
		int DebitChoice = 0;
		do
		{
			DebitMenu();
			DebitChoice = Convert.ToInt32(Console.ReadLine());

			switch (DebitChoice)
			{
				case 1:
					AtmWithdrawalLimitValidation();
					break;
				case 2:
					EmiBurdernEvaluation();
					break;
				case 3:
					TransactionBasedDailySpendCalculator();
					break;
				case 4:
					MinimumBalanceComplianceCheck();
					break;
				case 5:
					Console.WriteLine("\n\t\t\t---------------EXITING------------");
					break;
				default:
					Console.WriteLine("\n\t\t\tPlease Enter your choice between 1-5 only");
					break;
			}

		} while (DebitChoice != 5);

	}
	void AtmWithdrawalLimitValidation()
	{
		float fixedAmount = 40000.0f;
		float withdrawalAmount = 0.0f;
		Console.Write("\t\tEnter the withdrawal amount ::>> ");
		withdrawalAmount = Convert.ToSingle(Console.ReadLine());
		if (withdrawalAmount <= fixedAmount)
		{
			Console.WriteLine("\t\tWithdrawal permitted within daily limit.");
		}
		else
		{
			Console.WriteLine("\t\tDaily ATM withdrawal limit exceeded.");
		}
	}

	void EmiBurdernEvaluation()
	{
		float monthlyIncome = 0.0f;
		float emiAmount = 0.0f;

		Console.Write("\t\tEnter the  monthly income ::>> ");
		monthlyIncome = Convert.ToSingle(Console.ReadLine());
		
		Console.Write("\t\tEnter the emi Amount amount ::>> ");
		emiAmount = Convert.ToSingle(Console.ReadLine());

		float notExced = monthlyIncome * 0.4f;
		if (emiAmount <= notExced)
		{
			Console.WriteLine("\t\tEMI is financially manageable.");
		}
		else
		{
			Console.WriteLine("\t\tEMI exceeds safe income limit.");
		}
	}

	void TransactionBasedDailySpendCalculator()
	{
		int numOfTransactions = 0;
		Console.Write("\t\tEnter the number of transactions ::>> ");
		numOfTransactions = Convert.ToInt32(Console.ReadLine());

		float sum = 0.0f;
		for (int i = 0; i < numOfTransactions; i++)
		{
			sum += Convert.ToSingle(Console.ReadLine());
		}
		Console.WriteLine($"\t\tTotal debit amount for the day: ₹{sum}");
	}

	void MinimumBalanceComplianceCheck()
	{
		float minBalance = 2000.0f;
		float currentBalance = 0.0f;
		Console.Write("\t\tEnter the current balance ::>> ");
		currentBalance = Convert.ToSingle(Console.ReadLine());

		if (currentBalance < minBalance)
		{
			Console.WriteLine("\t\tMinimum balance not maintained. Penalty applicable.");
		}
		else
		{
			Console.WriteLine("\t\tMinimum balance requirement satisfied.");
		}
	}
}

class Credit
{

	void CreditMenu()
	{
		Console.WriteLine("");
		Console.WriteLine("\t\t\t ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
		Console.WriteLine("\t\t\t|         CREDIT MENU           |");
		Console.WriteLine("\t\t\t ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
		Console.WriteLine("\t\t1: Net Salary Credit Calculation");
		Console.WriteLine("\t\t2: Fixed Deposit Maturity Calculation");
		Console.WriteLine("\t\t3: Credit Card Reward Points Evaluation");
		Console.WriteLine("\t\t4: Employee Bonus Eligibility Check");
		Console.WriteLine("\t\t5: Main Menu");
		Console.WriteLine("");
		Console.Write("\t\tEnter your choice ::>> ");
	}
	public void runCredit()
	{
		int CreditChoice = 0;
		do
		{
			CreditMenu();
			CreditChoice = Convert.ToInt32(Console.ReadLine());

			switch (CreditChoice)
			{
				case 1:
					NetSalaryCreditCalculation();
					break;
				case 2:
					FixedDepositMaturityCalculation();
					break;
				case 3:
					CreditCardRewardPointsEvaluation();
					break;
				case 4:
					EmployeeBonusEligibilityCheck();
					break;
				case 5:
					Console.WriteLine("\n\t\t\t---------------EXITING CREDIT OPTION------------");
					break;
				default:
					Console.WriteLine("\n\t\t\tPlease Enter your choice between 1-5 only");
					break;
			}

		} while (CreditChoice != 5);

	}
	void NetSalaryCreditCalculation()
	{
		float grossSalary = 0.0f;
		Console.Write("\t\tEnter your gross salary ::>> ");
		grossSalary = Convert.ToSingle(Console.ReadLine());
		float netSalary = grossSalary - (grossSalary * 0.1f);
		Console.WriteLine($"\t\tNet salary credited: ₹{netSalary}");
	}

	void FixedDepositMaturityCalculation()
	{
		float principal = 0.0f;
		float rateOfInterest = 0.0f;
		int time = 0;

		Console.Write("\t\tEnter your principal ::>> ");
		principal = Convert.ToSingle(Console.ReadLine());

		Console.Write("\t\tEnter your rate Of Interest ::>> ");
		rateOfInterest = Convert.ToSingle(Console.ReadLine());

		Console.Write("\t\tEnter your number of month ::>> ");
		time = Convert.ToInt32(Console.ReadLine());

		float SI = (principal * rateOfInterest * time) / 100;
		float MaturityAmount = principal + SI;

		Console.WriteLine($"\t\tFixed Deposit maturity amount: ₹{MaturityAmount}");
	}

	void CreditCardRewardPointsEvaluation()
	{
		float totalCreditSpending = 0.0f;
		Console.Write("\t\tEnter your total credit card spending ::>> ");
		totalCreditSpending = Convert.ToSingle(Console.ReadLine());
		int rewardPoints = Convert.ToInt32(totalCreditSpending) / 100;
		Console.WriteLine($"\t\tReward points earned: {rewardPoints}");
	}

	void EmployeeBonusEligibilityCheck()
	{
		float salary = 0.0f;
		int yearOfService = 0;

		Console.Write("\t\tEnter your annual salary ::>> ");
		salary = Convert.ToSingle(Console.ReadLine());

		Console.Write("\t\tEnter your year of service ::>> ");
		yearOfService = Convert.ToInt32(Console.ReadLine());

		if (salary >= 500000 && yearOfService >= 3)
		{
			Console.WriteLine("\t\tEmployee is eligible for bonus.");
		}
		else
		{
			Console.WriteLine("\t\tEmployee is not eligible for bonus.");
		}
	}
}