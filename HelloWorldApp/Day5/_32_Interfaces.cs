// // interface ILogger
// // {
// //     void Log();
// // }

// // class FileLogger : ILogger
// // {
// //     void ILogger.Log()
// //     {
// //         Console.WriteLine("Logging to file");
// //     }
// // }

// interface ILogger
// {
//     void Log();
// }
// interface INotifier
// {
//     void Log();
// }
// class FileLogger : ILogger, INotifier
// {
//     void ILogger.Log()
//     {
//         Console.WriteLine("Logging to file via ILogger");
//     }
//     void INotifier.Log()
//     {
//         Console.WriteLine("Logging to notification via INotifier");
//     }
// }

class MyMath
{
    public static string Sqrt()
    {
        return "hello";
    }
}