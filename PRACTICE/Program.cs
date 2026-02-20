using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

class Student
{
    public int Id{get;set;}
    public string Name{get;set;}
    public float Height{get;set;}
    public int Age{get;set;}
}
class Program
{
    public static void Main(string[] args)
    {
        List<Student> lis = new List<Student>
        {
            new Student{Id=1,Name="Sandeep",Height=175,Age=23},
            new Student{Id=2,Name="Manish",Height=184,Age=21},
            new Student{Id=3,Name="Ramjee",Height=179,Age=22},
            new Student{Id=4,Name="Happy",Height=127,Age=20}
        };
        // var options = new JsonSerializerOptions{WriteIndented=true};
        string json = JsonSerializer.Serialize(lis);
        File.WriteAllText("student.json",json);

        string data = File.ReadAllText("student.json");
        List<Student> str = JsonSerializer.Deserialize<List<Student>>(data);
        foreach(Student i in str)
        {
            Console.WriteLine(i.Id);
        }
    }
}







// /*Question 1: Student Attendance Analyzer

// A college stores attendance data entered by a staff member as a single line:

// 101:Present,102:Absent,103:Present,104:,105:Present,ABC:Present,106:Absent

// Requirements

// Write a C# program that:

// Reads the input string.

// Parses each entry safely.

// Stores valid student attendance in a Dictionary<int, bool?>

// Key → Student ID

// Value →

// true = Present

// false = Absent

// null = Missing attendance

// Ignore invalid IDs (like ABC).

// If attendance value is missing (example: 104:), store it as null.

// Use StringBuilder to generate the output report.

// Output Format
// Attendance Report
// -----------------
// 101 -> Present
// 102 -> Absent
// 103 -> Present
// 104 -> Not Marked
// 105 -> Present
// 106 -> Absent

// Total Present: X
// Total Absent: X
// Not Marked: X
// using System;
// using Microsoft.Win32;

// */
// class Program
// {
//     static void Main()
//     {
//         // string inp1 = Console.ReadLine();
//         // string[] par1 = inp1.Split(",");

//         // Console.WriteLine(string.Join("---",par1));

//         // Dictionary<int,bool?> stu = new Dictionary<int, bool?>();
//         // int totalPresent = 0;
//         // int totalAbsent = 0;
//         // int notMarked = 0;

//         // foreach(string i in par1)
//         // {
//         //     string[] ids = i.Split(":");
//         //     int id;
//         //     if(int.TryParse(ids[0],out id))
//         //     {
//         //         if (ids[1].Equals("present", StringComparison.OrdinalIgnoreCase))
//         //         {
//         //             stu[id] = true;
//         //             totalPresent++;
//         //         }else if(ids[1].Equals("absent", StringComparison.OrdinalIgnoreCase))
//         //         {
//         //             stu[id] = false;
//         //             totalAbsent++;
//         //         }
//         //         else
//         //         {
//         //             stu[id] = null;
//         //             notMarked++;
//         //         }
//         //     }
//         // }
//         // Console.WriteLine(string.Join("-",stu));

//         // Console.WriteLine("Output");
//         // foreach(KeyValuePair<int,bool?> i in stu)
//         // {
//         //     string result = i.Value == true?"present":i.Value==false?"absent":"Not marked";
//         //     Console.WriteLine(i.Key+" -> "+result);
//         // }

//         // Console.WriteLine();
//         // Console.WriteLine("Total Present ::>> "+totalPresent);
//         // Console.WriteLine("Total Absent ::>> "+totalAbsent);
//         // Console.WriteLine("Not Marked ::>> "+notMarked);

//         // string path = "data.txt";
//         // File.WriteAllText(path, "Hello file handling");
//         // string[] lines = {"Hello ","Sandeep","Manish"};
//         // File.AppendAllLines(path, lines);

//         // string content = File.ReadAllText(path);
//         // Console.WriteLine(content);



//         string[] data = File.ReadAllLines("data.txt");
//         Console.WriteLine(string.Join("\n",data));

//     }
// }




