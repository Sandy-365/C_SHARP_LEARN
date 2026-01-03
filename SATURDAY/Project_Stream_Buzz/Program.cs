class Program
{
    public static List<CreatorStats> EngagementBoard = new List<CreatorStats>();
    public void RegisterCreator(CreatorStats record)
    {
        Console.Write("Enter Creator Name ::>> ");
        record.CreatorName = Console.ReadLine();

        Console.WriteLine("Enter weekly likes (Week 1 to 4) ::>>");
        record.WeeklyLikes = new double[4];
        for (int i = 0; i < 4; i++)
        {
            Console.Write($"Enter {i + 1} week likes ::>> ");
            record.WeeklyLikes[i] = Convert.ToInt32(Console.ReadLine());
        }

        EngagementBoard.Add(record);
        Console.WriteLine($"Creator {record.CreatorName} registered successfully!\n");
    }

    public Dictionary<string, int> GetTopPostCounts(List<CreatorStats> records, double likeThreshold)
    {
        Dictionary<string, int> data = new Dictionary<string, int>();
        foreach (CreatorStats i in records)
        {
            int count = 0;
            foreach (double j in i.WeeklyLikes)
            {
                if (j >= likeThreshold)
                {
                    count++;
                }
            }
            data.Add(i.CreatorName, count);
        }
        return data;
    }

    public double CalculateAverageLikes()
    {
        double countLike = 0.0d;
        int totalCreators = 0;
        foreach (CreatorStats i in EngagementBoard)
        {
            totalCreators++;
            foreach (double j in i.WeeklyLikes)
            {
                countLike += j;
            }
        }
        return countLike / (totalCreators * 4);
    }

    public static void Option1()
    {
        Program obj = new Program();
        CreatorStats newRecord = new CreatorStats();
        obj.RegisterCreator(newRecord);
    }
    public static void Option2()
    {
        Program obj = new Program();
        Console.Write("Enter like threshold ::>> ");
        int likeThreshold = Convert.ToInt32(Console.ReadLine());
        Dictionary<string, int> getData = obj.GetTopPostCounts(EngagementBoard, likeThreshold);
        int getDataCount = getData.Count;
        if (getDataCount == 0)
        {
            Console.WriteLine("No top-performing posts this week");
        }
        else
        {
            foreach (KeyValuePair<string, int> i in getData)
            {
                Console.WriteLine(i.Key + "  " + i.Value);
            }
        }
    }
    public static void Option3()
    {
        Program obj = new Program();
        double result = obj.CalculateAverageLikes();
        Console.WriteLine("Overall average weekly likes ::>> " + result);
    }

    public static void MainMenu()
    {
        Console.WriteLine("1. Register Creator");
        Console.WriteLine("2. Show Top Posts");
        Console.WriteLine("3. Calculate Average Likes");
        Console.WriteLine("4. Exit");
        Console.Write("Enter your choice ::>> ");
    }
    public static void Main(string[] args)
    {
        int ch = 0;
        while (ch != 4)
        {
            MainMenu();
            ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Option1();
                    break;
                case 2:
                    Option2();
                    break;
                case 3:
                    Option3();
                    break;
                case 4:
                    Console.WriteLine("Thankyou Exiting...");
                    break;
                default:
                    Console.WriteLine("Please Enter your Choice between 1-4 only");
                    break;
            }
        }
    }
}