class Program
{
    public static void Main(string[] args)
    {
        Chocolate cho = new Chocolate();
        Chocolate cho1 = new Chocolate();


        Console.Write("Enter Chocolate Flavour ::>> ");
        cho.Flavour = Console.ReadLine();

        Console.Write("Enter Quantity ::>> ");
        cho.Quantity = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Price per unti ::>> ");
        cho.PricePerUnit = Convert.ToInt32(Console.ReadLine());


        if (cho.ValidateChocolateFlavour())
        {
            cho1 = cho.CalculateDiscountedPrice(cho);
        }
        Console.WriteLine("\n------------- Detailed Info ------------------");
        Console.WriteLine($"Choclate Flavour ::>> {cho1.Flavour} \nChoclate Quantity ::>> {cho1.Quantity} \nChoclate PricePerUnit ::>> {cho1.PricePerUnit} \nChoclate TotalPrice ::>> {cho1.TotalPrice} \nChoclate Discounter Price ::>> {cho1.DiscountedPrice}");
    }   
}