using System;
using System.Collections.Generic;

public class Jewellery
{
    public string Id { get; set; }
    public string Type { get; set; }
    public string Material { get; set; }
    public int Price { get; set; }
}

public class JwelleryUtility
{
    public Dictionary<string, string> GetJewelleryDetails(string id)
    {
        Dictionary<string, string> result = new Dictionary<string, string>();
        foreach (var item in M13.jewelleryDetails.Values)
        {
            if (item.Id == id)
            {
                result.Add(item.Id, item.Type + "_" + item.Material);
                break;
            }
        }
        return result;
    }

    public Dictionary<string, Jewellery> UpdateJewelleryPrice(string id, int price)
    {
        Dictionary<string, Jewellery> result = new Dictionary<string, Jewellery>();
        foreach (var item in M13.jewelleryDetails)
        {
            if (item.Value.Id == id)
            {
                item.Value.Price = price;
                result.Add(id, item.Value);
                break;
            }
        }
        return result;
    }
}

public class M13
{
    public static Dictionary<int, Jewellery> jewelleryDetails = new Dictionary<int, Jewellery>();
    public void main()
    {
        jewelleryDetails.Add(1, new Jewellery{Id = "JW01",Type = "Bracelet",Material = "Silver",Price = 5000});
        jewelleryDetails.Add(2, new Jewellery{Id = "JW02",Type = "Ring",Material = "Gold",Price = 8000});
        jewelleryDetails.Add(3, new Jewellery{Id = "JW03",Type = "Necklace",Material = "Gold",Price = 12000});
        JwelleryUtility utility = new JwelleryUtility();
        bool run = true;
        while (run)
        {
            Console.WriteLine("1. Get Jewellery Details");
            Console.WriteLine("2. Update Price");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Enter your choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Enter the jewellery id");
                string id = Console.ReadLine();
                var result = utility.GetJewelleryDetails(id);
                if (result.Count == 0)
                {
                    Console.WriteLine("Jewellery id not found");
                }
                else
                {
                    foreach (var r in result)
                    {
                        Console.WriteLine(r.Key + "   " + r.Value);
                    }
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter the jewellery id");
                string id = Console.ReadLine();
                Console.WriteLine("Enter the price to be updated");
                int price = Convert.ToInt32(Console.ReadLine());
                var result = utility.UpdateJewelleryPrice(id, price);
                if (result.Count == 0)
                {
                    Console.WriteLine("Jewellery id not found");
                }
                else
                {
                    foreach (var r in result)
                    {
                        Jewellery j = r.Value;
                        Console.WriteLine(
                            "Id : " + j.Id +
                            ",    Type : " + j.Type +
                            ",    Material : " + j.Material +
                            ",    Price : " + j.Price
                        );
                    }
                }
            }
            else if (choice == 3)
            {
                Console.WriteLine("Thank you");
                run = false;
            }
            Console.WriteLine();
        }
    }
}
