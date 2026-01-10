class _57_Program
{
    public void Main()
    {
        Directory.CreateDirectory("Day14/Log_Folder");
        if (Directory.Exists("Day14/Log_Folder"))
        {
            Console.WriteLine("Folder Created sucessfully");
        }


        DirectoryInfo dir = new DirectoryInfo("Day14/Log_Folder");
        if (!dir.Exists)
        {
            dir.Create();
        }

        Console.WriteLine("Directory Name ::>> "+dir.Name);
        Console.WriteLine("Directory Create Time ::>> "+dir.CreationTime);
        Console.WriteLine("Directory Full Path ::>> "+dir.FullName);
    }
}