public class Book : LibraryItem,IReservable,INotifiable
{
    private float LateFees;
    private int ExtraDays;
    // public int extraDays
    // {
    //     set
    //     {
    //         ExtraDays = value;
    //     }
    // }
    public override void DisplayItems()
    {
        Console.WriteLine($"Title of the Book is ::>> {Title}");
        Console.WriteLine($"Author of the Book '{Title}' is ::>> {Author}");
        Console.WriteLine($"Item Id is ::>> {ItemId}");
        Console.WriteLine($"Late fee for exactly {ExtraDays} days is ::>> {LateFees}");
        
    }

    public override void CalculateLateFees(int Days)
    {
        ExtraDays = Days;
        LateFees = ExtraDays * 1.0f;
    }

    public void ReserveItem()
    {
        Console.WriteLine("Reservation Successfull");
    }

    public void AcceptMessage()
    {
        Console.WriteLine("Notification message sent ");
    }
}
