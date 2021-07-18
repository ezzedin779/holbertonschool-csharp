using System;
using System.Collections.Generic;

class  List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> Ls = new List<int>();
        foreach (var i in list1)
        {
            if (list2.Contains(i))
                continue;
            Ls.Add(i);
        }
        foreach (var i in list2)
        {
            if (list1.Contains(i))
                continue;
            Ls.Add(i);
        }
        Ls.Sort();
        return (Ls);
    }
}
