using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array == null || array.Length <= 0)
        {
            Console.WriteLine();
            return;
        }
        int i = 0;
        for (i = array.Length - 1; i > 0; i--)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine(array[i]);
    }
}

