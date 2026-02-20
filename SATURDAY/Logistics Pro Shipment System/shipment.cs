public class Shipment
{
    public string ShipmentCode { get; set; }
    public string TransportMode { get; set; }
    public double Weight { get; set; }
    public int StorageDays { get; set; }
}

public class ShipmentDetails : Shipment
{
    public bool ValidateShipmentCode()
    {
        if (ShipmentCode.Length != 7)
        {
            Console.WriteLine("LENGTH less than 7");
            return false;
        }

        if (!ShipmentCode.StartsWith("GC#"))
            return false;

        string numericPart = ShipmentCode.Substring(3);
        foreach (char ch in numericPart)
        {
            if (!char.IsDigit(ch))
                return false;
        }

        return true;
    }

    public double CalculateTotalCost()
    {
        double ratePerKg = 0;

        if (TransportMode == "Sea")
            ratePerKg = 15.00;
        else if (TransportMode == "Air")
            ratePerKg = 50.00;
        else if (TransportMode == "Land")
            ratePerKg = 25.00;

        double totalCost = (Weight * ratePerKg) + Math.Sqrt(StorageDays);
        return Math.Round(totalCost, 2);
    }
}
