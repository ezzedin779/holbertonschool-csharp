using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return (null);
        }
        else if (size == 0)
        {
            Console.WriteLine();
        }
        int i = 0;
        List<int> Ls = new List<int>();
        for (i = 0; i < size; i++)
        { 
            Ls.Add(i);
            if (i == size - 1)
            {
                Console.WriteLine(Ls[i]);
            }
            else
            {
                Console.Write(Ls[i] + " ");
            }
        }
        return (Ls);
    }
}
