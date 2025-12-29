class Program
{
    public static void Main(string[] args)
    {
        int a = 10;
        int b = 0;
        try
        {
            int result = a / b;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error occurred:" + ex.Message);
        }
    }
}