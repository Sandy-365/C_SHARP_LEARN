class Task1
{

    public static int avg;
    public void Main()
    {
        Console.WriteLine("\n1. Ask the user to enter the number of products. ");
        Console.Write("Enter the Number of Products ::>> ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n2. Create an integer array of that size. ");
        int[] arr = new int[n];
        Console.WriteLine($"Created an int array with {n} size ::>> int[] arr");

        Console.WriteLine("\n3. Accept only positive prices for each product. ");
        for (int i = 0; i < n; i++)
        {
            int val;
            while (true)
            {
                Console.Write($"Enter price for product {i + 1} ::>> ");
                val = Convert.ToInt32(Console.ReadLine());
                if (val < 0)
                {
                    Console.WriteLine("Please Enter Postive Value only");
                }
                else
                {
                    break;
                }
            }
            arr[i] = val;
        }
        Console.WriteLine("Entered Array is ::>> " + string.Join("  ", arr));


        Console.WriteLine("\n4. Calculate the average price. ");
        avg = 0;
        int sum = 0;
        foreach (int i in arr)
        {
            sum += i;
        }
        avg = sum / n;
        Console.WriteLine("Avg price is ::>> " + avg);


        Console.WriteLine("\n5. Sort the array using System.Array.Sort().");
        System.Array.Sort(arr);
        Console.WriteLine("Sorted Array is ::>> " + string.Join("  ", arr));


        Console.WriteLine("\n6. Replace prices below average with 0.");
        for (int i = 0; i < n; i++)
        {
            if (arr[i] < avg)
            {
                arr[i] = 0;
            }
        }

        Console.WriteLine("\n7. Resize the array by adding 5 new positions. ");
        Array.Resize(ref arr, n + 5);
        Console.WriteLine("Resized Array is ::>> " + string.Join("  ", arr));

        Console.WriteLine("\n8. Fill the newly added positions with the average price. ");
        for (int i = n; i < n + 5; i++)
        {
            arr[i] = avg;
        }
        Console.WriteLine("New Filled Array is ::>> " + string.Join("  ", arr));


        Console.WriteLine("\n9. Display the final array with index positions. ");
        for (int i = 0; i < n + 5; i++)
        {
            Console.WriteLine($"{i} index value is {arr[i]}");
        }

    }
}

