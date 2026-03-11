/*
    ===============================================================
    TOPIC: LINQ (Language Integrated Query) in C#
    ===============================================================

    LINQ is a feature of C# that allows querying collections
    (arrays, lists, databases, XML, etc.) using a SQL-like syntax.

    It provides two main syntaxes:
    1. Query Syntax  (similar to SQL)
    2. Method Syntax (uses extension methods like Where(), Select())

    This program demonstrates:
    ---------------------------------------------------------------
    1. Filtering numeric data using LINQ (where clause)
    2. Sorting data using orderby
    3. Filtering strings using string methods (Contains)
    4. Pattern matching using Regular Expressions (Regex)
    5. Iterating query results using foreach

    Namespaces Used:
    ---------------------------------------------------------------
    System
        Contains basic classes like Console for input/output.

    System.Linq
        Required for LINQ operations such as query syntax,
        Where(), Select(), OrderBy(), etc.

    System.Text.RegularExpressions
        Provides the Regex class used for pattern matching.

    Key LINQ Clauses Used:
    ---------------------------------------------------------------
    from      -> Specifies the data source
    where     -> Filters elements based on a condition
    orderby   -> Sorts elements
    select    -> Specifies what data to return

    Regex Pattern Used:
    ---------------------------------------------------------------
    ^S.n.d$

    Meaning:
    ^   -> Start of string
    S   -> First character must be 'S'
    .   -> Any single character
    n   -> Character 'n'
    .   -> Any single character
    d   -> Character 'd'
    $   -> End of string

    Example matching string:
    Sandy
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace LINQ_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Integer array representing ages
            int[] age = { 12, 13, 21, 22, 45, 33, 20, 26, 55, 66 };

            // -------------------------------------------------------
            // LINQ QUERY 1: Filter numbers greater than 20
            // -------------------------------------------------------

            var a = from i in age      // iterate through array
                    where i > 20       // condition
                    select i;          // return element

            // Display filtered result
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();


            // -------------------------------------------------------
            // LINQ QUERY 2: Filter numbers > 20 and sort them
            // -------------------------------------------------------

            var b = from i in age
                    where i > 20       // filter condition
                    orderby i          // ascending order sorting
                    select i;

            foreach (int i in b)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();


            // -------------------------------------------------------
            // LINQ QUERY 3: Filter names containing letter "S"
            // -------------------------------------------------------

            string[] names = { "Sandy", "Mandy", "Candy", "Handy" };

            var c = from name in names
                    where name.Contains("S") // string method
                    select name;

            foreach (string i in c)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();


            // -------------------------------------------------------
            // LINQ QUERY 4: Pattern matching using Regex
            // -------------------------------------------------------

            string[] names2 = { "Sandy", "Mandy", "Candy", "Handy", "Sendd" };

            var c2 = from name in names2
                     where Regex.IsMatch(name, "^S.n.d$")
                     select name;

            // Print names that match the regex pattern
            foreach (var i in c2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
        }
    }
}