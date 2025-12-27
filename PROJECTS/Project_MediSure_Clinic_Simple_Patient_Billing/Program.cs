class Program
{
    static PatientBill data = new PatientBill();
    static bool HasLastBill = true;
    public static void ShowMenu()
    {   
        Console.WriteLine("\n\n");
        Console.WriteLine("\t\t.------------------------------------------------------------------------------.");
        Console.WriteLine("\t\t|                               MediSure Clinic Billing                        |");
        Console.WriteLine("\t\t'------------------------------------------------------------------------------'");
        Console.WriteLine("\t\t1. Create New Bill (Enter Patient Details) ");
        Console.WriteLine("\t\t2. View Last Bill");
        Console.WriteLine("\t\t3. Clear Last Bill");
        Console.WriteLine("\t\t4. Exit");
        Console.Write("\n\t\t\tEnter your option:   ");
    }

    public static void CreateNewBill()
    {

        Console.WriteLine("\t\t--------------------------------------------------------------------------------\n");
        Console.Write("\t\t\tEnter Bill Id: ");
        data.BillId = Console.ReadLine();

        Console.Write("\t\t\tEnter Patient Name: ");
        data.PatientName = Console.ReadLine();

        Console.Write("\t\t\tIs the patient insured? (Y/N): ");
        String str = Console.ReadLine();
        if (str.Equals("Y") || str.Equals("y"))
        {
            data.HasInsurance = true;
        }
        else
        {
            data.HasInsurance = false;
        }


        Console.Write("\t\t\tEnter Consultation Fee: ");
        data.ConsultationFee = Convert.ToDecimal(Console.ReadLine());

        Console.Write("\t\t\tEnter Lab Charges: ");
        data.LabCharges = Convert.ToDecimal(Console.ReadLine());

        Console.Write("\t\t\tEnter Medicine Charges: ");
        data.MedicineCharges = Convert.ToDecimal(Console.ReadLine());

        data.calcGrossAmount();
        data.calcDiscountAmount();
        data.calcFinalPayable();

        Console.WriteLine("\n\t\t\t\t.------------Bill created successfully.---------------.");
        Console.WriteLine( $"\t\t\t\t|     Gross Amount\t:\t {data.GrossAmount,-20} |");
        Console.WriteLine( $"\t\t\t\t|     Discount Amount\t:\t {data.DiscountAmount,-20} |");
        Console.WriteLine( $"\t\t\t\t|     Final Payable\t:\t {data.FinalPayable,-20} |");
        Console.WriteLine( "\t\t\t\t'-----------------------------------------------------'");

        Console.WriteLine("\t\t-----------------------------------------------------------------------------------");

    }
    public static void ViewLastBill()
    {
        if (HasLastBill)
        {
            Console.WriteLine("\t\t\t.---------------------------- Last Bill --------------------.");
            Console.WriteLine("\t\t\t|                                                           |");
            Print("BillId", data.BillId);
            Print("Patient", data.PatientName);
            Print("Insured", data.HasInsurance);
            Print("Consultation Fee", data.ConsultationFee);
            Print("Lab Charges", data.LabCharges);
            Print("Medicine Charges", data.MedicineCharges);
            Print("Gross Amount", data.GrossAmount);
            Print("Discount Amount", data.DiscountAmount);
            Console.WriteLine("\t\t\t|                                                           |");
            Console.WriteLine("\t\t\t'._________________________________________________________.'");
            Console.WriteLine("\t\t\t.-----------------------------------------------------------.");
            Console.WriteLine("\t\t\t|                                                           |");
            Print("Final Payable", data.FinalPayable);
            Console.WriteLine("\t\t\t|                                                           |");
            Console.WriteLine("\t\t\t'-----------------------------------------------------------'");

            void Print(string label, object value)
            {
                Console.WriteLine($"\t\t\t|       {label,-20}: {value,-30}|");
            }

        }
        else
        {
            Console.WriteLine("\t\t\t-----------------NO DATA AVALABLE--------------------");
        }
    }

    public static void ClearLastBill()
    {
        HasLastBill = false;
        Console.WriteLine("\n\t\t\t----------------------LAST BILL REMOVED-------------------------");
    }

    public static void Main(string[] args)
    {
        int ch = 0;
        while (ch != 4)
        {
            ShowMenu();
            ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    CreateNewBill();
                    break;
                case 2:
                    ViewLastBill();
                    break;
                case 3:
                    ClearLastBill();
                    break;
                case 4:
                    Console.WriteLine("\n\t\t\t---------------Thank you. Application closed normally.------------------");
                    break;
                default:
                    Console.WriteLine("\n\t\t\t-------------------------ENTER YOUR CHOICE BETWEEN 1-4 ONLY---------------------");
                    break;
            }
        }
    }
}