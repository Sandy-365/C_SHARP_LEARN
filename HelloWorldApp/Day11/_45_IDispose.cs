class ResourceHandler : IDisposable
{
    public ResourceHandler()
    {
        Console.WriteLine("Resource Called");
    }
    public void Dispose()
    {
        Console.WriteLine("Dispose()");
    }
}
class _45_Dispose
{
    public void Main()
    {
        using (ResourceHandler handler = new ResourceHandler())
        {
            Console.WriteLine("Using resource.");
        }
        Console.WriteLine("End of program.");
    }
}

