
class stuRec_6
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Course { get; set; }
    public int Marks { get; set; }
}

class Meeting_6
{
    static List<stuRec_6> list = new List<stuRec_6>();

    static void fetchById(string id)
    {
        stuRec_6 student = null;

        foreach (stuRec_6 s in list)
        {
            if (s.Id == id)
            {
                student = s;
                break;
            }
        }

        if (student != null)
        {
            Console.WriteLine("\nStudent Found:");
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Course: {student.Course}, Marks: {student.Marks}");
        }
        else
        {
            Console.WriteLine("\nStudent not found!");
        }
    }

    static void updateById(string id, int marks)
    {
        stuRec_6 student = null;

        foreach (stuRec_6 s in list)
        {
            if (s.Id == id)
            {
                student = s;
                break;
            }
        }

        if (student != null)
        {
            student.Marks = marks;
            Console.WriteLine($"\nMarks updated successfully for Id {id}");
        }
        else
        {
            Console.WriteLine("\nStudent not found!");
        }
    }

    public void main()
    {
        Console.WriteLine("Hello World");

        list.Add(new stuRec_6 { Id = "1", Name = "Sandeep", Course = "CSE", Marks = 96 });
        list.Add(new stuRec_6 { Id = "2", Name = "Jayant", Course = "BIO", Marks = 98 });
        list.Add(new stuRec_6 { Id = "3", Name = "Manish", Course = "CHE", Marks = 92 });

        Console.WriteLine("\nAll Students:");
        foreach (var i in list)
        {
            Console.WriteLine($"Id: {i.Id}, Name: {i.Name}, Course: {i.Course}, Marks: {i.Marks}");
        }

        // fetchById("1");

        // updateById("2", 345);

        // fetchById("2");

        int ch = 1;
        while (ch != 3)
        {
            Console.WriteLine("\n1. Fetch by Id");
            Console.WriteLine("2. Update marks by Id");
            Console.WriteLine("3. Exit");
            Console.Write("Enter choice: ");

            ch = Convert.ToInt32(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Enter student id to fetch details: ");
                    string id = Console.ReadLine();
                    fetchById(id);
                    break;

                case 2:
                    Console.Write("Enter student id to update marks: ");
                    string uid = Console.ReadLine();
                    Console.Write("Enter new marks: ");
                    int marks = Convert.ToInt32(Console.ReadLine());
                    updateById(uid, marks);
                    break;

                case 3:
                    Console.WriteLine("Exiting program...");
                    break;

                default:
                    Console.WriteLine("Wrong input!");
                    break;
            }
        }

    }
}
