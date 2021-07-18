using System;
using System.Collections.Generic;

class  LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        List<int> Ls = new List<int>();
        int count = 0;
        int l = 0;
        foreach (var i in myLList)
        {
            if (count == index)
            {
                count++;
                continue;
            }
            Ls.Add(i);
            count++;
        }
        l = myLList.Count;
        for (int i = 1; i <= l; i++)
            myLList.RemoveFirst();
        foreach (var i in Ls)
            myLList.AddLast(i);
    }
}
