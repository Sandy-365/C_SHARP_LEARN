using System.Reflection;
class _74_Reflection
{
    public void Main()
    {
        Assembly asm = Assembly.LoadFrom("C:\\Users\\sagar\\Desktop\\CAPGEM-TRAIN\\NOTES\\__CODING__\\DLL\\bin\\Debug\\net10.0\\MyRef.dll");

        Console.WriteLine("ASSEMBLY: " + asm.FullName);
        Console.WriteLine();

        Type[] types = asm.GetTypes();

        Console.WriteLine("INTERFACES :");
        foreach (Type t in types.Where(x => x.IsInterface))
        {
            Console.WriteLine("  " + t.FullName);
        }
        Console.WriteLine("CLASSES :");
        foreach (Type t in types.Where(x => x.IsClass))
        {
            Console.WriteLine("  " + t.FullName);
        }


        Type classB = asm.GetType("MyRef.ClassB");
        MethodInfo[] methods = classB.GetMethods();

        Console.WriteLine("METHODS IN ClassB:");
        foreach (MethodInfo m in methods)
        {
            Console.WriteLine("  " + m.ReturnType.Name + " " + m.Name);
        }

    }
}