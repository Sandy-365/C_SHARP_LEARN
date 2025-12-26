/*
NOTE:

This program demonstrates **C# Collections**.

============================================================
COLLECTION TYPES COVERED
============================================================

NON-GENERIC COLLECTIONS (System.Collections)
1. ArrayList
2. Hashtable
3. Stack
4. Queue

GENERIC COLLECTIONS (System.Collections.Generic)
5. List<T>
6. Dictionary<TKey, TValue>
7. HashSet<T>
8. SortedList<TKey, TValue>

============================================================
KEY DIFFERENCE
============================================================
Non-Generic:
- Stores data as object
- No type safety
- Boxing / Unboxing
- Runtime errors possible

Generic:
- Type-safe
- Better performance
- Compile-time checking
- Recommended in real projects
============================================================
*/

using System.Collections;
using System.Collections.Generic;

class _38_Collections
{
    // This class is kept for conceptual grouping (optional)
}

class _38_Program
{
    public void Main()
    {
        // ==================================================
        // NON-GENERIC COLLECTIONS
        // ==================================================

        // ------------------ ArrayList ------------------
        // Can store ANY data type (not type-safe)

        ArrayList list = new ArrayList();
        list.Add(10);         // int
        list.Add("Sandeep");  // string
        list.Add(true);       // bool
        list.Add(10.45f);     // float

        // Must use Object type while iterating
        foreach (object n in list)
        {
            Console.WriteLine(n);
        }

        // Convert to array before using string.Join
        Console.WriteLine(string.Join("  -  ", list.ToArray()));

        // ------------------ Hashtable ------------------
        // Stores key-value pairs (non-generic)

        Hashtable ht = new Hashtable();
        ht.Add(1, "Sandep");
        ht.Add(2, "Ramjee");
        ht.Add(3, "Happy");
        ht.Add(4, "Manish");

        // DictionaryEntry is used for Hashtable
        foreach (DictionaryEntry e in ht)
        {
            Console.WriteLine(e.Key + " : " + e.Value);
        }

        // ------------------ Stack ------------------
        // LIFO (Last In First Out)

        Stack st = new Stack();
        st.Push(10);
        st.Push("Sandeep");
        st.Push(true);
        st.Push(10.54f);

        Console.WriteLine("\nStack (LIFO)");
        Console.WriteLine(string.Join("  ", st.ToArray()));

        // ------------------ Queue ------------------
        // FIFO (First In First Out)

        Queue qu = new Queue();
        qu.Enqueue(10);
        qu.Enqueue("Sandeep");
        qu.Enqueue(true);
        qu.Enqueue(10.54f);

        Console.WriteLine("\nQueue (FIFO)");
        Console.WriteLine(string.Join("  ", qu.ToArray()));

        // ==================================================
        // GENERIC COLLECTIONS (RECOMMENDED)
        // ==================================================

        // ------------------ List<T> ------------------
        // Type-safe dynamic array

        List<int> numbers1 = new List<int>();
        numbers1.Add(10);
        numbers1.Add(60);
        numbers1.Add(14);
        numbers1.Add(43);
        numbers1.Add(73);

        foreach (int n in numbers1)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine(string.Join("  -  ", numbers1));

        // Common List methods
        numbers1.Remove(14);          // removes element
        numbers1.Sort();              // sorts list
        Console.WriteLine("After Remove & Sort");
        Console.WriteLine(string.Join("  -  ", numbers1));

        // ------------------ Dictionary<TKey, TValue> ------------------
        // Generic key-value pair collection

        Dictionary<int, string> users = new Dictionary<int, string>();
        users.Add(1, "Sandeep");
        users.Add(2, "Manish");

        foreach (int key in users.Keys)
        {
            Console.WriteLine(key + " : " + users[key]);
        }

        // Safe access
        if (users.ContainsKey(1))
        {
            Console.WriteLine("User 1 exists");
        }

        // ------------------ HashSet<T> ------------------
        // Stores UNIQUE values only

        HashSet<int> set = new HashSet<int>();
        set.Add(10);
        set.Add(45);
        set.Add(12);
        set.Add(10);   // duplicate ignored

        Console.WriteLine("\nHashSet (Unique Values)");
        Console.WriteLine(string.Join("  ", set));

        // ------------------ SortedList<TKey, TValue> ------------------
        // Automatically sorted by key

        SortedList<string, string> sList = new SortedList<string, string>();
        sList.Add("a", "A");
        sList.Add("z", "Z");
        sList.Add("c", "C");
        sList.Add("6", "6");

        Console.WriteLine("\nSortedList (Sorted by Key)");
        foreach (string key in sList.Keys)
        {
            Console.WriteLine(key + " : " + sList[key]);
        }



        
    }
}
