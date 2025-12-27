/*
Find the frequency of elements in an array using a Dictionary
int[] arr = {1, 2, 3, 2, 1, 4, 2};
*/

class _39_Frequency
{
    public static void solve()
    {
        int[] arr = { 1, 2, 3, 2, 1, 4, 2 };
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (map.ContainsKey(arr[i]))
            {
                map[arr[i]] = map[arr[i]] + 1;
            }
            else
            {
                map.Add(arr[i], 1);
            }
        }

        foreach (KeyValuePair<int, int> maping in map)
        {
            Console.WriteLine(maping.Key + "  :  " + maping.Value);
        }
    }
}






/*
Merge two sorted arrays into a single sorted array.
Max Time: 10 minutes

Explanation: Demonstrates merging and sorting techniques.

using System;
using System.Linq;
class Program {
static void Main() {
int[] arr1 = {1, 3, 5};
int[] arr2 = {2, 4, 6};
*/
class _39_Merge_Two_Sorted_Array
{
    public static void solve()
    {
        //Merging the sorted array
        int[] arr1 = { 1, 3, 5 };
        int[] arr2 = { 2, 4, 6 };

        Console.WriteLine($"First arr ::>> {string.Join("  ", arr1)} \nSecond arr ::>> {string.Join("  ", arr2)}");

        int l1 = arr1.Length;
        int l2 = arr2.Length;
        int lF = l1 + l2;
        int[] newArr = new int[lF];

        int one = 0;
        int sec = 0;
        // while(one)
        int k = 0;
        while (one < l1 && sec < l2)
        {
            if (arr1[one] < arr2[sec])
            {
                newArr[k] = arr1[one];
                one++;
                k++;
            }
            else
            {
                newArr[k] = arr2[sec];
                sec++;
                k++;
            }
        }

        while (one < l1 && k < lF)
        {
            newArr[k] = arr1[one];
            one++;
            k++;
        }
        while (sec < l2 && k < lF)
        {
            newArr[k] = arr2[sec];
            sec++;
            k++;
        }

        Console.WriteLine("Final Array after merging is ::>> " + string.Join("  ", newArr));

    }
}




/*
A computer science instructor is designing a tool to help students understand ASCII
values and string manipulation. The utility removes characters with even ASCII 
codes from a word and reverses the remaining ones, offering a hands-on way to 
explore how data can be transformed for security or encoding purposes.
In the class Program, implement the below-given method.  


This method takes a word as input and performs a series of transformations and 
return a customized format of string. The transformation logic includes:
1) The input must not be null, and it must contain at least 6 characters long.
 If it is shorter or null, the function should return an empty string.
2)The input must not contain any space, digit or special characters. If not,
 the function should return an empty string.
Password Generation Logic:
•	Convert the input to lowercase.
•	Remove all characters whose ASCII values are even numbers.
•	Reverse the remaining characters.
•	In the reversed string, convert characters that have even positioned character (0 based index) to uppercase. Refer to the sample input and output.
Return the generated key. 


In the Program class, the Main method,
- Prompt the user to enter a string input.
- Call the CleanseAndInvert method if the input is valid and print the output as "The generated key is - <generated key>".
- If the method returns empty string, then display "Invalid Input".  Refer to the sample inputs/outputs.

Note:
•	Do not edit the existing code template.
•	In the Sample Input / Output provided, the highlighted text in bold corresponds to the input given by the user, and the rest of the text represents the output.
•	Implement the business requirements within the main method. Please do not change the class name.
•	Do not use the Environment.Exit() to terminate the program.


Sample Input 1:
Enter the word
Aeroplane


Sample Output 1:
The generated key is - EaOeA
(Explanation: Input contains even ASCII characters.)


Sample Input 2:
Enter the word
Cowages


Sample Output 2:
The generated key is - SeGaWoC
(Explanation : Input doesn't contain even ASCII character. )



Sample Input 3:
Enter the word
Magic


Sample Output 3:
Invalid Input
(Explanation : Length of the input is less than 6.)



Sample Input 4:
Enter the word
Kinder World

Sample Output 4:
Invalid Input
(Explanation : Input contains space.)



Sample Input 5:
Enter the word
B@rbie

Sample Output 5:
Invalid Input

*/

class _39_Clean_String
{
    public static void CleanseAndInvert()
    {
        string str;
        Console.Write("Enter your String here ::>> ");
        str = Console.ReadLine();

        if (str.Length < 6 || string.IsNullOrEmpty(str))
        {
            Console.WriteLine("String is Either null or less than 6 character!");
            return;
        }

        string ans = "";
        //checking and removing even ascii
        for (int i = 0; i < str.Length; i++)
        {
            if ((str[i] == ' ') || !char.IsLetter(str[i]))
            {
                Console.WriteLine("String conatins special or digit");
                return;
            }

            if ((int)str[i] % 2 != 0)
            {
                ans += str[i];
            }
        }

        ans = ans.ToLower();

        string finalAns = "";

        //reversing adn Uppercasing even index
        for (int i = ans.Length - 1; i >= 0; i--)
        {
            if (i % 2 == 0)
            {
                finalAns = finalAns + (ans[i] + "").ToUpper();
            }
            else
            {
                finalAns = finalAns + ans[i];
            }
        }
        Console.WriteLine("Final answer is ::>> " + finalAns);


    }
}

class _39_Questions
{
    public void Main()
    {

        // _39_Frequency.solve();
        // _39_Merge_Two_Sorted_Array.solve();

        
        string yesNo = "y";
        while (yesNo == "y")
        {
            _39_Clean_String.CleanseAndInvert();
            Console.Write("\n\nDo you want to Enter more Word y/n ::>> ");
            yesNo = Console.ReadLine();
        }

    }
}