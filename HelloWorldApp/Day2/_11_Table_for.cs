class TableUsingForLoop
{
    public void table()
    {
        int start =20;
        int end = 30;
        for(int i = start; i <= end; i++)
        {
            Console.WriteLine($"--------- Table of {i} -----------");
            for(int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} X {j} = {i*j}");
            }
            Console.WriteLine("\n\n");
        }
    }
}