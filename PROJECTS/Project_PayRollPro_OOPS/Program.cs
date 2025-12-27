class Program
{

    static List<EmployeeRecord> employees = new List<EmployeeRecord>();
    public static void ShowOptions()
    {
        Console.WriteLine("===========================================");
        Console.WriteLine("||         MAIN MENU                     ||");
        Console.WriteLine("===========================================");
        Console.WriteLine("1.Register Employee");
        Console.WriteLine("2.Show Overtime Summary");
        Console.WriteLine(":3.Calculate Average Monthly Pay");
        Console.WriteLine("4.Exit");
        Console.Write("\nEnter you Choice ::>> ");

    }

    public static void RegisterEmployee()
    {
        EmployeeRecord emp;

        Console.Write("Select Employee Type (1-Full Time, 2-Contract) ::>> ");
        int type = Convert.ToInt32(Console.ReadLine());

        emp = type == 1 ? new FullTimeEmployee() : new ContractEmployee();

        Console.Write("Enter Employee Name ::>> ");
        emp.EmployeeName = Console.ReadLine();

        Console.Write("Enter Hourly Rate ::>> ");
        double rate = Convert.ToDouble(Console.ReadLine());

        if (emp is FullTimeEmployee ft)
        {
            ft.HourlyRate = rate;
            Console.Write("Enter Monthly Bonus ::>> ");
            ft.MonthlyBonus = Convert.ToDouble(Console.ReadLine());
        }
        else
        {
            ((ContractEmployee)emp).HourlyRate = rate;
        }

        double[] hours = new double[4];
        Console.WriteLine("Enter Weekly Hours (Week 1 to 4)");

        for (int i = 0; i < 4; i++)
            hours[i] = Convert.ToDouble(Console.ReadLine());


        emp.WeeklyHours = hours;


        employees.Add(emp);
        Console.WriteLine("Employee registered successfully");
    }

    public static void ShowOvertimeSummary()
    {
        foreach (EmployeeRecord e in employees)
        {
            double totalHours = e.WeeklyHours.Sum();
            if (totalHours > 160)
                Console.WriteLine(e.EmployeeName + " Overtime Hours : " + (totalHours - 160));
        }
    }


    public static void CalculateAverageMonthlyPay()
    {
        if (employees.Count == 0)
        {
            Console.WriteLine("No employees registered");
            return;
        }

        double total = employees.Sum(e => e.GetMonthlyPay());
        Console.WriteLine("Average Monthly Pay : " + (total / employees.Count));
    }

    public static void Main(string[] args)
    {
        int ch = 0;
        while (ch != 4)
        {
            ShowOptions();
            ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    // Console.WriteLine("1");
                    RegisterEmployee();
                    break;
                case 2:
                    // Console.WriteLine("2");
                    ShowOvertimeSummary();
                    break;
                case 3:
                    Console.WriteLine("3");
                    CalculateAverageMonthlyPay();
                    break;
                default:
                    Console.WriteLine("Please enter your option between 1-4 only");
                    break;
            }
        }
    }
}