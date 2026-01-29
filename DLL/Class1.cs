namespace MyRef
{
    public interface I1
    {
        void m1();
        void m2();
    }
    public interface I2
    {
        void m3();
        void m4();
    }
    public interface I3
    {
        void m5();
        void m6();
    }

    public class ClassA : I1,I2,I3
    {
        public void m1() { }
        public void m2() { }
        public void m3() { }
        public void m4() { }
        public void m5() { }
        public void m6() { }

        public int add(int a, int b)
        {
            return a + b;
        }

        public string getName()
        {
            return "ClassA";
        }

    }

    public class ClassB : ClassA
    {
        public void RandomFunc(){}
    }
}