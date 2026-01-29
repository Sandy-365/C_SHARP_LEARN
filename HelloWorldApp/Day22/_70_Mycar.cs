using System;

interface IGear
{
    void Grear_1_Test();
    void Grear_2_Test();
    void Grear_3_Test();
    void Grear_4_Test();
    void Grear_5_Test();
    void Grear_6_Test();
    void Grear_7_Test();
}

class _70_MyCar : IGear
{
    public void Grear_1_Test() { Console.WriteLine("Gear 1 Tested Successfully"); }
    public void Grear_2_Test() { Console.WriteLine("Gear 2 Tested Successfully"); }
    public void Grear_3_Test() { Console.WriteLine("Gear 3 Tested Successfully"); }
    public void Grear_4_Test() { Console.WriteLine("Gear 4 Tested Successfully"); }
    public void Grear_5_Test() { Console.WriteLine("Gear 5 Tested Successfully"); }
    public void Grear_6_Test() { Console.WriteLine("Gear 6 Tested Successfully"); }
    public void Grear_7_Test() { Console.WriteLine("Gear 7 Tested Successfully"); }

    public void TestAllGears()
    {
        Grear_1_Test();
        Grear_2_Test();
        Grear_3_Test();
        Grear_4_Test();
        Grear_5_Test();
        Grear_6_Test();
        Grear_7_Test();

    }

    public class Program
    {
        public void Main()
        {
            _70_MyCar car = new _70_MyCar();
            car.TestAllGears();
        }
    }
}
