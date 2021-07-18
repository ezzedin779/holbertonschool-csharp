using System;
using System.Collections.Generic;

class  LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        List<int> Ls = new List<int>();
        int count = 0;
        myLList.AddLast(n);
        foreach (var i in myLList)
            Ls.Add(i);
        count = myLList.Count - 1;
        for (int i = 0; i <= count; i++)
            myLList.RemoveLast();
        Ls.Sort();
        foreach (var i in Ls)
            myLList.AddLast(i);
        return (myLList.First);
    }
}
