using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the Details ::>> ");
        string[] input = Console.ReadLine().Split(' ');
        string bookId = input[0];
        string title = input[1];
        int price = int.Parse(input[2]);
        int stock = int.Parse(input[3]);

        Book book = new Book(bookId, title, price, stock);
        BookUtility utility = new BookUtility(book);

        while (true)
        {
            Console.WriteLine("1 → Display book details");
            Console.WriteLine("2 → Update book price");
            Console.WriteLine("3 → Update book stock");
            Console.WriteLine("4 → Exit");

            Console.Write("Choice ::>> ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    utility.GetBookDetails();
                    break;
                case 2:
                    Console.Write("Enter the new Book Price ::>> ");
                    int newPrice = int.Parse(Console.ReadLine());
                    utility.UpdateBookPrice(newPrice);
                    break;
                case 3:
                Console.Write("Enter the new Stock amount ::>> ");
                    int newStock = int.Parse(Console.ReadLine());
                    utility.UpdateBookStock(newStock);
                    break;
                case 4:
                    Console.WriteLine("Thank You");
                    return;
                default:
                    break;
            }
        }
    }
}
