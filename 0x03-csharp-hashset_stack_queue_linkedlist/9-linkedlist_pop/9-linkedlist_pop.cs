using System;
using System.Collections.Generic;

class  LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        foreach (var i in myLList)
        {
            myLList.RemoveFirst();
            return (i);
        }
        return (0);
    }
}
