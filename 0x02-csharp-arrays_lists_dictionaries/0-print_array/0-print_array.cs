using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size == 0)
        {
            Console.WriteLine();
        }
        else if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return (null);
        }
        int[] tab = new int[size];
        for (int i = 0; i < size; i++)
        {
            tab[i] = i;
            if (i == size - 1)
            {
                Console.WriteLine(tab[i]);
            }
            else
            {
                Console.Write(tab[i] + " ");
            }
        }
        return (tab);
    }
}
