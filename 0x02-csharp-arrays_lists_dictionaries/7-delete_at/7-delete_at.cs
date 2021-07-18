using System;
using System.Collections.Generic;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (index > myList.Count - 1 || index < 0)
            return (myList);
        myList.Remove(myList[index]);
        return (myList);
    }
}
