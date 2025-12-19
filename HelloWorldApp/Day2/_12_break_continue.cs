class BreakContinueExample
{
    public void BreakExample()
    {
        for(int i = 0; i <= 10; i++)
        {
            if (i == 5)
            {
                Console.WriteLine($"Breaking out of loop after {i}");
                break;
            }
            Console.WriteLine($"Count is {i}");
        }
    }

    public void ContinueExample()
    {
        Console.WriteLine("\n\n----------GAME BEGINS-------------");
        for(int i = 1; i <= 10; i++){
            if (i == 4)
            {
                Console.WriteLine($"E{i} is invinsible skipping e{4}");
                continue;
                // Console.WriteLine("now this will not run");
                // Console.WriteLine("Hello i am below E4");
            }

            Console.WriteLine($"Player killed e{i}");
        }
    }
}