using System.Text.RegularExpressions;

namespace LogProcessing
{
    class LogParser
    {
        private readonly string validLineRegexPattern = @"^\[(TRC|DBG|INF|WRN|ERR|FTL)\]";
        private readonly string splitLineRegexPattern = @"<[\^*=]+>";
        private readonly string quotedPasswordRegexPattern = @"""(password|PASSWORD)[^""]*";
        private readonly string endOfLineRegexPattern = @"end-of-line\d+";
        private readonly string weakPasswordRegexPattern = @"^(password|PASSWORD)[a-zA-Z0-9]+";

        public bool IsValidLine(string text)
        {
            bool result = Regex.IsMatch(text, validLineRegexPattern);
            return result;
        }

        public void task1()
        {
            string str1 = "[INF] Application started ";
            string str2 = "[ERR] Database connection failed";
            string str3 = "[WRN] Low memory warning";
            string str4 = "INF Application started";
            string str5 = "[INFO] Application started";
            string str6 = "[ABC] Unknown message";
            Console.WriteLine($"Answer for string {str1} is ::>> {IsValidLine(str1)}");
            Console.WriteLine($"Answer for string {str2} is ::>> {IsValidLine(str2)}");
            Console.WriteLine($"Answer for string {str3} is ::>> {IsValidLine(str3)}");
            Console.WriteLine($"Answer for string {str4} is ::>> {IsValidLine(str4)}");
            Console.WriteLine($"Answer for string {str5} is ::>> {IsValidLine(str5)}");
            Console.WriteLine($"Answer for string {str6} is ::>> {IsValidLine(str6)}");
        }

        public void task2()
        {
            string str1 = "[INF] User login<*>Session created<====>Access granted";
            string[] allSplits = Regex.Split(str1, splitLineRegexPattern);
            Console.WriteLine("Splited string is ::>> \n" + (string.Join("\n", allSplits)));
        }

        public void task3()
        {
            string str1 = """User said "password123 is weak" Admin noted "PASSWORD456 expired" No issue found with password its okay """;
            int ans = Regex.Matches(str1, quotedPasswordRegexPattern).Count;
            Console.WriteLine("Number of password found is ::>> " + ans);
        }

        public void task4()
        {
            string str1 = "Transaction completed successfully end-of-line456";
            string result = Regex.Replace(str1, endOfLineRegexPattern, "");
            Console.WriteLine(result);
        }

        public void task5()
        {
            string str1 = "password123";
            string str2 = "password1A2B3C";
            string str3 = "password@123";

            bool result1 = Regex.IsMatch(str1, weakPasswordRegexPattern);
            bool result2 = Regex.IsMatch(str2, weakPasswordRegexPattern);
            bool result3 = Regex.IsMatch(str3, weakPasswordRegexPattern);

            Console.WriteLine("password123 is weak password ::>> " + result1);
            Console.WriteLine("password1A2B3C is weak password ::>> " + result2);
            Console.WriteLine("password@123 is weak password ::>> " + result3);
        }
    }
}