using System.Text.RegularExpressions;

class _41_Regex
{
    public void Main()
    {
        // bool result = Regex.IsMatch("abc123", @"\d");
        // Console.WriteLine("Pattern Matched is ::>> " + result);

        // string Sentence = "abc123";
        // string pattern = @"\d";

        // string Sentence = "abc123";
        // string pattern = @"\d";


        // bool result2 = Regex.IsMatch(Sentence, pattern);
        // Console.WriteLine("Pattern matching for abc123 with \\d is " + result2);


        // string Sentence = "abc123";
        // string pattern = @"\d*";
        // Match m = Regex.Match(Sentence,pattern);
        // Console.WriteLine("Checking the first occurance of integer abc123 ::>> "+m);

        // string Sentence = "10_20_30";
        // string pattern = @"\D";
        // Match m = Regex.Match(Sentence,pattern);
        // Console.WriteLine("Checking the first occurance of integer abc123 ::>> "+m);


        // string Sentence = "10A20B30C";
        // string pattern = @"\D";
        // Match m = Regex.Match(Sentence,pattern);
        // Console.WriteLine("Checking the first occurance of integer abc123 ::>> "+m);

        // string Sentence = "10A20B30C";
        // string pattern = @"\D$";
        // Match m = Regex.Match(Sentence,pattern);
        // Console.WriteLine("Checking the first occurance of integer abc123 ::>> "+m);


        // string Sentence = "10A20B30C";
        // string pattern = @"\D$";
        // MatchCollection m = Regex.Matches(Sentence, pattern);
        // Console.WriteLine("Checking the first occurance of integer abc123 ::>> " + m);


        // @(?< groupname > pattern)
        // Original code

        // string Sentence = "5000";
        // string Amount = "5000";
        // string Pattern = @"Amount=(?<value>\d+)";

        string Pattern = @"(?<year>\d{4})-(?<month>\d{2})-(?<date>\d{2})";
        // string Input = "23-02-1992";
        string Input = "1992-02-23, 1990-01-01";

        // Match m = Regex.Match(Input, Pattern);
        // Console.WriteLine(m.Groups["year"].Value);
        // Console.WriteLine(m.Groups["month"].Value);

        MatchCollection m = Regex.Matches(Input, Pattern);
        foreach (Match x in m)
        {
            Console.WriteLine("What will printed in x.Group[0].value ::>> " + x.Groups[0].Value);
            Console.WriteLine("What will printed in x.Group[1].value ::>> " + x.Groups[1].Value);
            Console.WriteLine("What will printed in x.Group[2].value ::>> " + x.Groups[2].Value);
            Console.WriteLine("What will printed in x.Group[3].value ::>> " + x.Groups[3].Value);
            Console.WriteLine(x.Groups["year"].Value);
            Console.WriteLine(x.Groups["month"].Value);
            Console.WriteLine(x.Groups["date"].Value);
            Console.WriteLine();
        }

        // Match ans = Regex.Match("apple","a..");
        // Console.WriteLine("Output of Match m = Regex.Match('apple','a..'); ::>> "+ans);
        // Match ans = Regex.Match("frapples","^a...e");
        // Match ans = Regex.Match("frapples", "(?<grp>a...e)");
        // Console.WriteLine("Output of Match m = Regex.Match('apple','a..'); ::>> " + ans.Groups["grp"]);


        List<string> Emails = new List<string>
        {
            "john.doe@gmail.com",
            "alice_123@yahoo.in",
            "mark.smith@company.com",
            "support-abc@banking.co.in",
            "user.nametag@domain.org",
            "john.doe@gmail",          // Missing domain extension
            "alice@@yahoo.com",        // Double @
            "mark.smith@.com",         // Domain missing name
            "support@banking..com",    // Double dot in domain
            "user name@gmail.com",     // Space not allowed
            "@domain.com",             // Missing username
            "admin@domain",            // No top-level domain
            "info@domain,com",         // Comma instead of dot
            "finance#dept@corp.com",   // Invalid character #
            "plainaddress"             // Missing @ and domain
        };
        string pattern = @"/b[\w.-]+@[\w.-]+\.\w{2,}/b";
        // foreach (string i in Emails)
        // {
        //     if (Regex.IsMatch(i, pattern))
        //     {
        //         Console.WriteLine(i + "   is VALID email found");
        //     }
        //     else
        //     {
        //         Console.WriteLine(i + "   is NOT VALID email found");
        //     }
        // }
        if (Regex.IsMatch("sandeep@gamil.comManish@gmail.com", pattern))
        {
            Console.WriteLine("   is VALID email found");
        }
        else
        {
            Console.WriteLine("   is NOT VALID email found");
        }

        if (Regex.IsMatch("Cat", @"\bCat\b"))
        {
            Console.WriteLine("True");
        }
        if (Regex.IsMatch("manCat", @"\bCat\b"))
        {
            Console.WriteLine("True");
        }
    }
}
