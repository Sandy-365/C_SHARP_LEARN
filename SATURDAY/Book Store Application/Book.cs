public class Book
{
    public string Id { get; private set; }
    public string Title { get; private set; }
    public string Author { get; private set; }
    public int Price { get; private set; }
    public int Stock { get; private set; }

    public Book(string id, string title, int price, int stock)
    {
        Id = id;
        Title = title;
        Price = price;
        Stock = stock;
    }

    public void SetPrice(int newPrice)
    {
        if (newPrice < 0)
            Console.WriteLine("Price cannot be negative");
            return;
        Price = newPrice;
    }

    public void SetStock(int newStock)
    {
        if (newStock < 0)
            Console.WriteLine("Stock cannot be negative");
            return;
        Stock = newStock;
    }
}

public class BookUtility
{
    private Book book;

    public BookUtility(Book book)
    {
        this.book = book;
    }

    public void GetBookDetails()
    {
        Console.WriteLine($"Details: {book.Id} {book.Title} {book.Price} {book.Stock}");
    }

    public void UpdateBookPrice(int newPrice)
    {
        book.SetPrice(newPrice);
        Console.WriteLine($"Updated Price: {newPrice}");
    }

    public void UpdateBookStock(int newStock)
    {
        book.SetStock(newStock);
        Console.WriteLine($"Updated Stock: {newStock}");
    }
}