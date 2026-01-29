interface CompulsoryFeature
{
    public void Grea1();
    public void Grea2();
    public void Grea3();
}

abstract class Features
{
    abstract public void Grea4();
    abstract public void Grea5();

    public void Camera()
    {
        Console.WriteLine("Cam Feature");
    }

    public void Radio()
    {
        Console.WriteLine("Radio");
    }
}

class _71_Program:Features,CompulsoryFeature
{
    public void Grea1(){Console.WriteLine("Grea 1 added");}
    public void Grea2(){Console.WriteLine("Grea 2 added");}
    public void Grea3(){Console.WriteLine("Grea 3 added");}


    public override void Grea4(){Console.WriteLine("Grear 4 added");}
    public override void Grea5(){Console.WriteLine("Grear 5 added");}
    public void Main()
    {
        run();
    }

    public void run()
    {
        Console.WriteLine("Hellow");
    }
}