
using System;
using Services;
using Domain;

class Program
{
    static void Main()
    {
        Console.WriteLine("01_WarehouseInventory - Boilerplate");
        ManagementService service = new ManagementService();

        // TODO: Create entity
        PrimaryEntity entity = new PrimaryEntity{PriorityOrKey = 1};

        // TODO: Add entity
        service.AddEntity(entity);
        // TODO: Trigger custom exceptions
        
        // TODO: Display sorted results

        Console.ReadLine();
    }
}
