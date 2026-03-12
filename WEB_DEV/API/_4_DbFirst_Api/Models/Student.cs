using System;
using System.Collections.Generic;

namespace _4_DbFirst_Api.Models;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? M1 { get; set; }

    public int? M2 { get; set; }
}
