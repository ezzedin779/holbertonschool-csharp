using System;
using System.Collections.Generic;

class  List
{
    public static int Sum(List<int> myList)
    {
        List<int> Ls = new List<int>();
        foreach (var i in myList)
        {
            if (Ls.Contains(i))
                continue;
            Ls.Add(i);
        }
        int result = 0;
        for (int i = 0; i < Ls.Count; i++)
            result = result + Ls[i];
        return (result);
    }
}
