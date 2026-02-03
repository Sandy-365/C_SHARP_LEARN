/*
A bike rental shop wants a simple console-based application to manage bike details such as model, brand, and price per day, and also to group bikes based on their brand. This application will help the shop organize its inventory efficiently and easily view bikes from the same brand.
🛠️ Functionalities
 
In class Program
 
public static SortedDictionary<int, Bike> bikeDetails
 
This sorted dictionary is already provided. It stores bike details with a unique integer key.
In class Bike, implement the below p
Data Type	Property Name
string	Model
string	Brand
int	PricePerDay
 
In class BikeUtility, implement the below methods
Method 1
public void AddBikeDetails(string model, string brand, int pricePerDay)
 
 
 
 
Adds the bike details (model, brand, price per day) to the bikeDetails dictionary.
The key of the dictionary should be one more than the current number of items.
Initially, the dictionary contains 0 items.
Method 2
public SortedDictionary<string, List<Bike>> GroupBikesByBrand()
 
 
 
 
Groups bikes based on their brand.
Each brand should map to a list of bikes belonging to it.
The grouped result should be returned as a SortedDictionary.

 
In Program class – Main Method
Get the required values from the user.
Call the appropriate methods.
Display the output exactly as shown in the Sample Input/Output.
Sample Input/Output

1. Add Bike Details
2. Group Bikes By Brand
3. Exit
Enter your choice
1

Enter the model
CBR 250R
Enter the brand
Honda
Enter the price per day
1200
Bike details added successfully
 
1. Add Bike Details
2. Group Bikes By Brand
3. Exit
Enter your choice
1

Enter the model
Ninja 300
Enter the brand
Kawasaki
Enter the price per day
1500
Bike details added successfully
 
1. Add Bike Details
2. Group Bikes By Brand
3. Exit
Enter your choice
2
Honda
CBR 250R
Kawasaki
Ninja 300
 
1. Add Bike Details
2. Group Bikes By Brand
3. Exit
Enter your choice
3

*/
class Bike
{
    public string Model { get; set; }
    public string Brand { get; set; }
    public int PricePerDay { get; set; }
}


class BikeUtility
{
    public void AddBikeDetails(string model, string brand, int pricePerDay)
    {
        int key = Program.bikeDetails.Count + 1;
        Bike bike = new Bike
        {
            Model = model,
            Brand = brand,
            PricePerDay = pricePerDay
        };
        Program.bikeDetails.Add(key, bike);
    }

    public SortedDictionary<string, List<Bike>> GroupBikesByBrand()
    {
        SortedDictionary<string, List<Bike>> result =
            new SortedDictionary<string, List<Bike>>();

        foreach (var item in Program.bikeDetails.Values)
        {
            if (!result.ContainsKey(item.Brand))
                result[item.Brand] = new List<Bike>();

            result[item.Brand].Add(item);
        }

        return result;
    }
}

class Program
{
    public static SortedDictionary<int, Bike> bikeDetails =
        new SortedDictionary<int, Bike>();

    static void Main(string[] args)
    {
        BikeUtility util = new BikeUtility();

        while (true)
        {
            Console.WriteLine("1. Add Bike Details");
            Console.WriteLine("2. Group Bikes By Brand");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Enter your choice");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Enter the model");
                string model = Console.ReadLine();

                Console.WriteLine("Enter the brand");
                string brand = Console.ReadLine();

                Console.WriteLine("Enter the price per day");
                int price = int.Parse(Console.ReadLine());

                util.AddBikeDetails(model, brand, price);
                Console.WriteLine("Bike details added successfully");
            }
            else if (choice == 2)
            {
                var grouped = util.GroupBikesByBrand();

                foreach (var brand in grouped)
                {
                    Console.WriteLine();
                    Console.WriteLine(brand.Key);
                    Console.WriteLine();

                    foreach (var bike in brand.Value)
                        Console.WriteLine(bike.Model);
                }
            }
            else if (choice == 3)
            {
                break;
            }
        }
    }
}