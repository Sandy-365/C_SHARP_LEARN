using System;
class SaleTransaction{
    public string InvoiceNo;
    public string CustomerName;
    public string ItemName;
    public int Quantity;
    public double PurchaseAmount;
    public double SellingAmount;
    public string ProfitOrLossStatus;
    public double ProfitOrLossAmount;
    public double ProfitMarginPercent;
    public static SaleTransaction LastTransaction=null;
    public static bool HasLastTransaction=false;
    public void CreateTransaction(){
        Console.Write("Enter Invoice No: ");
        InvoiceNo=Console.ReadLine();
        Console.Write("Enter Customer Name: ");
        CustomerName=Console.ReadLine();
        Console.Write("Enter Item Name: ");
        ItemName=Console.ReadLine();
        Console.Write("Enter Quantity: ");
        Quantity=int.Parse(Console.ReadLine());
        if(Quantity<=0){
            Console.WriteLine("Quantity must be greater than 0.");
            return;
        }
        Console.Write("Enter Purchase Amount (total): ");
        PurchaseAmount=double.Parse(Console.ReadLine());
        if(PurchaseAmount<=0){
            Console.WriteLine("Purchase Amount must be greater than 0.");
            return;
        }
        Console.Write("Enter Selling Amount (total): ");
        SellingAmount=double.Parse(Console.ReadLine());
        if(SellingAmount<0){
            Console.WriteLine("Selling Amount cannot be negative.");
            return;
        }
        if(SellingAmount>PurchaseAmount){
            ProfitOrLossStatus="PROFIT";
            ProfitOrLossAmount=SellingAmount-PurchaseAmount;
        }
        else if(SellingAmount<PurchaseAmount){
            ProfitOrLossStatus="LOSS";
            ProfitOrLossAmount=PurchaseAmount-SellingAmount;
        }
        else{
            ProfitOrLossStatus="BREAK-EVEN";
            ProfitOrLossAmount=0;
        }
        ProfitMarginPercent=(ProfitOrLossAmount/PurchaseAmount)*100;
        LastTransaction=this; 
        HasLastTransaction=true;
        Console.WriteLine("Transaction saved successfully.");
        Console.WriteLine("Status: "+ProfitOrLossStatus);
        Console.WriteLine("Profit/Loss Amount: "+ProfitOrLossAmount);
        Console.WriteLine("Profit Margin (%): "+ProfitMarginPercent);
    }
    public static void ViewLastTransaction(){
        if (!HasLastTransaction){
            Console.WriteLine("No transaction available. Please create a new transaction first.");
            return;
        }
        Console.WriteLine("-------------- Last Transaction --------------");
        Console.WriteLine("InvoiceNo: "+LastTransaction.InvoiceNo);
        Console.WriteLine("Customer: "+LastTransaction.CustomerName);
        Console.WriteLine("Item: "+LastTransaction.ItemName);
        Console.WriteLine("Quantity: "+LastTransaction.Quantity);
        Console.WriteLine("Purchase Amount: "+LastTransaction.PurchaseAmount);
        Console.WriteLine("Selling Amount: "+LastTransaction.SellingAmount);
        Console.WriteLine("Status: "+LastTransaction.ProfitOrLossStatus);
        Console.WriteLine("Profit/Loss Amount: "+LastTransaction.ProfitOrLossAmount);
        Console.WriteLine("Profit Margin (%): "+LastTransaction.ProfitMarginPercent);
    }
    public static void RecomuteProfitLoss(){
        if(!HasLastTransaction){
            Console.WriteLine("No transaction available. Please create a new transaction first.");
            return;
        }
        if(LastTransaction.SellingAmount>LastTransaction.PurchaseAmount){
            LastTransaction.ProfitOrLossStatus="PROFIT";
            LastTransaction.ProfitOrLossAmount=LastTransaction.SellingAmount-LastTransaction.PurchaseAmount;
        }
        else if(LastTransaction.SellingAmount<LastTransaction.PurchaseAmount){
            LastTransaction.ProfitOrLossStatus="LOSS";
            LastTransaction.ProfitOrLossAmount=LastTransaction.PurchaseAmount-LastTransaction.SellingAmount;
        }
        else{
            LastTransaction.ProfitOrLossStatus="BREAK-EVEN";
            LastTransaction.ProfitOrLossAmount = 0;
        }
        LastTransaction.ProfitMarginPercent=(LastTransaction.ProfitOrLossAmount/LastTransaction.PurchaseAmount)*100;
        Console.WriteLine("----------- Recalculated Result -----------");
        Console.WriteLine("Status: " + LastTransaction.ProfitOrLossStatus);
        Console.WriteLine("Profit/Loss Amount: " +
            LastTransaction.ProfitOrLossAmount);
        Console.WriteLine("Profit Margin (%): " +
            LastTransaction.ProfitMarginPercent);
    }
    public static void Main(string[] args){
        SaleTransaction st=new SaleTransaction();
        int opt = 0; 
        while (opt != 4){
            Console.WriteLine("\n================== QuickMart Traders ==================");
            Console.WriteLine("1. Create New Transaction (Enter Purchase & Selling Details)");
            Console.WriteLine("2. View Last Transaction");
            Console.WriteLine("3. Calculate Profit/Loss (Recompute & Print)");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your option: ");
            opt=int.Parse(Console.ReadLine());
            switch(opt){
                case 1:
                    st.CreateTransaction();
                    break;
                case 2:
                    ViewLastTransaction();
                    break;
                case 3:
                    RecomuteProfitLoss();
                    break;
                case 4:
                    Console.WriteLine("Thank you. Application closed normally.");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
