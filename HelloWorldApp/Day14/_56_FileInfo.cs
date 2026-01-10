class _56_Program
{
    public void Main()
    {
        FileInfo file = new FileInfo("Day14/_56_sample.txt");
        if (!file.Exists)
        {
            using(StreamWriter writer = file.CreateText())
            {
                writer.WriteLine("Hello FileInfo class");
            }
        }

        Console.WriteLine("File Name ::>> "+file.Name);
        Console.WriteLine("File Size ::>> "+file.Length+" bytes");
        Console.WriteLine("Created On ::>> "+file.CreationTime);

    }
}