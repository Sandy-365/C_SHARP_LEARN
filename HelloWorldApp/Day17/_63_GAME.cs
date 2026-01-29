using System;
using System.Reflection;

class _63_GAME
{
    public void Main()
    {
        string dllPath = @"C:\Users\sagar\Desktop\TestFiles\SkyDrive_Data\Managed\Assembly-CSharp.dll";

        Assembly gameAssembly = Assembly.LoadFrom(dllPath);

        Console.WriteLine("Loaded Assembly:");
        Console.WriteLine(gameAssembly.FullName);
        Console.WriteLine();

        Console.WriteLine("All Classes/Scripts:");
        foreach (Type t in gameAssembly.GetTypes())
        {
            Console.WriteLine(t.FullName);
        }

        Console.WriteLine();
        string className = "CarCoins";
        Type type = gameAssembly.GetType(className);

        Console.WriteLine("Selected Class:");
        Console.WriteLine(type == null ? "Class not found" : type.FullName);

        if (type == null) return;

        Console.WriteLine();
        Console.WriteLine("Fields (Data Members):");
        foreach (FieldInfo f in type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly))
        {
            Console.WriteLine($"{f.FieldType.Name} {f.Name}");
        }

        Console.WriteLine();
        Console.WriteLine("Properties:");
        foreach (PropertyInfo p in type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly))
        {
            Console.WriteLine($"{p.PropertyType.Name} {p.Name}");
        }

        Console.WriteLine();
        Console.WriteLine("All Methods of " + type.FullName + ":");
        foreach (MethodInfo m in type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly))
        {
            Console.WriteLine(m);
        }
    }
}
