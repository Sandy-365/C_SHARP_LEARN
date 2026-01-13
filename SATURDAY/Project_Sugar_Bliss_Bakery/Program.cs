using System.Collections;
using System.Diagnostics;

class User
{
    public string Name;
    public int Age;
}
class Program
{
    public static void Validate(User u)
    {
        if (u.Age > 18)
        {
            Console.WriteLine("Age is greater than 18");
        }
    }
    public static void Main(string[] args)
    {


        // List<User> users = new List<User>();
        // users.Add(new User { Name = "Aryan", Age = 22 });
        // users.Add(new User { Name = "Mohit", Age = 15 });
        // users.Add(new User { Name = "Sushant", Age = 68 });
        // users.Add(new User { Name = "Ritik", Age = 63 });
        // users.Add(new User { Name = "Sahil", Age = 52 });

        // foreach (var user in users)
        // {
        //     Console.WriteLine($"User name is ::>> {user.Name} and Age is {user.Age}");
        // }


        // Queue<int> queue = new Queue<int>();
        // queue.Enqueue(45);
        // queue.Enqueue(55);
        // queue.Enqueue(65);
        // queue.Enqueue(75);
        // queue.Enqueue(25);

        // while (queue.Count > 0)
        // {
        //     Console.Write(queue.Dequeue() + " ");
        // }


        // Trace.Listeners.Add(new ConsoleTraceListener());
        // Trace.WriteLine("Application execution Started");
        // int a = 10;
        // int b = 0;
        // try
        // {
        //     int result = a/b;
        //     Console.WriteLine("Answer is ::>> "+result);   
        // }catch(Exception e)
        // {
        //     Console.WriteLine("Exception occured ::>> "+e.Message);
        // }

        // int total = 0;
        // for(int i = 0; i <= 5; i++)
        // {
        //     total += i;
        // }
        // Console.WriteLine("Total sum is ::>> "+total);

        // Chocolate cho = new Chocolate();
        // Chocolate cho1 = new Chocolate();


        // Console.Write("Enter Chocolate Flavour ::>> ");
        // cho.Flavour = Console.ReadLine();

        // Console.Write("Enter Quantity ::>> ");
        // cho.Quantity = Convert.ToInt32(Console.ReadLine());

        // Console.Write("Enter Price per unti ::>> ");
        // cho.PricePerUnit = Convert.ToInt32(Console.ReadLine());


        // if (cho.ValidateChocolateFlavour())
        // {
        //     cho1 = cho.CalculateDiscountedPrice(cho);
        // }
        // Console.WriteLine("\n------------- Detailed Info ------------------");
        // Console.WriteLine($"Choclate Flavour ::>> {cho1.Flavour}");
        // Console.WriteLine($"Choclate Quantity ::>> {cho1.Quantity}");
        // Console.WriteLine($"Choclate PricePerUnit ::>> {cho1.PricePerUnit}");
        // Console.WriteLine($"Choclate TotalPrice ::>> {cho1.TotalPrice}");
        // Console.WriteLine($"Choclate Discounter Price ::>> {cho1.DiscountedPrice}");

        _linq_Main obj = new _linq_Main();
        obj.Main();
    }
}