class Task2
{
    public void Main()
    {
        /*
        1. Ask the user to enter: 
            ○ Number of branches 
            ○ Number of months 
        2. Create a 2D integer array accordingly. 
        3. Accept sales data for each branch and month. 
        4. Calculate:   
            ○ Total sales per branch 
            ○ Highest monthly sale across all branches 
        5. Display branch totals and global highest sale. 


        EXPECTED OUTCOME 
        ● Correct 2D array creation. 
        ● Accurate per-branch totals. 
        ● Correct identification of highest sale value.
        */

        Console.WriteLine("\n1. Ask the user to enter: \n\t○ Number of branches \n\t○ Number of months ");
        Console.Write("\tEnter the Number of branches ::>> ");
        int branch = Convert.ToInt32(Console.ReadLine());
        Console.Write("\tEnter the Number of months ::>> ");
        int months = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n2. Create a 2D integer array accordingly. ");
        int[][] arr = new int[branch][];
        for (int i = 0; i < branch; i++)
            arr[i] = new int[months];

        Console.WriteLine("\tCreated an 2D integer array int[][] arr");

        Console.WriteLine("\n3. Accept sales data for each branch and month");
        for (int i = 0; i < branch; i++)
        {
            for (int j = 0; j < months; j++)
            {
                Console.Write($"\tEneter the values for branch {i + 1} and month {j + 1} ::>> ");
                arr[i][j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("\n4. Calculate:\n\t○ Total sales per branch \n\t○ Highest monthly sale across all branches ");
        int[] bran = new int[branch];
        int highestSale = 0;
        for (int i = 0; i < branch; i++)
        {
            for (int j = 0; j < months; j++)
            {
                bran[i] += arr[i][j];
                if (arr[i][j] > highestSale)
                {
                    highestSale = arr[i][j];
                }
            }
        }
        Console.WriteLine("\tCalculated");

        Console.WriteLine("\n5. Display branch totals and global highest sale.");
        for (int i = 0; i < bran.Length; i++)
        {
            Console.WriteLine($"\tSale of branch {i + 1} is {bran[i]}");
        }
        Console.WriteLine("\tHighest Sale is " + highestSale);


    }
}



class Task4
{
    /*
    TASK 4 – CUSTOMER TRANSACTION 
    CLEANING (LIST & HASHSET) 
    WHAT THE STUDENT MUST DO 
    1. Ask for number of customer transactions. 
    2. Store customer IDs in a List<int> (duplicates allowed). 
    3. Convert the list into a HashSet<int> to remove duplicates. 
    4. Convert the HashSet back into a List. 
    5. Display: 
        ○ Cleaned customer list 
        ○ Number of duplicate entries removed 
    EXPECTED OUTCOME 
        ● Duplicate customer IDs are removed. 
        ● Original and cleaned data counts are correctly compared. 
        ● Demonstrates round-trip conversion.
    */
    public void Main()
    {
        Console.WriteLine("\n1. Ask for number of customer transactions.");
        Console.Write("\tEnter the number of customer transactions ::>> ");
        int trans = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n2. Store customer IDs in a List<int> (duplicates allowed).");
        List<string> list = new List<string>();
        for (int i = 0; i < trans; i++)
        {
            Console.Write($"\tEnter customer ID {i + 1} ::>> ");
            list.Add(Console.ReadLine());
        }
        Console.WriteLine($"\tData enter is {string.Join("  ", list)}");

        Console.WriteLine("\n3. Convert the list into a HashSet<int> to remove duplicates.");
        HashSet<string> hashSet = new HashSet<string>();
        foreach (string i in list)
        {
            hashSet.Add(i);
        }
        int diff = list.Count - hashSet.Count;
        Console.WriteLine("\tList converted to HashSet for removing duplicates");

        Console.WriteLine("\n4. Convert the HashSet back into a List.");
        list.Clear();
        foreach (string i in hashSet)
        {
            list.Add(i);
        }
        Console.WriteLine("\thashSet converted back to list");

        Console.WriteLine("\n5. Display: \n\t○ Cleaned customer list \n\t○ Number of duplicate entries removed ");
        foreach (string i in list)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Number of duplicate entries was ::>> " + diff);
    }
}



class Task5
{
    /*
    WHAT THE STUDENT MUST DO 
    1. Ask for number of transactions.
    2. Store transaction ID and amount in a Dictionary<int, double>.
    3. Prevent duplicate transaction IDs. 
    4. Create a SortedList<int, double> containing only transactions: 
        ○ Amount ≥ product average 
    5. Display sorted high-value transactions. 

    EXPECTED OUTCOME 
        ● Dictionary enforces unique keys. 
        ● SortedList displays data in ascending key order.
        ● Cross-task filtering logic is applied correctly.
*/

    public void Main()
    {
        Console.WriteLine("\n1. Ask for number of transactions.");
        Console.Write("\tEnter number of transactions ::>> ");
        int n = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("\n2. Store transaction ID and amount in a Dictionary<int, double>.");
        Dictionary<int, double> dict = new Dictionary<int, double>();

        for (int i = 0; i < n; i++)
        {
            Console.Write($"\n\tEnter Transaction ID {i + 1} ::>> ");
            int id = Convert.ToInt32(Console.ReadLine());

            if (dict.ContainsKey(id))
            {
                Console.WriteLine("\tDuplicate Transaction ID not allowed");
                i--;
                continue;
            }

            Console.Write("\tEnter Transaction Amount ::>> ");
            double amount = Convert.ToDouble(Console.ReadLine());

            dict.Add(id, amount);
        }

        Console.WriteLine("\n3. Dictionary stored all unique transactions.");

        Console.WriteLine("\n4. Create SortedList<int, double> for transactions >= average.");
        double avg = Task1.avg;
        SortedList<int, double> sortedList = new SortedList<int, double>();

        foreach (var item in dict)
        {
            if (item.Value >= avg)
            {
                sortedList.Add(item.Key, item.Value);
            }
        }

        Console.WriteLine("\n5. Display sorted high-value transactions.");
        foreach (var item in sortedList)
        {
            Console.WriteLine($"Transaction ID ::>> {item.Key}   Amount ::>> {item.Value}");
        }
    }
}


class Task6
{
    /*
        WHAT THE STUDENT MUST DO 
        1. Ask for number of operations. 
        2. Insert each operation into: 
            ○ Queue (processing order) 
            ○ Stack (undo tracking) 
        3. Process all queue elements in FIFO order. 
        4. Undo the last two operations using Stack. 
        5. Display processed and undone operations. 
        EXPECTED OUTCOME 
        ● Queue processes tasks in correct order. 
        ● Stack correctly reverses operations. 
        ● Proper use of LIFO and FIFO behavior.
    */

    public void Main()
    {
        Console.WriteLine("\n1. Ask for number of operations.");
        Console.Write("\tEnter number of operations ::>> ");
        int n = Convert.ToInt32(Console.ReadLine());

        Queue<string> queue = new Queue<string>();
        Stack<string> stack = new Stack<string>();

        Console.WriteLine("\n2. Insert operations into Queue and Stack.");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"\tEnter Operation {i + 1} ::>> ");
            string op = Console.ReadLine();
            queue.Enqueue(op);
            stack.Push(op);
        }

        Console.WriteLine("\n3. Processing operations using Queue (FIFO).");
        List<string> processed = new List<string>();
        while (queue.Count > 0)
        {
            string op = queue.Dequeue();
            processed.Add(op);
            Console.WriteLine($"\tProcessed ::>> {op}");
        }

        Console.WriteLine("\n4. Undo last two operations using Stack.");
        List<string> undone = new List<string>();
        int undoCount = 2;
        for (int i = 0; i < undoCount; i++)
        {
            string op = stack.Pop();
            undone.Add(op);
            Console.WriteLine($"\tUndone ::>> {op}");
        }

        Console.WriteLine("\n5. Summary");
        Console.WriteLine("\nProcessed Operations:");
        foreach (var op in processed)
            Console.WriteLine($"\t{op}");

        Console.WriteLine("\nUndone Operations:");
        foreach (var op in undone)
            Console.WriteLine($"\t{op}");
    }

}