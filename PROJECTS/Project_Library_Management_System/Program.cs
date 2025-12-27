class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("STARTING LIBRARY MANAGEMENT SYSTEM");

        Book bookObj = new Book();
        bookObj.Title = "Sandy Theory";
        bookObj.Author = "Sandeep Kumar";
        bookObj.ItemId = 103;
        // bookObj.extraDays = 100;
        bookObj.CalculateLateFees(100);
        // bookObj.DisplayItems();
        bookObj.ReserveItem();
        bookObj.AcceptMessage();

        Console.WriteLine("");
        Magazine magObj = new Magazine();
        magObj.Title = "managaine sandy";
        magObj.Author = "San";
        magObj.ItemId = 123;
        // magObj.extraDays = 100;
        magObj.CalculateLateFees(100);
        // magObj.DisplayItems();
        

        LibraryItem[] libItems = new LibraryItem[2];
        libItems[0] = bookObj;
        libItems[1] = magObj;

        foreach(LibraryItem i in libItems)
        {
            Console.WriteLine("");
            i.DisplayItems();
        } 

    }
}