class SumOfNumberWhile
{
    public void sum()
    {
        int count = 0;
        int sum = 0;
        while(count <= 5)
        {
            sum += count;
            count++;
        }
        Console.WriteLine("Sum of numb 0 to num 5 is "+sum);

    }
}