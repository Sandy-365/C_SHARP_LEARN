using System;
using System.Collections.Generic;

namespace _8_Task_CollegeHostel.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string? StudentName { get; set; }

    public string? Department { get; set; }

    public int? Year { get; set; }

    public virtual ICollection<Hostel> Hostels { get; set; } = new List<Hostel>();
}
