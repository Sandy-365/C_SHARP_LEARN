using System;

class Program
{
    static void Main()
    {
        ShipmentDetails shipment = new ShipmentDetails();

        Console.Write("Enter Shipment Code ::>> ");
        shipment.ShipmentCode = Console.ReadLine();

        if (!shipment.ValidateShipmentCode())
        {
            Console.WriteLine("Invalid shipment code");
            return;
        }

        Console.Write("Enter TransportMode ::>> ");
        shipment.TransportMode = Console.ReadLine();

        Console.Write("Enter Weight ::>> ");
        shipment.Weight = double.Parse(Console.ReadLine());

        Console.Write("Enter StorageDays ::>> ");
        shipment.StorageDays = int.Parse(Console.ReadLine());

        double totalCost = shipment.CalculateTotalCost();
        Console.WriteLine($"The total shipping cost is {totalCost:F2}");
    }
}
