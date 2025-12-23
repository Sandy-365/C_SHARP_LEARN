abstract class _31_abs
{
    public void Display()
    {
        Console.WriteLine("Display");
    }

    public abstract void Hello();
}

class _31_child : _31_abs
{
    public override void Hello()
    {
        Console.WriteLine("Hello");
    }
}
