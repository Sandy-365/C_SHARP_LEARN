
class _Employee
{
    public string name;
    public int salary;
}

class _75_Main
{
    public void Main()
    {
        List<_Employee> lis = new List<_Employee>();
        lis.Add(new _Employee{name = "Saneep",salary = 1000});
        lis.Add(new _Employee{name = "Manish",salary = 1300});
        lis.Add(new _Employee{name = "Mohan",salary = 3452});

        int maxSal = lis.Max(x => x.salary);
        var res = lis.Where(x => x.salary == maxSal);

        Console.WriteLine(res.First().name);
        // foreach(var i in res)
        // {
        //     Console.WriteLine(i.name +" is having max salary");
        // }
    }
}