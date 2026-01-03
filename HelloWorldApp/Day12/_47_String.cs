using System.Text;
class _47_String
{
    public void Main()
    {
        // string str = "Sandeep";
        // str = str + " Manish";
        // Console.WriteLine("str ::>> " + str);


        // StringBuilder sb = new StringBuilder();
        // sb.Append("Hello");
        // sb.Append(" ");
        // sb.Append("World");
        // Console.WriteLine("sb ::>> " + sb.ToString());

        Console.WriteLine(GC.GetTotalMemory(false));

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 10000; i++)
            sb.Append(i);

        string result = sb.ToString();

        Console.WriteLine(GC.GetTotalMemory(false));
        Console.WriteLine(GC.GetTotalMemory(false));
        string str = "Sandeep";
        for (int i = 0; i < 10000; i++)
            str = str+i;


        StringBuilder sb1 = new StringBuilder("Hello");
        StringBuilder sb2 = new StringBuilder("Hello");

        Console.WriteLine(sb1.Equals(sb2));

        StringBuilder sb3 = sb2;
        Console.WriteLine(sb3.Equals(sb2));

        Console.WriteLine();

    }
}