using AutonomousRobot.AI;

class Program
{
    public static void Main(string[] args)
    {
        List<SensorReading> list = new List<SensorReading>{
            new SensorReading { SensorId = 1, Type = "Distance", Value = 1, TimeStamp = DateTime.Now, Confidence = 0.99 },
            new SensorReading { SensorId = 2, Type = "Battery", Value = 18, TimeStamp = DateTime.Now, Confidence = 0.43 },
            new SensorReading { SensorId = 3, Type = "Temperature", Value = 40, TimeStamp = DateTime.Now, Confidence = 0.83 },
            new SensorReading { SensorId = 4, Type = "Vibration", Value = 2, TimeStamp = DateTime.Now, Confidence = 0.76 },
            new SensorReading { SensorId = 5, Type = "Battery", Value = 20, TimeStamp = DateTime.Now, Confidence = 0.97 },
            new SensorReading { SensorId = 6, Type = "Distance", Value = 0.4, TimeStamp = DateTime.Now, Confidence = 0.68 },
            new SensorReading { SensorId = 11, Type = "Distance", Value = 1, TimeStamp = DateTime.Now, Confidence = 0.99 },
            new SensorReading { SensorId = 12, Type = "Battery", Value = 18, TimeStamp = DateTime.Now, Confidence = 0.43 },
            new SensorReading { SensorId = 13, Type = "Temperature", Value = 40, TimeStamp = DateTime.Now, Confidence = 0.83 },
            new SensorReading { SensorId = 14, Type = "Vibration", Value = 2, TimeStamp = DateTime.Now, Confidence = 0.76 },
            new SensorReading { SensorId = 15, Type = "Battery", Value = 20, TimeStamp = DateTime.Now, Confidence = 0.97 },
            new SensorReading { SensorId = 16, Type = "Distance", Value = 0.4, TimeStamp = DateTime.Now, Confidence = 0.68 }
        };

        DecisionEngine obj = new DecisionEngine();

        //// TASK 1
        Console.WriteLine("\n");
        DateTime fromTime = DateTime.Now.AddSeconds(-10);
        List<SensorReading> listResult = obj.GetRecentReadings(list, fromTime);
        foreach (var i in listResult)
        {
            Console.WriteLine(i.SensorId + " " + i.Type + " " + i.Value);
        }



        //// TASK 2
        Console.WriteLine("\n");
        bool Task_2_Result = obj.IsBatteryCritical(list);
        Console.WriteLine("Answer for Task 2 (IsBatteryCritical) is ::>> "+Task_2_Result);


        //// TASk 3
        Console.WriteLine("\n");
        double Task_3_Result = obj.GetNearestObstacleDistance(list);
        Console.WriteLine("Answer for Task 3 (GetNearestObstacleDistance) is ::>> "+Task_3_Result);


        //// TASk 4
        Console.WriteLine("\n");
        bool Task_4_Result = obj.IsTemperatureSafe(list);
        Console.WriteLine("Answer for Task 4 (IsTemperatureSafe) is ::>> "+Task_4_Result);


        //// TASk 5
        Console.WriteLine("\n");
        double Task_5_Result = obj.GetAverageVibration(list);
        Console.WriteLine("Answer for Task 5 (GetAverageVibration) is ::>> "+Task_5_Result);


        //// TASk 6
        Console.WriteLine("\n");
        Dictionary<string, double> Task_6_Result = obj.CalculateSensorHealth(list);
        Console.WriteLine("Answer for Task 6 (CalculateSensorHealth) is ::>> "+string.Join(" ",Task_6_Result));


        //// TASk 7
        Console.WriteLine("\n");
        List<string> Task_7_Result = obj.DetectFaultySensors(list);
        Console.WriteLine("Answer for Task 7 (DetectFaultySensors) is ::>> "+string.Join(" ",Task_7_Result));


        //// TASk 9
        Console.WriteLine("\n");
        double Task_9_Result = obj.GetWeightedDistance(list);
        Console.WriteLine("Answer for Task 9 (GetWeightedDistance) is ::>> "+string.Join(" ",Task_9_Result));



    }
}
