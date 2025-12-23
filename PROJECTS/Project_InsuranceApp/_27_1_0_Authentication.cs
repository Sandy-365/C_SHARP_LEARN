sealed class _27_Authentication
{
    private string password="admin123";
    public string Password
    {
        set
        {
            password = value;
        }
    }

    public bool authenticate(string pass)
    {
        if (password == pass)
        {
            Console.WriteLine(" -------------------------------------");
            Console.WriteLine("|  User Authentication Successfull  ! |");
            Console.WriteLine(" -------------------------------------");
            return true;
        }
        Console.WriteLine(" ------------------------------------");
        Console.WriteLine("|  User Authentication Failed  !!!   |");
        Console.WriteLine(" ------------------------------------");
        return false;
    }
}
