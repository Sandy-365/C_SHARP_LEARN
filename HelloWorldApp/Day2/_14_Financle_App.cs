/*
Mini Project: Finance Management System (C#)

⸻

1. Problem Statement (Verified)

The aim of this project is to develop a menu-driven finance management system using C#,
demonstrating the use of classes, functions, loops, conditional statements, and switch-case.
The project is divided into Debit and Credit operations, each handling distinct financial activities related to money outflow and inflow.

⸻

2. Project Rules (Validated)
	1.	Two classes are used:
	•	Debit
	•	Credit
	2.	Each class contains exactly four different functions.
	3.	Menu navigation is implemented using switch-case.
	4.	Decision making is implemented using if–else and logical operators.
	5.	Loops are used for repetitive calculations.
	6.	Program executes until the user selects Exit.

⸻

3. Class: Debit (Money Outflow Operations)

The Debit class handles financial activities where money is spent, deducted, or restricted.

⸻

Function 1: ATM Withdrawal Limit Validation

Purpose:
To verify whether the withdrawal amount is within the daily ATM limit.

Rules / Logic:
	•	User enters withdrawal amount.
	•	Daily withdrawal limit is fixed (₹40,000).
	•	If withdrawal amount ≤ limit → allowed.
	•	If withdrawal amount > limit → rejected.

Expected Output:
	•	“Withdrawal permitted within daily limit.”
	•	OR
	•	“Daily ATM withdrawal limit exceeded.”

⸻

Function 2: EMI Burden Evaluation

Purpose:
To determine whether a customer can manage a loan EMI.

Rules / Logic:
	•	User enters monthly income.
	•	User enters EMI amount.
	•	EMI must not exceed 40% of monthly income.
	•	EMI ≤ 40% → manageable.
	•	EMI > 40% → financial burden.

Expected Output:
	•	“EMI is financially manageable.”
	•	OR
	•	“EMI exceeds safe income limit.”

⸻

Function 3: Transaction-Based Daily Spending Calculator

Purpose:
To calculate total spending from multiple debit transactions.

Rules / Logic:
	•	User enters number of transactions.
	•	Loop runs for each transaction.
	•	Transaction amounts are summed.

Loop Used:
	•	for or while loop

Expected Output:
	•	“Total debit amount for the day: ₹XXXX”

⸻

Function 4: Minimum Balance Compliance Check

Purpose:
To check whether the account maintains the required minimum balance.

Rules / Logic:
	•	Minimum balance required: ₹2,000.
	•	User enters current balance.
	•	Balance < ₹2,000 → penalty applicable.
	•	Balance ≥ ₹2,000 → compliant.

Expected Output:
	•	“Minimum balance not maintained. Penalty applicable.”
	•	OR
	•	“Minimum balance requirement satisfied.”

⸻

4. Class: Credit (Money Inflow Operations)

The Credit class manages financial activities where money is earned, credited, or accumulated.

⸻

Function 1: Net Salary Credit Calculation

Purpose:
To calculate the net salary credited after deductions.

Rules / Logic:
	•	User enters gross salary.
	•	Fixed deduction of 10% is applied.
	•	Net salary is calculated.

Expected Output:
	•	“Net salary credited: ₹XXXX”

⸻

Function 2: Fixed Deposit Maturity Calculation

Purpose:
To calculate the maturity amount of a fixed deposit.

Rules / Logic:
	•	User enters principal, rate of interest, and time period.
	•	Simple interest is calculated.
	•	Maturity amount = Principal + Interest.

Expected Output:
	•	“Fixed Deposit maturity amount: ₹XXXX”

⸻

Function 3: Credit Card Reward Points Evaluation

Purpose:
To calculate reward points based on spending.

Rules / Logic:
	•	User enters total credit card spending.
	•	1 reward point is earned for every ₹100 spent.
	•	Reward points are calculated using division.

Expected Output:
	•	“Reward points earned: XXXX”

⸻

Function 4: Employee Bonus Eligibility Check

Purpose:
To determine bonus eligibility based on salary and experience.

Rules / Logic:
	•	Annual salary ≥ ₹5,00,000
	•	Years of service ≥ 3
	•	Both conditions must be satisfied.

Conditions Used:
	•	Logical AND (&&)

Expected Output:
	•	“Employee is eligible for bonus.”
	•	OR
	•	“Employee is not eligible for bonus.”

⸻

5. Menu System (Confirmed Correct)

Main Menu Options:
	1.	Debit Operations
	2.	Credit Operations
	3.	Exit

Rules:
	•	Menu displayed repeatedly using a loop.
	•	Selection handled using switch-case.
	•	Exit terminates the program.

⸻
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