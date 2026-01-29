
delegate void MyIntDeligate(int a,int b);
delegate void MyStringDelegate(string str);

class _72_func
{
    public void add(int a,int b)
    {
        Console.WriteLine("A + B is "+(a+b));
    }

    public void subtract(int c,int d)
    {
        Console.WriteLine("C - D is "+(c-d));
    }

    public void stringLength(string str)
    {
        Console.WriteLine("Length of the string is "+(str.Length));
    }
}
class _72_Program
{
    public void Main()
    {
        _72_func obj = new _72_func();
        MyIntDeligate d = obj.add;
        d += obj.subtract;
        d(20,8);


        MyStringDelegate dStr = obj.stringLength;
        dStr("Sandeep");
    }
}