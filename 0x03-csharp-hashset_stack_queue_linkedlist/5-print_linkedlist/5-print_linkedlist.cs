using System;
using System.Collections.Generic;

class  LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> Ls = new LinkedList<int>();
        if (size < 0)
            return (Ls);
        for (int i = 0; i < size; i++)
            Ls.AddLast(i);
        foreach (var i in Ls)
            Console.WriteLine(i);
        return (Ls);
    }
}
