class _1_Array
{
    public static void main()
    {
        int[] arr = new int[5];
        int[] arr2 = { 1, 2, 3, 4, 5 };

        for (int i = 0; i < 5; i++)
        {
            arr[i] = i;
        }

        //printing data
        Console.WriteLine("----------PRINTING USING FOR-----------");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }


        Console.WriteLine("----------PRINTING USING FOR-EACH-----------");
        foreach (int i in arr2)
        {
            Console.WriteLine(i);
        }

        // similer to the int one compiler automaticaly convert that into its original type
        foreach(var i in arr2)
        {
            Console.WriteLine(i);
        }

        // avoid using this in code
        foreach(object i in arr2)
        {
            Console.WriteLine(i);
        }


        //MULTI-DIMENSIONAL ARRAY
        
    }
}