using System;
using System.Windows.Forms;

class Program
{
    [STAThread] // REQUIRED for Windows Forms
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World");

        // your other console logic can stay
        _1_Array.main();

        // start drawing window
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }
}
